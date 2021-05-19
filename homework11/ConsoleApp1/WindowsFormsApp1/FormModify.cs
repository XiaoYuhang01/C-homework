using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;

namespace WindowsFormsApp1
{
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            switch (comboBoxModify.SelectedItem.ToString())
            {
                case "客户":
                    foreach(Order order in MainForm.orderService.OrderList)
                    {
                        if(order.client.CustomerName == textBoxNeedModify.Text)
                        {
                            order.client.CustomerName = textBoxResult.Text;
                        }
                    }
                    break;

                case "客户电话":
                    foreach (Order order in MainForm.orderService.OrderList)
                    {
                        if (order.client.PhoneNumber == textBoxNeedModify.Text)
                        {
                            order.client.PhoneNumber = textBoxResult.Text;
                        }
                    }
                    break;

                case "客户地址":
                    foreach (Order order in MainForm.orderService.OrderList)
                    {
                        if (order.client.Address == textBoxNeedModify.Text)
                        {
                            order.client.Address = textBoxResult.Text;
                        }
                    }
                    break;
            }

            Close();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
