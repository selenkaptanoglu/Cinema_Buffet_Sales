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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cashTotal = 0; //Global area
        private void button1_Click(object sender, EventArgs e)
        {
            int corn, tea, coffee, ticket,total;
            corn=Convert.ToInt16(TxtCorn.Text);
            tea=Convert.ToInt16(TxtTea.Text);
            coffee=Convert.ToInt16(TxtCoffee.Text);
            ticket=Convert.ToInt16(TxtTicket.Text);
            total = corn * 4 + tea * 2 + coffee * 5 + ticket * 8;
            LblTotal.Text = total.ToString()+" $";
            cashTotal = cashTotal + total;
            LblCash.Text = cashTotal.ToString()+" $";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtTicket.Text = "";
            TxtTea.Text = "";
            TxtCoffee.Text = "";
            TxtCorn.Text = "";
            TxtCorn.Focus();
        }
    }
}
