using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;

namespace PokedexApp
{

    public partial class Form1 : Form
    {
        private List<Pokemon> pokemons = new List<Pokemon>();
        private int nextId = 31; // Pour auto-incr�menter les IDs
        private static readonly string ImagesFolderPath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "images\\");

        // Liste des attaques disponibles
        List<string> allAttacks = new List<string>
            {
                "-",
                // type psy tmts
                "Ultrason",
                // attaques acier
                "Griffe Acier",
                // Attaques normales
                "Charge", "Vive-Attaque", "Damocl�s", "M�t�ores", "Poursuite", "Rugissement", "Combo-Griffe", "Coup d'Boule", "Griffe", "�crasement",

                // Attaques de type Feu
                "Flamm�che", "Lance-Flammes", "Danse-Flamme", "D�flagration", "Nitrocharge", "Feu Follet", "Surchauffe", "Poing de Feu", "Boutefeu", "Vortex Magma",

                // Attaques de type Eau
                "Pistolet � O", "Surf", "Hydrocanon", "Cascade", "�bullition", "Plong�e", "Bulles d�O", "Danse Pluie", "Ocroupi", "Hydroqueue", "Rafale Hydro",

                // Attaques de type Plante
                "Fouet Lianes", "Canon Graine", "Tranch'Herbe", "Lance-Soleil", "Synth�se", "Vampigraine", "M�ga-Sangsue", "Temp�teverte", "Noeud Herbe", "Feuillemagik",

                // Attaques de type �lectrique
                "�clair", "Fatal-Foudre", "Cage-�clair", "Tonnerre", "Crocs �clair", "�tincelle", "Change�clair", "Parabocharge", "�lectacle", "Tonnerre Charge",

                // Attaques de type Roche
                "Jet-Pierres", "�boulement", "Lame de Roc", "Pouvoir Antique", "Pi�ge de Roc", "Tacle Lourd", "Force Naturelle", "Tomberoche", "Roulade", "Hurlement",

                // Attaques de type Sol
                "Jet de Sable", "S�isme", "Tunnel", "Coud�Boue", "Pi�ge de Sable", "Ampleur", "Telluriforce", "Tourbi-Sable", "Pi�tisol", "Ab�me",

                // Attaques de type Insecte
                "Armure", "Dard-Venin", "Bourdon", "Vent Argent�", "Piq�re", "Coupe", "Plaie Croix", "Survinsecte", "Picore", "Demi-Tour",

                // Attaques de type Vol
                "Tornade", "H�te", "Cru-Aile", "A�ropique", "Rapace", "Atterrissage", "Cyclone", "Vent Arri�re", "Lame d�Air", "Hurle-Temps",

                // Attaques de type Combat
                "Balayette", "Poing-Karat�", "Close Combat", "Mitra-Poing", "Poing-Boost", "Mach Punch", "Coup-Croix", "Choc M�t�ore", "Dynamopoing", "Riposte",

                // Attaques de type F�e
                "Charme", "C�linerie", "Pouvoir Lunaire", "Voeu Soin", "Vague Psy", "Lumi-�clat", "Vent F��rique", "Rune Protect", "Danse-Lune", "�cras�Face",

                // Attaques de type Spectre
                "L�chouille", "Ombre Port�e", "Ball�Ombre", "Onde Folie", "Feu Fatu", "T�n�bres", "Spectres-Bouclier", "T�n�br�me", "Vibrasoin", "Mal�fice",

                // Attaques de type Dragon
                "Ultralaser", "Col�re", "Draco-Rage", "Vibraqua", "Danse Draco", "Dracochoc", "Dracossouffle", "Hurle-Temps", "Temp�teverte", "Lance Draco",

                // Attaques de type T�n�bres
                "Morsure", "Poursuite", "M�chouille", "Sabotage", "Provoc", "Crocs Feu", "Tricherie", "Bluff", "Coup Bas", "Sombre-Larme",

                // Attaques de type Glace
                "Poudreuse", "Laser Glace", "Blizzard", "Onde Bor�ale", "Vent Glac�", "Eclats Glace", "Avalanche", "Chute Glace", "Poing-Glace", "Gr�le",

                // Attaques de statut (multitype)
                "Protection", "Mur Lumi�re", "Clonage", "Hypnose", "Provoc", "Boost", "Reflet", "Regard Noir", "Grincement", "Berceuse", "T�l�port",
                // Attaques des Pok�mon
                "�boulement", "Coup d'Main", "Roulade", "S�isme", // Kranidos
                "Morsure", "Tacle", "Mimi-Queue", "H�te", // �voli
                "Crocs �clair", "Griffe", "Vive-Attaque", "Tonnerre", // Lixy
                "Psyko", "Doux Baiser", "M�ditation", "Soin", // Cerfrousse
                "�claboussure", "Barrage", "Aqua Jet", "Hydrocanon", // Azurill
                "Pistolet � O", "Rafale Hydro", "Ultrason", "Poudre Dodo", // Tiplouf
                "Aurasph�re", "Poing-Glace", "Griffe", "Coup d'Poing", // Lucario
                "Ultralaser", "Draco-Rage", "Griffe", "Lance-Dragon", // Draco
                "Canon Graine", "Fouet Lianes", "Dard-Venin", "Rugissement", // Tortipouss
                "Tranch'Herbe", "Coup d'Main", "Vive-Attaque", "Rugissement", // Arcko
                "Spore Coton", "Fouet Lianes", "Poudre Dodo", "Tranch'Herbe", // Balignon
                "Parabocharge", "Tonnerre", "Vive-Attaque", "Queue de Fer", // Pachirisu
                "Surf", "Barrage", "Hydrocanon", "Plongeon", // D�manta
                "Force Chtonienne", "Draco-Queue", "S�isme", "Lance-Dragon" // Zygarde
            };

