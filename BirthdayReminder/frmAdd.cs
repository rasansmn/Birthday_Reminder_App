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
    public partial class frmAdd : Form
    {
        DBCon brdb = new DBCon();
        
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter the name", "Add");
                txtName.Focus();
            }
            else
            {
                try
                {
                    brdb.open();
                    //getting new ID to insert
                    int count = 0;
                    int newid = 0;
                    SqlCommand cmdcount = new SqlCommand("SELECT COUNT (*) FROM tblPeople", brdb.mycon);
                    count = (int) cmdcount.ExecuteScalar();
                    if (count > 0)
                    {
                        SqlCommand cmd = new SqlCommand("SELECT MAX (ID) FROM tblPeople", brdb.mycon);
                        newid = (int)cmd.ExecuteScalar();
                    }
                    newid += 1; // new ID is ready now
                    SqlCommand cmdin = new SqlCommand("INSERT INTO tblPeople VALUES (@newid, @name, @bday, @phone, @email, @address)", brdb.mycon);
                    cmdin.Parameters.Add(new SqlParameter("newid", newid));
                    cmdin.Parameters.Add(new SqlParameter("name", txtName.Text));
                    cmdin.Parameters.Add(new SqlParameter("bday", dpicBday.Text));
                    cmdin.Parameters.Add(new SqlParameter("phone", txtPhone.Text));
                    cmdin.Parameters.Add(new SqlParameter("email", txtEmail.Text));
                    cmdin.Parameters.Add(new SqlParameter("address", txtAddress.Text));
                    cmdin.ExecuteNonQuery();
                    MessageBox.Show("Successflly added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in : " + ex.Message);
                }
                finally
                {
                    brdb.close();
                    clear();
                }
            }
        }

        void clear()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtName.Focus();
        }
    }
}
