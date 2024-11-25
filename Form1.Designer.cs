
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
            groupBox1 = new GroupBox();
            btnSearchByType = new Button();
            cmbType = new ComboBox();
            btnList = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            chkCaptured = new CheckBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            listBoxPokemons = new ListBox();
            pictureBoxPokemon = new PictureBox();
            txtImagePath = new TextBox();
            buttonSearchName = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSearchName);
            groupBox1.Controls.Add(btnSearchByType);
            groupBox1.Controls.Add(cmbType);
            groupBox1.Controls.Add(btnList);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(chkCaptured);
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(txtWeight);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(425, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(318, 543);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détails du pokémon";
            // 
            // btnSearchByType
            // 
            btnSearchByType.Location = new Point(73, 447);
            btnSearchByType.Margin = new Padding(3, 4, 3, 4);
            btnSearchByType.Name = "btnSearchByType";
            btnSearchByType.Size = new Size(189, 31);
            btnSearchByType.TabIndex = 11;
            btnSearchByType.Text = "Rechercher par Type";
            btnSearchByType.UseVisualStyleBackColor = true;
            btnSearchByType.Click += btnSearchByType_Click;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(7, 125);
            cmbType.Margin = new Padding(3, 4, 3, 4);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(303, 28);
            cmbType.TabIndex = 10;
            // 
            // btnList
            // 
            btnList.Location = new Point(93, 395);
            btnList.Margin = new Padding(3, 4, 3, 4);
            btnList.Name = "btnList";
            btnList.Size = new Size(150, 31);
            btnList.TabIndex = 9;
            btnList.Text = "Rafraichir le Pokédex";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(123, 340);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Editer";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(224, 292);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 292);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // chkCaptured
            // 
            chkCaptured.AutoSize = true;
            chkCaptured.Location = new Point(214, 241);
            chkCaptured.Margin = new Padding(3, 4, 3, 4);
            chkCaptured.Name = "chkCaptured";
            chkCaptured.Size = new Size(104, 24);
            chkCaptured.TabIndex = 5;
            chkCaptured.Text = "Est capturé";
            chkCaptured.UseVisualStyleBackColor = true;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(8, 203);
            txtHeight.Margin = new Padding(3, 4, 3, 4);
            txtHeight.Name = "txtHeight";
            txtHeight.PlaceholderText = "Taille";
            txtHeight.Size = new Size(302, 27);
            txtHeight.TabIndex = 4;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(7, 164);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.PlaceholderText = "Poids";
            txtWeight.Size = new Size(302, 27);
            txtWeight.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(7, 84);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(302, 27);
            txtDescription.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(7, 29);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nom";
            txtName.Size = new Size(302, 27);
            txtName.TabIndex = 0;
            // 
            // listBoxPokemons
            // 
            listBoxPokemons.FormattingEnabled = true;
            listBoxPokemons.Location = new Point(14, 16);
            listBoxPokemons.Margin = new Padding(3, 4, 3, 4);
            listBoxPokemons.Name = "listBoxPokemons";
            listBoxPokemons.Size = new Size(404, 324);
            listBoxPokemons.TabIndex = 1;
            listBoxPokemons.SelectedIndexChanged += listBoxPokemons_SelectedIndexChanged;
            // 
            // pictureBoxPokemon
            // 
            pictureBoxPokemon.Location = new Point(14, 356);
            pictureBoxPokemon.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPokemon.Name = "pictureBoxPokemon";
            pictureBoxPokemon.Size = new Size(405, 403);
            pictureBoxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPokemon.TabIndex = 2;
            pictureBoxPokemon.TabStop = false;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(469, 567);
            txtImagePath.Margin = new Padding(3, 4, 3, 4);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(244, 27);
            txtImagePath.TabIndex = 3;
            txtImagePath.Visible = false;
            // 
            // buttonSearchName
            // 
            buttonSearchName.Location = new Point(73, 486);
            buttonSearchName.Margin = new Padding(3, 4, 3, 4);
            buttonSearchName.Name = "buttonSearchName";
            buttonSearchName.Size = new Size(189, 31);
            buttonSearchName.TabIndex = 12;
            buttonSearchName.Text = "Rechercher par Nom";
            buttonSearchName.UseVisualStyleBackColor = true;
            buttonSearchName.Click += buttonSearchName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 859);
            Controls.Add(txtImagePath);
            Controls.Add(pictureBoxPokemon);
            Controls.Add(listBoxPokemons);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtName;
        private TextBox txtDescription;
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
    }
}
