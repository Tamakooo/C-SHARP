using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService order=new OrderService();
            bool judge=true;
            while(judge)
            {
                Console.WriteLine("Enter : 1->add order ; 2->remove order ; 3->search order ; 4->show all orders ; 5->exit");
                string c=Console.ReadLine();
                switch(c)
                {
                    case "1":order.AddOrder();break;
                    case "2":order.RemoveOrder();break;
                    case "3":order.SearchOrder();break;
                    case "4":order.ShowOrder();break;
                    case "5":judge=false;break;
                    default:Console.WriteLine("Enter error.");break;
                }
            }
        }
    }

    class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public double Money { get; set; }

        public List<OrderDetails> orderDetails = new List<OrderDetails>();

        public Order(int id,string name,string customer)
        {
            this.Id = id;
            this.Name = name;
            this.Customer = customer;
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return this.Id == order.Id;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Id);
        }

        public void GetAllPrice()
        {
            double money = 0;
            foreach(OrderDetails order in this.orderDetails)
            {
                money += order.GetPrice();
            }
            this.Money = money;
        }

        public void AddOrderDetails(string name,int number,double price)
        {
            OrderDetails orderDetails = new OrderDetails(name, number, price);
            this.orderDetails.Add(orderDetails);
        }

        public void ShowOrderDetails()
        {
            foreach(OrderDetails m in this.orderDetails)
            {
                Console.WriteLine("Id--Name--Number--Price");
                Console.WriteLine(" ",this.orderDetails.IndexOf(m)," ", m.Name," ", m.Number," ", m.Price);
            }
        }

        public void RemoveOrderDetails()
        {
            Console.WriteLine("Enter the id of the order that you will delete:");
            int id = Convert.ToInt32(Console.ReadLine());
            this.orderDetails.RemoveAt(id);
            Console.WriteLine("Deleted successfully!");
        }
    }

    class OrderDetails
    {

        private string name;
        private int number;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public OrderDetails(string name, int number, double price)
        {
            this.name = name;
            this.number = number;
            this.price = price;
        }

        public double GetPrice()
        {
            return this.number * this.price;
        }
    }

    class OrderService
    {
        public List<Order> order = new List<Order>();

        public OrderService() { }

        public void ShowOrder()
        {
            foreach(Order m in this.order)
            {
                Console.WriteLine("Id--Name--Customer--Money");
                Console.WriteLine(" ", m.Id, " ", m.Name, " ", m.Customer, " ", m.Money);
                m.ShowOrderDetails();
            }
        }

        public void AddOrder()
        {
            Console.WriteLine("Enter the id of the order:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the customer:");
            string customer = Console.ReadLine();
            Console.WriteLine("Enter the name of the order:");
            string name = Console.ReadLine();
            Order ord = new Order(id, name, customer);
            Console.WriteLine("Enter the order:");
            bool judge = true;
            bool same = false;
            foreach(Order m in this.order)
            {
                if (m.Equals(order)) same = true;
            }
            if (same)
            {
                Console.WriteLine("The order already exists!");
            }
            else
            {
                while(judge && !same)
                {
                    Console.WriteLine("Enter the name of the object:");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Enter the number of the object:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the unit price:");
                    double price = Convert.ToDouble(Console.ReadLine());
                    ord.AddOrderDetails(name1, number, price);
                    Console.WriteLine("Continue Adding?");
                    string x = Console.ReadLine();
                    if (x == "Yes") { judge = false; }
                    else { continue; }
                }
                order.Add(ord);
                ord.GetAllPrice();
                Console.WriteLine("Added successfully!");
            }
        }

        public void RemoveOrder()
        {
            Console.WriteLine("Enter the id or some details of the order you will remove:");
            int id = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            foreach(Order m in this.order)
            {
                if (m.id == id) { index = this.order.IndexOf(m); }
            }
            Console.WriteLine("Enter 1 to remove order; enter 2 to remove order details.");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    this.order.RemoveAt(index);
                    Console.WriteLine("Detele successfully!");
                    break;
                case 2:
                    this.order[index].ShowOrderDetails();
                    this.order[index].RemoveOrderDetails();
                    break;
                default:Console.WriteLine("Enter error.");break;
            }
        }

        public void SearchOrder(int i)
        {
            switch(i)
            {
                case 1:
                    int min,max;
                    Console.WriteLine("Enter the minimum sum you will search:");
                    min=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the maximum sum you will search:");
                    max=Convert.ToInt32(Console.ReadLine());

                    var query1=from s1 in order
                        where max>s1.Price
                        orderby s1.Price
                        select s1;
                    var query3=from s3 in query1
                        where s3.Price>min
                        orderby s3.Price
                        select s3;
                    
                    List<Order> ord1=query3.ToList();
                    foreach(Order m in ord1)
                    {
                        Console.WriteLine("Id--Name--Customer--Money");
                        Console.WriteLine(" ", m.Id, " ", m.Name, " ", m.Customer, " ", m.Money);
                        m.ShowOrderDetails();
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the name of customer:");
                    string name1=Console.ReadLine();

                    var query2=from s2 in order
                        where s2.Customer==name1
                        orderby s2.Price
                        select s2
                    
                    List<Order> ord2=query2.ToList();
                    foreach(Order m in ord2)
                    {
                        Console.WriteLine("Id--Name--Customer--Money");
                        Console.WriteLine(" ", m.Id, " ", m.Name, " ", m.Customer, " ", m.Money);
                        m.ShowOrderDetails();
                    }
                    break;
                default:Console.WriteLine("Enter error.");break;
            }
        }
    }
}
