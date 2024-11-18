﻿namespace MangaStorageManager
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
            this.buttonResetTitre = new System.Windows.Forms.Button();
            this.labelNum = new System.Windows.Forms.Label();
            this.numericManga = new System.Windows.Forms.NumericUpDown();
            this.labelEAN = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxEditeur = new System.Windows.Forms.ComboBox();
            this.textBoxEANManga = new System.Windows.Forms.TextBox();
            this.textBoxTitreManga = new System.Windows.Forms.TextBox();
            this.buttonSaveManga = new System.Windows.Forms.Button();
            this.addStoragePage = new System.Windows.Forms.TabPage();
            this.buttonSaveStorage = new System.Windows.Forms.Button();
            this.buttonGenerateCB = new System.Windows.Forms.Button();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCB = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelPiece = new System.Windows.Forms.Label();
            this.textBoxPiece = new System.Windows.Forms.TextBox();
            this.manageMS = new System.Windows.Forms.TabPage();
            this.textBoxCBManage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRanger = new System.Windows.Forms.Button();
            this.textBoxEANManage = new System.Windows.Forms.TextBox();
            this.tabPageConsArt = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.addMangaPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericManga)).BeginInit();
            this.addStoragePage.SuspendLayout();
            this.manageMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addMangaPage);
            this.tabControl1.Controls.Add(this.addStoragePage);
            this.tabControl1.Controls.Add(this.manageMS);
            this.tabControl1.Controls.Add(this.tabPageConsArt);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // addMangaPage
            // 
            this.addMangaPage.Controls.Add(this.buttonResetTitre);
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
            // buttonResetTitre
            // 
            this.buttonResetTitre.Location = new System.Drawing.Point(6, 212);
            this.buttonResetTitre.Name = "buttonResetTitre";
            this.buttonResetTitre.Size = new System.Drawing.Size(257, 23);
            this.buttonResetTitre.TabIndex = 10;
            this.buttonResetTitre.Text = "Reset";
            this.buttonResetTitre.UseVisualStyleBackColor = true;
            this.buttonResetTitre.Click += new System.EventHandler(this.ButtonResetTitre_Click);
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
            "Soleil",
            "Akiko",
            "Clair de Lune",
            "Saphira",
            "Booken Manga",
            "Mana Books"});
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
            this.textBoxEANManga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEANManga_KeyPress);
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
            this.buttonSaveManga.Click += new System.EventHandler(this.ButtonSaveManga_Click);
            // 
            // addStoragePage
            // 
            this.addStoragePage.Controls.Add(this.buttonSaveStorage);
            this.addStoragePage.Controls.Add(this.buttonGenerateCB);
            this.addStoragePage.Controls.Add(this.labelCode);
            this.addStoragePage.Controls.Add(this.textBoxCB);
            this.addStoragePage.Controls.Add(this.labelDesc);
            this.addStoragePage.Controls.Add(this.textBoxDesc);
            this.addStoragePage.Controls.Add(this.labelPiece);
            this.addStoragePage.Controls.Add(this.textBoxPiece);
            this.addStoragePage.Location = new System.Drawing.Point(4, 22);
            this.addStoragePage.Name = "addStoragePage";
            this.addStoragePage.Padding = new System.Windows.Forms.Padding(3);
            this.addStoragePage.Size = new System.Drawing.Size(768, 400);
            this.addStoragePage.TabIndex = 1;
            this.addStoragePage.Text = "AddStorage";
            this.addStoragePage.UseVisualStyleBackColor = true;
            // 
            // buttonSaveStorage
            // 
            this.buttonSaveStorage.Location = new System.Drawing.Point(580, 199);
            this.buttonSaveStorage.Name = "buttonSaveStorage";
            this.buttonSaveStorage.Size = new System.Drawing.Size(182, 23);
            this.buttonSaveStorage.TabIndex = 7;
            this.buttonSaveStorage.Text = "Sauvegarder";
            this.buttonSaveStorage.UseVisualStyleBackColor = true;
            this.buttonSaveStorage.Click += new System.EventHandler(this.ButtonSaveStorage_Click);
            // 
            // buttonGenerateCB
            // 
            this.buttonGenerateCB.Location = new System.Drawing.Point(580, 144);
            this.buttonGenerateCB.Name = "buttonGenerateCB";
            this.buttonGenerateCB.Size = new System.Drawing.Size(182, 23);
            this.buttonGenerateCB.TabIndex = 6;
            this.buttonGenerateCB.Text = "Generate";
            this.buttonGenerateCB.UseVisualStyleBackColor = true;
            this.buttonGenerateCB.Click += new System.EventHandler(this.ButtonGenerateCB_Click);
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
            // textBoxCB
            // 
            this.textBoxCB.Location = new System.Drawing.Point(580, 173);
            this.textBoxCB.Name = "textBoxCB";
            this.textBoxCB.Size = new System.Drawing.Size(182, 20);
            this.textBoxCB.TabIndex = 4;
            this.textBoxCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCB_KeyPress);
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
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(240, 144);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(334, 78);
            this.textBoxDesc.TabIndex = 2;
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
            // textBoxPiece
            // 
            this.textBoxPiece.Location = new System.Drawing.Point(6, 173);
            this.textBoxPiece.Name = "textBoxPiece";
            this.textBoxPiece.Size = new System.Drawing.Size(228, 20);
            this.textBoxPiece.TabIndex = 0;
            // 
            // manageMS
            // 
            this.manageMS.Controls.Add(this.textBoxCBManage);
            this.manageMS.Controls.Add(this.label3);
            this.manageMS.Controls.Add(this.comboBoxStatus);
            this.manageMS.Controls.Add(this.label2);
            this.manageMS.Controls.Add(this.label1);
            this.manageMS.Controls.Add(this.buttonRanger);
            this.manageMS.Controls.Add(this.textBoxEANManage);
            this.manageMS.Location = new System.Drawing.Point(4, 22);
            this.manageMS.Name = "manageMS";
            this.manageMS.Size = new System.Drawing.Size(768, 400);
            this.manageMS.TabIndex = 2;
            this.manageMS.Text = "ManageMS";
            this.manageMS.UseVisualStyleBackColor = true;
            // 
            // textBoxCBManage
            // 
            this.textBoxCBManage.Location = new System.Drawing.Point(214, 176);
            this.textBoxCBManage.Name = "textBoxCBManage";
            this.textBoxCBManage.Size = new System.Drawing.Size(189, 20);
            this.textBoxCBManage.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(409, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 173);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Lu",
            "Non Lu",
            "Article",
            "A Vendre"});
            this.comboBoxStatus.Location = new System.Drawing.Point(409, 175);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(195, 21);
            this.comboBoxStatus.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(214, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 173);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code Bar Storage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // buttonRanger
            // 
            this.buttonRanger.Location = new System.Drawing.Point(610, 173);
            this.buttonRanger.Name = "buttonRanger";
            this.buttonRanger.Size = new System.Drawing.Size(155, 23);
            this.buttonRanger.TabIndex = 2;
            this.buttonRanger.Text = "Ranger";
            this.buttonRanger.UseVisualStyleBackColor = true;
            this.buttonRanger.Click += new System.EventHandler(this.ButtonRanger_Click);
            // 
            // textBoxEANManage
            // 
            this.textBoxEANManage.Location = new System.Drawing.Point(3, 176);
            this.textBoxEANManage.Name = "textBoxEANManage";
            this.textBoxEANManage.Size = new System.Drawing.Size(205, 20);
            this.textBoxEANManage.TabIndex = 1;
            this.textBoxEANManage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEANManage_KeyPress);
            // 
            // tabPageConsArt
            // 
            this.tabPageConsArt.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsArt.Name = "tabPageConsArt";
            this.tabPageConsArt.Size = new System.Drawing.Size(768, 400);
            this.tabPageConsArt.TabIndex = 3;
            this.tabPageConsArt.Text = "Consult Art";
            this.tabPageConsArt.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.numericManga)).EndInit();
            this.addStoragePage.ResumeLayout(false);
            this.addStoragePage.PerformLayout();
            this.manageMS.ResumeLayout(false);
            this.manageMS.PerformLayout();
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
        private System.Windows.Forms.Button buttonSaveStorage;
        private System.Windows.Forms.Button buttonGenerateCB;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCB;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelPiece;
        private System.Windows.Forms.TextBox textBoxPiece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRanger;
        private System.Windows.Forms.TextBox textBoxEANManage;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.NumericUpDown numericManga;
        private System.Windows.Forms.Button buttonResetTitre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxCBManage;
        private System.Windows.Forms.TabPage tabPageConsArt;
    }
}

