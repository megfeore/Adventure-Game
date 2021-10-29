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
//Meg Feore
//October 28/21
//Are you able to get to Hogwarts and survive your first class?

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        //tracks what page the story is on
        int page = 1;
        Random randGen = new Random();
        SoundPlayer cheerSound = new SoundPlayer(Properties.Resources.Cheering);


        public Form1()
        {
            InitializeComponent();
            //initial page setup
            headingLabel.Text = "Welcome to your Hogwarts Adventure!";
            outputLabel.Text = "You get sent your Hogwarts letter. " +
                "Do you accept to go to the School Of Wizardy and Witchcraft?";
            button1.Text = "Accept";
            button2.Text = "Do not accept";
            button3.Visible = false;
            button4.Visible = false;

            //displays photo
            pictureBox1.BackgroundImage = Properties.Resources.Hogwarts_Letter;

            //play sound
            SoundPlayer startSound = new SoundPlayer(Properties.Resources.Magic2);
            startSound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sends you to a different page from clicking button number 1
            if (page == 1) { page = 2; }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 9; }
            else if (page == 4) { page = 6; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 7; }
            else if (page == 7) { page = 1; }
            else if (page == 8) { page = 11; }
            else if (page == 9) { page = 1; }
            else if (page == 10) { page = 8; }
            else if (page == 11) { page = 15; }
            else if (page == 12) { page = 15; }
            else if (page == 13) { page = 15; }
            else if (page == 14) { page = 15; }
            else if (page == 15) { page = 17; }
            else if (page == 16) { page = 1; }
            else if (page == 17) { page = 18; }
            else if (page == 18) { page = 99; }
            else if (page == 19) { page = 1; }

            //display game components and text based on the correct page
            Game();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //picks random number between 1 and 10
            int number = randGen.Next(1, 11);

            //sends you to a different page from clicking button 2
            if (page == 1) { page = 3; }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 10; }
            else if (page == 4) { page = 6; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 8; }
            else if (page == 7) { page = 99; }
            else if (page == 8) { page = 12; }
            else if (page == 9) { page = 99; }
            else if (page == 11) { page = 16; }
            else if (page == 12) { page = 16; }
            else if (page == 13) { page = 16; }
            else if (page == 14) { page = 16; }
            else if (page == 15) { page = 16; }
            else if (page == 16) { page = 99; }

            //random generator
            //80 percent chance you will survive
            //20 perfect chance the potion will explode in face
            else if (page == 17)
            {
                if (number > 2)
                {
                    page = 18;
                }
                else
                {
                    page = 19;
                }
            }
            else if (page == 19) { page = 99; }

            //display game components and text based on the correct page
            Game();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //display game components and text based on the correct page if click button 3
            if (page == 1) { page = 3; }
            else if (page == 8) { page = 13; }
            Game();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //display game components and text based on the correct page if click button 4
            if (page == 1) { page = 3; }
            else if (page == 8) { page = 14; }
            Game();
        }

        //holds my case options
        public void Game()
        {
            switch (page)
            {
                case 1:
                    headingLabel.Text = "Welcome to your Hogwarts Adventure!";
                    outputLabel.Text = "You get sent your Hogwarts letter. " +
                        "Do you accept to go to the School Of Wizardy and Witchcraft?";
                    button1.Text = "Accept";
                    button2.Text = "Do not accept";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Hogwarts_Letter;

                    //play sound
                    SoundPlayer startSound = new SoundPlayer(Properties.Resources.Magic2);
                    startSound.Play();
                    break;
                case 2:
                    outputLabel.Text = "You made your way onto the Hogwarts Express." +
                        " Do you buy candy from the trolly or eat the food your mom packed for you?";
                    button1.Text = "Buy candy";
                    button2.Text = "Eat packed food";
                    button3.Visible = false;
                    button4.Visible = false;

                    //picture
                    pictureBox1.BackgroundImage = Properties.Resources.Hogwarts_Express_1;

                    //play train horn sound
                    SoundPlayer trainSound = new SoundPlayer(Properties.Resources.Train);
                    trainSound.Play();
                    break;
                case 3:
                    outputLabel.Text = "You did not accept the experience of a lifetime." +
                        " You are now punished and sent away to be a house maid for the Dursley's." +
                        " Do you stay and take care of them? Or try to escape?";
                    button1.Text = "Stay";
                    button2.Text = "Escape";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Dursleys;
                    break;
                case 4:
                    outputLabel.Text = "You decide to buy candy from the trolly." +
                        " Do you buy the signature chocolate frogs or jelly beans?";
                    button1.Text = "Frogs";
                    button2.Text = "Jelly Beans";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Trolly;
                    break;
                case 5:
                    outputLabel.Text = "You take a bite out of your sandwhich and you now regret not buying candy." +
                        " Do you force the sandwhich down your throat or throw it out the window?";
                    button1.Text = "Keep eating";
                    button2.Text = "Throw out window";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Sandwich;
                    break;
                case 6:
                    outputLabel.Text = "You have now arrived at Hogwarts!" +
                        " How do you make your way to the castle?";
                    button1.Text = "Walk";
                    button2.Text = "Take a boat";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Castle_2;

                    //play magic sound
                    SoundPlayer castleSound = new SoundPlayer(Properties.Resources.Magic);
                    castleSound.Play();
                    break;
                case 7:
                    outputLabel.Text = "You decided to walk to the castle. " +
                        "Unfortunately that was not so smart. " +
                        "You walked into the Forbidden Forest and a giant ate you. " +
                        "Would you like to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Forbidden_Forest;
                    break;
                case 8:
                    outputLabel.Text = "Yay you made it to the castle! " +
                        "You are now in the Great Hall and being sorted into the Hogwart's Houses. " +
                        "How would you describe yourself to the sorting hat?";
                    button1.Text = "Brave";
                    button2.Visible = true;
                    button2.Text = "Shy";
                    button3.Visible = true;
                    button4.Visible = true;
                    button3.Text = "Wicked";
                    button4.Text = "Smart";

                    //picture shown
                    pictureBox1.BackgroundImage = Properties.Resources.Hermione_Granger_wearing_the_Sorting_Hat;

                    //button colours
                    button1.BackColor = Color.DarkRed;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.Gold;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.DarkGreen;
                    button3.ForeColor = Color.White;
                    button4.BackColor = Color.MidnightBlue;
                    button4.ForeColor = Color.White;
                    break;

                case 9:
                    outputLabel.Text = "You decided to stay. That was a terrible choice. " +
                        "The Dursley's got so annoyed with you that they locked you in the " +
                        "cupboard under the stairs. You are never seen again! " +
                        "Want to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Cupboard;
                    break;
                case 10:
                    outputLabel.Text = "Your escape worked! Hagrid thankfully " +
                        "came to rescue you and took you to Hogwarts! " +
                        "Would you like to continue your adventure?";
                    button1.Text = "Continue";
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Hagr;
                    break;
                case 11:
                    outputLabel.Text = "You are a brave soul! You got sorted into " +
                        "Gryffindor House! Would you like to go to sleep or " +
                        "celebrate by throwing a party?";
                    button1.Text = "Sleep";
                    button2.Text = "Party";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Gryffindor;

                    //play cheering sound
                    cheerSound.Play();

                    //change background setup to Gryffindor colours
                    headingLabel.BackColor = Color.Goldenrod;
                    outputLabel.BackColor = Color.DarkRed;
                    outputLabel.ForeColor = Color.White;
                    button1.BackColor = Color.Goldenrod;
                    button2.BackColor = Color.DarkRed;
                    break;
                case 12:
                    outputLabel.Text = "You are a quiet soul filled with kindness!" +
                        " You got sorted into Hufflepuff House! " +
                        "Would you like to go to sleep or " +
                        "celebrate by throwing a party?";
                    button1.Text = "Sleep";
                    button2.Text = "Party";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Hufflepuff;

                    //play cheering sound
                    cheerSound.Play();

                    //change background setup to Hufflepuff colours
                    headingLabel.BackColor = Color.Gold;
                    outputLabel.BackColor = Color.Black;
                    outputLabel.ForeColor = Color.White;
                    button1.BackColor = Color.Gold;
                    button1.ForeColor = Color.Black;
                    button2.BackColor = Color.Black;
                    break;
                case 13:
                    outputLabel.Text = "You are full of ideas and greatness! " +
                        "You got sorted into Slytherin House! " +
                        "Would you like to go to sleep or celebrate by throwing a party?";
                    button1.Text = "Sleep";
                    button2.Text = "Party";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Slytherin;

                    //play cheering sound
                    cheerSound.Play();

                    //change background setup to Slytherin colours
                    headingLabel.BackColor = Color.DarkGreen;
                    headingLabel.ForeColor = Color.White;
                    outputLabel.BackColor = Color.DimGray;
                    outputLabel.ForeColor = Color.White;
                    button1.BackColor = Color.DarkGreen;
                    button2.BackColor = Color.DimGray;
                    break;
                case 14:
                    outputLabel.Text = "You have a mind of gold!" +
                        " You got sorted into Ravenclaw House! " +
                        "Would you like to go to sleep or celebrate by throwing a party?";
                    button1.Text = "Sleep";
                    button2.Text = "Party";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.R;

                    //play cheering sound
                    cheerSound.Play();

                    //change background setup to Ravenclaw colours
                    headingLabel.BackColor = Color.MidnightBlue;
                    headingLabel.ForeColor = Color.White;
                    outputLabel.BackColor = Color.DimGray;
                    outputLabel.ForeColor = Color.White;
                    button1.BackColor = Color.MidnightBlue;
                    button2.BackColor = Color.DimGray;
                    break;
                case 15:
                    outputLabel.Text = "You had such a wonderful sleep for your first night " +
                        "in the castle. Now you have your first class. " +
                        "However, you are quite tired. Do you go to your potions class? " +
                        "Or fall back to sleep?";
                    button1.Text = "Go to class";
                    button2.Text = "Sleep";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Castle_Daytime;

                    //change background back to original colours
                    headingLabel.BackColor = Color.Silver;
                    headingLabel.ForeColor = Color.Black;
                    outputLabel.BackColor = Color.LightGray;
                    outputLabel.ForeColor = Color.Black;
                    button1.BackColor = Color.Black;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.Black;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.Black;
                    button3.ForeColor = Color.White;
                    button4.BackColor = Color.Black;
                    button4.ForeColor = Color.White;
                    break;
                case 16:
                    outputLabel.Text = "Oh no! You got expelled! " +
                        "See you never. Would you like to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Expelled;

                    //change background to original colours
                    headingLabel.BackColor = Color.Silver;
                    headingLabel.ForeColor = Color.Black;
                    outputLabel.BackColor = Color.LightGray;
                    outputLabel.ForeColor = Color.Black;
                    button1.BackColor = Color.Black;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.Black;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.Black;
                    button3.ForeColor = Color.White;
                    button4.BackColor = Color.Black;
                    button4.ForeColor = Color.White;
                    break;

                case 17:
                    outputLabel.Text = "Going to class was a smart choice! " +
                        "You are making a love potion in potions today. " +
                        "Do you want to follow the recipe or no?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Pot;
                    break;
                case 18:
                    outputLabel.Text = "Congratulations! You have made it through your " +
                        "first class! Your future at Hogwarts looks great!";
                    button1.Text = "End Game";
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Castle_Daytime;

                    //play sound
                    SoundPlayer congrats = new SoundPlayer(Properties.Resources.Ovation);
                    congrats.Play();
                    break;
                case 19:
                    outputLabel.Text = "Wow you have terrible luck! " +
                        "The potion exploded in your face and tragically you passed away. " +
                        "Want to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Visible = false;
                    button4.Visible = false;

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Exploded;

                    //play explosion sound
                    SoundPlayer explode = new SoundPlayer(Properties.Resources.Explosion);
                    explode.Play();
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing!";

                    //show picture
                    pictureBox1.BackgroundImage = Properties.Resources.Willow;

                    //wait 2 seconds
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }

        }
    }
}

