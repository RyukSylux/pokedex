using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PokedexApp
{
    public partial class AttackDex : Form
    {
        public List<Attacks> pokemonAttacks = new List<Attacks>();
        public AttackDex()
        {
            pokemonAttacks = new List<Attacks>
        {
            new Attacks { Name = "Charge", Type = "Normal", lowDamage = 10, highDamage = 15, BonusType = "", MalusType = "Roche, Acier, Spectre" },
            new Attacks { Name = "Vive-Attaque", Type = "Normal", lowDamage = 15, highDamage = 25, BonusType = "", MalusType = "Roche, Acier, Spectre" },
            new Attacks { Name = "Flammèche", Type = "Feu", lowDamage = 20, highDamage = 30, BonusType = "Plante, Insecte, Acier, Glace", MalusType = "Eau, Roche, Dragon, Feu" },
            new Attacks { Name = "Lance-Flammes", Type = "Feu", lowDamage = 40, highDamage = 60, BonusType = "Plante, Insecte, Acier, Glace", MalusType = "Eau, Roche, Dragon, Feu" },
            new Attacks { Name = "Hydrocanon", Type = "Eau", lowDamage = 50, highDamage = 70, BonusType = "Feu, Sol, Roche", MalusType = "Eau, Plante, Dragon" },
            new Attacks { Name = "Pistolet à O", Type = "Eau", lowDamage = 10, highDamage = 20, BonusType = "Feu, Sol, Roche", MalusType = "Eau, Plante, Dragon" },
            new Attacks { Name = "Fatal-Foudre", Type = "Électrique", lowDamage = 55, highDamage = 75, BonusType = "Eau, Vol", MalusType = "Plante, Sol, Dragon" },
            new Attacks { Name = "Éclair", Type = "Électrique", lowDamage = 20, highDamage = 40, BonusType = "Eau, Vol", MalusType = "Plante, Sol, Dragon" },
            new Attacks { Name = "Tranch’Herbe", Type = "Plante", lowDamage = 15, highDamage = 25, BonusType = "Eau, Sol, Roche", MalusType = "Feu, Vol, Insecte, Poison, Plante, Dragon, Acier" },
            new Attacks { Name = "Fouet Lianes", Type = "Plante", lowDamage = 25, highDamage = 40, BonusType = "Eau, Sol, Roche", MalusType = "Feu, Vol, Insecte, Poison, Plante, Dragon, Acier" },
            new Attacks { Name = "Lame Feuille", Type = "Plante", lowDamage = 50, highDamage = 70, BonusType = "Eau, Sol, Roche", MalusType = "Feu, Vol, Insecte, Poison, Plante, Dragon, Acier" },
            new Attacks { Name = "Psyko", Type = "Psy", lowDamage = 50, highDamage = 70, BonusType = "Poison, Combat", MalusType = "Ténèbres, Acier, Psy" },
            new Attacks { Name = "Choc Mental", Type = "Psy", lowDamage = 25, highDamage = 40, BonusType = "Poison, Combat", MalusType = "Ténèbres, Acier, Psy" },
            new Attacks { Name = "Dracogriffe", Type = "Dragon", lowDamage = 40, highDamage = 60, BonusType = "Dragon", MalusType = "Acier, Fée" },
            new Attacks { Name = "Draco-Choc", Type = "Dragon", lowDamage = 55, highDamage = 75, BonusType = "Dragon", MalusType = "Acier, Fée" },
            new Attacks { Name = "Poing-Éclair", Type = "Électrique", lowDamage = 30, highDamage = 50, BonusType = "Eau, Vol", MalusType = "Plante, Sol, Dragon" },
            new Attacks { Name = "Poing de Feu", Type = "Feu", lowDamage = 30, highDamage = 50, BonusType = "Plante, Insecte, Acier, Glace", MalusType = "Eau, Roche, Dragon, Feu" },
            new Attacks { Name = "Poing Glace", Type = "Glace", lowDamage = 30, highDamage = 50, BonusType = "Dragon, Vol, Sol, Plante", MalusType = "Eau, Glace, Feu, Acier" },
            new Attacks { Name = "Laser Glace", Type = "Glace", lowDamage = 40, highDamage = 60, BonusType = "Dragon, Vol, Sol, Plante", MalusType = "Eau, Glace, Feu, Acier" },
            new Attacks { Name = "Vent Glace", Type = "Glace", lowDamage = 15, highDamage = 25, BonusType = "Dragon, Vol, Sol, Plante", MalusType = "Eau, Glace, Feu, Acier" },
            new Attacks { Name = "Onde de Choc", Type = "Électrique", lowDamage = 25, highDamage = 35, BonusType = "Eau, Vol", MalusType = "Plante, Sol, Dragon" },
            new Attacks { Name = "Tunnel", Type = "Sol", lowDamage = 45, highDamage = 65, BonusType = "Feu, Roche, Acier, Électrique, Poison", MalusType = "Vol, Insecte, Plante" },
            new Attacks { Name = "Séisme", Type = "Sol", lowDamage = 60, highDamage = 80, BonusType = "Feu, Roche, Acier, Électrique, Poison", MalusType = "Vol, Insecte, Plante" },
            new Attacks { Name = "Tranche", Type = "Normal", lowDamage = 20, highDamage = 35, BonusType = "", MalusType = "Roche, Acier, Spectre" },
            new Attacks { Name = "Coup d’Boule", Type = "Normal", lowDamage = 25, highDamage = 40, BonusType = "", MalusType = "Roche, Acier, Spectre" },
            new Attacks { Name = "Morsure", Type = "Ténèbres", lowDamage = 20, highDamage = 35, BonusType = "Psy, Spectre", MalusType = "Combat, Fée, Ténèbres" },
            new Attacks { Name = "Griffe", Type = "Normal", lowDamage = 15, highDamage = 25, BonusType = "", MalusType = "Roche, Acier, Spectre" },
            new Attacks { Name = "Ténèbres", Type = "Ténèbres", lowDamage = 50, highDamage = 70, BonusType = "Psy, Spectre", MalusType = "Combat, Fée, Ténèbres" },
            new Attacks { Name = "Queue de Fer", Type = "Acier", lowDamage = 50, highDamage = 70, BonusType = "Fée, Roche, Glace", MalusType = "Feu, Eau, Acier, Électrique" }
        };


            InitializeComponent();

            listBoxAttacks.DisplayMember = "Name"; // Affiche uniquement le nom des attaques
            listBoxAttacks.DataSource = pokemonAttacks; // Lie la liste à la ListBox

            comboBoxTypes.Items.AddRange(new string[]
           {
                "Normal", "Feu", "Eau", "Plante", "Électrique", "Glace",
                "Combat", "Poison", "Sol", "Vol", "Psy", "Insecte",
                "Roche", "Spectre", "Dragon", "Ténèbres", "Acier", "Fée"
           });


        }

        private void listBoxAttacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAttacks.SelectedItem is Attacks selectedAttack)
            {

                textBoxType.Text = selectedAttack.Type;
                textBoxDamageLow.Text = selectedAttack.lowDamage.ToString();
                textBoxDamageHigh.Text = selectedAttack.highDamage.ToString();
                textBoxBonus.Text = selectedAttack.BonusType;
                textBoxMalus.Text = selectedAttack.MalusType;

                if (selectedAttack.BonusType == "")
                {
                    textBoxBonus.Text = "Aucun";
                }
            }
        }



        private void btnSearchbyType_Click(object sender, EventArgs e)
        {
            List<Attacks> filteredAttacks;
            if (comboBoxTypes.SelectedItem != null)
            {
                string selectedType = comboBoxTypes.SelectedItem.ToString();

                 filteredAttacks = pokemonAttacks.FindAll(a => a.Type == selectedType);

                // Met à jour la ListBox avec les résultats filtrés
                listBoxAttacks.DataSource = null; // Réinitialise la source de données
                listBoxAttacks.DataSource = filteredAttacks;
                listBoxAttacks.DisplayMember = "Name"; // Affiche uniquement le nom des attaques

            }
        }
    }
}
