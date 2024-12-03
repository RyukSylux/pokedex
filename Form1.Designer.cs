﻿
namespace PokedexApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonSearchName = new Button();
            btnSearchByType = new Button();
            cmbType = new ComboBox();
            btnList = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            chkCaptured = new CheckBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            txtName = new TextBox();
            listBoxPokemons = new ListBox();
            pictureBoxPokemon = new PictureBox();
            txtImagePath = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            comboBoxAttck4 = new ComboBox();
            comboBoxAttck3 = new ComboBox();
            comboBoxAttck2 = new ComboBox();
            comboBoxAttck1 = new ComboBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            labelAtq = new Label();
            textAtqS = new TextBox();
            chkEvolve = new CheckBox();
            cmbWeak = new ComboBox();
            labelWeakness = new Label();
            RegionLabel = new Label();
            cmbRegion = new ComboBox();
            txtDescription = new RichTextBox();
            btnSearchByRegion = new Button();
            newPkm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonSearchName
            // 
            buttonSearchName.Location = new Point(273, 413);
            buttonSearchName.Margin = new Padding(3, 2, 3, 2);
            buttonSearchName.Name = "buttonSearchName";
            buttonSearchName.Size = new Size(137, 23);
            buttonSearchName.TabIndex = 12;
            buttonSearchName.Text = "Rechercher par Nom";
            buttonSearchName.UseVisualStyleBackColor = true;
            buttonSearchName.Click += buttonSearchName_Click;
            // 
            // btnSearchByType
            // 
            btnSearchByType.Location = new Point(273, 443);
            btnSearchByType.Margin = new Padding(3, 2, 3, 2);
            btnSearchByType.Name = "btnSearchByType";
            btnSearchByType.Size = new Size(137, 24);
            btnSearchByType.TabIndex = 11;
            btnSearchByType.Text = "Rechercher par Type";
            btnSearchByType.UseVisualStyleBackColor = true;
            btnSearchByType.Click += btnSearchByType_Click;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(137, 58);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(103, 23);
            cmbType.TabIndex = 10;
            // 
            // btnList
            // 
            btnList.Location = new Point(38, 443);
            btnList.Margin = new Padding(3, 2, 3, 2);
            btnList.Name = "btnList";
            btnList.Size = new Size(159, 24);
            btnList.TabIndex = 9;
            btnList.Text = "Rafraichir le Pokédex";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(615, 519);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(66, 24);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Editer";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(808, 519);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 24);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(524, 519);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 24);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // chkCaptured
            // 
            chkCaptured.AutoSize = true;
            chkCaptured.BackColor = Color.Transparent;
            chkCaptured.BackgroundImageLayout = ImageLayout.None;
            chkCaptured.FlatStyle = FlatStyle.System;
            chkCaptured.Location = new Point(267, 157);
            chkCaptured.Margin = new Padding(3, 2, 3, 2);
            chkCaptured.Name = "chkCaptured";
            chkCaptured.Size = new Size(90, 20);
            chkCaptured.TabIndex = 5;
            chkCaptured.Text = "Est capturé";
            chkCaptured.UseVisualStyleBackColor = false;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = SystemColors.Info;
            txtHeight.BorderStyle = BorderStyle.None;
            txtHeight.Location = new Point(240, 120);
            txtHeight.Margin = new Padding(3, 2, 3, 2);
            txtHeight.Name = "txtHeight";
            txtHeight.PlaceholderText = "Taille";
            txtHeight.Size = new Size(37, 16);
            txtHeight.TabIndex = 4;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = SystemColors.Info;
            txtWeight.BorderStyle = BorderStyle.None;
            txtWeight.Location = new Point(240, 142);
            txtWeight.Margin = new Padding(3, 2, 3, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.PlaceholderText = "Poids";
            txtWeight.Size = new Size(42, 16);
            txtWeight.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(188, 33);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nom";
            txtName.Size = new Size(152, 16);
            txtName.TabIndex = 0;
            // 
            // listBoxPokemons
            // 
            listBoxPokemons.FormattingEnabled = true;
            listBoxPokemons.ItemHeight = 15;
            listBoxPokemons.Location = new Point(38, 150);
            listBoxPokemons.Margin = new Padding(3, 2, 3, 2);
            listBoxPokemons.Name = "listBoxPokemons";
            listBoxPokemons.Size = new Size(372, 259);
            listBoxPokemons.TabIndex = 1;
            listBoxPokemons.SelectedIndexChanged += listBoxPokemons_SelectedIndexChanged;
            // 
            // pictureBoxPokemon
            // 
            pictureBoxPokemon.BackColor = Color.FromArgb(255, 255, 128);
            pictureBoxPokemon.Location = new Point(12, 36);
            pictureBoxPokemon.Margin = new Padding(3, 2, 3, 2);
            pictureBoxPokemon.Name = "pictureBoxPokemon";
            pictureBoxPokemon.Size = new Size(117, 117);
            pictureBoxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPokemon.TabIndex = 2;
            pictureBoxPokemon.TabStop = false;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(6, 421);
            txtImagePath.Margin = new Padding(3, 2, 3, 2);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(512, 23);
            txtImagePath.TabIndex = 3;
            txtImagePath.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxAttck4);
            groupBox1.Controls.Add(comboBoxAttck3);
            groupBox1.Controls.Add(comboBoxAttck2);
            groupBox1.Controls.Add(comboBoxAttck1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(labelAtq);
            groupBox1.Controls.Add(textAtqS);
            groupBox1.Controls.Add(chkEvolve);
            groupBox1.Controls.Add(cmbWeak);
            groupBox1.Controls.Add(labelWeakness);
            groupBox1.Controls.Add(RegionLabel);
            groupBox1.Controls.Add(cmbRegion);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(pictureBoxPokemon);
            groupBox1.Controls.Add(cmbType);
            groupBox1.Controls.Add(txtImagePath);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(txtWeight);
            groupBox1.Controls.Add(chkCaptured);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(524, 150);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(362, 365);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // comboBoxAttck4
            // 
            comboBoxAttck4.FormattingEnabled = true;
            comboBoxAttck4.Location = new Point(13, 334);
            comboBoxAttck4.Name = "comboBoxAttck4";
            comboBoxAttck4.Size = new Size(121, 23);
            comboBoxAttck4.TabIndex = 29;
            // 
            // comboBoxAttck3
            // 
            comboBoxAttck3.FormattingEnabled = true;
            comboBoxAttck3.Location = new Point(219, 334);
            comboBoxAttck3.Name = "comboBoxAttck3";
            comboBoxAttck3.Size = new Size(121, 23);
            comboBoxAttck3.TabIndex = 28;
            // 
            // comboBoxAttck2
            // 
            comboBoxAttck2.FormattingEnabled = true;
            comboBoxAttck2.Location = new Point(219, 293);
            comboBoxAttck2.Name = "comboBoxAttck2";
            comboBoxAttck2.Size = new Size(121, 23);
            comboBoxAttck2.TabIndex = 27;
            // 
            // comboBoxAttck1
            // 
            comboBoxAttck1.FormattingEnabled = true;
            comboBoxAttck1.Location = new Point(13, 293);
            comboBoxAttck1.Name = "comboBoxAttck1";
            comboBoxAttck1.Size = new Size(121, 23);
            comboBoxAttck1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 259);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 25;
            label1.Text = "Attaques :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.combat_tile;
            pictureBox2.Location = new Point(0, 276);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(362, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // labelAtq
            // 
            labelAtq.AutoSize = true;
            labelAtq.Location = new Point(13, 178);
            labelAtq.Name = "labelAtq";
            labelAtq.Size = new Size(107, 15);
            labelAtq.TabIndex = 23;
            labelAtq.Text = "Attaque signature :";
            // 
            // textAtqS
            // 
            textAtqS.BorderStyle = BorderStyle.None;
            textAtqS.Location = new Point(126, 177);
            textAtqS.Name = "textAtqS";
            textAtqS.PlaceholderText = "Attaque signature";
            textAtqS.Size = new Size(152, 16);
            textAtqS.TabIndex = 22;
            // 
            // chkEvolve
            // 
            chkEvolve.AutoSize = true;
            chkEvolve.BackColor = Color.Transparent;
            chkEvolve.BackgroundImageLayout = ImageLayout.None;
            chkEvolve.FlatStyle = FlatStyle.System;
            chkEvolve.Location = new Point(154, 157);
            chkEvolve.Margin = new Padding(3, 2, 3, 2);
            chkEvolve.Name = "chkEvolve";
            chkEvolve.Size = new Size(98, 20);
            chkEvolve.TabIndex = 20;
            chkEvolve.Text = "Peut évoluer";
            chkEvolve.UseVisualStyleBackColor = false;
            // 
            // cmbWeak
            // 
            cmbWeak.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeak.FormattingEnabled = true;
            cmbWeak.Location = new Point(267, 87);
            cmbWeak.Name = "cmbWeak";
            cmbWeak.Size = new Size(94, 23);
            cmbWeak.TabIndex = 19;
            // 
            // labelWeakness
            // 
            labelWeakness.AutoSize = true;
            labelWeakness.Location = new Point(203, 90);
            labelWeakness.Name = "labelWeakness";
            labelWeakness.Size = new Size(60, 15);
            labelWeakness.TabIndex = 18;
            labelWeakness.Text = "Faiblesse :";
            // 
            // RegionLabel
            // 
            RegionLabel.AutoSize = true;
            RegionLabel.Location = new Point(13, 162);
            RegionLabel.Name = "RegionLabel";
            RegionLabel.Size = new Size(50, 15);
            RegionLabel.TabIndex = 16;
            RegionLabel.Text = "Région :";
            // 
            // cmbRegion
            // 
            cmbRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegion.FormattingEnabled = true;
            cmbRegion.Location = new Point(67, 156);
            cmbRegion.Margin = new Padding(3, 2, 3, 2);
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(81, 23);
            cmbRegion.TabIndex = 15;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(13, 193);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(338, 53);
            txtDescription.TabIndex = 14;
            txtDescription.Text = "Description";
            // 
            // btnSearchByRegion
            // 
            btnSearchByRegion.Location = new Point(38, 413);
            btnSearchByRegion.Margin = new Padding(3, 2, 3, 2);
            btnSearchByRegion.Name = "btnSearchByRegion";
            btnSearchByRegion.Size = new Size(159, 23);
            btnSearchByRegion.TabIndex = 17;
            btnSearchByRegion.Text = "Rechercher par Région";
            btnSearchByRegion.UseVisualStyleBackColor = true;
            btnSearchByRegion.Click += btnSearchByRegion_Click;
            // 
            // newPkm
            // 
            newPkm.Location = new Point(712, 520);
            newPkm.Name = "newPkm";
            newPkm.Size = new Size(75, 23);
            newPkm.TabIndex = 18;
            newPkm.Text = "Nouveau Pkm";
            newPkm.UseVisualStyleBackColor = true;
            newPkm.Click += newPkm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.emptyTile;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(911, 575);
            Controls.Add(newPkm);
            Controls.Add(listBoxPokemons);
            Controls.Add(groupBox1);
            Controls.Add(buttonSearchName);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnSearchByRegion);
            Controls.Add(btnDelete);
            Controls.Add(btnList);
            Controls.Add(btnSearchByType);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "PokeDex";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtName;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private ListBox listBoxPokemons;
        private CheckBox chkCaptured;
        private Button btnList;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cmbType;
        private Button btnSearchByType;
        private PictureBox pictureBoxPokemon;
        private TextBox txtImagePath;
        private Button buttonSearchName;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RichTextBox txtDescription;
        private Label RegionLabel;
        private ComboBox cmbRegion;
        private Button btnSearchByRegion;
        private ComboBox cmbWeak;
        private Label labelWeakness;
        private CheckBox chkEvolve;
        private TextBox textAtqS;
        private Label labelAtq;
        private PictureBox pictureBox2;
        private Label label1;
        private ComboBox comboBoxAttck4;
        private ComboBox comboBoxAttck3;
        private ComboBox comboBoxAttck2;
        private ComboBox comboBoxAttck1;
        private Button newPkm;
    }
}
