using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Workshopmanagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;database=wms;username=root;password=kent";
                string Query = "insert into WMS.customer(FirstName, LastName, Phone) values('" + fname.Text + "','" + lname.Text + "','" + phone.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                /*long id = MyCommand2.LastInsertedId;
                Query = "insert into WMS.address(Street, City, Postcode, State, CustomerID) values('" + this.StreetTextbox.Text + "','" + this.CityTextbox.Text + "','" + this.PostcodeTextbox.Text + "','" + this.StateTextbox.Text + "', " + id.ToString() + ");";
                MyConn2 = new MySqlConnection(MyConnection2);
                MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                */
                MessageBox.Show("Customer Added");

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
