using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            option1Button.Text = "Enter the house.";
            option2Button.Text = "Leave.";
            outputLabel.Text = "You come across a creepy house.";
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 2; }
            else if (page == 2) { page = 3; }
            else if (page == 3) { page = 4; }
            else if (page == 4) { page = 5; }
            else if (page == 5) { page = 1; } 
            else if (page == 6) { page = 7; }
            else if (page == 7) { page = 8; }
            else if (page == 8) { page = 9; }
            else if (page == 9) { page = 10; }
            else if (page == 10) { page = 11; }
            else if (page == 11) { page = 12; }

            switch (page)

            {
                case 1:
                    option1Button.Text = "Enter the house.";
                    option2Button.Text = "Leave.";
                    outputLabel.Text = "You come across a creepy house";
                    pictureBox3.Image = Properties.Resources.house;
                    break;
                case 2:
                    option1Button.Text = "Go down the hallway.";
                    option2Button.Text = "Go up the staricase.";
                    outputLabel.Text = "You see a hallway and a staircase.";
                    pictureBox3.Image = Properties.Resources.interior;
                    break;
                case 3:
                    option1Button.Text = "Keep going.";
                    option2Button.Text = "Check it out.";
                    outputLabel.Text = "You hear something go upstairs.";
                    pictureBox3.Image = Properties.Resources.hallway;
                    break;
                case 4:
                    option1Button.Text = "Open the stove.";
                    option2Button.Text = "Keep going.";
                    outputLabel.Text = "You enter the kitchen.";
                    pictureBox3.Image = Properties.Resources.kitchen;
                    break;
                case 5:
                    option1Button.Text = "Play again.";
                    option2Button.Text = "Exit.";
                    outputLabel.Text = "You got pushed into the stove and burned to death.";
                    pictureBox3.Image = Properties.Resources.stove;
                    break;





            }




        }

        private void option2Button_Click(object sender, EventArgs e)
        {

            if (page == 1) { page = 2; }
            else if (page == 2) { page = 3; }
            else if (page == 3) { page = 4; }
            else if (page == 4) { page = 5; }
            else if (page == 5) { page = 1; }
            else if (page == 6) { page = 7; }
            else if (page == 7) { page = 8; }
            else if (page == 8) { page = 9; }
            else if (page == 9) { page = 10; }
            else if (page == 10) { page = 11; }
            else if (page == 11) { page = 12; }

            switch (page)

            {
                case 1:
                    option1Button.Text = "Enter the house.";
                    option2Button.Text = "Leave.";
                    outputLabel.Text = "You come across a creepy house";
                    pictureBox3.Image = Properties.Resources.house;
                    break;
                case 2:
                    option1Button.Text = "Play Again.";
                    option2Button.Text = "Exit.";
                    outputLabel.Text = "You left and went home.";
                    pictureBox3.Image = Properties.Resources.interior;
                    break;
                case 3:
                    Application.Exit();
                    break;
                case 4:
                    option1Button.Text = "You enter the living room. Someone is on the couch.";
                    option2Button.Text = "Talk to them.";
                    outputLabel.Text = "Sneak past them.";
                    pictureBox3.Image = Properties.Resources.livingroom;

                    break;
                case 5:
                    option1Button.Text = "";
                    option2Button.Text = "";
                    outputLabel.Text = "";
                    break;



            }
        }
    }
}

