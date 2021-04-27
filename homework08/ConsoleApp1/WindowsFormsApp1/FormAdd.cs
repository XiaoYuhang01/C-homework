using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAdd : Form
    {
        public int ordernumber { get => Int32.Parse(textBoxnum.Text); }
        public string customername { get => textBoxcus.ToString(); }
        public string address{get => textBoxadd.ToString(); }
        public string phone { get => textBoxpho.ToString(); }
        public List<string> cargo { get => new List<String>(){textBoxcar.ToString()}; }
        public List<double> price { get => new List<double>() { Double.Parse(textBoxpri.Text) }; }
        public List<int> number { get => new List<int>() { Int32.Parse(textBoxnum1.Text) }; }

    public FormAdd()
        {
            InitializeComponent();
        }

        public bool closeForm()
        {
            MainForm.orderService.AddOrder(ordernumber, customername, address, phone, cargo, number, price);
            Close();
            return true;
        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {
            closeForm();
        }

    }
}
