using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Voting_System.Database;
using System.Threading;

namespace Voting_System
{
    public partial class VotingSystem : MetroForm
    {
        
        public VotingSystem()
        {
            InitializeComponent();
        }

        private void VotingSystem_Load(object sender, EventArgs e)
        {
           
           
          
           // loadChart();
        }

        //private void loadChart()
        //{
           
        //        BindingSource bindingsource = new BindingSource();

        //        List<DBTabulationSummary> rec = DBTabulationSummary.GetDataTabulationSummary();
        //        foreach (DBTabulationSummary data in rec)

        //            bindingsource.Add(new DBTabulationSummary(
        //            data.Group_id,
        //            data.Votes
        //            ));


        //        chart1.DataSource = bindingsource;


        //        chart1.DataSource = bindingsource;

        //        chart1.Series.First().XValueMember = "Group_id";
        //        chart1.Series.First().YValueMembers = "Votes";

        //        chart1.DataBind();
            
        //}

        //private void loadChartRefresh()
        //{
            
        //}

        //private void button_Refresh_Click(object sender, EventArgs e)
        //{
        //    loadChart();
        //}

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
           // loadChart();
        }

        private void metroTile_Congressman_Click(object sender, EventArgs e)
        {
            Forms.Congressman f = new Forms.Congressman();
            f.Show();
        }

        private void metroTile_Councilors_Click(object sender, EventArgs e)
        {
            Forms.Councilor f = new Forms.Councilor();
            f.Show();
        }

        private void metroTile_Mayor_Click(object sender, EventArgs e)
        {
            Forms.Mayor f = new Forms.Mayor();
            f.Show();
        }

        private void metroTile_ViceMayor_Click(object sender, EventArgs e)
        {
            Forms.ViceMayor f = new Forms.ViceMayor();
            f.Show();
        }

        private void metroTile_Retailers_Click(object sender, EventArgs e)
        {
            Forms.Watchers f = new Forms.Watchers();
            f.Show();
        }

        private void metroReciever_Click(object sender, EventArgs e)
        {
            Forms.ReceiverForm f = new Forms.ReceiverForm();
            f.Show();
        }
    }
}
