using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaStorageManager
{
    public partial class Form1 : Form
    {
        DataSendManager dataSM;
        public Form1()
        {
            InitializeComponent();
            dataSM = new DataSendManager();
        }

        // =============================================================================
        // =============================== S E N D =====================================
        // =============================================================================

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

        public void SendStorage()
        {
            string piece = textBoxPiece.Text;
            string desc = textBoxDesc.Text;
            string cb = textBoxCB.Text.ToString().Replace("+", "");
            Console.WriteLine("SEND Storage");
            textBoxDesc.Text = "";
            textBoxCB.Text = "";
        }

        public void SendManagement()
        {
            string ean = textBoxEANManage.Text.ToString().Replace("+", "");
            string storage = comboBoxStrorageM.Text;
            Console.WriteLine("SEND Management");
            textBoxEANManage.Text = "";
        }

        // =============================================================================
        // ============================ A C T I V A T I O N ============================
        // =============================================================================

        private void buttonSaveManga_Click(object sender, EventArgs e)
        {
            SendManga();
        }

        private void textBoxEANManga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendManga();
                e.Handled = true;
            }
        }

        private void buttonSaveStorage_Click(object sender, EventArgs e)
        {
            SendStorage();
        }

        private void textBoxCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendStorage();
                e.Handled = true;
            }
        }

        private void textBoxEANManage_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendManagement();
        }

        private void buttonRanger_Click(object sender, EventArgs e)
        {
            SendManagement();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetTitre_Click(object sender, EventArgs e)
        {
            textBoxTitreManga.Text = "";
            numericManga.Value = 1;
        }
    }
}
