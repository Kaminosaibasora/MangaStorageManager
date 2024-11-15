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

        public void sendManga()
        {
            string titre = textBoxTitreManga.Text;
            string num = numericManga.Value.ToString();
            string editor = comboBoxEditeur.Text;
            string ean = textBoxEANManga.Text.ToString().Replace("+", "");
            Console.WriteLine(titre + "|" + num + "|" + editor + "|" + ean);
            dataSM.sendData(titre, num, editor, ean);
            textBoxEANManga.Text = "";
            numericManga.Value += 1;
        }

        private void buttonSaveManga_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SAVE");
            sendManga();
        }

        private void textBoxEANManga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Vérifie si la touche "Entrée" est pressée
            {
                Console.WriteLine("SAVE");
                sendManga();
                e.Handled = true;
            }
        }
    }
}
