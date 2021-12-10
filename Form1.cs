using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodResturantProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        //نمایش زمان در پایین صفحه
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        //دکمه کلیک غذا ها
        private void friesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (friesCb.Checked == true)
                friesTb.Enabled = true;
            else
            {
                friesTb.Enabled = false;
                friesTb.Text = "0";
            }
        }
        private void burgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (burgerCb.Checked == true)
                burgerTb.Enabled = true;
            else
            {
                burgerTb.Enabled = false;
                burgerTb.Text = "0";
            }
        }
        private void chickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (chickenCb.Checked == true)
                chickenTb.Enabled = true;
            else
            {
                chickenTb.Enabled = false;
                chickenTb.Text = "0";
            }
        }
        private void saladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (saladCb.Checked == true)
                saladTb.Enabled = true;
            else
            {
                saladTb.Enabled = false;
                saladTb.Text = "0";
            }
        }
        private void colaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (colaCb.Checked == true)
                colaTb.Enabled = true;
            else
            {
                colaTb.Enabled = false;
                colaTb.Text = "0";
            }
        }
        private void waterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (waterCb.Checked == true)
                waterTb.Enabled = true;
            else
            {
                waterTb.Enabled = false;
                waterTb.Text = "0";
            }
        }
        private void orangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (orangeCb.Checked == true)
                orangeTb.Enabled = true;
            else
            {
                orangeTb.Enabled = false;
                orangeTb.Text = "0";
            }
        }
        private void teaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (teaCb.Checked == true)
                teaTb.Enabled = true;
            else
            {
                teaTb.Enabled = false;
                teaTb.Text = "0";
            }
        }
        //خروج از برنامه
        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label13_Click(object sender, EventArgs e)
        {
        }
        //قیمت ها
        double _fries = 12000, _burger = 25000, _salad = 18000, _chicken = 52000, _cola = 6000, _orange = 10000, _water = 2000, _tea = 15000;
        //با دکمه ریسه امکان نوشتن در تکست باکس منع و مقدار پیش فرض 0 جایگزین می شود
        private void resetBtn_Click_1(object sender, EventArgs e)
        {
            friesCb.Checked = false;
            burgerCb.Checked = false;
            chickenCb.Checked = false;
            saladCb.Checked = false;
            colaCb.Checked = false;
            waterCb.Checked = false;
            orangeCb.Checked = false;
            teaCb.Checked = false;
        }
        //محاسبه قیمت با احتساب تعداد ان ها
        double _friestp, _burgertp, _saladtp, _chickentp, _colatp, _orangetp, _watertp, _teatp;
        double subTotal, tax, gradtotal;
        //کلیک ادد
        private void button1_Click(object sender, EventArgs e)
        {
            _friestp = _fries * Convert.ToDouble(friesTb.Text);
            _burgertp = _burger * Convert.ToDouble(burgerTb.Text);
            _saladtp = _salad * Convert.ToDouble(saladTb.Text);
            _chickentp = _chicken * Convert.ToDouble(chickenTb.Text);
            _colatp = _cola * Convert.ToDouble(colaTb.Text);
            _orangetp = _orange * Convert.ToDouble(orangeTb.Text);
            _watertp = _water * Convert.ToDouble(waterTb.Text);
            _teatp = _tea * Convert.ToDouble(teaTb.Text);
            //بروزرسانی فاکتور
            recieptTb.Clear();
            subTotal = 0;
            recieptTb.AppendText(Environment.NewLine);
            recieptTb.AppendText("\t\t\t\tREYHAN Resturant's Bill" + "   " + DateLbl.Text + Environment.NewLine);
            recieptTb.AppendText("\t\t\t\t***********************" + Environment.NewLine);
            if (friesCb.Checked == true)
            {
                recieptTb.AppendText("\t French Fries : " + _friestp + "Toman" + Environment.NewLine);
                subTotal = subTotal + _friestp;
                subtotalLbl.Text = "" + subTotal;
            }
            if (burgerCb.Checked == true)
            {
                recieptTb.AppendText("\t Burger : " + _burgertp + "Toman" + Environment.NewLine);
                subTotal = subTotal + _burgertp;
                subtotalLbl.Text = "" + subTotal;
            }
            if (chickenCb.Checked == true)
            {
                recieptTb.AppendText("\t Chicken : " + _chickentp + "Toman" + Environment.NewLine);
                subTotal = subTotal + _chickentp;
                subtotalLbl.Text = "" + subTotal;
            }
            if (saladCb.Checked == true)
            {
                recieptTb.AppendText("\t Salad : " + _saladtp + "Toman" + Environment.NewLine);
                subTotal = subTotal + _saladtp;
                subtotalLbl.Text = "" + subTotal;
            }
            if (colaCb.Checked == true)
            {
                recieptTb.AppendText("\t Cola : " + _colatp + "Toman" + Environment.NewLine);
                subTotal = subTotal + _colatp;
                subtotalLbl.Text = "" + subTotal;
            }
            if (waterCb.Checked == true)
            {
                recieptTb.AppendText("\t Water : " + _watertp + "Toman" + Environment.NewLine);
                subTotal = subTotal + _watertp;
                subtotalLbl.Text = "" + subTotal;
            }
            if (orangeCb.Checked == true)
            {
                recieptTb.AppendText("\t Orange Juice : " + _orangetp + "Toman" + Environment.NewLine);
                subTotal = subTotal + _orangetp;
                subtotalLbl.Text = "" + subTotal;
            }
            if (teaCb.Checked == true)
            {
                recieptTb.AppendText("\t Tea : " + _teatp + "Toman" + Environment.NewLine);
                subTotal = subTotal + _teatp;
                subtotalLbl.Text = "" + subTotal;
            }
            //مالیات
            tax = subTotal * 0.15;
            //محاسبه قیمت کل با مالیات
            gradtotal = subTotal + tax;
            taxLbl.Text = "Toman" + tax;
            gradtotalLbl.Text = "Toman" + gradtotal;
        }
        private void recieptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
