using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentDashBoardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournaments_All();

        public TournamentDashBoardForm()
        {
            InitializeComponent();

            WireUpList();
        }

        private void WireUpList()
        {
            loadExistingTournamentDrodown.DataSource = tournaments;
            loadExistingTournamentDrodown.DisplayMember = "TournamentName";
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }
    }
}
