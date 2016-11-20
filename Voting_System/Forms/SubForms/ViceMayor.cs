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
using Voting_System.Database.DBPrecinctTabulation;


namespace Voting_System.Forms
{
    public partial class ViceMayor : MetroForm
    {
        public ViceMayor()
        {
            InitializeComponent();
        }

        private void ViceMayor_Load(object sender, EventArgs e)
        {
            timer1.Start();
            loadMunicipality();
            comboBox_Municipality.SelectedIndex = 16;
        }

        private void loadChart()
        {

            BindingSource bindingsource = new BindingSource();

            List<DBPrecinctViceMayor> rec = DBPrecinctViceMayor.SumationDataTabulation(comboBox_Municipality.Text);
            foreach (DBPrecinctViceMayor data in rec)

                bindingsource.Add(new DBPrecinctViceMayor(
                data.Candidate_id,
                data.Votes
                ));


            chart1.DataSource = bindingsource;

            chart1.Series.First().XValueMember = "Candidate_id";
            chart1.Series.First().YValueMembers = "Votes";

            chart1.DataBind();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadChart();
        }

        private void ViceMayor_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void loadMunicipality()
        {
            try
            {
                this.comboBox_Municipality.Items.Clear();
                BindingSource bindingsource = new BindingSource();

                List<Database.DBElection.DBPrecincts> rec = Database.DBElection.DBPrecincts.GetDataListMunicipality();
                foreach (Database.DBElection.DBPrecincts data in rec)
                    bindingsource.Add(new Database.DBElection.DBPrecincts(
                    data.Municipality
                    ));

                this.comboBox_Municipality.DataSource = bindingsource;
                this.comboBox_Municipality.DisplayMember = "Municipality";

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
