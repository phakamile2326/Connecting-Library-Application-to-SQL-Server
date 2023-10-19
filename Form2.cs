using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Connecting_Library_Application_to_SQL_Server
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // we will be using the sqlCommandQueryReader method to add a new book to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string titleID = titleIDTextBox.Text;
            string titleName=titleNameTextBox.Text;
            string titleType = titleTypeTextBox.Text;
            string pubid = pubbid.Text;
            string pricee = priceTextBox.Text;
            string pubdate = pubdateTextBox.Text;

            


            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-M748B2N\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True"))
                if (titleIDTextBox.Text.Length !=0 && titleNameTextBox.Text.Length !=0 && titleTypeTextBox.Text.Length !=0 && 
                    pubbid.Text.Length !=0 && priceTextBox.Text.Length !=0 && pubdateTextBox.Text.Length != 0)
                {
                    string insertt = "insert into titles(title_id,title,type,pub_id,price,pubdate) values (' " + titleID + " ', ' " + titleName + " ', ' " + titleType + " ',  ' " + pubid + " ', ' " +
                  pricee + " ', ' " + pubdate + " ');";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(insertt, connection))
                    {
                        //command.Parameters.AddWithValue("@titleID", titleID);
                        command.Parameters.AddWithValue("@titleName", titleName);
                        command.Parameters.AddWithValue("@titleType", titleType);
                        command.Parameters.AddWithValue("pubid", pubid);
                        command.Parameters.AddWithValue("@pricee", pricee);
                        command.Parameters.AddWithValue("@pubdate", pubdate);

                        
                    }
                    connection.Close();
                    MessageBox.Show("Information inseted");

                }
       


        }
    }
}
