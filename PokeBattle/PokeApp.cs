using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PokeBattle
{
    public partial class PokeApp : Form
    {
        Charmander charm1 = new Charmander();
        public static Pokemon partnerPokemon;
        public static Pokemon opponentPokemon;
        SelectPokemon player = new SelectPokemon();
        SelectPokemon opponent = new SelectPokemon();
        bool isPokemonSelected = false;

        public PokeApp()
        {
            InitializeComponent();
            statusText.Text = "Welcome to the wonderful word of Pokemon! Please choose a pokemon to battle with.";

        }

        private void InitializeCharmander(object sender, EventArgs e)
        {
            button2.Visible = false;
            pictureBox2.Visible = false;
            button3.Visible = false;
            pictureBox3.Visible = false;
            button1.Enabled = false;
            pictureBox4.Image = Properties.Resources.charmander__1_;
            isPokemonSelected = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            player.selectPokemon(0);
            label1.Text = partnerPokemon.name();
            progressBar1.Maximum = partnerPokemon.getHp();
            progressBar1.Value = partnerPokemon.getHp();
            label4.Text = partnerPokemon.getHp().ToString();
        }

        private void InitializeSquirtle(object sender, EventArgs e)
        {
            button1.Visible = false;
            pictureBox1.Visible = false;
            button3.Visible = false;
            pictureBox3.Visible = false;
            button2.Enabled = false;
            pictureBox4.Image = Properties.Resources.squirtle__1_;
            isPokemonSelected = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            player.selectPokemon(1);
            label1.Text = partnerPokemon.name();
            progressBar1.Maximum = partnerPokemon.getHp();
            progressBar1.Value = partnerPokemon.getHp();
            label4.Text = partnerPokemon.getHp().ToString();

        }

        private void InitializeBulbasaur(object sender, EventArgs e)
        {
            button2.Visible = false;
            pictureBox2.Visible = false;
            button1.Visible = false;
            pictureBox1.Visible = false;
            button3.Enabled = false;
            pictureBox4.Image = Properties.Resources.bulbasaur__1_;
            isPokemonSelected = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            player.selectPokemon(2);
            label1.Text = partnerPokemon.name();
            progressBar1.Maximum = partnerPokemon.getHp();
            progressBar1.Value = partnerPokemon.getHp();
            label4.Text = partnerPokemon.getHp().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int getHp = partnerPokemon.getHp();
            int setHp;
            int attackDmg = partnerPokemon.getAttackDamage(0);

            chat.Text = partnerPokemon.name() + " used " + partnerPokemon.moves(0) + " and caused "
                + attackDmg.ToString() + " Damage!";
            setHp = getHp - attackDmg;
            partnerPokemon.setHp(setHp);
            
            if(partnerPokemon.getHp() < 1)
            {
                partnerPokemon.setHp(0);
                progressBar1.Value = 0;
                label4.Text = partnerPokemon.getHp().ToString();
                pictureBox4.Image = null;
                MessageBox.Show(partnerPokemon.name() + " has been knocked out!");
            }
            else
            {
                label4.Text = partnerPokemon.getHp().ToString();
                progressBar1.Value = partnerPokemon.getHp();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            chat.Text = partnerPokemon.name() + " used " + partnerPokemon.moves(1) + " and caused "
                + partnerPokemon.getAttackDamage(1).ToString() + " Damage!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chat.Text = partnerPokemon.name() + " used " + partnerPokemon.moves(2) + " and caused "
                + partnerPokemon.getAttackDamage(2).ToString() + " Damage!";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chat.Text = partnerPokemon.name() + " used " + partnerPokemon.moves(3) + " and caused " 
                + partnerPokemon.getAttackDamage(3).ToString() + " Damage!";
            //label3.Text = partnerPokemon.getAttackDamage(3).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Bulbasaur bulb = new Bulbasaur();
            String ha = "";
            if (isPokemonSelected)
            {
                Console.WriteLine(partnerPokemon.getAttackDamage(2));
            } else
            {
                Console.WriteLine("Select a pokeon first!");
            }

        }
    }
}
