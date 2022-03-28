using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Get_A_Snack_At_4_AM
{
    public partial class Form1 : Form
    {
        int page = 1;
        SoundPlayer player5 = new SoundPlayer(Properties.Resources.Jumpscare_golden_freddy_s_un_fnaf_one);
        SoundPlayer player4 = new SoundPlayer(Properties.Resources.Carmen_Overture__Toreador___Music_Box_Theme_);
        public Form1()
        {
            InitializeComponent();
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 9;

            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }


            DisplayPage();




        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 11)
            {
                page = 16;
            }

            DisplayPage();

        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You awaken at 4:00 AM you hunger for a snack.";
                    option1Label.Text = "Go back to sleep";
                    option2Label.Text = "Leave bedroom";
                    pictureBox1.Image = Properties.Resources.Bedroomnight;
                    break;
                case 2:
                    outputLabel.Text = "You lie back down in bed. you are consumed by your own hunger, your body is never found.  Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 3:
                    outputLabel.Text = "You enter the hallway, your stomach screeches with ravenous howls.   Walking into the kitchen you spot your refrigerator and a bag of chips.";
                    option1Label.Text = "Grab the bag of chips";
                    option2Label.Text = "Look into the refrigerator";
                    pictureBox1.Image = Properties.Resources.Kitchennight;
                    break;

                case 4:
                    outputLabel.Text = "You ravenously grab the bag of chips and scarf them down very loudly.....the power cuts out...I heard you eating those chips, it woke me up.  DON'T WAKE DAD!";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;


                case 6:
                    outputLabel.Text = "Looking into the refrigerator you see pickles, pickles, and pickles.";
                    option1Label.Text = "Consume the pickle";
                    option2Label.Text = "Back out of fridge";
                    pictureBox1.Image = Properties.Resources.Picklefridge;
                    break;
                case 7:
                    outputLabel.Text = "You Crunch down on a delicious dill pickle YOU WIN!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(10000);
                    outputLabel.Text = "You have aquired the main ending \"Pickle\" Two endings remain undiscovered, play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 8:
                    outputLabel.Text = "Not feeling like pickles you sadly leave the cool breeze and dilly smell of your fridge...You feel compelled to go outside in search of food.";
                    option1Label.Text = "Go outside";
                    option2Label.Text = "Go outside";
                    break;
                case 9:
                    outputLabel.Text = "Exiting the house and walking down the street you spot a man at a bus stop, he appears to be sleeping.";
                    pictureBox1.Image = Properties.Resources.Street;
                    option1Label.Text = "Approach the man";
                    option2Label.Text = "Continue down the street";

                    break;
                case 10:
                    outputLabel.Text = "Approaching the man you realize he is wearing a hood. Have you come in search of something child? he asks. I know you have, here take this. The man offers you a chocolate bar.";
                    pictureBox1.Image = Properties.Resources.BusStop;
                    option1Label.Text = "Accept his gift";
                    option2Label.Text = "Decline his gift";

                    break;
                case 11:
                    outputLabel.Text = "Continuing down the street you spot a convenient store and a closed pizza place";
                    pictureBox1.Image = Properties.Resources.Street;
                    option1Label.Text = "Convenient store";
                    option2Label.Text = "Pizza place";
                    break;
                case 12:
                    outputLabel.Text = "Accepting the chocolate bar you quickly begin eating it.";
                   
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(6000);
                    outputLabel.Text = "Once you finish the man stands up removing his hood revealing none other than Todd Howard underneath.";
                    pictureBox1.Image = Properties.Resources.Todd;
                    option1Label.Text = "";
                    option2Label.Text = "";
                    
                    Refresh();
                    Thread.Sleep(6000);
                    outputLabel.Text = "\"It just works.\" He whispers into your ear as you blackout from the laced chocolate.";
                    Refresh();
                    Thread.Sleep(6000);
                    outputLabel.Text = "coming to your senses you see yourself in a carriage with three other men, one of them turns to you. \"Hey you finally awake.\" You scream silently as you realize your soul is forever trapped in the opening sequence of Skyrim. Play again?";
                    pictureBox1.Image = Properties.Resources.hey_you_youre_finally_awake_skyrim;
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 13:
                    outputLabel.Text = "Deciding the convenient store is more practical you start approaching it. You notice the employee outside smoking a cigarette. I'm on break right now but you can go in.    just before you enter the man grabs your arm.  No shoplifting.  You feel a sense of dread.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(10000);
                    outputLabel.Text = "Entering the store you see that the shelves are mostly empty, feeling your pockets you realize you left your wallet at home, starving and with no money you must decide.";
                    option1Label.Text = "Shoplift";
                    option2Label.Text = "Leave without buying anything";
                    break;
                case 14:
                    outputLabel.Text = "Grabbing the closest item of food to you,you break for the exit. When you leave you see the employee is gone a still lit cigarette on the ground where he stood. I warned you, you see a pair of red eyes dash toward you from the end of the street at inhuman speed. You can't even scream before you are decapitated. play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    outputLabel.Text = "Deciding not to shoplift you walk out towards the exit defeated.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(10000);
                    outputLabel.Text = "when suddenly you fall through the floor and reality itself.";
                    Refresh();
                    Thread.Sleep(10000);
                    outputLabel.Text = "You briefly black out and when you awaken you find yourself in a mysterious room, florescent lights buzzing loudly, the wallpaper peeling off from years of moisture damage, and the sickly yellow carpet beneath your feet just slightly damp for no good reason";
                    pictureBox1.Image = Properties.Resources.Backrooms;
                    SoundPlayer player6 = new SoundPlayer(Properties.Resources.Cursed_images_with_The_Caretakers_It_s_just_a_burning_memory);
                    player6.Play();

                    Refresh();
                    Thread.Sleep(10000);
                    pictureBox1.Image = Properties.Resources.Backrooms;
                    outputLabel.Text = "You have aquired the main ending \"Backrooms\" Two endings remain undiscovered. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 16:
                    outputLabel.Text = "Against your better judgment you head towards the pizza joint. it's obviously closed but a no trespassing sign won't stop you.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    pictureBox1.Image = Properties.Resources.PizzaExterior;
                    Refresh();
                    Thread.Sleep(10000);
                    
                    outputLabel.Text = "you enter, the dim backup lights barely illuminate your surroundings you decide to make your way to the office to hopefully turn the power back on";
                    pictureBox1.Image = Properties.Resources.PizzaInterior;
                    Refresh();
                    Thread.Sleep(10000);
                    
                    outputLabel.Text = "Entering the office you spot a breaker box on the wall, flipping the switch labeled Power the lights switch on with a deafening sound";
                    pictureBox1.Image = Properties.Resources.Officelights;
                    Refresh();
                    Thread.Sleep(10000);

                    outputLabel.Text = "Seconds later the power completely fails not even the backup lights are on now.You hear footsteps approaching the office, you turn to look out the door on the left. Your fate is already sealed";
                    pictureBox1.Image = Properties.Resources.Nopower;
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.FNAF__Power_Outage___Gaming_Sound_Effect__HD_);
                    player3.Play();
                    Refresh();
                    Thread.Sleep(10000);

                    pictureBox1.Image = Properties.Resources.NopowerFr;

                    player4.Play();
                    Refresh();
                    Thread.Sleep(15000);
                    pictureBox1.Image = Properties.Resources.Nopower;
                    Refresh();
                    player5.Play();
                    Thread.Sleep(3000);
                    pictureBox1.Size = new System.Drawing.Size(878, 504);
                    pictureBox1.Image = Properties.Resources.Bear;
                   
                    
                    Refresh();
                    Thread.Sleep(6000);
                    this.Close();
                    break;
            }
        }
    }
}





