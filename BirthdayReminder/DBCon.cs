// (c) Rasan 2012-03-11
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BirthdayReminder
{
    class DBCon
    {
       public SqlConnection mycon = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=BRDB;Integrated Security=SSPI");  
       public void open()
        {
            mycon.Open();
        }

       public void close()
        {
            mycon.Close();
        }
    }
}
