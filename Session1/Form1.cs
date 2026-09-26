using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // void : پوچ 
            // Form کلاس 
            // Close() متد انجام فعل یا یک کار همه باید پرانتز داشته باشند 

            if (checkBox1.Checked==true)
            {
                MessageBox.Show("نسخه پشتیبان تهیه شد.");
                Close();
            }
            else
            {
                Close();
            }
        }
        /// <summary>
        /// باتن آبی
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //BackColor=Color.Blue;
            tabPage1.BackColor = Color.Blue;
        }
        /// <summary>
        /// باتن قرمز
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Red;
        }

        /// <summary>
        /// باتن سفید رنگ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.White;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor= Color.White;
            button2.ForeColor= Color.Black;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor= Color.White;
            button3.ForeColor= Color.Black;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor= Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor= Color.White;
            button4.ForeColor= Color.Black;
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                txtPrintNumbers.Text += i.ToString() + "\r\n";
            }
        }

        private void btnZojFard_Click(object sender, EventArgs e)
        {
            // عددی دریافت کند 
            // تشخیص دهد زوج است یا فرد 

            int n; // n = 4 byte
            //n = (int)numericZojFard.Value;
            // +2  -2   4byte
            n = Convert.ToInt32(numericZojFard.Value);

            // دستوری بنویسید اگر 0 بود پیغام مناسب دهد و برنامه ادامه پیدا نکند
            // return;


            if (n %2== 0)
            {
                MessageBox.Show("عدد زوج است");
            }
            else
            {
                MessageBox.Show("عدد فرد است");
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            timer1.Enabled=true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            timer1.Enabled=false;
        }

        int ncolor = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ncolor++;

            switch (ncolor)
            {
                case 1:
                    l1.Visible = true;
                    break;
                case 2:
                    l2.Visible = true;
                    break;
                case 3:
                    l3.Visible = true;
                    break;
                case 4:
                    l4.Visible = true;
                    break;
                default:
                    
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    ncolor=1;
                    break;
            }


            
            lblColor.Text = ncolor.ToString();
            // وقتی به 4 رسید دوباره از 1 شروع شود 

            // اگر 1 بود اولی نمایش داده شود 
            // اگر 2 بود اولی نمایش داده شود دومی هم نمایش داده شود 
            // اگر سه بود اولی و دومی نمایش داده شود سومی هم نمایش داده شود 
            // اگر چهار بود اولی و دومی و سومی نمایش داده شود چهارمین مورد نمایش داده شود
            // سپس همه مخفی شوند و دوباره 
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }
    }
}
