using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Text.RegularExpressions;
using Voting_System.Database.DBPrecinctTabulation;

namespace Voting_System.Forms
{
    public partial class Watchers : MetroForm
    {
        public string Number
        {
            get { return this.textBox_Number.Text; }
            set { this.textBox_Number.Text = value; }
        }

        public string Municipality
        {
            get { return this.comboBox_Municipality.GetItemText(this.comboBox_Municipality.SelectedItem); }
            set { this.comboBox_Municipality.SelectedText = value; }
        }

        public string Precinct_no
        {
            get { return this.comboBox_Precinct_no.GetItemText(this.comboBox_Precinct_no.SelectedItem); }
            set { this.comboBox_Precinct_no.PromptText = value; }
        }

        public Watchers()
        {
            InitializeComponent();
        }

        private void Watchers_Load(object sender, EventArgs e)
        {
            loadMunicipality();
            loadgrid();
            comboBox_Municipality.SelectedIndex = 16;
            
           
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(" Are You Sure ? ", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                Database.DBWatchers.DBWatchers r = new Database.DBWatchers.DBWatchers();
                r.Delete(this.dataGridView_Watchers.SelectedCells[0].Value.ToString());
                loadgrid();
            }
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            Database.DBWatchers.DBWatchers r = new Database.DBWatchers.DBWatchers();
            r.Add(Number, Municipality, Precinct_no);
            loadgrid();
            Number = "";
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

            }catch(Exception ex){
                ex.ToString();
            }
        }

        private void loadPrecinct(string municipality)
        {
            try
            {
                //this.comboBox_Precinct_no.Items.Clear();
                BindingSource bindingsource = new BindingSource();

                List<Database.DBElection.DBPrecincts> rec = Database.DBElection.DBPrecincts.GetDataListPrecinct_no(municipality);
                foreach (Database.DBElection.DBPrecincts data in rec)
                    bindingsource.Add(new Database.DBElection.DBPrecincts(
                       data.Municipality,
                       data.Precinct
                    ));

                this.comboBox_Precinct_no.DataSource = bindingsource;
                this.comboBox_Precinct_no.DisplayMember = "Precinct";

            }catch(Exception ex){
                ex.ToString();
            }
        }

        private void comboBox_Municipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPrecinct(this.comboBox_Municipality.GetItemText(this.comboBox_Municipality.SelectedItem));
        }

        private void loadgrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            BindingSource bindingsource = new BindingSource();

            List<Database.DBWatchers.DBWatchers> rec = Database.DBWatchers.DBWatchers.GetDataList();
            foreach (Database.DBWatchers.DBWatchers data in rec)
                bindingsource.Add(new Database.DBWatchers.DBWatchers(
                   data.Number,
                   data.Municipality,
                   data.Precinct_no
                ));

            this.dataGridView_Watchers.AutoGenerateColumns = false;
            this.dataGridView_Watchers.DataSource = bindingsource;
            this.dataGridView_Watchers.ClearSelection();

            Cursor.Current = Cursors.Default;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DialogResult dialogResult = MessageBox.Show(" Are You Sure ? ", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
             if (dialogResult == DialogResult.Yes)
             {
                 DBPrecinctCongressman cl1 = new DBPrecinctCongressman();
                 cl1.ClearLogs();

                 DBPrecinctCouncilors cl2 = new DBPrecinctCouncilors();
                 cl2.ClearLogs();

                 DBPrecinctMayor cl3 = new DBPrecinctMayor();
                 cl3.ClearLogs();

                 DBPrecinctViceMayor cl4 = new DBPrecinctViceMayor();
                 cl4.ClearLogs();
             }
            
        }
    }
}
