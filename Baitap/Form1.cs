using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtpassword.Text;

       
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");
                // Thực hiện các hành động khác sau khi đăng nhập thành công (nếu cần)
                Form2 successForm = new Form2();
                this.Hide();
                successForm.ShowDialog();
                this.Close();
            }
          
        }
    }
}
