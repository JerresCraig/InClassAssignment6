using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment6
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Jerres Craig
        //This is my own work

        //send link to github and submit link
        //page 563 in textbook for UML
        //dice class
        class Dice
        {
            private int numSides;
            static Random rnd = new Random();
            public Dice(int n)
            {
                numSides = n;
            }
            public int rollDie()
            {
                return rnd.Next() % numSides + 1;
            }
        }
        int numRolls = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Dice d1 = new Dice(6);
            Dice d2 = new Dice(6);

            lblD1.Text = d1.rollDie().ToString();
            lblD2.Text = d2.rollDie().ToString();

            numRolls++;
            lblNumRolls.Text = numRolls.ToString();

            //snake eyes
            if (lblD1.Text == "1" && lblD2.Text == "1")
            {
                MessageBox.Show("It took " + numRolls + " rolls to get snake eyes!");
                btnRollDice.Enabled = false;
            }


        }
    }

}
