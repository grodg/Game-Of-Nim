namespace GameOfNim
{
    partial class frmGameOfNimControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOfNimControllerForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtPlayerAName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPlayerBName = new System.Windows.Forms.TextBox();
            this.lblPlayerAName = new System.Windows.Forms.Label();
            this.lblPlayerBName = new System.Windows.Forms.Label();
            this.lblReadyToPlay = new System.Windows.Forms.Label();
            this.btnLetsPlay = new System.Windows.Forms.Button();
            this.btnOK1 = new System.Windows.Forms.Button();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnCompletedTurn = new System.Windows.Forms.Button();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.lblYourTurn = new System.Windows.Forms.Label();
            this.collectionOfPics = new System.Windows.Forms.ImageList(this.components);
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(243, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Game of Nim";
            // 
            // txtPlayerAName
            // 
            this.txtPlayerAName.Location = new System.Drawing.Point(216, 103);
            this.txtPlayerAName.Name = "txtPlayerAName";
            this.txtPlayerAName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerAName.TabIndex = 1;
            this.txtPlayerAName.TextChanged += new System.EventHandler(this.txtPlayerAName_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 37);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(1068, 50);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // txtPlayerBName
            // 
            this.txtPlayerBName.Enabled = false;
            this.txtPlayerBName.Location = new System.Drawing.Point(216, 133);
            this.txtPlayerBName.Name = "txtPlayerBName";
            this.txtPlayerBName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerBName.TabIndex = 3;
            this.txtPlayerBName.Visible = false;
            this.txtPlayerBName.TextChanged += new System.EventHandler(this.txtSecondPlayerName_TextChanged);
            // 
            // lblPlayerAName
            // 
            this.lblPlayerAName.AutoSize = true;
            this.lblPlayerAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPlayerAName.Location = new System.Drawing.Point(16, 106);
            this.lblPlayerAName.Name = "lblPlayerAName";
            this.lblPlayerAName.Size = new System.Drawing.Size(166, 17);
            this.lblPlayerAName.TabIndex = 4;
            this.lblPlayerAName.Text = "First Player name --> ";
            // 
            // lblPlayerBName
            // 
            this.lblPlayerBName.AutoSize = true;
            this.lblPlayerBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerBName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPlayerBName.Location = new System.Drawing.Point(16, 136);
            this.lblPlayerBName.Name = "lblPlayerBName";
            this.lblPlayerBName.Size = new System.Drawing.Size(185, 17);
            this.lblPlayerBName.TabIndex = 5;
            this.lblPlayerBName.Text = "Second Player Name -->";
            this.lblPlayerBName.Visible = false;
            // 
            // lblReadyToPlay
            // 
            this.lblReadyToPlay.AutoSize = true;
            this.lblReadyToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyToPlay.Location = new System.Drawing.Point(19, 164);
            this.lblReadyToPlay.Name = "lblReadyToPlay";
            this.lblReadyToPlay.Size = new System.Drawing.Size(316, 18);
            this.lblReadyToPlay.TabIndex = 6;
            this.lblReadyToPlay.Text = "When Ready to Play Click this Button -->";
            this.lblReadyToPlay.Visible = false;
            // 
            // btnLetsPlay
            // 
            this.btnLetsPlay.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLetsPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetsPlay.Location = new System.Drawing.Point(355, 158);
            this.btnLetsPlay.Name = "btnLetsPlay";
            this.btnLetsPlay.Size = new System.Drawing.Size(105, 30);
            this.btnLetsPlay.TabIndex = 7;
            this.btnLetsPlay.Text = "Lets Play!";
            this.btnLetsPlay.UseVisualStyleBackColor = true;
            this.btnLetsPlay.Visible = false;
            this.btnLetsPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOK1
            // 
            this.btnOK1.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOK1.Enabled = false;
            this.btnOK1.Location = new System.Drawing.Point(355, 100);
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(40, 23);
            this.btnOK1.TabIndex = 2;
            this.btnOK1.Text = "OK";
            this.btnOK1.UseVisualStyleBackColor = false;
            this.btnOK1.Click += new System.EventHandler(this.btnOK1_Click);
            // 
            // btnOK2
            // 
            this.btnOK2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK2.Enabled = false;
            this.btnOK2.Location = new System.Drawing.Point(355, 130);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(40, 23);
            this.btnOK2.TabIndex = 9;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = false;
            this.btnOK2.Visible = false;
            this.btnOK2.Click += new System.EventHandler(this.btnOK2_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Controls.Add(this.label1);
            this.pnlBoard.Controls.Add(this.btnCompletedTurn);
            this.pnlBoard.Controls.Add(this.txtCurrentPlayer);
            this.pnlBoard.Controls.Add(this.lblYourTurn);
            this.pnlBoard.Location = new System.Drawing.Point(12, 194);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(612, 317);
            this.pnlBoard.TabIndex = 10;
            // 
            // btnCompletedTurn
            // 
            this.btnCompletedTurn.Enabled = false;
            this.btnCompletedTurn.Location = new System.Drawing.Point(534, 185);
            this.btnCompletedTurn.Name = "btnCompletedTurn";
            this.btnCompletedTurn.Size = new System.Drawing.Size(75, 39);
            this.btnCompletedTurn.TabIndex = 2;
            this.btnCompletedTurn.Text = "Completed \r\nTurn";
            this.btnCompletedTurn.UseVisualStyleBackColor = true;
            this.btnCompletedTurn.Visible = false;
            this.btnCompletedTurn.Click += new System.EventHandler(this.btnCompletedTurn_Click);
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Location = new System.Drawing.Point(128, 12);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.ReadOnly = true;
            this.txtCurrentPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPlayer.TabIndex = 1;
            this.txtCurrentPlayer.Visible = false;
            // 
            // lblYourTurn
            // 
            this.lblYourTurn.AutoSize = true;
            this.lblYourTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourTurn.Location = new System.Drawing.Point(7, 13);
            this.lblYourTurn.Name = "lblYourTurn";
            this.lblYourTurn.Size = new System.Drawing.Size(115, 17);
            this.lblYourTurn.TabIndex = 0;
            this.lblYourTurn.Text = "It\'s Your Turn -->";
            this.lblYourTurn.Visible = false;
            // 
            // collectionOfPics
            // 
            this.collectionOfPics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("collectionOfPics.ImageStream")));
            this.collectionOfPics.TransparentColor = System.Drawing.Color.Transparent;
            this.collectionOfPics.Images.SetKeyName(0, "unnamed[1] (2).jpg");
            this.collectionOfPics.Images.SetKeyName(1, "unnamed[1] (3).jpg");
            this.collectionOfPics.Images.SetKeyName(2, "unnamed[1].jpg");
            this.collectionOfPics.Images.SetKeyName(3, "unnamed[2] (2).jpg");
            this.collectionOfPics.Images.SetKeyName(4, "unnamed[2] (3).jpg");
            this.collectionOfPics.Images.SetKeyName(5, "unnamed[2] (4).jpg");
            this.collectionOfPics.Images.SetKeyName(6, "unnamed[2].jpg");
            this.collectionOfPics.Images.SetKeyName(7, "unnamed[3] (2).jpg");
            this.collectionOfPics.Images.SetKeyName(8, "unnamed[3] (3).jpg");
            this.collectionOfPics.Images.SetKeyName(9, "unnamed[3] (4).jpg");
            this.collectionOfPics.Images.SetKeyName(10, "unnamed[3].jpg");
            this.collectionOfPics.Images.SetKeyName(11, "unnamed[4] (2).jpg");
            this.collectionOfPics.Images.SetKeyName(12, "unnamed[4] (3).jpg");
            this.collectionOfPics.Images.SetKeyName(13, "unnamed[4].jpg");
            this.collectionOfPics.Images.SetKeyName(14, "unnamed[5] (2).jpg");
            this.collectionOfPics.Images.SetKeyName(15, "unnamed[5].jpg");
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPlayAgain.Location = new System.Drawing.Point(77, 532);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(105, 23);
            this.btnPlayAgain.TabIndex = 11;
            this.btnPlayAgain.Text = "Lets Play Again!";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(393, 532);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // frmGameOfNimControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(636, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnOK2);
            this.Controls.Add(this.btnOK1);
            this.Controls.Add(this.btnLetsPlay);
            this.Controls.Add(this.lblReadyToPlay);
            this.Controls.Add(this.lblPlayerBName);
            this.Controls.Add(this.lblPlayerAName);
            this.Controls.Add(this.txtPlayerBName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtPlayerAName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmGameOfNimControllerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBoard.ResumeLayout(false);
            this.pnlBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtPlayerAName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPlayerBName;
        private System.Windows.Forms.Label lblPlayerAName;
        private System.Windows.Forms.Label lblPlayerBName;
        private System.Windows.Forms.Label lblReadyToPlay;
        private System.Windows.Forms.Button btnLetsPlay;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.Button btnOK2;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblYourTurn;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
        private System.Windows.Forms.Button btnCompletedTurn;
        private System.Windows.Forms.ImageList collectionOfPics;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

