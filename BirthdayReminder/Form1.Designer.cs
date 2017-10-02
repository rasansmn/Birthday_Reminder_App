namespace BirthdayReminder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dpicBday = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbLookin = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.White;
            this.dataGrid1.BackColor = System.Drawing.Color.White;
            this.dataGrid1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.Lavender;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Wheat;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGrid1.Location = new System.Drawing.Point(14, 70);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Ivory;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.PreferredColumnWidth = 125;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Wheat;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGrid1.Size = new System.Drawing.Size(793, 312);
            this.dataGrid1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dataGrid1, "To select a particular name click on the left pane of the table.");
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
            // 
            // dpicBday
            // 
            this.dpicBday.CustomFormat = "dd-MMMM-yyyy";
            this.dpicBday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpicBday.Location = new System.Drawing.Point(14, 36);
            this.dpicBday.Name = "dpicBday";
            this.dpicBday.Size = new System.Drawing.Size(200, 20);
            this.dpicBday.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dpicBday, "Pick a date to see birthdays.");
            this.dpicBday.ValueChanged += new System.EventHandler(this.dpicBday_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(677, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 20);
            this.txtSearch.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtSearch, "Enter text to search");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbLookin
            // 
            this.cmbLookin.FormattingEnabled = true;
            this.cmbLookin.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Birthday",
            "Phone",
            "Email",
            "Address"});
            this.cmbLookin.Location = new System.Drawing.Point(547, 38);
            this.cmbLookin.Name = "cmbLookin";
            this.cmbLookin.Size = new System.Drawing.Size(121, 21);
            this.cmbLookin.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cmbLookin, "Select the field to search on.");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(732, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Add new record.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(221, 36);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "All";
            this.toolTip1.SetToolTip(this.btnAll, "Show all names");
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Location = new System.Drawing.Point(651, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnDelete, "Delete selected record.");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(570, 388);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.btnEdit, "Edit selected record.");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search In:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.namesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // namesToolStripMenuItem
            // 
            this.namesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.showAllToolStripMenuItem});
            this.namesToolStripMenuItem.Name = "namesToolStripMenuItem";
            this.namesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.namesToolStripMenuItem.Text = "Names";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbLookin);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dpicBday);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birthday Reminder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DateTimePicker dpicBday;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbLookin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;

    }
}

