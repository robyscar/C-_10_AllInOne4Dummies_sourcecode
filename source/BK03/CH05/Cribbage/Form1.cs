using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cribbage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Player1_Leave(object sender, EventArgs e)
        {
            // Handle the score.
            HandleScore(Player1, Player1Points, Player2Points, 
                ref Player1LastTotal);

            // Update the board.
            Form1.ActiveForm.Invalidate();
        }

        private void Player2_Leave(object sender, EventArgs e)
        {
            // Handle the score.
            HandleScore(Player2, Player2Points, Player1Points, 
                ref Player2LastTotal);

            // Update the board.
            Form1.ActiveForm.Invalidate();
        }

        // Fields used to keep track of score.
        private int Player1LastTotal = 0;
        private int Player2LastTotal = 0;

        private void HandleScore(TextBox scoreBox, Label points, 
            Label otherPlayer, ref Int32 lastScore)
        {
            try
            {
                if (0 > Int32.Parse(scoreBox.Text) | 
                    Int32.Parse(scoreBox.Text) > 27)
                {
                    // Display an error message and ensure the errant
                    // score textbox has focus.
                    scoreBox.Focus();
                    WinMessage.Text = "Score must be between 0 and 27";
                }
                else
                {
                    // Clear any error message.
                    WinMessage.Text = "";

                    // Update the last score.
                    lastScore = Int32.Parse(points.Text);

                    //Add the score written to the points
                    points.Text = (Int32.Parse(points.Text) + 
                        Int32.Parse(scoreBox.Text)).ToString();

                    // Reset the score text.
                    scoreBox.Text = "0";

                    // Change the focus to the next player.
                    if (scoreBox.Name == "Player1")
                        Player2.Focus();
                    else
                        Player1.Focus();
                }
            }
            catch (System.FormatException ext)
            {
                //Something other than a number
                if (scoreBox.Text.Length > 0)
                {
                    scoreBox.Focus();
                    WinMessage.Text = "Score must be a number";
                }
            }
            catch (Exception ex)
            {
                //Eek!
                scoreBox.Focus();
                MessageBox.Show("Something went wrong!  " + ex.Message);
            }

            //Check the score
            if (Int32.Parse(points.Text) > 120)
            {
                // Make it possible to print the score.
                PrintMe.Visible = true;

                if (Int32.Parse(points.Text) / 
                    Int32.Parse(otherPlayer.Text) > 1.5)
                {
                    WinMessage.Text = scoreBox.Name + " Skunked 'em!!!";
                }
                else
                {
                    WinMessage.Text = scoreBox.Name + " Won!!";
                }
                WinMessage.Visible = true;
            }
        }

        private void CribbageBoard_Paint(object sender, PaintEventArgs e)
        {
            // Obtain the graphics object.
            Graphics g = e.Graphics;

            // Create the board
            SolidBrush brownBrush = new SolidBrush(Color.Brown);
            g.FillRectangle(brownBrush, new Rectangle(20, 20, 820, 180));

            //Paint the little holes.
            //There are 244 little holes in the board.
            //Three rows of 40 times two, with the little starts and stops on
            //either end.
            //Let's start with the 240.
            int rows = 0;
            int columns = 0;
            int scoreBeingDrawn = 0;
            Pen blackPen = new Pen(Color.Black, 1);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //There are 6 rows, then, at 24 and 40, 80 and 100, then 140 and 160.
            for (rows = 40; rows <= 160; rows += 60)
            {
                //There are 40 columns. They are every 20
                for (columns = 40; columns <= 820; columns += 20)
                {
                    //Calculate score being drawn
                    scoreBeingDrawn = ((columns - 20) / 20) + 
                        ((((rows + 20) / 60) - 1) * 40);

                    //Draw Player1
                    //If score being drawn = Player1 fill, otherwise draw
                    if (scoreBeingDrawn == Int32.Parse(Player1Points.Text))
                    {
                        g.FillEllipse(blackBrush, columns - 2, rows - 2, 6, 6);
                    }
                    else if (scoreBeingDrawn == Player1LastTotal)
                    {
                        g.FillEllipse(redBrush, columns - 2, rows - 2, 6, 6);
                    }
                    else
                    {
                        g.DrawEllipse(blackPen, columns - 2, rows - 2, 4, 4);
                    }

                    //Draw Player2
                    //If score being drawn = Player2 fill, otherwise draw
                    if (scoreBeingDrawn == Int32.Parse(Player2Points.Text))
                    {
                        g.FillEllipse(blackBrush, columns - 2, rows + 16, 6, 6);
                    }
                    else if (scoreBeingDrawn == Player2LastTotal)
                    {
                        g.FillEllipse(redBrush, columns - 2, rows + 16, 6, 6);
                    }
                    else
                    {
                        g.DrawEllipse(blackPen, columns - 2, rows + 16, 4, 4);
                    }
                }
            }

            // Perform the required cleanup.
            g.Dispose();
            brownBrush.Dispose();
            blackPen.Dispose();
        }

        private void StartGame_LinkClicked(object sender, 
            LinkLabelLinkClickedEventArgs e)
        {
            // Set the scores to zero.
            Player1.Text = "0";
            Player2.Text = "0";
            Player1Points.Text = "0";
            Player2Points.Text = "0";
            Player1LastTotal = 0;
            Player2LastTotal = 0;

            // Reset the text and hide the print link.
            WinMessage.Text = "";
            PrintMe.Visible = false;
        }

        // Define a variable to hold the bitmap to print.
        private Bitmap memoryImage;

        private void PrintMe_LinkClicked(object sender, 
            LinkLabelLinkClickedEventArgs e)
        {
            // Create a graphics object.
            Graphics thisPage = this.CreateGraphics();
            Size thisSize = this.Size;
            memoryImage = new Bitmap(thisSize.Width, thisSize.Height, thisPage);

            // Copy the form image to memory.
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 
                0, 0, thisSize);

            // Print the document.
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, 
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Ensure the image will fit on the paper by
            // resizing it.
            e.Graphics.DrawImage(memoryImage, 0, 0, 
                memoryImage.Width/2, memoryImage.Height/2);
        }
    }
}
