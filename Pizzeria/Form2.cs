using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form2 : Form
    {
        const double pricePepproni = 50;
        const double priceKebab = 50;
        const double priceSkinke = 50;
        const double priceChampignon = 10;
        const double pricePolser = 10;
        const double priceOst = 10;

        
        
        //const double price = 50;
        //const double price = 50;
        //const double price = 50;
        //const double price = 50;
        //const double price = 50;
        //const double price = 50;
        //const double price = 50;
        //const double price = 50;

        double mySubTotal, myTotal;


        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Vil du afslutte","Pizzeia", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double[] itemCost = new double[12];
            itemCost[0] = Convert.ToDouble(txt_amount1.Text) * pricePepproni;
            itemCost[1] = Convert.ToDouble(txt_amount2.Text) * priceKebab;
            itemCost[2] = Convert.ToDouble(txt_amount3.Text) * priceSkinke;

            itemCost[3] = Convert.ToDouble(chk_Champignon1.Text) * priceChampignon;
            itemCost[4] = Convert.ToDouble(chk_Polser1.Text) * pricePolser;
            itemCost[5] = Convert.ToDouble(txtOst1.Text) * priceOst;

            itemCost[6] = Convert.ToDouble(chk_Champignon2.Text) * priceChampignon;
            itemCost[7] = Convert.ToDouble(chk_Polser2.Text) * pricePolser;
            itemCost[8] = Convert.ToDouble(txtOst2.Text) * priceOst;

            itemCost[9] = Convert.ToDouble(chk_Champignon3.Text) * priceChampignon;
            itemCost[10] = Convert.ToDouble(chk_Polser3.Text) * pricePolser;
            itemCost[11] = Convert.ToDouble(txtOst3.Text) * priceOst;

            

           



        }
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::://
        private void checkBox_Champignon_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Champignon1.Checked == true)
            {
                txtChampigon1.Enabled = true;
                txtChampigon1.Text = "";
                txtChampigon1.Focus();
            }
            else
            {
                txtChampigon1.Enabled = false;
                txtChampigon1.Text = "0";
            }
        }

        private void checkBox_Pepproni(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::://
        private void chk_Pepproni_Click(object sender, EventArgs e)
        {
            if (chk_Pepproni.Checked == true)
            {
                txt_amount1.Enabled = true;
                txt_amount1.Text = "";
                txt_amount1.Focus();
            }
            else
            {
                txt_amount1.Enabled = false;
                txt_amount1.Text = "0";
            }
        }

        private void chk_Kebab_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Kebab.Checked == true)
            {
                txt_amount2.Enabled = true;
                txt_amount2.Text = "";
                txt_amount2.Focus();
            }
            else
            {
                txt_amount2.Enabled = false;
                txt_amount2.Text = "0";
            }
        }

        private void chk_Skinke_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Skinke.Checked == true)
            {
                txt_amount3.Enabled = true;
                txt_amount3.Text = "";
                txt_amount3.Focus();
            }
            else
            {
                txt_amount3.Enabled = false;
                txt_amount3.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_Polser_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Polser1.Checked == true)
            {
                txtPolser1.Enabled = true;
                txtPolser1.Text = "";
                txtPolser1.Focus();
            }
            else
            {
                txtPolser1.Enabled = false;
                txtPolser1.Text = "0";
            }
        }

        private void chk_Ost_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Ost1.Checked == true)
            {
                txtOst1.Enabled = true;
                txtOst1.Text = "";
                txtOst1.Focus();
            }
            else
            {
                txtOst1.Enabled = false;
                txtOst1.Text = "0";
            }
        }

        private void chk_Champignon2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Champignon2.Checked == true)
            {
                txtChampigon2.Enabled = true;
                txtChampigon2.Text = "";
                txtChampigon2.Focus();
            }
            else
            {
                txtChampigon2.Enabled = false;
                txtChampigon2.Text = "0";
            }
        }

        private void chk_Polser2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Polser2.Checked == true)
            {
                txtPolser2.Enabled = true;
                txtPolser2.Text = "";
                txtPolser2.Focus();
            }
            else
            {
                txtPolser2.Enabled = false;
                txtPolser2.Text = "0";
            }
        }

        private void chk_Ost2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Ost2.Checked == true)
            {
                txtOst2.Enabled = true;
                txtOst2.Text = "";
                txtOst2.Focus();
            }
            else
            {
                txtOst2.Enabled = false;
                txtOst2.Text = "0";
            }
        }

        private void chk_Champignon3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Champignon3.Checked == true)
            {
                txtChampigon3.Enabled = true;
                txtChampigon3.Text = "";
                txtChampigon3.Focus();
            }
            else
            {
                txtChampigon3.Enabled = false;
                txtChampigon3.Text = "0";
            }
        }

        private void chk_Polser3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Polser3.Checked == true)
            {
                txtPolser3.Enabled = true;
                txtPolser3.Text = "";
                txtPolser3.Focus();
            }
            else
            {
                txtPolser3.Enabled = false;
                txtPolser3.Text = "0";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbPayMentMetode.items.Add();
        }

        private void chk_Ost3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Ost3.Checked == true)
            {
                txtOst3.Enabled = true;
                txtOst3.Text = "";
                txtOst3.Focus();
            }
            else
            {
                txtOst3.Enabled = false;
                txtOst3.Text = "0";
            }
        }
    }
}
