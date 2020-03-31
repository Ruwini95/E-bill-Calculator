using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_calculator
{
    public partial class Form1 : Form
    {
        double total = 0.0;
        double amount = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

       private void label1_Click(object sender, EventArgs e)
       {

       }

        private void Form1_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
        }


        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }


        private void Date_Click(object sender, EventArgs e)
        {
           
        }

       

        private void c_amount_Click_1(object sender, EventArgs e)
        {
            int no; //customer number
            int u; //no_of_units
            string name, tf; //customer name , tariff code

            if (c_no.Text == "" || c_name.Text == "" || c_type.Text == "" || units.Text == "")
            {
                MessageBox.Show("Please fill all the required fields.");
                return; 
            }
            no = int.Parse(c_no.Text);
            name = c_name.Text;
            tf = c_type.Text;
            u = int.Parse(units.Text);

            String tf1 = "D";
            String tf2 = "d";
            String tf3 = "C";
            String tf4 = "c";

           

            //Domestic Customer
            if (string.Equals(tf, tf1) || string.Equals(tf, tf2))
            {
                //MessageBox.Show(name);
                if (u <= 100)
                {
                    amount = u * 5;
                    total = amount + total;

                    view_panel.Items.Add("******************************");
                    view_panel.Items.Add("Customer No :" + c_no.Text);
                    view_panel.Items.Add("Customer Name : " + c_name.Text);
                    view_panel.Items.Add("Total units consumed :" + units.Text);
                    view_panel.Items.Add("Total amount Payable  : Rs." + amount);
                    view_panel.Items.Add("******************************");
                    c_no.Clear();
                    c_name.Clear();
                    c_type.Clear();
                    units.Clear();

                  

                }

                else
                {
                    amount = 500 + 10 * (u - 100);
                    total = amount + total;
                    view_panel.Items.Add("******************************");
                    view_panel.Items.Add("Customer No :" + c_no.Text);
                    view_panel.Items.Add("Customer Name : " + c_name.Text);
                    view_panel.Items.Add("Total units consumed :" + units.Text);
                    view_panel.Items.Add("Total amount Payable  : Rs." + amount);
                    view_panel.Items.Add("******************************");
                    c_no.Clear();
                    c_name.Clear();
                    c_type.Clear();
                    units.Clear();
                }

            }

            //Commercial Customer
            else if (string.Equals(tf, tf3) || string.Equals(tf, tf4))
            {
                //MessageBox.Show(name);
                if (u <= 200)
                {
                    amount = u * 10;
                    total = amount + total;
                    view_panel.Items.Add("******************************");
                    view_panel.Items.Add("Customer No :" + c_no.Text);
                    view_panel.Items.Add("Customer Name : " + c_name.Text);
                    view_panel.Items.Add("Total units consumed :" + units.Text);
                    view_panel.Items.Add("Total amount Payable  : Rs." + amount);
                    view_panel.Items.Add("******************************");
                    c_no.Clear();
                    c_name.Clear();
                    c_type.Clear();
                    units.Clear();


                }

                else
                {
                    amount = 2000 + 15 * (u - 200);
                    total = amount + total;
                    view_panel.Items.Add("******************************");
                    view_panel.Items.Add("Customer No :" + c_no.Text);
                    view_panel.Items.Add("Customer Name : " + c_name.Text);
                    view_panel.Items.Add("Total units consumed :" + units.Text);
                    view_panel.Items.Add("Total amount Payable  : Rs." + amount);
                    view_panel.Items.Add("******************************");
                    c_no.Clear();
                    c_name.Clear();
                    c_type.Clear();
                    units.Clear();
                }

            }


            

            else
            {
                MessageBox.Show("You have entered an invalid tariff code");
                c_type.Clear();
            }

        }


        private void Total_earnings_Click(object sender, EventArgs e)
        {
            view_panel.Items.Add("Total earnings to CEB : Rs." + total);
        }

        private void c_no_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void c_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void c_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void units_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void list_clear_Click(object sender, EventArgs e)
        {
            view_panel.Items.Clear();
        }
    }
}
