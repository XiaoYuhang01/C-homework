using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService TestOrder = new OrderService();

        [TestInitialize()]
        public void Initialize()
        {
            List<string> Cargo = new List<string>() { "吉米诺维奇数学分析", "圣经选读" };
            List<int> Number = new List<int>() { 1, 1 };
            List<double> Price = new List<double>() { 50, 40 };
            TestOrder.AddOrder(1, "李奇伟", "武汉大学", "12345678900", Cargo, Number, Price);
        }
        /*[TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }*/

        /*[TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }*/

        /*[TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }*/

        [TestMethod()]
        public void AddOrderTest()
        {
            List<string> Cargo = new List<string>() { "吉米诺维奇数学分析", "圣经选读" };
            List<int> Number = new List<int>() { 1, 1 };
            List<double> Price = new List<double>() { 50, 40 };
            TestOrder.AddOrder(2, "丛兴柏", "武汉大学", "12345678901", Cargo, Number, Price);

            Assert.IsTrue(TestOrder.OrderList.Count() == 2);
        }

        [TestMethod()]
        public void SearchByNumberTest()
        {
            Assert.IsTrue(TestOrder.SearchByNumber(1) != null);
        }

        [TestMethod()]
        public void SearchByCargoTest()
        {
            Assert.IsTrue(TestOrder.SearchByCargo("吉米诺维奇数学分析") != null);
        }

        [TestMethod()]
        public void SearchByClientTest()
        {
            Assert.IsTrue(TestOrder.SearchByClient("李奇伟") != null);
        }

        [TestMethod()]
        public void SearchMorethanAmountTest()
        {
            Assert.IsTrue(TestOrder.SearchMorethanAmount(80) != null);
        }

        [TestMethod()]
        public void SearchLessthanAmountTest()
        {
            Assert.IsTrue(TestOrder.SearchLessthanAmount(100) != null);
        }

        /*[TestMethod()]
        public void SearchTest()
        {
            Assert.Fail();
        }*/

        [TestMethod()]
        public void DeletOrderTest()
        {
            TestOrder.DeletOrder(1);
            Assert.IsTrue(TestOrder.OrderList.Count() == 0);
        }

        /*[TestMethod()]
        public void ModifyOrderTest()
        {
            Assert.Fail();
        }*/
    }
}