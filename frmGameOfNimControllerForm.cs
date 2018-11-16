/*Gavin Rodgers
 * This is the form class that controls the game of nim board and communicates with the playermodel class
 * and the internalboard class
 * 3309 Project 1 Game of Nim
 * Due: September 24th 2018
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameOfNim.classes;

namespace GameOfNim
{
    public partial class frmGameOfNimControllerForm : System.Windows.Forms.Form
    {
        // PlayerModel players
        // I did things a little differently from what I said in class.
        // The first statement below not only creates a reference variable but it also 
        //     creates a two element array of type PlayerModel where PlayerModel is the
        //     name of the player class.  A pointer to these two elements is stored in
        //     reference variable named playersList
        // What does the second line below do? 

        private List<PlayerModel> playersList = new List<PlayerModel>(2);
        private PlayerModel currentPlayer;

        private const int maxRows = 4;
        private const int maxCols = 7;

        // What does this line (below) do?
        private InternalBoard boardModel = new InternalBoard(maxRows);
      

        int marblesSelectedCount = 0;  // Total number of marbles selected in current turn
        int gameCount = 0;             // counts number of games played
        int rowID;                      // row number of row just slected by current player

        private string playerAName;
        private string playerBName;
        private Button[,] newButton = new Button[maxRows, maxCols];
        private Button[] newRowButton = new Button[maxRows];

        //initializes the game form
        public frmGameOfNimControllerForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("LETS PLAY NIM!!");
        }
        //this method calls for the Game Board to get to created
        private void button1_Click(object sender, EventArgs e)
        {
            if (gameCount > 0)
            {
                currentPlayer = playersList[0];
                displayGameBoard();

            }
            if (txtPlayerAName.Text != txtPlayerBName.Text)
            {
                PlayerModel p;
                p = new PlayerModel(playerAName, 1);
                playersList.Add(p);
                p = new PlayerModel(playerBName, 1);
                playersList.Add(p);

                currentPlayer = playersList[0];
                displayGameBoard();

            }
        }
        //event handler that handles the game marble buttons
        private void Button_Click(object sender, EventArgs e)
        {
            marblesSelectedCount++;
            ((Button)sender).Visible = false;
        } // end button clickhandler         
       // Displays the initial game board
        private void displayGameBoard()
        {
            pnlBoard.Location = new System.Drawing.Point(32, 232);
            txtCurrentPlayer.Text = playerAName;
            pnlBoard.Visible = true;
            createBoard();
        }

        //finished
        // Creates the Nim Board for play
        private void RowButton_Click(object sender, EventArgs e)
        {
            rowID = convertCharToInt(((Button)sender).Name[6]);
            // MessageBox.Show("Row Button [" + (rowID+1) + "] has been selected!");
            ((Button)sender).BackColor = System.Drawing.Color.Orange;
            for (int i = 0; i < maxRows; i++) newRowButton[i].Enabled = false;
            if (rowID == 0) newButton[rowID, maxCols / 2].Enabled = true;
            if (rowID == 1) for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++)
                    newButton[rowID, i].Enabled = true;
            if (rowID == 2) for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++)
                    newButton[rowID, i].Enabled = true;
            if (rowID == 3) for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++)
                    newButton[rowID, i].Enabled = true;
            btnCompletedTurn.Enabled = true;
        } // end button clickhandler
          //finished

        // Convert a charcter to its equivalent integer
        int convertCharToInt(Char c)
        {
            return ((int)(c) - (int)('0'));
        }  // end convertCharToInt

        //creates the gameboard for the Game of Nim
        private void createBoard()
        {
            // Dynamically Creates a 4x7 grid and associated row buttons  
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            pnlBoard.Visible = true;
            btnCompletedTurn.Visible = true;
            Size size = new Size(50, 50);
            Point loc = new Point(0, 0);
            int padding = 10;
            int topMargin = 50;

            // The board is treated like a maxRows x MaxCols array
            for (int row = 0; row < maxRows; row++)
            {
                // For each new row, insert at left the Row i Button
                loc.Y = (topMargin + 10) + row * (size.Height + padding);
                int rowBtnExtraLeftPadding = 15;
                newRowButton[row] = new System.Windows.Forms.Button();
                newRowButton[row].Location = new Point(rowBtnExtraLeftPadding, loc.Y);
                newRowButton[row].Size = new Size(75, 23);
                newRowButton[row].Text = "Row " + (row + 1) + " -->";
                newRowButton[row].Enabled = true;
                newRowButton[row].Visible = true;
                newRowButton[row].Name = "rowBtn" + row;
                newRowButton[row].Click += new EventHandler(RowButton_Click);

                // Add row button to the form
                pnlBoard.Controls.Add(newRowButton[row]);

                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 100;
                for (int col = 0; col < maxCols; col++)
                {
                    newButton[row, col] = new System.Windows.Forms.Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col *
                                                   (size.Width + padding), loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Text = "";
                    newButton[row, col].Enabled = false;
                    newButton[row, col].Visible = true;
                    newButton[row, col].Name = "btn" + row + col;

                    // Associates the same event handler with each of the buttons generated

                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlBoard.Controls.Add(newButton[row, col]);
                } // end for col
            } // end for row

            lblYourTurn.Visible = true;
            txtCurrentPlayer.Visible = true;
            // Set up the board with the 16 marbles
            // For now, instead of worrying about images in this code, just store any character
            //     you want in the Text field of each newButton.  (You will need to change the
            //     line of code above that sets the Text attribute of newButton.) 

            newButton[0, maxCols / 2].Image = collectionOfPics.Images[0];
            for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++) newButton[1, i].Image =
                    collectionOfPics.Images[i - 1];
            for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++) newButton[2, i].Image =
                    collectionOfPics.Images[i + 3];
            for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++) newButton[3, i].Image =
                    collectionOfPics.Images[i + 9];

        } // end createBoard


        //Makes sure player A name is enetered
        private void btnOK1_Click(object sender, EventArgs e)
        {

            if (txtPlayerAName.Text == "")
            {
                MessageBox.Show("Please Enter a Name", "Error");
            }
            else
            {
                lblPlayerBName.Visible = true;
                txtPlayerBName.Visible = true;
                txtPlayerBName.Enabled = true;
                btnOK2.Visible = true;
                txtPlayerBName.Focus();
            }
            playerAName = txtPlayerAName.Text;
        }
        //checks to make sure the player names for A and B are filled in and different
        private void btnOK2_Click(object sender, EventArgs e)
        {
            if (txtPlayerBName.Text == txtPlayerAName.Text)
            {
                txtPlayerBName.Focus();
                MessageBox.Show("Please Enter a different Name", "Same Name");
                txtPlayerBName.Text = "";
            }
            else
            {
                btnLetsPlay.Visible = true;
                btnLetsPlay.Enabled = true;
                lblReadyToPlay.Visible = true;
                lblReadyToPlay.Enabled = true;
            }
            playerBName = txtPlayerAName.Text;
        }
        //Checks for the second player name text field isnt blank or the same as player 1
        private void txtSecondPlayerName_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayerBName.Text == "")
            {
                btnOK2.Enabled = false;
                
            }
            else if (txtPlayerBName.Text != txtPlayerAName.Text && txtPlayerBName.Text != "")
            {
                btnOK2.Enabled = true;
            }

        }
        //Checks player A text box to make sure that the field isnt blank
        private void txtPlayerAName_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayerAName.Text == "")
            {
                txtPlayerAName.Focus();
                btnOK1.Enabled = false;
            }
            else
            {
                btnOK1.Enabled = true;
            }
        }
        //closes the program when quit button is executed
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //completes the turn for a player and sets the board for the next player
        public void btnCompletedTurn_Click(object sender, EventArgs e)
        {         
            if (!boardModel.isWinner())
            {
                if (marblesSelectedCount != 0) {
                    if (currentPlayer == playersList[0])
                    {
                        txtCurrentPlayer.Text = txtPlayerBName.Text;
                        currentPlayer = playersList[1];
                        MessageBox.Show(txtPlayerAName.Text + " Selected " + marblesSelectedCount + " marbles " + " from Row " + (rowID + 1));
                    }
                    else 
                    {
                        txtCurrentPlayer.Text = txtPlayerAName.Text;
                        currentPlayer = playersList[0];
                        MessageBox.Show(txtPlayerBName.Text + " Selected " + marblesSelectedCount + " marbles " + " from Row " + (rowID + 1));
                    }
                    reset();

                    if (boardModel.getRowCount(0) != 0)
                    {
                        newRowButton[0].Enabled = true;
                    }
                    if (boardModel.getRowCount(1) != 0)
                    {
                        newRowButton[1].Enabled = true;
                    }
                    if (boardModel.getRowCount(2) != 0 )
                    {
                        newRowButton[2].Enabled = true;
                    }
                    if (boardModel.getRowCount(3) != 0 )
                    {
                        newRowButton[3].Enabled = true;
                    }

                    marblesSelectedCount = 0;

                }
                else
                {
                    MessageBox.Show("Please Select a Marble");
                }
                
              
            }
            else
            {
                pnlBoard.Enabled = false;
                if(boardModel.currentMarbleCount == 1)
                {
                    MessageBox.Show("Congradulations" +txtCurrentPlayer.Text +"You have won the Game!");
                }
                else if(boardModel.currentMarbleCount == 0)
                {
                    if (currentPlayer == playersList[0]) {
                        txtCurrentPlayer.Text = txtPlayerBName.Text;
                        MessageBox.Show("Congradulations" + txtCurrentPlayer.Text + "You have won the Game!" );
                    }
                    else if(currentPlayer == playersList[1])
                    {
                        txtCurrentPlayer.Text = txtPlayerAName.Text;
                        MessageBox.Show("Congradulations" + txtCurrentPlayer.Text + "You have won the Game!")
                    }
                }
            }
           
        }
        //sets the board for each new turn
        public void reset()
        {      
            boardModel.recordTurn(rowID, marblesSelectedCount);
            if (rowID == 0) newButton[rowID, maxCols / 2].Enabled = false;
            if (rowID == 1)
            {
                for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++)
                {
                    newButton[rowID, i].Enabled = false;                
                }           
            }
            if (rowID == 2)
            {
                for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++) {
                    newButton[rowID, i].Enabled = false;
                    
                }
            }
            if (rowID == 3) {
                for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++)
                {
                    newButton[rowID, i].Enabled = false;
                }
            }
            btnCompletedTurn.Enabled = true;
            newRowButton[rowID].BackColor = SystemColors.ButtonFace;
            newRowButton[rowID].UseVisualStyleBackColor = true;
        }
        //creates the board for a new game
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want to play again click exit and relaunch the form");
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}






