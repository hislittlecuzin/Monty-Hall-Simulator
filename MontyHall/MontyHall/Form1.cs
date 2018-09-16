using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MontyHall
{
    public partial class Form1 : Form
    {

        bool[] doorHasCar = new bool[3];
        bool guessedOnce;

        public Form1()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame() {
            informationText.Text = "Welcome to the Monty Hall Simulator. " +
                "There is a new car behind one of the 3 doors." +
                "Guess which door it is & win yourself a new car!";

            //Allows player to guess 2 times. 
            guessedOnce = false;

            //Allows player to guess
            acceptButton.Enabled = true;

            //Resets all doors to not have car
            for (int i = 0; i < doorHasCar.Length; i++) {
                 doorHasCar[i] = false;
            }

            //Sets 1 door to have car behind it.
            Random rnd = new Random();
            int highestIndexInArray = doorHasCar.Length - 1;
            doorHasCar[rnd.Next(0, highestIndexInArray)] = true;
        }

        //Checks if player guessed the correct door. 
        private bool CorrectChoice(int choice) {
            choice -= 1;
            if (doorHasCar[choice] == true) {
                return true;
            }
            return false;
        }



        //Unused function. Do NOT DELETE. 
        private void informationText_TextChanged(object sender, EventArgs e)
        {

        }

        //Restarts game
        private void RestartButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

            bool GuessedCorrect = false;
#region radio Button Check
            if (doorButton1.Checked == true) {
                GuessedCorrect = CorrectChoice(1);
            }
            else if (doorButton2.Checked == true) {
                GuessedCorrect = CorrectChoice(2);
            }
            else if (doorButton3.Checked == true) {
                GuessedCorrect = CorrectChoice(3);
            }
            #endregion

            //Runs if the player guessed the right door and tells the player he wins. 
            if (GuessedCorrect == true) {
                informationText.Text = "You guessed correctly. You win! :D";
                acceptButton.Enabled = false;
                return;
                
            }

            //Runs if this is the player's second guess and didn't get the answer correct. Ends the game. 
            if (guessedOnce == true) {
                int doorThatHasCar = -1;
                for(int i = 0; i < doorHasCar.Length; i++) {
                    if (doorHasCar[i] == true) {
                        doorThatHasCar = (i + 1);
                    }
                }
                informationText.Text = "Sorry. The car was behind door " + doorThatHasCar + ". Better luck next time! Click restart to try again.";
                acceptButton.Enabled = false;
                return;
            }

            //Runs if this is player's first guess & didn't get answer correct. 
            informationText.Text = "Not Correct this time. I'll give you one last chance to get it right.";
            guessedOnce = true;
        }
    }
}
