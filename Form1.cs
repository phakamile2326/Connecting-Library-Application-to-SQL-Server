using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Connecting_Library_Application_to_SQL_Server
{
    public partial class Form1 : Form
    {
        static SqlConnection connectionString = new
            SqlConnection(@"Data Source = DESKTOP-M748B2N\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True");
        public static DataTable dataAdapterSelect(string sqlQuery)
        //this method will convert any select string to a query
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connectionString);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        //this method will convert any string that would manipulate the data to a query
        public static void sqlCommandQueryReader(string sqlQuery)
        {
            SqlCommand myCommand = new SqlCommand(sqlQuery, connectionString);
            myCommand.Connection.Open();
            SqlDataReader dr;
            dr = myCommand.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
            }
            myCommand.Connection.Close();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this query is responsible for displaying the information about the books in the DataGridView
            string sqlQuery = "SELECT title_id,title,type,pub_name,price,ytd_sales FROM titles inner join publishers ON titles.pub_id=publishers.pub_id";
            

            DataTable dt =
                dataAdapterSelect(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["title_id"], dr["pub_name"], dr["price"], dr["ytd_sales"], dr["title"], dr["type"]);

            }
            string sqlQuery2 = " select* from authors order by au_fname asc";
            //define columns programmatically
            dataGridView2.Columns.Add("id", "Id");
            dataGridView2.Columns.Add("first_name", "First_Name");
            dataGridView2.Columns.Add("phone", "Phone");
            dataGridView2.Columns.Add("address", "Address");
            dataGridView2.Columns.Add("city", "City");

            DataTable dt2 =
                dataAdapterSelect(sqlQuery2);
            foreach (DataRow dr in dt2.Rows)
            {
                dataGridView2.Rows.Add(dr["au_id"], dr["au_fname"], dr["phone"], dr["address"], dr["city"]);
            }
                //this query will only display the count of the books that the author wrote on that datagridview.
            string sqlQuery3 = "SELECT authors.au_fname,count(titleauthor.title_id)as authorcount FROM authors,titleauthor WHERE authors.au_id =titleauthor.au_id GROUP BY authors.au_fname";

             DataTable dt3 =
                 dataAdapterSelect(sqlQuery3);
             foreach (DataRow dr  in dt3.Rows)
             {
                dataGridView3.Rows.Add(dr["authorcount"]);
             }
            
            //this query will display the discounts using the discount id and stores id
            string q5 = "select* from stores left outer join discounts on stores.stor_id = discounts.stor_id";
            DataTable q55 =
                dataAdapterSelect(q5);
            foreach (DataRow dr in q55.Rows)
            {
                dataGridView5.Rows.Add(dr["stor_name"], dr["discount"]);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sqlQuery = " SELECT title_id,title,type,pub_name,price,ytd_sales FROM titles inner join publishers ON titles.pub_id = publishers.pub_id";
            DataTable dt =
                dataAdapterSelect(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["title_id"], dr["pub_name"], dr["price"], dr["ytd_sales"], dr["title"], dr["type"]);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string idd = puid.Text;
            string sqlQuery00 = "select* from publishers where publishers.pub_id=' " + idd + " ' ";
            DataTable dt00 =
                dataAdapterSelect(sqlQuery00);
            if (dt00.Rows.Count > 0)
                foreach (DataRow dr in dt00.Rows)
            {
                dataGridView4.Rows.Clear();
                dataGridView4.Rows.Add(dr["pub_id"], dr["pub_name"], dr["city"], dr["state"], dr["country"]);
            }
            else
            {
                MessageBox.Show("This id does not exist");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
