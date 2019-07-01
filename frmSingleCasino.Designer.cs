namespace BlackJack
{
    partial class frmSingleCasino
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGameNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGameHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGameExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfirmBet = new System.Windows.Forms.Button();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCashAmount = new System.Windows.Forms.Label();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrBetting = new System.Windows.Forms.Timer(this.components);
            this.btnDouble = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGameNewGame,
            this.mnuGameHelp,
            this.toolStripMenuItem1,
            this.mnuGameExit});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // mnuGameNewGame
            // 
            this.mnuGameNewGame.Name = "mnuGameNewGame";
            this.mnuGameNewGame.Size = new System.Drawing.Size(187, 22);
            this.mnuGameNewGame.Text = "New Game";
            this.mnuGameNewGame.Click += new System.EventHandler(this.mnuGameNewGame_Click);
            // 
            // mnuGameHelp
            // 
            this.mnuGameHelp.Name = "mnuGameHelp";
            this.mnuGameHelp.Size = new System.Drawing.Size(187, 22);
            this.mnuGameHelp.Text = "Help";
            this.mnuGameHelp.Click += new System.EventHandler(this.mnuGameHelp_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // mnuGameExit
            // 
            this.mnuGameExit.Name = "mnuGameExit";
            this.mnuGameExit.Size = new System.Drawing.Size(187, 22);
            this.mnuGameExit.Text = "Return to Main Menu";
            this.mnuGameExit.Click += new System.EventHandler(this.mnuGameExit_Click);
            // 
            // btnConfirmBet
            // 
            this.btnConfirmBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnConfirmBet.Location = new System.Drawing.Point(639, 123);
            this.btnConfirmBet.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmBet.Name = "btnConfirmBet";
            this.btnConfirmBet.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmBet.TabIndex = 1;
            this.btnConfirmBet.Text = "Confirm Bet";
            this.btnConfirmBet.UseVisualStyleBackColor = true;
            this.btnConfirmBet.Click += new System.EventHandler(this.btnConfirmBet_Click);
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblBetAmount.Location = new System.Drawing.Point(636, 102);
            this.lblBetAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(53, 17);
            this.lblBetAmount.TabIndex = 2;
            this.lblBetAmount.Text = "Bet: $1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(636, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "W/S to change bet";
            // 
            // lblCashAmount
            // 
            this.lblCashAmount.AutoSize = true;
            this.lblCashAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblCashAmount.Location = new System.Drawing.Point(636, 40);
            this.lblCashAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCashAmount.Name = "lblCashAmount";
            this.lblCashAmount.Size = new System.Drawing.Size(64, 17);
            this.lblCashAmount.TabIndex = 4;
            this.lblCashAmount.Text = "Cash: $0";
            // 
            // btnDeal
            // 
            this.btnDeal.Enabled = false;
            this.btnDeal.Location = new System.Drawing.Point(12, 132);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 37);
            this.btnDeal.TabIndex = 5;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnHold
            // 
            this.btnHold.Enabled = false;
            this.btnHold.Location = new System.Drawing.Point(93, 132);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(75, 37);
            this.btnHold.TabIndex = 6;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dealer Hand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player Hand:";
            // 
            // tmrBetting
            // 
            this.tmrBetting.Interval = 50;
            this.tmrBetting.Tick += new System.EventHandler(this.tmrBetting_Tick);
            // 
            // btnDouble
            // 
            this.btnDouble.Enabled = false;
            this.btnDouble.Location = new System.Drawing.Point(12, 86);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 37);
            this.btnDouble.TabIndex = 9;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // frmSingleCasino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 441);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.lblCashAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBetAmount);
            this.Controls.Add(this.btnConfirmBet);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSingleCasino";
            this.Text = "frmSingleCasino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSingleCasino_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSingleCasino_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSingleCasino_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGameNewGame;
        private System.Windows.Forms.ToolStripMenuItem mnuGameHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuGameExit;
        private System.Windows.Forms.Button btnConfirmBet;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCashAmount;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrBetting;
        private System.Windows.Forms.Button btnDouble;
    }
}