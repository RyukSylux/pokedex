
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
            cmbWeak = new ComboBox();
            labelWeakness = new Label();
            btnSearchByRegion = new Button();
            RegionLabel = new Label();
            cmbRegion = new ComboBox();
            txtDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSearchName
            // 
            buttonSearchName.Location = new Point(224, 290);
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
            btnSearchByType.Location = new Point(224, 264);
            btnSearchByType.Margin = new Padding(3, 2, 3, 2);
            btnSearchByType.Name = "btnSearchByType";
            btnSearchByType.Size = new Size(137, 23);
            btnSearchByType.TabIndex = 11;
            btnSearchByType.Text = "Rechercher par Type";
            btnSearchByType.UseVisualStyleBackColor = true;
            btnSearchByType.Click += btnSearchByType_Click;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(137, 52);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(106, 23);
            cmbType.TabIndex = 10;
            // 
            // btnList
            // 
            btnList.Location = new Point(3, 264);
            btnList.Margin = new Padding(3, 2, 3, 2);
            btnList.Name = "btnList";
            btnList.Size = new Size(139, 23);
            btnList.TabIndex = 9;
            btnList.Text = "Rafraichir le Pokédex";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(137, 237);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(58, 23);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Editer";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(294, 237);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 237);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(58, 23);
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
            chkCaptured.Location = new Point(271, 142);
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
            txtHeight.Location = new Point(240, 108);
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
            txtWeight.Location = new Point(240, 128);
            txtWeight.Margin = new Padding(3, 2, 3, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.PlaceholderText = "Poids";
            txtWeight.Size = new Size(37, 16);
            txtWeight.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(188, 32);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nom";
            txtName.Size = new Size(133, 16);
            txtName.TabIndex = 0;
            // 
            // listBoxPokemons
            // 
            listBoxPokemons.FormattingEnabled = true;
            listBoxPokemons.ItemHeight = 15;
            listBoxPokemons.Location = new Point(38, 150);
            listBoxPokemons.Margin = new Padding(3, 2, 3, 2);
            listBoxPokemons.Name = "listBoxPokemons";
            listBoxPokemons.Size = new Size(373, 319);
            listBoxPokemons.TabIndex = 1;
            listBoxPokemons.SelectedIndexChanged += listBoxPokemons_SelectedIndexChanged;
            // 
            // pictureBoxPokemon
            // 
            pictureBoxPokemon.BackColor = Color.FromArgb(255, 255, 128);
            pictureBoxPokemon.Location = new Point(12, 38);
            pictureBoxPokemon.Margin = new Padding(3, 2, 3, 2);
            pictureBoxPokemon.Name = "pictureBoxPokemon";
            pictureBoxPokemon.Size = new Size(116, 98);
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
            pictureBox1.Size = new Size(358, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbWeak);
            groupBox1.Controls.Add(labelWeakness);
            groupBox1.Controls.Add(btnSearchByRegion);
            groupBox1.Controls.Add(RegionLabel);
            groupBox1.Controls.Add(cmbRegion);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(pictureBoxPokemon);
            groupBox1.Controls.Add(btnSearchByType);
            groupBox1.Controls.Add(buttonSearchName);
            groupBox1.Controls.Add(cmbType);
            groupBox1.Controls.Add(txtImagePath);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnList);
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(txtWeight);
            groupBox1.Controls.Add(btnAdd);
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
            // cmbWeak
            // 
            cmbWeak.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeak.FormattingEnabled = true;
            cmbWeak.Location = new Point(267, 80);
            cmbWeak.Name = "cmbWeak";
            cmbWeak.Size = new Size(89, 23);
            cmbWeak.TabIndex = 19;
            // 
            // labelWeakness
            // 
            labelWeakness.AutoSize = true;
            labelWeakness.Location = new Point(203, 83);
            labelWeakness.Name = "labelWeakness";
            labelWeakness.Size = new Size(60, 15);
            labelWeakness.TabIndex = 18;
            labelWeakness.Text = "Faiblesse :";
            // 
            // btnSearchByRegion
            // 
            btnSearchByRegion.Location = new Point(224, 317);
            btnSearchByRegion.Margin = new Padding(3, 2, 3, 2);
            btnSearchByRegion.Name = "btnSearchByRegion";
            btnSearchByRegion.Size = new Size(137, 23);
            btnSearchByRegion.TabIndex = 17;
            btnSearchByRegion.Text = "Rechercher par Région";
            btnSearchByRegion.UseVisualStyleBackColor = true;
            btnSearchByRegion.Click += btnSearchByRegion_Click;
            // 
            // RegionLabel
            // 
            RegionLabel.AutoSize = true;
            RegionLabel.Location = new Point(15, 139);
            RegionLabel.Name = "RegionLabel";
            RegionLabel.Size = new Size(50, 15);
            RegionLabel.TabIndex = 16;
            RegionLabel.Text = "Région :";
            // 
            // cmbRegion
            // 
            cmbRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegion.FormattingEnabled = true;
            cmbRegion.Location = new Point(71, 136);
            cmbRegion.Margin = new Padding(3, 2, 3, 2);
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(71, 23);
            cmbRegion.TabIndex = 15;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(12, 163);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(337, 60);
            txtDescription.TabIndex = 14;
            txtDescription.Text = "Description";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.emptyTile;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(911, 575);
            Controls.Add(listBoxPokemons);
            Controls.Add(groupBox1);
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
    }
}
