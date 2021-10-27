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

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        //tracks what page the story is on
        int page = 1;
        Random randGen = new Random();
      

        public Form1()
        {
            InitializeComponent();
            headingLabel.Text = "Welcome to your Hogwarts Adventure!";
            outputLabel.Text = "You get sent your Hogwarts letter. " +
                "Do you accept to go to the School Of Wizardy and Witchcraft?";
            button1.Text = "Accept";
            button2.Text = "Do not accept";
            button3.Visible = false;
            button4.Visible = false;
            pictureBox1.BackgroundImage = Properties.Resources.Hogwarts_Letter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sends you to a different page 
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
            
            //sends you to a different page 
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
            
            else if (page == 17)
            {
               //random generator if you die or make it through
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
            //display game components and text based on the correct page
            Game();
            if (page == 1) { page = 3; }
            else if (page == 8) { page = 13; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //display game components and text based on the correct page
            Game();
            if (page == 1) { page = 3; }
            else if (page == 8) { page = 14; }
        }

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
                    pictureBox1.BackgroundImage = Properties.Resources.Hogwarts_Letter;
                    break;
                case 2:
                    outputLabel.Text = "You made your way onto the Hogwarts Express. " +
                        "Do you buy candy from the trolly or eat the food your mom packed for you?";
                    button1.Text = "Buy candy";
                    button2.Text = "Eat packed food";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Hogwarts_Express_1;
                    break;
                case 3:
                    outputLabel.Text = "You did not accept the experience of a lifetime. " +
                        "You are now punished and sent away to be a house maid for the Dursley's." +
                        "Do you stay and take care of them? Or try to escape?";
                    button1.Text = "Stay";
                    button2.Text = "Escape";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Dursleys;
                    break;
                case 4:
                    outputLabel.Text = "You decide to buy candy from the trolly... " +
                        "do you buy signature chocolate frogs, or jelly beans?";
                    button1.Text = "Frogs";
                    button2.Text = "Jelly Beans";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Trolly;
                    break;
                case 5:
                    outputLabel.Text = "You take a bite out of your sandwhich and you now regret not buying candy. " +
                        "Do you force the sandwhich down your throat or throw it out the window?";
                    button1.Text = "Keep eating";
                    button2.Text = "Throw out window";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Sandwich;
                    break;
                case 6:
                    outputLabel.Text = "You have now arrived at Hogwarts! " +
                        "How do you make your way to the castle?";
                    button1.Text = "Walk";
                    button2.Text = "Take a boat";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Castle_2;
                    break;
                case 7:
                    outputLabel.Text = "You decided to walk to the castle. " +
                        "Unfortunately that was not so smart. " +
                        "You walked into the Forbidden Forest and a giant ate you. " +
                        "Would you like to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Forbidden_Forest;
                    break;
                case 8:
                    outputLabel.Text = "Yay you made it to the castle! " +
                        "You are now in the Great Hall and being sorted into the Hogwart's Houses. " +
                        "How would you describe yourself to the sorting hat?";
                    button1.Text = "Brave";
                    button2.Text = "Shy";
                    button3.Visible = true;
                    button4.Visible = true;
                    button3.Text = "Wicked";
                    button4.Text = "Smart";
                    pictureBox1.BackgroundImage = Properties.Resources.Hermione_Granger_wearing_the_Sorting_Hat;
                    break;
                case 9:
                    outputLabel.Text = "You decided to stay. That was a terrible choice. " +
                        "The Dursley's got so annoyed with you that they locked you in the " +
                        "cupboard under the stairs. You are never seen again. " +
                        "Want to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Cupboard;
                    break;
                case 10:
                    outputLabel.Text = "Your escape worked! Hagrid thankfully " +
                        "comes to rescue you and takes you to Hogwarts! " +
                        "Would you like to continue your adventure?";
                    button1.Text = "Continue";
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
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
                    pictureBox1.BackgroundImage = Properties.Resources.Gryffindor;
                    break;
                case 12:
                    outputLabel.Text = "You are a quiet soul filled with kindness!" +
                        "You got sorted into Hufflepuff House! " +
                        "Would you like to go to sleep or " +
                        "celebrate by throwing a party?";
                    button1.Text = "Sleep";
                    button2.Text = "Party";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Hufflepuff;
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
                    break;
                case 14:
                    outputLabel.Text = "You have a mind of gold!" +
                        "You got sorted into Ravenclaw House! " +
                        "Would you like to go to sleep or celebrate by throwing a party?";
                    button1.Text = "Sleep";
                    button2.Text = "Party";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.R;
                    break;
                case 15:
                    outputLabel.Text = "You had such a wonderful sleep in your first night " +
                        "in the castle. Now you have your first class. " +
                        "However, you are quite tired. Do you go to your potions class? " +
                        "Or fall back to sleep?";
                    button1.Text = "Go to class";
                    button2.Text = "Sleep";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Hagr;
                    break;
                case 16:
                    outputLabel.Text = "Oh no! You got expelled. " +
                        "See you never! Would you like to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Expelled;
                    break;
                   
                case 17:
                    outputLabel.Text = "Going to class was a smart choice! " +
                        "You are making a love potion in class today. " +
                        "Do you want to follow the recipe, or no?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Pot;
                    break;
                case 18:
                    outputLabel.Text = "Congratulations! You have made it through your " +
                        "first class! Your future at Hogwarts looks great!";
                    button1.Text = "End Game";
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Castle_Daytime;
                    break;
                case 19:
                    outputLabel.Text = "Wow you have terrible luck! " +
                        "The potion exploded in your face and tragically you passed away. " +
                        "Want to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Visible = false;
                    button4.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.Exploded;
                    break;
                case 99:
                    headingLabel.Text = "Thank you for playing!";
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    pictureBox1.BackgroundImage = Properties.Resources.Willow;
                    break;
                default:
                    break;
            }

        }
    }
}

