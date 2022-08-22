using System.Data;
using System.Windows.Forms;

namespace Csharplab
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
            
        }
    

        private void btnsave_Click(object sender, EventArgs e)
        {
        Class1 class1 = new Class1();
            class1.Name = txtName.Text;
            class1.Fname = txtFname.Text;
            class1.age = int.Parse(txtage.Text);
            class1.gname = txtgname.Text;   
            class1.productName =txtproductname.Text;
            class1.price = int.Parse(txtprize.Text);
               
            
            class1.Save();
            
            
            MessageBox.Show("Data saved!!");
            Form2 f = new Form2();
            f.Show();
           
           
    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txtName.Text="";
            txtFname.Text = "";
            txtage.Text="";
            txtgname.Text="";
            txtproductname.Text="";
            txtprize.Text="";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}