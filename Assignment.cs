using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3lab
{
    public partial class Form1 : Form
    {
        public string Patientname { get; set; }
        public int date { get; set; }
        public char Bloodtype { get; set; }

        public string Disease { get; set; }
        public string DoctorName { get; set; }
        public int price { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_sku_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_itemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            inventory i = new inventory();
            {
                i.Patientname = text_Number.Text;
                i.date = txt_date.Text;
                i.Bloodtype = text_bloodtype.Text;
                i.Disease = text_itemname.Text;
                i.DoctorName = text_quantity.Text;
                i.price = Convert.ToDouble(text_price.Text);

            }
          //  inventory.GetInventories();

            bool validation = true;
            if (text_bloodtype.Text.Length > 2)
            {
                errorProvider1.SetError(text_bloodtype, "Can't contain more than 2 characters!!!");
                validation = false;
            }
            if (validation) { 
                i.Save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = inventory.GetInventories();
            }
        }

   
    }

}
        

      