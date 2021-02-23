/// created by : 
/// date       : 
/// description: A basic text adventure game engine

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

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        SoundPlayer sceneSound;

        // random number generator

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) 
                { 
                    scene = 1; 
                }
                else if (scene == 1) 
                { 
                    scene = 3; 
                }
                else if (scene == 2) { }
                else if (scene == 3) 
                {
                    scene = 0;
                }
                else if (scene == 4) 
                {
                    scene = 5;
                }
                else if (scene == 5) 
                {
                    scene = 0;
                }
                else if (scene == 6) 
                {
                    scene = 0;
                }
                else if (scene == 7) { }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0) 
                {
                    //70% of scene 7, 30% of scene 2
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);

                    if (value <= 7) { scene = 7; }
                    else { scene = 2; } 
                }
                else if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 99; }
                else if (scene == 3) { scene = 99; }
                else if (scene == 4) { scene = 6; }
                else if (scene == 5) { scene = 99; }
                else if (scene == 6) { scene = 99; }
                else if (scene == 7) { scene = 99; }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    sceneImage.BackgroundImage = Properties.Resources.deepBrush;
                    sceneSound = new SoundPlayer(Properties.Resources.jungle);
                    sceneSound.Play();

                    outputLabel.Text = "You are lost in a forest";
                    redLabel.Text = "Go north";
                    blueLabel.Text = "Go south";
                    break;
                case 1:
                    sceneImage.BackgroundImage = Properties.Resources.forestLake;
                    sceneSound = new SoundPlayer(Properties.Resources.brook);
                    sceneSound.Play();

                    outputLabel.Text = "You come to a lake. Do you want to drink?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "You fall in a pit and die. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 3:
                    outputLabel.Text = "The water is stagnant. You die of cholera. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "A horse swims by. Do you ride it?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You tame the horse and ride to safety. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "The horse walks past. You die of lonliness. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 7:
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing?";
                    redLabel.Text = "";
                    blueLabel.Text = "";

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
