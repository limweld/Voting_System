namespace Voting_System
{
    partial class VotingSystem
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
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.metroTile_ViceMayor = new MetroFramework.Controls.MetroTile();
            this.metroTile_Retailers = new MetroFramework.Controls.MetroTile();
            this.metroTile_Councilors = new MetroFramework.Controls.MetroTile();
            this.metroTile_Mayor = new MetroFramework.Controls.MetroTile();
            this.metroTile_Congressman = new MetroFramework.Controls.MetroTile();
            this.metroReciever = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // metroTile_ViceMayor
            // 
            this.metroTile_ViceMayor.ActiveControl = null;
            this.metroTile_ViceMayor.Location = new System.Drawing.Point(150, 158);
            this.metroTile_ViceMayor.Name = "metroTile_ViceMayor";
            this.metroTile_ViceMayor.Size = new System.Drawing.Size(121, 89);
            this.metroTile_ViceMayor.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile_ViceMayor.TabIndex = 14;
            this.metroTile_ViceMayor.Text = "Vice Mayor";
            this.metroTile_ViceMayor.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile_ViceMayor.UseSelectable = true;
            this.metroTile_ViceMayor.UseTileImage = true;
            this.metroTile_ViceMayor.Click += new System.EventHandler(this.metroTile_ViceMayor_Click);
            // 
            // metroTile_Retailers
            // 
            this.metroTile_Retailers.ActiveControl = null;
            this.metroTile_Retailers.Location = new System.Drawing.Point(23, 253);
            this.metroTile_Retailers.Name = "metroTile_Retailers";
            this.metroTile_Retailers.Size = new System.Drawing.Size(121, 89);
            this.metroTile_Retailers.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile_Retailers.TabIndex = 13;
            this.metroTile_Retailers.Text = "Watchers";
            this.metroTile_Retailers.UseSelectable = true;
            this.metroTile_Retailers.Click += new System.EventHandler(this.metroTile_Retailers_Click);
            // 
            // metroTile_Councilors
            // 
            this.metroTile_Councilors.ActiveControl = null;
            this.metroTile_Councilors.Location = new System.Drawing.Point(150, 63);
            this.metroTile_Councilors.Name = "metroTile_Councilors";
            this.metroTile_Councilors.Size = new System.Drawing.Size(121, 89);
            this.metroTile_Councilors.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile_Councilors.TabIndex = 12;
            this.metroTile_Councilors.Text = "Councilors";
            this.metroTile_Councilors.UseSelectable = true;
            this.metroTile_Councilors.Click += new System.EventHandler(this.metroTile_Councilors_Click);
            // 
            // metroTile_Mayor
            // 
            this.metroTile_Mayor.ActiveControl = null;
            this.metroTile_Mayor.Location = new System.Drawing.Point(23, 158);
            this.metroTile_Mayor.Name = "metroTile_Mayor";
            this.metroTile_Mayor.Size = new System.Drawing.Size(121, 89);
            this.metroTile_Mayor.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_Mayor.TabIndex = 11;
            this.metroTile_Mayor.Text = "Mayor";
            this.metroTile_Mayor.UseSelectable = true;
            this.metroTile_Mayor.Click += new System.EventHandler(this.metroTile_Mayor_Click);
            // 
            // metroTile_Congressman
            // 
            this.metroTile_Congressman.ActiveControl = null;
            this.metroTile_Congressman.Location = new System.Drawing.Point(23, 63);
            this.metroTile_Congressman.Name = "metroTile_Congressman";
            this.metroTile_Congressman.Size = new System.Drawing.Size(121, 89);
            this.metroTile_Congressman.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_Congressman.TabIndex = 10;
            this.metroTile_Congressman.Text = "Congressman";
            this.metroTile_Congressman.UseSelectable = true;
            this.metroTile_Congressman.Click += new System.EventHandler(this.metroTile_Congressman_Click);
            // 
            // metroReciever
            // 
            this.metroReciever.ActiveControl = null;
            this.metroReciever.Location = new System.Drawing.Point(150, 253);
            this.metroReciever.Name = "metroReciever";
            this.metroReciever.Size = new System.Drawing.Size(121, 89);
            this.metroReciever.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroReciever.TabIndex = 15;
            this.metroReciever.Text = "Reciever";
            this.metroReciever.UseSelectable = true;
            this.metroReciever.Click += new System.EventHandler(this.metroReciever_Click);
            // 
            // VotingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 357);
            this.Controls.Add(this.metroReciever);
            this.Controls.Add(this.metroTile_ViceMayor);
            this.Controls.Add(this.metroTile_Retailers);
            this.Controls.Add(this.metroTile_Councilors);
            this.Controls.Add(this.metroTile_Mayor);
            this.Controls.Add(this.metroTile_Congressman);
            this.Name = "VotingSystem";
            this.Text = "Voting System";
            this.Load += new System.EventHandler(this.VotingSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerRefresh;
        private MetroFramework.Controls.MetroTile metroTile_ViceMayor;
        private MetroFramework.Controls.MetroTile metroTile_Retailers;
        private MetroFramework.Controls.MetroTile metroTile_Councilors;
        private MetroFramework.Controls.MetroTile metroTile_Mayor;
        private MetroFramework.Controls.MetroTile metroTile_Congressman;
        private MetroFramework.Controls.MetroTile metroReciever;
    }
}

