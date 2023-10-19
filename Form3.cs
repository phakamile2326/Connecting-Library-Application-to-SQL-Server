using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //we will be using the sqlCommandQueryReader method to edit  an existing book from the database
            string Titlename = Tname.Text;
            string Titletype = Ttype.Text;
            string Titleprice = Tprice.Text;

            string oid = oldid.Text;
            string oname = oldname.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-M748B2N\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True"))

                if (Tname.Text.Length != 0 && Ttype.Text.Length != 0 && oldname.Text.Length != 0 && oldid.Text.Length != 0 && Tprice.Text.Length != 0)
            {
                string editt = "update titles set titles = ' " + Titlename + " ', type= ' " + Titletype + " ', price=' " + Titleprice
                + " 'where titles.title_id=' " + oid + " 'and titles.title=' " + oname + " ';";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(editt, connection))
                    {
                       // command.Parameters.AddWithValue("@Titlename",Titlename);
                        command.Parameters.AddWithValue("@Titletype", Titletype);
                        command.Parameters.AddWithValue("@Titlename", Titleprice);
                        command.Parameters.AddWithValue("@oid", oid);
                        command.Parameters.AddWithValue("@oname", oname);
                        //removed the following to be able to edit, command.Parameters.AddWithValue.executeNonQuery();
                    }
                    connection.Close();
                
                    MessageBox.Show("Title has been edited");
                    
            }
            else
                MessageBox.Show("missing information!");
        }
    }
}
