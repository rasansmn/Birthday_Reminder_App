// (c) Rasan 2012-03-11
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BirthdayReminder
{
  
    public partial class frmMain : Form
    {
        DBCon brdb = new DBCon();      
        DataSet dset = new DataSet();
        SqlDataAdapter dadapt;
        int selectedid = 0;
        string selectedname = "";
        int reference = 2; //1-all, 2-today, 3-calenderpick, 4-search

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {          
           loadgrid(reference);   
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrow = dataGrid1.CurrentRowIndex;
                selectedid = (int)dataGrid1[selectedrow, 0];
                selectedname = (string)dataGrid1[selectedrow, 1];
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch
            { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form addform = new frmAdd();
            addform.Show();
        }

        private void dpicBday_ValueChanged(object sender, EventArgs e)
        {
            reference = 3;
            loadgrid(reference);
        }

        void loadgrid(int reference)
        {
            string query = null;       
            switch (reference)
            {
                case (1): //showing all
                    query = "SELECT * FROM tblPeople";
                    dataGrid1.CaptionText = "All";
                    break;
                case(2): //today (on loading form)
                    query = "SELECT * FROM tblPeople WHERE Birthday='" + dpicBday.Text +"'";
                    dataGrid1.CaptionText = "Birthdays on " + dpicBday.Text.Substring(0, dpicBday.Text.Length - 5);
                    break;
                case(3): //calenderpick
                    query = "SELECT * FROM tblPeople WHERE Birthday LIKE '" + dpicBday.Text.Substring(0, dpicBday.Text.Length - 4) + "%'";
                    dataGrid1.CaptionText = "Birthdays on " + dpicBday.Text.Substring(0, dpicBday.Text.Length - 5);
                    break;
                case (4): //search
                    var builder = new SqlCommandBuilder();
                    string fieldname = builder.QuoteIdentifier(cmbLookin.Text);
                    if (cmbLookin.Text.Trim() =="")
                      {
                       fieldname = "[Name]";
                      }
                    query = "SELECT * FROM tblPeople WHERE " + fieldname + " LIKE '%' + @value + '%'";
                    dataGrid1.CaptionText = "Search "+ fieldname + " - " + txtSearch.Text;
                    break;
            }
            try
            {
                dset.Clear();
                SqlCommand cmd = new SqlCommand(query, brdb.mycon);
                cmd.Parameters.Add(new SqlParameter("value", txtSearch.Text)); //parameter when use search
                dadapt = new SqlDataAdapter(cmd);
                dadapt.Fill(dset, "tblPeople");
                dataGrid1.SetDataBinding(dset, "tblPeople");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in : " + ex.Message);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
           reference = 1;
           loadgrid(reference);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            reference = 4;
            loadgrid(reference);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                brdb.open();
                if (MessageBox.Show(selectedname + "\n\nThis record will be deleted. Are you sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlCommand del = new SqlCommand("DELETE FROM tblPeople WHERE ID =" + selectedid, brdb.mycon);
                    del.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in: " + ex.Message);
            }
            finally
            {
                brdb.close();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                loadgrid(reference); //showing current query
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form frmEdit = new frmEdit(selectedid);
            frmEdit.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmabt = new frmAbout();
            frmabt.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addform = new frmAdd();
            addform.Show();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reference = 1;
            loadgrid(reference);
        }
    }
}