        public Form1()
        {
            // Liste de Pok�mon pr�remplis

            pokemons = new List<Pokemon>
                {
                    new Pokemon { ID = 1, Name = "Bulbizarre", Type = "Plante", Description = "Un Pok�mon graine qui aime le soleil.", Weight = 6.9, Height = 0.7, IsCaptured = true, ImagePath = ImagesFolderPath + "bulbizarre.png", Region = "Kanto", Weakness = "Feu", CanEvolve = true, AtqSign = "Fouet Lianes",Attacks = new List<string> { "Fouet Lianes", "Tranch'Herbe", "Canon Graine", "Dard-Venin" } },
                    new Pokemon { ID = 2, Name = "Salam�che", Type = "Feu", Description = "Sa queue br�le en permanence.", Weight = 8.5, Height = 0.6, IsCaptured = false, ImagePath = ImagesFolderPath + "salameche.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Flamm�che", Attacks = new List<string> { "Flamm�che", "Griffe", "Lance-Flammes", "Griffe Acier" } },
                    new Pokemon { ID = 3, Name = "Carapuce", Type = "Eau", Description = "Sa carapace le prot�ge des attaques.", Weight = 9.0, Height = 0.5, IsCaptured = true, ImagePath = ImagesFolderPath + "carapuce.png", Region = "Kanto", Weakness = "Plante", CanEvolve = true, AtqSign = "Pistolet � O", Attacks = new List<string> { "Pistolet � O", "Morsure", "Ultrason", "Rafale Hydro" }},
                    new Pokemon { ID = 4, Name = "Pikachu", Type = "�lectrique", Description = "Un Pok�mon tr�s populaire qui stocke l'�lectricit� dans ses joues.", Weight = 6.0, Height = 0.4, IsCaptured = false, ImagePath = ImagesFolderPath + "pikachu.png", Region = "Kanto", Weakness = "Sol", CanEvolve = true, AtqSign = "�clair", Attacks = new List<string> { "�clair", "Vive-Attaque", "Queue de Fer", "Tonnerre" }},
                    new Pokemon { ID = 5, Name = "Roucool", Type = "Vol", Description = "Il est souvent trouv� dans les champs et for�ts.", Weight = 1.8, Height = 0.3, IsCaptured = true, ImagePath = ImagesFolderPath + "roucool.png", Region = "Kanto", Weakness = "�lectrique", CanEvolve = true, AtqSign = "Tornade", Attacks = new List<string> { "Tornade", "Mimi-Queue", "Vive-Attaque", "Vent Violent" }},
                    new Pokemon { ID = 6, Name = "Rattata", Type = "Normal", Description = "Un rongeur rapide et agressif.", Weight = 3.5, Height = 0.3, IsCaptured = false, ImagePath = ImagesFolderPath + "rattata.png", Region = "Kanto", Weakness = "Combat", CanEvolve = true, AtqSign = "Vive-Attaque" , Attacks = new List<string> { "Vive-Attaque", "Griffe", "Morsure", "Queue de Fer" } },
                    new Pokemon { ID = 7, Name = "Sabelette", Type = "Sol", Description = "Il s'enroule pour se prot�ger.", Weight = 12.0, Height = 0.6, IsCaptured = false, ImagePath = ImagesFolderPath + "sabelette.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Jet de Sable" , Attacks = new List<string> { "Jet de Sable", "Griffe", "Pi�ge de Roc", "S�isme" }},
                    new Pokemon { ID = 8, Name = "Goupix", Type = "Feu", Description = "Sa queue s'illumine lorsqu'il est heureux.", Weight = 9.9, Height = 0.6, IsCaptured = true, ImagePath = ImagesFolderPath + "goupix.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Flamm�che" , Attacks = new List<string> { "Flamm�che", "Rugissement", "Lance-Flammes", "Griffe" }},
                    new Pokemon { ID = 9, Name = "M�lof�e", Type = "F�e", Description = "Il danse � la lumi�re de la lune.", Weight = 7.5, Height = 0.6, IsCaptured = false, ImagePath = ImagesFolderPath + "melofee.png", Region = "Kanto", Weakness = "Acier", CanEvolve = true, AtqSign = "Vague Psy" , Attacks = new List<string> { "Vague Psy", "Doux Baiser", "M�ditation", "Soin" }},
                    new Pokemon { ID = 10, Name = "Paras", Type = "Insecte", Description = "Il transporte des spores sur son dos.", Weight = 5.4, Height = 0.3, IsCaptured = true, ImagePath = ImagesFolderPath + "paras.png", Region = "Kanto", Weakness = "Vol", CanEvolve = true, AtqSign = "Spore" , Attacks = new List<string> { "Spore", "Coup d'Main", "Dard-Venin", "Poudre Dodo" }},
                    new Pokemon { ID = 11, Name = "Mimitoss", Type = "Insecte", Description = "Ses yeux brillants sont fascinants.", Weight = 30.0, Height = 1.0, IsCaptured = false, ImagePath = ImagesFolderPath + "mimitoss.png", Region = "Kanto", Weakness = "Feu", CanEvolve = true, AtqSign = "Poudre Toxik" , Attacks = new List<string> { "Poudre Toxik", "Soin", "Mimi-Queue", "Psychup" }},
                    new Pokemon { ID = 12, Name = "Tentacool", Type = "Eau", Description = "Un Pok�mon marin avec des tentacules venimeux.", Weight = 45.5, Height = 0.9, IsCaptured = false, ImagePath = ImagesFolderPath + "tentacool.png", Region = "Kanto", Weakness = "�lectrique", CanEvolve = true, AtqSign = "Acide" , Attacks = new List<string> { "Acide", "Pistolet � O", "Toxic", "Rafale Hydro" }},
                    new Pokemon { ID = 13, Name = "Ponyta", Type = "Feu", Description = "Ses flammes ne br�lent que s'il est en danger.", Weight = 30.0, Height = 1.0, IsCaptured = true, ImagePath = ImagesFolderPath + "ponyta.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Charge" , Attacks = new List<string> { "Charge", "Flamm�che", "Rugissement", "Lance-Flammes" }},
                    new Pokemon { ID = 14, Name = "Magn�ti", Type = "�lectrique", Description = "Il g�n�re des champs magn�tiques puissants.", Weight = 6.0, Height = 0.3, IsCaptured = false, ImagePath = ImagesFolderPath + "magneti.png", Region = "Kanto", Weakness = "Sol", CanEvolve = true, AtqSign = "Onde de Choc" , Attacks = new List<string> { "Onde de Choc", "�lectromagn�tisme", "Toxik", "Puissance" }},
                    new Pokemon { ID = 15, Name = "Onix", Type = "Roche", Description = "Un �norme serpent de pierre.", Weight = 210.0, Height = 8.8, IsCaptured = true, ImagePath = ImagesFolderPath + "onix.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "�boulement" , Attacks = new List<string> { "�boulement", "Coup d'Main", "Roulade", "S�isme" }},
                    new Pokemon { ID = 16, Name = "Fantominus", Type = "Spectre", Description = "Un Pok�mon gaz qui peut traverser les murs.", Weight = 0.1, Height = 1.3, IsCaptured = false, ImagePath = ImagesFolderPath + "fantominus.png", Region = "Kanto", Weakness = "T�n�bres", CanEvolve = true, AtqSign = "L�chouille" , Attacks = new List<string> { "L�chouille", "Psyko", "Ball'Ombre", "Vibraqua" }},
                    new Pokemon { ID = 17, Name = "Kranidos", Type = "Roche", Description = "Un dinosaure avec une t�te dure comme le roc.", Weight = 37.0, Height = 0.9, IsCaptured = false, ImagePath = ImagesFolderPath + "kranidos.png", Region = "Sinnoh", Weakness = "Eau", CanEvolve = true, AtqSign = "Coup d'Boule", Attacks = new List<string> { "�boulement", "Coup d'Main", "Roulade", "S�isme" } },
                    new Pokemon { ID = 18, Name = "�voli", Type = "Normal", Description = "Il peut �voluer sous diff�rentes formes.", Weight = 6.5, Height = 0.3, IsCaptured = true, ImagePath = ImagesFolderPath + "evoli.png", Region = "Kanto", Weakness = "Combat", CanEvolve = true, AtqSign = "Morsure", Attacks = new List<string> { "Morsure", "Tacle", "Mimi-Queue", "H�te" } },
                    new Pokemon { ID = 19, Name = "Lixy", Type = "�lectrique", Description = "Un lionceau qui �met des �tincelles.", Weight = 9.5, Height = 0.5, IsCaptured = false, ImagePath = ImagesFolderPath + "lixy.png", Region = "Sinnoh", Weakness = "Sol", CanEvolve = true, AtqSign = "Crocs �clair", Attacks = new List<string> { "Crocs �clair", "Griffe", "Vive-Attaque", "Tonnerre" } },
                    new Pokemon { ID = 20, Name = "Cerfrousse", Type = "Normal", Description = "Il ressemble � un cerf majestueux.", Weight = 71.2, Height = 1.4, IsCaptured = true, ImagePath = ImagesFolderPath + "cerfrousse.png", Region = "Johto", Weakness = "Combat", CanEvolve = false, AtqSign = "Psyko", Attacks = new List<string> { "Psyko", "Doux Baiser", "M�ditation", "Soin" } },
                    new Pokemon { ID = 21, Name = "Azurill", Type = "Eau", Description = "Un petit Pok�mon qui joue avec sa queue flottante.", Weight = 2.0, Height = 0.2, IsCaptured = false, ImagePath = ImagesFolderPath + "azurill.png", Region = "Hoenn", Weakness = "Plante", CanEvolve = true, AtqSign = "�claboussure", Attacks = new List<string> { "�claboussure", "Barrage", "Aqua Jet", "Hydrocanon" } },
                    new Pokemon { ID = 22, Name = "Tiplouf", Type = "Eau", Description = "Un pingouin �l�gant et courageux.", Weight = 5.2, Height = 0.4, IsCaptured = true, ImagePath = ImagesFolderPath + "tiplouf.png", Region = "Sinnoh", Weakness = "Plante", CanEvolve = true, AtqSign = "Pistolet � O", Attacks = new List<string> { "Pistolet � O", "Rafale Hydro", "Ultrason", "Poudre Dodo" } },
                    new Pokemon { ID = 23, Name = "Lucario", Type = "Combat", Description = "Il ressent les auras des �tres vivants.", Weight = 54.0, Height = 1.2, IsCaptured = false, ImagePath = ImagesFolderPath + "lucario.png", Region = "Sinnoh", Weakness = "Psy", CanEvolve = false, AtqSign = "Aurasph�re", Attacks = new List<string> { "Aurasph�re", "Poing-Glace", "Griffe", "Coup d'Poing" } },
                    new Pokemon { ID = 24, Name = "Draco", Type = "Dragon", Description = "Un Pok�mon dragon au corps �l�gant.", Weight = 16.5, Height = 4.0, IsCaptured = true, ImagePath = ImagesFolderPath + "draco.png", Region = "Kanto", Weakness = "Glace", CanEvolve = true, AtqSign = "Ultralaser", Attacks = new List<string> { "Ultralaser", "Draco-Rage", "Griffe", "Lance-Dragon" } },
                    new Pokemon { ID = 25, Name = "Tortipouss", Type = "Plante", Description = "Il porte une petite pousse sur sa t�te.", Weight = 10.2, Height = 0.4, IsCaptured = false, ImagePath = ImagesFolderPath + "tortipouss.png", Region = "Sinnoh", Weakness = "Feu", CanEvolve = true, AtqSign = "Canon Graine", Attacks = new List<string> { "Canon Graine", "Fouet Lianes", "Dard-Venin", "Rugissement" } },
                    new Pokemon { ID = 26, Name = "Arcko", Type = "Plante", Description = "Un Pok�mon agile et vif.", Weight = 5.0, Height = 0.5, IsCaptured = true, ImagePath = ImagesFolderPath + "arcko.png", Region = "Hoenn", Weakness = "Feu", CanEvolve = true, AtqSign = "Tranch'Herbe", Attacks = new List<string> { "Tranch'Herbe", "Coup d'Main", "Vive-Attaque", "Rugissement" } },
                    new Pokemon { ID = 27, Name = "Balignon", Type = "Plante", Description = "Il ressemble � un champignon.", Weight = 4.5, Height = 0.3, IsCaptured = false, ImagePath = ImagesFolderPath + "balignon.png", Region = "Hoenn", Weakness = "Feu", CanEvolve = true, AtqSign = "Spore Coton", Attacks = new List<string> { "Spore Coton", "Fouet Lianes", "Poudre Dodo", "Tranch'Herbe" } },
                    new Pokemon { ID = 28, Name = "Pachirisu", Type = "�lectrique", Description = "Un �cureuil �lectrique rapide.", Weight = 3.9, Height = 0.4, IsCaptured = true, ImagePath = ImagesFolderPath + "pachirisu.png", Region = "Sinnoh", Weakness = "Sol", CanEvolve = false, AtqSign = "Parabocharge", Attacks = new List<string> { "Parabocharge", "Tonnerre", "Vive-Attaque", "Queue de Fer" } },
                    new Pokemon { ID = 29, Name = "D�manta", Type = "Eau", Description = "Un Pok�mon marin qui glisse sur l'eau.", Weight = 220.0, Height = 2.1, IsCaptured = false, ImagePath = ImagesFolderPath + "demanta.png", Region = "Johto", Weakness = "�lectrique", CanEvolve = false, AtqSign = "Surf", Attacks = new List<string> { "Surf", "Barrage", "Hydrocanon", "Plongeon" } },
                    new Pokemon { ID = 30, Name = "Zygarde", Type = "Dragon", Description = "Le gardien de l'�quilibre �cologique.", Weight = 305.0, Height = 5.0, IsCaptured = true, ImagePath = ImagesFolderPath + "zygarde.png", Region = "Kalos", Weakness = "F�e", CanEvolve = false, AtqSign = "Force Chtonienne", Attacks = new List<string> { "Force Chtonienne", "Draco-Queue", "S�isme", "Lance-Dragon" } }
                };
            InitializeComponent();
            UpdatePokemonList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "S�lectionner une image pour le Pok�mon";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Afficher l'image s�lectionn�e dans le PictureBox
                    pictureBoxPokemon.ImageLocation = openFileDialog.FileName;

                    // Stocker le chemin de l'image temporairement
                    txtImagePath.Text = openFileDialog.FileName;
                }
                else
                {
                    pictureBoxPokemon.ImageLocation = ImagesFolderPath + "missingno.png";
                    txtImagePath.Text = ImagesFolderPath + "missingno.png";
                }
            }
            try
            {
                if (ValidateInputFields())
                {
                    // Ajouter un Pok�mon
                    var pokemon = new Pokemon
                    {
                        ID = nextId++,
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        Type = cmbType.SelectedItem.ToString(),
                        Weight = double.Parse(txtWeight.Text),
                        Height = double.Parse(txtHeight.Text),
                        IsCaptured = chkCaptured.Checked,
                        CanEvolve = chkEvolve.Checked,
                        ImagePath = txtImagePath.Text,
                        Region = cmbRegion.SelectedItem.ToString(),
                        Weakness = cmbWeak.SelectedItem.ToString(),
                        AtqSign = textAtqS.Text,
                        Attacks = new List<string> { comboBoxAttck1.Text, comboBoxAttck2.Text, comboBoxAttck3.Text, comboBoxAttck4.Text }
                    };
                    pokemons.Add(pokemon);
                    allAttacks = allAttacks.Union(pokemon.Attacks).ToList();

                    comboBoxAttck1.DataSource = new List<string>(allAttacks);
                    comboBoxAttck2.DataSource = new List<string>(allAttacks);
                    comboBoxAttck3.DataSource = new List<string>(allAttacks);
                    comboBoxAttck4.DataSource = new List<string>(allAttacks);

                    UpdatePokemonList();
                    listBoxPokemons.SelectedItem = pokemon;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de l'ajout du Pok�mon : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Supprimer un Pok�mon
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                pokemons.Remove(selectedPokemon);
                UpdatePokemonList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner un Pok�mon � supprimer.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // �diter un Pok�mon
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                if (ValidateInputFields())
                {

                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.bmp";
                        openFileDialog.Title = "S�lectionner une image pour le Pok�mon";

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Afficher l'image s�lectionn�e dans le PictureBox
                            pictureBoxPokemon.ImageLocation = openFileDialog.FileName;

                            // Stocker le chemin de l'image temporairement
                            txtImagePath.Text = openFileDialog.FileName;
                        }
                        else if (txtImagePath.Text == "")
                        {
                            pictureBoxPokemon.ImageLocation = ImagesFolderPath + "missingno.png";
                            txtImagePath.Text = ImagesFolderPath + "missingno.png";
                        }
                    }


                    selectedPokemon.Name = txtName.Text;
                    selectedPokemon.Description = txtDescription.Text;
                    selectedPokemon.Type = cmbType.SelectedItem.ToString();
                    selectedPokemon.Weight = double.Parse(txtWeight.Text);
                    selectedPokemon.Height = double.Parse(txtHeight.Text);
                    selectedPokemon.IsCaptured = chkCaptured.Checked;
                    selectedPokemon.CanEvolve = chkEvolve.Checked;
                    selectedPokemon.ImagePath = txtImagePath.Text;
                    selectedPokemon.Region = cmbRegion.Text;
                    selectedPokemon.Weakness = cmbWeak.Text;
                    selectedPokemon.AtqSign = textAtqS.Text;
                    selectedPokemon.Attacks = new List<string> { comboBoxAttck1.Text, comboBoxAttck2.Text, comboBoxAttck3.Text, comboBoxAttck4.Text };

                    allAttacks = allAttacks.Union(selectedPokemon.Attacks).ToList();

                    comboBoxAttck1.DataSource = new List<string>(allAttacks);
                    comboBoxAttck2.DataSource = new List<string>(allAttacks);
                    comboBoxAttck3.DataSource = new List<string>(allAttacks);
                    comboBoxAttck4.DataSource = new List<string>(allAttacks);
                    UpdatePokemonList();

                    listBoxPokemons.SelectedItem = txtName.Text;
                }
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner un Pok�mon � �diter.");
            }
        }

        private void listBoxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            //V�rifie si un Pok�mon est s�lectionn�
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {

                //Remplit les champs avec les informations du Pok�mon
                txtName.Text = selectedPokemon.Name;
                txtDescription.Text = selectedPokemon.Description;
                cmbType.SelectedItem = selectedPokemon.Type;
                txtWeight.Text = selectedPokemon.Weight.ToString();
                txtHeight.Text = selectedPokemon.Height.ToString();
                chkCaptured.Checked = selectedPokemon.IsCaptured;
                chkEvolve.Checked = selectedPokemon.CanEvolve;
                txtImagePath.Text = selectedPokemon.ImagePath;
                cmbRegion.SelectedItem = selectedPokemon.Region;
                cmbWeak.SelectedItem = selectedPokemon.Weakness;
                textAtqS.Text = selectedPokemon.AtqSign;
                string imgType = ImagesFolderPath + selectedPokemon.Type + ".png";

                if (selectedPokemon.Attacks.Count >= 1) comboBoxAttck1.SelectedItem = selectedPokemon.Attacks[0]; else { comboBoxAttck1.SelectedIndex = 0; }
                if (selectedPokemon.Attacks.Count >= 2) comboBoxAttck2.SelectedItem = selectedPokemon.Attacks[1]; else { comboBoxAttck2.SelectedIndex = 0; }
                if (selectedPokemon.Attacks.Count >= 3) comboBoxAttck3.SelectedItem = selectedPokemon.Attacks[2]; else { comboBoxAttck3.SelectedIndex = 0; }
                if (selectedPokemon.Attacks.Count >= 4) comboBoxAttck4.SelectedItem = selectedPokemon.Attacks[3]; else { comboBoxAttck4.SelectedIndex = 0; }

                comboBoxAttck1.Refresh();
                comboBoxAttck2.Refresh();
                comboBoxAttck3.Refresh();
                comboBoxAttck4.Refresh();


                if (!string.IsNullOrEmpty(selectedPokemon.ImagePath) && System.IO.File.Exists(selectedPokemon.ImagePath))
                {
                    pictureBoxPokemon.ImageLocation = selectedPokemon.ImagePath;
                }
                else
                {
                    pictureBoxPokemon.Image = null; // Si aucune image, vide le PictureBox
                }

                if (!string.IsNullOrEmpty(selectedPokemon.Type) && System.IO.File.Exists(imgType))
                {
                    pictureBoxType.ImageLocation = imgType;
                }
                else
                {
                    pictureBoxType.Image = null; // Si aucune image, vide le PictureBox
                }


            }
            else
            {
                // Si rien n'est s�lectionn�, vide les champs
                ClearInputFields();
            }
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            UpdatePokemonList();
        }

        private void UpdatePokemonList()
        {
            listBoxPokemons.DataSource = null;
            listBoxPokemons.DataSource = pokemons;

        }

        private void ClearInputFields()
        {
            txtName.Text = null;
            txtDescription.Text = null;
            cmbType.SelectedIndex = -1;
            cmbRegion.SelectedIndex = -1;
            cmbWeak.SelectedIndex = -1;
            txtWeight.Text = null;
            txtHeight.Text = null;
            chkCaptured.Checked = false;
            chkEvolve.Checked = false;
            txtImagePath.Text = null;
            pictureBoxPokemon.ImageLocation = null;
            textAtqS.Text = null;
            comboBoxAttck1.SelectedIndex = 0;
            comboBoxAttck2.SelectedIndex = 0;
            comboBoxAttck3.SelectedIndex = 0;
            comboBoxAttck4.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbType.Items.AddRange(new string[]
            {
                "Normal", "Feu", "Eau", "Plante", "�lectrique", "Glace",
                "Combat", "Poison", "Sol", "Vol", "Psy", "Insecte",
                "Roche", "Spectre", "Dragon", "T�n�bres", "Acier", "F�e"
            });

            cmbRegion.Items.AddRange(new string[]{
                "Kanto", "Johto", "Hoenn", "Sinnoh","Kalos"
            });

            cmbWeak.Items.AddRange(new string[]{
                "Feu", "Eau", "Plante", "�lectrique", "Glace",
                "Combat", "Poison", "Sol", "Vol", "Psy", "Insecte",
                "Roche", "Spectre", "Dragon", "T�n�bres", "Acier", "F�e"
            });


            foreach (var pokemon in pokemons)
            {
                allAttacks = allAttacks.Union(pokemon.Attacks).ToList();
            }

            // Remplir les ComboBox avec les attaques
            comboBoxAttck1.DataSource = new List<string>(allAttacks);
            comboBoxAttck2.DataSource = new List<string>(allAttacks);
            comboBoxAttck3.DataSource = new List<string>(allAttacks);
            comboBoxAttck4.DataSource = new List<string>(allAttacks);

            listBoxPokemons.SelectedIndex = 0;
            listBoxPokemons.SelectedIndex = 1;
            listBoxPokemons.SelectedIndex = 0;

        }

        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Le champ Nom est obligatoire.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Le champ Description est obligatoire.");
                return false;
            }
            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Veuillez s�lectionner un type de Pok�mon.");
                return false;
            }
            if (!double.TryParse(txtWeight.Text, out _))
            {
                MessageBox.Show("Le champ Poids doit �tre un nombre valide.");
                return false;
            }
            if (!double.TryParse(txtHeight.Text, out _))
            {
                MessageBox.Show("Le champ Taille doit �tre un nombre valide.");
                return false;
            }

            return true;
        }

        private void SearchByType()
        {
            if (cmbType.SelectedItem != null)
            {
                string selectedType = cmbType.SelectedItem.ToString();

                // Filtrer les Pok�mon en fonction du type s�lectionn�
                var filteredPokemons = pokemons.FindAll(p => p.Type == selectedType);

                // Met � jour la ListBox avec les r�sultats filtr�s
                listBoxPokemons.DataSource = null; // R�initialise la source de donn�es
                listBoxPokemons.DataSource = filteredPokemons;

                if (filteredPokemons.Count == 0)
                {
                    MessageBox.Show($"Aucun Pok�mon trouv� pour le type '{selectedType}'.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner un type dans la liste d�roulante.");
            }
        }

        private void SearchByName()
        {
            if (txtName.Text != null)
            {
                string search = txtName.Text;
                var filteredPokemons = pokemons.FindAll(p => p.Name.Contains(search));

                listBoxPokemons.DataSource = null; // R�initialise la source de donn�es
                listBoxPokemons.DataSource = filteredPokemons;
            }
            else
            {
                MessageBox.Show("Aucun pokemon trouv�.");
            }
        }

        private void SearchByRegion()
        {
            if (cmbRegion.SelectedItem != null)
            {
                string selectedRegion = cmbRegion.SelectedItem.ToString();

                // Filtrer les Pok�mon en fonction du type s�lectionn�
                var filteredPokemons = pokemons.FindAll(p => p.Region == selectedRegion);

                // Met � jour la ListBox avec les r�sultats filtr�s
                listBoxPokemons.DataSource = null; // R�initialise la source de donn�es
                listBoxPokemons.DataSource = filteredPokemons;

                if (filteredPokemons.Count == 0)
                {
                    MessageBox.Show($"Aucun Pok�mon trouv� pour la rgion '{selectedRegion}'.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner un type dans la liste d�roulante.");
            }
        }


        private void btnSearchByType_Click(object sender, EventArgs e)
        {
            SearchByType();
        }

        private void buttonSearchName_Click(object sender, EventArgs e)
        {
            SearchByName();
        }

        private void btnSearchByRegion_Click(object sender, EventArgs e)
        {
            SearchByRegion();
        }

        private void newPkm_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                string imgType = ImagesFolderPath + selectedPokemon.Type + ".png";
                if (!string.IsNullOrEmpty(selectedPokemon.Type) && System.IO.File.Exists(imgType))
                {
                    pictureBoxType.ImageLocation = imgType;
                }
            }

        }
    }
}
