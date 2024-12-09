namespace PokedexApp
{
    partial class AttackDex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxAttacks = new ListBox();
            labelTypeTitre = new Label();
            textBoxType = new TextBox();
            labelDamageLox = new Label();
            labelDamageHigh = new Label();
            textBoxDamageLow = new TextBox();
            textBoxDamageHigh = new TextBox();
            labelBonus = new Label();
            labelMalus = new Label();
            textBoxBonus = new TextBox();
            textBoxMalus = new TextBox();
            btnSearchbyType = new Button();
            comboBoxTypes = new ComboBox();
            SuspendLayout();
            // 
            // listBoxAttacks
            // 
            listBoxAttacks.FormattingEnabled = true;
            listBoxAttacks.Location = new Point(12, 33);
            listBoxAttacks.Name = "listBoxAttacks";
            listBoxAttacks.Size = new Size(187, 344);
            listBoxAttacks.TabIndex = 0;
            listBoxAttacks.SelectedIndexChanged += listBoxAttacks_SelectedIndexChanged;
            // 
            // labelTypeTitre
            // 
            labelTypeTitre.AutoSize = true;
            labelTypeTitre.Location = new Point(485, 57);
            labelTypeTitre.Name = "labelTypeTitre";
            labelTypeTitre.Size = new Size(47, 20);
            labelTypeTitre.TabIndex = 1;
            labelTypeTitre.Text = "Type :";
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(606, 50);
            textBoxType.Name = "textBoxType";
            textBoxType.ReadOnly = true;
            textBoxType.Size = new Size(125, 27);
            textBoxType.TabIndex = 2;
            // 
            // labelDamageLox
            // 
            labelDamageLox.AutoSize = true;
            labelDamageLox.Location = new Point(427, 121);
            labelDamageLox.Name = "labelDamageLox";
            labelDamageLox.Size = new Size(130, 20);
            labelDamageLox.TabIndex = 3;
            labelDamageLox.Text = "Dégâts minimum :";
            // 
            // labelDamageHigh
            // 
            labelDamageHigh.AutoSize = true;
            labelDamageHigh.Location = new Point(424, 189);
            labelDamageHigh.Name = "labelDamageHigh";
            labelDamageHigh.Size = new Size(133, 20);
            labelDamageHigh.TabIndex = 4;
            labelDamageHigh.Text = "Dégâts maximum :";
            // 
            // textBoxDamageLow
            // 
            textBoxDamageLow.Location = new Point(606, 114);
            textBoxDamageLow.Name = "textBoxDamageLow";
            textBoxDamageLow.ReadOnly = true;
            textBoxDamageLow.Size = new Size(125, 27);
            textBoxDamageLow.TabIndex = 5;
            // 
            // textBoxDamageHigh
            // 
            textBoxDamageHigh.Location = new Point(606, 182);
            textBoxDamageHigh.Name = "textBoxDamageHigh";
            textBoxDamageHigh.ReadOnly = true;
            textBoxDamageHigh.Size = new Size(125, 27);
            textBoxDamageHigh.TabIndex = 6;
            // 
            // labelBonus
            // 
            labelBonus.AutoSize = true;
            labelBonus.Location = new Point(327, 270);
            labelBonus.Name = "labelBonus";
            labelBonus.Size = new Size(194, 20);
            labelBonus.TabIndex = 7;
            labelBonus.Text = "Super efficace sur les types :";
            // 
            // labelMalus
            // 
            labelMalus.AutoSize = true;
            labelMalus.Location = new Point(327, 323);
            labelMalus.Name = "labelMalus";
            labelMalus.Size = new Size(205, 20);
            labelMalus.TabIndex = 8;
            labelMalus.Text = "Pas très efficace sur les types :";
            // 
            // textBoxBonus
            // 
            textBoxBonus.Location = new Point(548, 263);
            textBoxBonus.Name = "textBoxBonus";
            textBoxBonus.ReadOnly = true;
            textBoxBonus.Size = new Size(240, 27);
            textBoxBonus.TabIndex = 9;
            // 
            // textBoxMalus
            // 
            textBoxMalus.Location = new Point(548, 323);
            textBoxMalus.Name = "textBoxMalus";
            textBoxMalus.ReadOnly = true;
            textBoxMalus.Size = new Size(240, 27);
            textBoxMalus.TabIndex = 10;
            // 
            // btnSearchbyType
            // 
            btnSearchbyType.Location = new Point(205, 33);
            btnSearchbyType.Name = "btnSearchbyType";
            btnSearchbyType.Size = new Size(157, 29);
            btnSearchbyType.TabIndex = 11;
            btnSearchbyType.Text = "Rechercher par type";
            btnSearchbyType.UseVisualStyleBackColor = true;
            btnSearchbyType.Click += btnSearchbyType_Click;
            // 
            // comboBoxTypes
            // 
            comboBoxTypes.FormattingEnabled = true;
            comboBoxTypes.Location = new Point(205, 68);
            comboBoxTypes.Name = "comboBoxTypes";
            comboBoxTypes.Size = new Size(151, 28);
            comboBoxTypes.TabIndex = 12;
            // 
            // AttackDex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxTypes);
            Controls.Add(btnSearchbyType);
            Controls.Add(textBoxMalus);
            Controls.Add(textBoxBonus);
            Controls.Add(labelMalus);
            Controls.Add(labelBonus);
            Controls.Add(textBoxDamageHigh);
            Controls.Add(textBoxDamageLow);
            Controls.Add(labelDamageHigh);
            Controls.Add(labelDamageLox);
            Controls.Add(textBoxType);
            Controls.Add(labelTypeTitre);
            Controls.Add(listBoxAttacks);
            Name = "AttackDex";
            Text = "AttackDex";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAttacks;
        private Label labelTypeTitre;
        private TextBox textBoxType;
        private Label labelDamageLox;
        private Label labelDamageHigh;
        private TextBox textBoxDamageLow;
        private TextBox textBoxDamageHigh;
        private Label labelBonus;
        private Label labelMalus;
        private TextBox textBoxBonus;
        private TextBox textBoxMalus;
        private Button btnSearchbyType;
        private ComboBox comboBoxTypes;
    }
}