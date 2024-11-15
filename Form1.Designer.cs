namespace MangaStorageManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addMangaPage = new System.Windows.Forms.TabPage();
            this.labelEAN = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxEditeur = new System.Windows.Forms.ComboBox();
            this.textBoxEANManga = new System.Windows.Forms.TextBox();
            this.textBoxTitreManga = new System.Windows.Forms.TextBox();
            this.buttonSaveManga = new System.Windows.Forms.Button();
            this.addStoragePage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelPiece = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.manageMS = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonRanger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericManga = new System.Windows.Forms.NumericUpDown();
            this.labelNum = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.addMangaPage.SuspendLayout();
            this.addStoragePage.SuspendLayout();
            this.manageMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericManga)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addMangaPage);
            this.tabControl1.Controls.Add(this.addStoragePage);
            this.tabControl1.Controls.Add(this.manageMS);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // addMangaPage
            // 
            this.addMangaPage.Controls.Add(this.labelNum);
            this.addMangaPage.Controls.Add(this.numericManga);
            this.addMangaPage.Controls.Add(this.labelEAN);
            this.addMangaPage.Controls.Add(this.labelEdit);
            this.addMangaPage.Controls.Add(this.labelTitle);
            this.addMangaPage.Controls.Add(this.comboBoxEditeur);
            this.addMangaPage.Controls.Add(this.textBoxEANManga);
            this.addMangaPage.Controls.Add(this.textBoxTitreManga);
            this.addMangaPage.Controls.Add(this.buttonSaveManga);
            this.addMangaPage.Location = new System.Drawing.Point(4, 22);
            this.addMangaPage.Name = "addMangaPage";
            this.addMangaPage.Padding = new System.Windows.Forms.Padding(3);
            this.addMangaPage.Size = new System.Drawing.Size(768, 400);
            this.addMangaPage.TabIndex = 0;
            this.addMangaPage.Text = "Add Manga";
            this.addMangaPage.UseVisualStyleBackColor = true;
            // 
            // labelEAN
            // 
            this.labelEAN.Location = new System.Drawing.Point(562, 3);
            this.labelEAN.Name = "labelEAN";
            this.labelEAN.Size = new System.Drawing.Size(200, 180);
            this.labelEAN.TabIndex = 7;
            this.labelEAN.Text = "EAN";
            this.labelEAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEdit
            // 
            this.labelEdit.Location = new System.Drawing.Point(366, 3);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(190, 180);
            this.labelEdit.TabIndex = 6;
            this.labelEdit.Text = "Editeur";
            this.labelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(6, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(257, 180);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Titre";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxEditeur
            // 
            this.comboBoxEditeur.FormattingEnabled = true;
            this.comboBoxEditeur.Items.AddRange(new object[] {
            "Kana",
            "Panini",
            "Doki-Doki",
            "Delcourt-Tonkam",
            "Akata",
            "Kurokawa",
            "Kioon",
            "Kaze",
            "Asuka",
            "Ototo",
            "Glénat",
            "Pika",
            "Meian",
            "Soleil"});
            this.comboBoxEditeur.Location = new System.Drawing.Point(369, 186);
            this.comboBoxEditeur.Name = "comboBoxEditeur";
            this.comboBoxEditeur.Size = new System.Drawing.Size(187, 21);
            this.comboBoxEditeur.TabIndex = 4;
            // 
            // textBoxEANManga
            // 
            this.textBoxEANManga.Location = new System.Drawing.Point(562, 187);
            this.textBoxEANManga.Name = "textBoxEANManga";
            this.textBoxEANManga.Size = new System.Drawing.Size(200, 20);
            this.textBoxEANManga.TabIndex = 3;
            this.textBoxEANManga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEANManga_KeyPress);
            // 
            // textBoxTitreManga
            // 
            this.textBoxTitreManga.Location = new System.Drawing.Point(6, 186);
            this.textBoxTitreManga.Name = "textBoxTitreManga";
            this.textBoxTitreManga.Size = new System.Drawing.Size(257, 20);
            this.textBoxTitreManga.TabIndex = 2;
            // 
            // buttonSaveManga
            // 
            this.buttonSaveManga.Location = new System.Drawing.Point(562, 213);
            this.buttonSaveManga.Name = "buttonSaveManga";
            this.buttonSaveManga.Size = new System.Drawing.Size(200, 23);
            this.buttonSaveManga.TabIndex = 1;
            this.buttonSaveManga.Text = "Sauvegarder";
            this.buttonSaveManga.UseVisualStyleBackColor = true;
            this.buttonSaveManga.Click += new System.EventHandler(this.buttonSaveManga_Click);
            // 
            // addStoragePage
            // 
            this.addStoragePage.Controls.Add(this.button3);
            this.addStoragePage.Controls.Add(this.button2);
            this.addStoragePage.Controls.Add(this.labelCode);
            this.addStoragePage.Controls.Add(this.textBox5);
            this.addStoragePage.Controls.Add(this.labelDesc);
            this.addStoragePage.Controls.Add(this.textBox4);
            this.addStoragePage.Controls.Add(this.labelPiece);
            this.addStoragePage.Controls.Add(this.textBox3);
            this.addStoragePage.Location = new System.Drawing.Point(4, 22);
            this.addStoragePage.Name = "addStoragePage";
            this.addStoragePage.Padding = new System.Windows.Forms.Padding(3);
            this.addStoragePage.Size = new System.Drawing.Size(768, 400);
            this.addStoragePage.TabIndex = 1;
            this.addStoragePage.Text = "AddStorage";
            this.addStoragePage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(580, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sauvegarder";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelCode
            // 
            this.labelCode.Location = new System.Drawing.Point(577, 3);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(191, 138);
            this.labelCode.TabIndex = 5;
            this.labelCode.Text = "Code Bar";
            this.labelCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(580, 173);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 20);
            this.textBox5.TabIndex = 4;
            // 
            // labelDesc
            // 
            this.labelDesc.Location = new System.Drawing.Point(237, 3);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(337, 138);
            this.labelDesc.TabIndex = 3;
            this.labelDesc.Text = "Description";
            this.labelDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(240, 144);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(334, 78);
            this.textBox4.TabIndex = 2;
            // 
            // labelPiece
            // 
            this.labelPiece.Location = new System.Drawing.Point(6, 3);
            this.labelPiece.Name = "labelPiece";
            this.labelPiece.Size = new System.Drawing.Size(225, 167);
            this.labelPiece.TabIndex = 1;
            this.labelPiece.Text = "Pièce";
            this.labelPiece.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 0;
            // 
            // manageMS
            // 
            this.manageMS.Controls.Add(this.label2);
            this.manageMS.Controls.Add(this.label1);
            this.manageMS.Controls.Add(this.buttonRanger);
            this.manageMS.Controls.Add(this.textBox6);
            this.manageMS.Controls.Add(this.comboBox2);
            this.manageMS.Location = new System.Drawing.Point(4, 22);
            this.manageMS.Name = "manageMS";
            this.manageMS.Size = new System.Drawing.Size(768, 400);
            this.manageMS.TabIndex = 2;
            this.manageMS.Text = "ManageMS";
            this.manageMS.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(214, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 176);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(205, 20);
            this.textBox6.TabIndex = 1;
            // 
            // buttonRanger
            // 
            this.buttonRanger.Location = new System.Drawing.Point(494, 176);
            this.buttonRanger.Name = "buttonRanger";
            this.buttonRanger.Size = new System.Drawing.Size(271, 23);
            this.buttonRanger.TabIndex = 2;
            this.buttonRanger.Text = "Ranger";
            this.buttonRanger.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 173);
            this.label1.TabIndex = 6;
            this.label1.Text = "EAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(214, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 173);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code Bar Storage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericManga
            // 
            this.numericManga.Location = new System.Drawing.Point(269, 187);
            this.numericManga.Name = "numericManga";
            this.numericManga.Size = new System.Drawing.Size(94, 20);
            this.numericManga.TabIndex = 8;
            this.numericManga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNum
            // 
            this.labelNum.Location = new System.Drawing.Point(269, 4);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(94, 180);
            this.labelNum.TabIndex = 9;
            this.labelNum.Text = "N°";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "MangaStorageManager";
            this.tabControl1.ResumeLayout(false);
            this.addMangaPage.ResumeLayout(false);
            this.addMangaPage.PerformLayout();
            this.addStoragePage.ResumeLayout(false);
            this.addStoragePage.PerformLayout();
            this.manageMS.ResumeLayout(false);
            this.manageMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericManga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addMangaPage;
        private System.Windows.Forms.TabPage addStoragePage;
        private System.Windows.Forms.TextBox textBoxEANManga;
        private System.Windows.Forms.TextBox textBoxTitreManga;
        private System.Windows.Forms.Button buttonSaveManga;
        private System.Windows.Forms.TabPage manageMS;
        private System.Windows.Forms.Label labelEAN;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxEditeur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelPiece;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRanger;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.NumericUpDown numericManga;
    }
}

