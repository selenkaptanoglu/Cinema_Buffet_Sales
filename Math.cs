using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Bufe_Sales
{
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shortSide, longSide, area, environment;
            shortSide=Convert.ToInt16(TxtSside.Text);
            longSide=Convert.ToInt16(TxtLSide.Text);
            area = longSide* shortSide;
            environment = 2 * (longSide + shortSide);
            LblArea.Text = area.ToString()+" m²";
            LblEnv.Text = environment.ToString()+" m";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int radius;
            decimal environment,area, pi = 3.14m;
            radius=Convert.ToInt16(TxtRadius.Text);
            area=radius*radius*pi;
            environment = 2 * pi * radius;
            label5.Text = area.ToString() + " m²";
            label6.Text = environment.ToString() + " m";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int exam1, exam2, exam3,average;
            exam1=Convert.ToInt16(TxtExam1.Text);
            exam2=Convert.ToInt16(TxtExam2.Text);
            exam3=Convert.ToInt16(TxtExam3.Text);
            average = (exam1 + exam2 + exam3) / 3;
            LblAverage.Text = average.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1,number2,number3,total,extraction,multiply;
            number1 = Convert.ToInt16(TxtNum1.Text);
            number2 = Convert.ToInt16(TxtNum2.Text);
            number3 = Convert.ToInt16(TxtNum3.Text);
            total = number1 + number2 + number3;
            extraction=number1-number2-number3;
            multiply=number1*number2*number3;
            LblTotal.Text= total.ToString();
            LblExt.Text= extraction.ToString();
            LblMult.Text= multiply.ToString();
        }
    }
}
