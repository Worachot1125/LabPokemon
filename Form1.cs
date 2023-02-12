using Pokemon.pokemon;
using Pokemon.pokemons;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        List<Pokemons> pokemons;
        Pokemons selectedPokemon;
        Pokemons monster;

        // count hit 
        int hit = 1;
        // item
        int item = 5;
        //charactor
        int ni = 1;
        int cha = 1;
        int war = 1;
        int odd = 1;

        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Pokemons>();
            pokemons.Add(new Nidoran());
            pokemons.Add(new Charmander());
            pokemons.Add(new Wartortle());
            pokemons.Add(new Oddish());

            this.monster = new Arbok();
            this.picArbok.Image = this.monster.getImage();
            this.tbMonsName.Text = this.monster.getName();
            this.tbMonsHP.Text = this.monster.getHP().ToString();
        }

        // Nidoran
        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbMypkname.Text = selectedPokemon.getName();
            this.tbMypkHP.Text = selectedPokemon.getHP().ToString();
        }

        // Charmander
        private void btMyPok2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbMypkname.Text = selectedPokemon.getName();
            this.tbMypkHP.Text = selectedPokemon.getHP().ToString();

        }

        // Wartortle
        private void btMyPok3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbMypkname.Text = selectedPokemon.getName();
            this.tbMypkHP.Text = selectedPokemon.getHP().ToString();

        }

        // Oddish
        private void btMyPok4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbMypkname.Text = selectedPokemon.getName();
            this.tbMypkHP.Text = selectedPokemon.getHP().ToString();
        }

        // Atk
        private void button8_Click(object sender, EventArgs e)
        {
            var pokePlayer = selectedPokemon;
            var pokeMonster = monster;

            int atkPlayer = Math.Abs(this.monster.getDefense() - this.selectedPokemon.getAttack());
            this.monster.Attack(atkPlayer);
            this.tbMonsHP.Text = this.monster.getHP().ToString();

            // player hit 3 / monster hit 1
            if((hit % 3) == 0)
            {
                var  atkMonster = Math.Abs(this.selectedPokemon.getDefense() - this.monster.getAttack());
                this.selectedPokemon.Attack(atkMonster);
                this.tbMypkHP.Text = this.selectedPokemon.getHP().ToString();
            }
            hit++;
            if (pokemons[0].getHP() <= 0)
            {
                btnNidoran.Enabled = false;
                
                
            }
            if (pokemons[1].getHP() <= 0)
            {
                btnCharmander.Enabled = false;
                
            }
            if(pokemons[2].getHP() <= 0)
            {
                btnWartortle.Enabled = false;
                ;
            }
            if(pokemons[3].getHP() <= 0)
            {
                btnOddish.Enabled = false;
                
            }
        }

        private void btPlusHP_Click(object sender, EventArgs e)
        {
            this.selectedPokemon.getHp50();
            this.tbMypkHP.Text = this.selectedPokemon.getHP().ToString();
            item--;
            if (item == 0) 
            {
               btnPlusHP50.Enabled = false;
                MessageBox.Show("item emtry");
            }
        }
        

    }
}