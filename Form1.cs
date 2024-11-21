using MangaStorageManager.Services;
using System;
using System.Windows.Forms;

namespace MangaStorageManager
{
    public partial class Form1 : Form
    {
        private DataSendManager dataSM;
        private GenerateCBStorage genCBS;
        public Form1()
        {
            InitializeComponent();
            dataSM = new DataSendManager();
            genCBS = new GenerateCBStorage();
            listViewMangaCons.Columns.Add("EAN", 100);
            listViewMangaCons.Columns.Add("Titre", 350);
            listViewMangaCons.Columns.Add("N°", 40);
            listViewMangaCons.Columns.Add("Editeur", 150);
            //listViewMangaCons.Items.Add(new ListViewItem(new[] { "1234567989", "test", "1", "test"}));
            listViewStorageCons.Columns.Add("CB", 100);
            listViewStorageCons.Columns.Add("Pièce", 150);
            listViewStorageCons.Columns.Add("Description", 500);
            //listViewStorageCons.Items.Add(new ListViewItem(new[] { "012345679", "piece", "descriptrion un peu plus longue" }));
            listViewManagementCons.Columns.Add("EAN", 150);
            listViewManagementCons.Columns.Add("CB", 150);
            listViewManagementCons.Columns.Add("Status", 150);
            listViewManagementCons.Columns.Add("Date", 150);
            //listViewManagementCons.Items.Add(new ListViewItem(new[] { "012345679", "0123456789", "lu", "11/10/1998" }));
        }

        // =============================================================================
        // =============================== S E N D =====================================
        // =============================================================================

        /// <summary>
        /// Réceptionne les données relatives à un manga et en effectue le pré-traitement pour l'envoie vers la bdd.
        /// </summary>
        public void SendManga()
        {
            string titre = textBoxTitreManga.Text;
            string num = numericManga.Value.ToString();
            string editor = comboBoxEditeur.Text;
            string ean = textBoxEANManga.Text.ToString().Replace("+", "");
            Console.WriteLine(titre + "|" + num + "|" + editor + "|" + ean);
            dataSM.SendManga(titre, num, editor, ean);
            textBoxEANManga.Text = "";
            numericManga.Value += 1;
        }

        /// <summary>
        /// Réceptionne les données relative à un storage et effecture le pré-traitement pour l'envoie vers la bdd.
        /// </summary>
        public void SendStorage()
        {
            string piece = textBoxPiece.Text;
            string desc = textBoxDesc.Text;
            string cb = textBoxCB.Text.ToString().Replace("+", "");
            Console.WriteLine("SEND Storage");
            dataSM.SendStorage(piece, desc, cb);
            textBoxDesc.Text = "";
            textBoxCB.Text = "";
        }

        /// <summary>
        /// Réceptionne les données relative à un rangement / management et effecture le pré-traitement pour l'envoie vers la bdd.
        /// </summary>
        public void SendManagement()
        {
            string ean = textBoxEANManage.Text.ToString().Replace("+", "");
            string storage = textBoxCBManage.Text;
            string status = comboBoxStatus.Text;
            Console.WriteLine("SEND Management");
            dataSM.SendManagement(ean, storage, status);
            textBoxEANManage.Text = "";
        }



        // =============================================================================
        // =============================== H E L P I N G ===============================
        // =============================================================================

        /// <summary>
        /// Lance la génération d'un code CB pour une nouvelle zone.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenerateCB_Click(object sender, EventArgs e)
        {
            textBoxCB.Text = genCBS.getGenerateCB();
        }

        /// <summary>
        /// Permet de reset l'input titre et de remettre le numéro du tome à 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetTitre_Click(object sender, EventArgs e)
        {
            textBoxTitreManga.Text = "";
            numericManga.Value = 1;
            textBoxTitreManga.Focus();
        }

        // =============================================================================
        // ============================ A C T I V A T I O N ============================
        // =============================================================================


        // --------------------- SEND MANGA ---------------------
        private void ButtonSaveManga_Click(object sender, EventArgs e)
        {
            SendManga();
        }

        private void TextBoxEANManga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendManga();
                e.Handled = true;
            }
        }

        // --------------------- SEND STORAGE ---------------------

        private void ButtonSaveStorage_Click(object sender, EventArgs e)
        {
            SendStorage();
        }

        private void TextBoxCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendStorage();
                e.Handled = true;
            }
        }

        // --------------------- SEND MANAGEMENT ---------------------

        private void TextBoxEANManage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendManagement();
                e.Handled = true;
            }
        }

        private void ButtonRanger_Click(object sender, EventArgs e)
        {
            SendManagement();
        }

        // =============================================================================
        // ============================ C O N S U L T ==================================
        // =============================================================================

        /// <summary>
        /// Lance la recherche de données et met à jour les list view.
        /// </summary>
        private void SearchData()
        {
            string ean   = textBoxEANCons.Text;
            string titre = textBoxTitreCons.Text;
            string cb    = textBoxCBCons.Text;
            string piece = textBoxPieceCons.Text;
            // lance la recherche
            if (ean != "")
            {
                string data = dataSM.getManga(new string[] {ean});
                Console.WriteLine(data);
            } else if (titre != "")
            {
                string data = dataSM.getMangasByTitles(new string[] { titre });
                Console.WriteLine(data);
            }
            // -----------------------------
            listViewMangaCons     .Items.Clear();
            listViewMangaCons     .Items.Add(new ListViewItem(new[] { "1234567989", "test", "1", "test" }));
            listViewStorageCons   .Items.Clear();
            listViewStorageCons   .Items.Add(new ListViewItem(new[] { "012345679", "piece", "descriptrion un peu plus longue" }));
            listViewManagementCons.Items.Clear();
            listViewManagementCons.Items.Add(new ListViewItem(new[] { "012345679", "0123456789", "lu", "11/10/1998" }));
            textBoxEANCons  .Text = "";
            textBoxTitreCons.Text = "";
            textBoxCBCons   .Text = "";
            textBoxPieceCons.Text = "";
        }

        private void ButtonSearchStoCons_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void ButtonSearchCons_Click(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
