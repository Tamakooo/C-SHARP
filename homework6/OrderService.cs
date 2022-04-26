public class OrderService
    {
        private List<Order> orders = new List<Order>();
        public OrderService() { }

        public void export()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Order>));
            using (FileStream m=new FileStream("order.xml", FileMode.Create))
            {
                xml.Serialize(m, this.orders);
            }
            Console.WriteLine("Successfully!");
        }

        public void import()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Order>));
            using(FileStream m=new FileStream("order.xml", FileMode.Open))
            {
                List<Order> ord = (List<Order>)xml.Deserialize(m); 
                foreach(Order o in ord)
                {
                    Console.WriteLine("Id---Customer---Date---Money");
                    Console.WriteLine(" ", o.Id, " ", o.Customer, " ", o.Date, " ", o.Money);
                    o.ShowDetail();
                }
            }
        }

        public void ShowOrder()
        {
            foreach(Order m in this.orders)
            {
                Console.WriteLine("Id---Customer---Date---Money");
                Console.WriteLine(" ", m.Id, " ", m.Customer, " ", m.Date, " ", m.Money);
                m.ShowDetail();
            }
        }

        public void AddOrder()
        {
            Console.WriteLine("Enter the Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer:");
            string cus = Console.ReadLine();
            Console.WriteLine("Enter the Date:");
            string date = Console.ReadLine();
            Order order = new Order(id, cus, date);
            Console.WriteLine("Enter the order details:");
            bool same = false;
            foreach(Order m in this.orders)
            {
                if (m.Equals(order)) { same = true; }
            }
            if (same) { Console.WriteLine("The Id already exists!"); }
            else
            {
                Console.WriteLine("Enter the name of the object:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the number you will buy:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price of each object:");
                double price = Convert.ToDouble(Console.ReadLine());
                order.AddDetail(name, num, price);
            }
            orders.Add(order);
            order.AllPrice();
            Console.WriteLine("Added successfully!");
        }

        public void RemoveOrder()
        {
            Console.WriteLine("Enter the id or some details of the order you will remove:");
            int id = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            foreach (Order m in this.orders)
            {
                if (m.Id == id) { index = this.orders.IndexOf(m); }
            }
            Console.WriteLine("Enter 1 to remove order; enter 2 to remove order details.");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    this.orders.RemoveAt(index);
                    Console.WriteLine("Detele successfully!");
                    break;
                case 2:
                    this.orders[index].ShowDetail();
                    this.orders[index].RemoveDetail();
                    break;
                default: Console.WriteLine("Enter error."); break;
            }
        }

        public void SearchOrder(int i)
        {
            switch (i)
            {
                case 1:
                    int min, max;
                    Console.WriteLine("Enter the minimum sum you will search:");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the maximum sum you will search:");
                    max = Convert.ToInt32(Console.ReadLine());

                    var query1 = from s1 in orders
                                 where max > s1.Money
                                 orderby s1.Money
                                 select s1;
                    var query3 = from s3 in query1
                                 where s3.Money > min
                                 orderby s3.Money
                                 select s3;

                    List<Order> ord1 = query3.ToList();
                    foreach (Order m in ord1)
                    {
                        Console.WriteLine("Id---Customer---Date---Money");
                        Console.WriteLine(" ", m.Id, " ", m.Customer, " ", m.Date, " ", m.Money);
                        m.ShowDetail();
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the name of customer:");
                    string name1 = Console.ReadLine();

                    var query2 = from s2 in orders
                                 where s2.Customer == name1
                                 orderby s2.Money
                                 select s2;


                    List<Order> ord2 = query2.ToList();
                    foreach (Order m in ord2)
                    {
                        Console.WriteLine("Id---Customer---Date---Money");
                        Console.WriteLine(" ", m.Id, " ", m.Customer, " ", m.Date, " ", m.Money);
                        m.ShowDetail();
                    }
                    break;
                default: Console.WriteLine("Enter error."); break;
            }
        }
    }
