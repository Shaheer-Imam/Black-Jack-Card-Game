namespace BlackJack
{
    partial class frmSingle17
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGameNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGameHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblDollarValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGameNewGame,
            this.mnuGameHelp,
            this.fileSep1,
            this.fileExit});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // mnuGameNewGame
            // 
            this.mnuGameNewGame.Name = "mnuGameNewGame";
            this.mnuGameNewGame.Size = new System.Drawing.Size(132, 22);
            this.mnuGameNewGame.Text = "New Game";
            this.mnuGameNewGame.Click += new System.EventHandler(this.mnuGameNewGame_Click);
            // 
            // mnuGameHelp
            // 
            this.mnuGameHelp.Name = "mnuGameHelp";
            this.mnuGameHelp.Size = new System.Drawing.Size(132, 22);
            this.mnuGameHelp.Text = "Help";
            this.mnuGameHelp.Click += new System.EventHandler(this.mnuGameHelp_Click);
            // 
            // fileSep1
            // 
            this.fileSep1.Name = "fileSep1";
            this.fileSep1.Size = new System.Drawing.Size(129, 6);
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.Size = new System.Drawing.Size(132, 22);
            this.fileExit.Text = "Exit";
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // btnHold
            // 
            this.btnHold.Enabled = false;
            this.btnHold.Location = new System.Drawing.Point(106, 27);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(75, 23);
            this.btnHold.TabIndex = 1;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Enabled = false;
            this.btnDeal.Location = new System.Drawing.Point(25, 27);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Deal a Card";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lblDollarValue
            // 
            this.lblDollarValue.AutoSize = true;
            this.lblDollarValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDollarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollarValue.Location = new System.Drawing.Point(342, 27);
            this.lblDollarValue.Name = "lblDollarValue";
            this.lblDollarValue.Size = new System.Drawing.Size(135, 20);
            this.lblDollarValue.TabIndex = 3;
            this.lblDollarValue.Text = "$$$$ Dollar Value";
            // 
            // frmSingle17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 239);
            this.Controls.Add(this.lblDollarValue);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSingle17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack 17-Style";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGameNewGame;
        private System.Windows.Forms.ToolStripSeparator fileSep1;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lblDollarValue;
        private System.Windows.Forms.ToolStripMenuItem mnuGameHelp;
    }
}

