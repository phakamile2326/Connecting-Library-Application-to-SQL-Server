using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connecting_Library_Application_to_SQL_Server
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {//we will be using the sqlCommandReader method to delete a book that already exists in the database
            string dell = textBox1.Text;
            string query = "delete from roysched where roysched.title_id = @dell; delete from sales where sales.title_id=@dell;delete from titles where titles.title_id=@dell;";
            using (SqlConnection connection = new SqlConnection( @"Data Source = DESKTOP-M748B2N\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True"))
            
            if (textBox1.Text.Length != 0)
            {
                connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dell", dell);
                        
                    }
                    connection.Close();
                   
                        MessageBox.Show("Title has been deleted");
            }
            else
                MessageBox.Show("enter a title id");
        } 



        
    }
}
