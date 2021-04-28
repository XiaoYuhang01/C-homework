using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using ConsoleApp1;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public static OrderService orderService = new OrderService();
        
        public MainForm()
        {
            InitializeComponent();
            labelNotice.Text = "";
            bindingSourceOrder.DataSource = orderService.OrderList;
            List<string> cargo = new List<string>() { "吉米诺维奇数学分析", "Oxygen Not Include" };
            List<int> number = new List<int>() { 1, 1 };
            List<double> price = new List<double>() { 40.5, 59.5 };
            orderService.AddOrder(1, "李奇伟", "武汉大学", "1234", cargo, number, price);
            orderService.AddOrder(2, "李奇伟", "武汉大学", "1234", cargo, number, price);
            orderService.AddOrder(3, "杜特", "武汉大学", "1234", cargo, number, price);
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            switch (comboBoxQuery.SelectedItem.ToString())
            {
                case "订单号":
                    bindingSourceOrder.DataSource = orderService.OrderList.Where(order => order.orderNumber == Int32.Parse(textBoxQuery.Text));
                    break;
                case "客户":
                    bindingSourceOrder.DataSource = orderService.OrderList.Where(order => order.client.CustomerName == textBoxQuery.Text);
                    break;
                case "货物名":
                    bindingSourceOrder.DataSource = orderService.OrderList.Where(order => order.Search(textBoxQuery.Text) ==true);
                    break;
                case "大于指定金额":
                    bindingSourceOrder.DataSource = orderService.OrderList.Where(order => order.orderAmount > Double.Parse(textBoxQuery.Text));
                    break;
                case "小于指定金额":
                    bindingSourceOrder.DataSource = orderService.OrderList.Where(order => order.orderNumber < Double.Parse(textBoxQuery.Text));
                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd formadd = new FormAdd();
            formadd.ShowDialog();
            labelNotice.Text = "添加成功";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (Order a in orderService.OrderList)
            {
                if (a.orderNumber == Int32.Parse(this.textBoxQuery.Text)) { orderService.OrderList.Remove(a); return; }
            }
            labelNotice.Text = "删除成功";
            bindingSourceOrder.ResetBindings(false);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog ExportOrder = new SaveFileDialog();
            XmlSerializer OrderXml = new XmlSerializer(typeof(List<Order>));
            
            if(ExportOrder.ShowDialog() == DialogResult.OK)
            {
                using(FileStream order = new FileStream(ExportOrder.FileName, FileMode.Create))
                {
                    OrderXml.Serialize(order, orderService.OrderList);
                }
            }
            labelNotice.Text = "导出成功";
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImportOrder = new OpenFileDialog();
            XmlSerializer OrderXml = new XmlSerializer(typeof(List<Order>));

            if(ImportOrder.ShowDialog() == DialogResult.OK)
            {
                using (FileStream order = new FileStream(ImportOrder.FileName, FileMode.Open))
                {
                    bindingSourceOrder.DataSource = (List<Order>)OrderXml.Deserialize(order);
                }
            }
            labelNotice.Text = "导入成功";
            bindingSourceOrder.ResetBindings(false);
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            ModifyForm modifyForm = new ModifyForm();
            modifyForm.ShowDialog();
            labelNotice.Text = "修改成功";
        }

       
    }
}
