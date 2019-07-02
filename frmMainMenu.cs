using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//William Tran
//Nov 5, 2018
//This form is the main menu, controlling which gamemode the user is sent to

namespace BlackJack
{
    public partial class frmMainMenu : Form
    {
        

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int StartingCash = -1; //starts at -1, is changed if valid number is inputted
            int.TryParse(txtStartingCash.Text, out StartingCash); //check if starting cash is a valid amount

            if (StartingCash > 0) //if StartingCash is valid then start selected gamemode
            {
                if (rad17Style.Checked == true)
                {
                    frmSingle17 NewWindow = new frmSingle17(StartingCash);
                    this.Visible = false;
                    NewWindow.ShowDialog();
                    this.Visible = true;
                }
                else if (radSingleCasino.Checked == true)
                {
                    frmSingleCasino NewWindow = new frmSingleCasino(StartingCash);
                    this.Visible = false;
                    NewWindow.ShowDialog();
                    this.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Error. The starting cash amount must be a positive integer.");
            }
            

        }

        private void mnuGameExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
