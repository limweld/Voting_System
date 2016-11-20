namespace Voting_System.Forms
{
    partial class Watchers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Watchers = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textBox_Number = new MetroFramework.Controls.MetroTextBox();
            this.comboBox_Precinct_no = new MetroFramework.Controls.MetroComboBox();
            this.comboBox_Municipality = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.cmd_Add = new MetroFramework.Controls.MetroButton();
            this.cmd_delete = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Watchers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Watchers
            // 
            this.dataGridView_Watchers.AllowUserToAddRows = false;
            this.dataGridView_Watchers.AllowUserToDeleteRows = false;
            this.dataGridView_Watchers.AllowUserToResizeColumns = false;
            this.dataGridView_Watchers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Aquamarine;
            this.dataGridView_Watchers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Watchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Watchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column1});
            this.dataGridView_Watchers.Location = new System.Drawing.Point(26, 207);
            this.dataGridView_Watchers.Name = "dataGridView_Watchers";
            this.dataGridView_Watchers.ReadOnly = true;
            this.dataGridView_Watchers.RowHeadersVisible = false;
            this.dataGridView_Watchers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Watchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Watchers.Size = new System.Drawing.Size(343, 193);
            this.dataGridView_Watchers.TabIndex = 42;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Number";
            this.Column2.HeaderText = "Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "Municipality";
            this.Column3.HeaderText = "Municipality";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 87;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Precinct_no";
            this.Column1.HeaderText = "Precinct No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(36, 111);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 59;
            this.metroLabel4.Text = "Number :";
            // 
            // textBox_Number
            // 
            // 
            // 
            // 
            this.textBox_Number.CustomButton.Image = null;
            this.textBox_Number.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.textBox_Number.CustomButton.Name = "";
            this.textBox_Number.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Number.CustomButton.TabIndex = 1;
            this.textBox_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Number.CustomButton.UseSelectable = true;
            this.textBox_Number.CustomButton.Visible = false;
            this.textBox_Number.Lines = new string[0];
            this.textBox_Number.Location = new System.Drawing.Point(173, 110);
            this.textBox_Number.MaxLength = 32767;
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.PasswordChar = '\0';
            this.textBox_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Number.SelectedText = "";
            this.textBox_Number.SelectionLength = 0;
            this.textBox_Number.SelectionStart = 0;
            this.textBox_Number.ShortcutsEnabled = true;
            this.textBox_Number.Size = new System.Drawing.Size(196, 20);
            this.textBox_Number.TabIndex = 58;
            this.textBox_Number.UseSelectable = true;
            this.textBox_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBox_Precinct_no
            // 
            this.comboBox_Precinct_no.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBox_Precinct_no.FormattingEnabled = true;
            this.comboBox_Precinct_no.ItemHeight = 19;
            this.comboBox_Precinct_no.Location = new System.Drawing.Point(173, 167);
            this.comboBox_Precinct_no.Name = "comboBox_Precinct_no";
            this.comboBox_Precinct_no.Size = new System.Drawing.Size(196, 25);
            this.comboBox_Precinct_no.TabIndex = 63;
            this.comboBox_Precinct_no.UseSelectable = true;
            // 
            // comboBox_Municipality
            // 
            this.comboBox_Municipality.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBox_Municipality.FormattingEnabled = true;
            this.comboBox_Municipality.ItemHeight = 19;
            this.comboBox_Municipality.Location = new System.Drawing.Point(173, 136);
            this.comboBox_Municipality.Name = "comboBox_Municipality";
            this.comboBox_Municipality.Size = new System.Drawing.Size(196, 25);
            this.comboBox_Municipality.TabIndex = 62;
            this.comboBox_Municipality.UseSelectable = true;
            this.comboBox_Municipality.SelectedIndexChanged += new System.EventHandler(this.comboBox_Municipality_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "Precinct # :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Municipality";
            // 
            // cmd_Add
            // 
            this.cmd_Add.Location = new System.Drawing.Point(26, 406);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(75, 27);
            this.cmd_Add.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmd_Add.TabIndex = 64;
            this.cmd_Add.Text = "ADD";
            this.cmd_Add.UseSelectable = true;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // cmd_delete
            // 
            this.cmd_delete.Location = new System.Drawing.Point(107, 406);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(75, 27);
            this.cmd_delete.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmd_delete.TabIndex = 65;
            this.cmd_delete.Text = "DELETE";
            this.cmd_delete.UseSelectable = true;
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 24);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Clear Logs";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // Watchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 444);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_Add);
            this.Controls.Add(this.comboBox_Precinct_no);
            this.Controls.Add(this.comboBox_Municipality);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.dataGridView_Watchers);
            this.Name = "Watchers";
            this.Text = "Watchers";
            this.Load += new System.EventHandler(this.Watchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Watchers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Watchers;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textBox_Number;
        private MetroFramework.Controls.MetroComboBox comboBox_Precinct_no;
        private MetroFramework.Controls.MetroComboBox comboBox_Municipality;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroButton cmd_Add;
        private MetroFramework.Controls.MetroButton cmd_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}