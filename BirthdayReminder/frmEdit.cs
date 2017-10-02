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
    public partial class frmEdit : Form
    {
        int editid;
        DBCon brdb = new DBCon();

        public frmEdit(int userid) //constructor when build the form
        {
            InitializeComponent();
            editid = userid; //what to edit
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            try
            {
                brdb.open();
                SqlCommand cmdretrieve = new SqlCommand("SELECT * FROM tblPeople WHERE ID =" + editid, brdb.mycon);
                reader = cmdretrieve.ExecuteReader();
                while (reader.Read())
                {
                    txtName.Text = (string)reader["Name"];
                    dpicBday.Text = (string)reader["Birthday"];
                    txtPhone.Text = (string)reader["Phone"];
                    txtEmail.Text = (string)reader["Email"];
                    txtAddress.Text = (string)reader["Address"];
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in : " + ex.Message);
            }
            finally
            {
                reader.Close();
                brdb.close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter the name", "Update");
            }
            else
            {
                try
                {
                    brdb.open();
                    SqlCommand cmdup = new SqlCommand("UPDATE tblPeople SET Name=@name, Birthday=@birthday, Phone=@phone, Email=@email, Address=@address WHERE ID = @id", brdb.mycon);
                    cmdup.Parameters.Add(new SqlParameter("name", txtName.Text));
                    cmdup.Parameters.Add(new SqlParameter("birthday", dpicBday.Text));
                    cmdup.Parameters.Add(new SqlParameter("phone", txtPhone.Text));
                    cmdup.Parameters.Add(new SqlParameter("email", txtEmail.Text));
                    cmdup.Parameters.Add(new SqlParameter("address", txtAddress.Text));
                    cmdup.Parameters.Add(new SqlParameter("id", editid));
                    cmdup.ExecuteNonQuery();
                    MessageBox.Show("Successflly updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception in : " + ex.Message);
                }
                finally
                {
                    brdb.close();
                    this.Close();
                }
            }
        }
    }
}
