internal class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public double Money { get; set; }
        public string Date { get; set; }

        private List<OrderDetail> orderDetails = new List<OrderDetail>();

        public Order()
        {
            this.Id = 0;
            this.Customer = string.Empty;
            this.Money = 0;
            this.Date = string.Empty;
        }
        public Order(int id,string cus,string date)
        {
            this.Id = id;
            this.Customer = cus;
            this.Date = date;
        }

        public int CompareTo(object obj)
        {
            Order order = obj as Order;
            return this.Id.CompareTo(order.Id);
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

        public void AllPrice()
        {
            double i = 0;
            foreach(OrderDetail m in this.orderDetails)
            {
                i = i + m.GetPrice();
            }
            this.Money = i;
        }

        public void AddDetail(string name,int num,double price)
        {
            OrderDetail detail = new OrderDetail(name, num, price);
            this.orderDetails.Add(detail);
        }

        public void RemoveDetail()
        {
            Console.WriteLine("Enter the Id that you will delete:");
            int det = Convert.ToInt32(Console.ReadLine());
            this.orderDetails.RemoveAt(det);
            Console.WriteLine("Deleted successfully!");
        }

        public void ShowDetail()
        {
            Console.WriteLine("Id---Name---Number---Price");
            foreach(OrderDetail m in this.orderDetails)
            {
                Console.WriteLine(" ", this.orderDetails.IndexOf(m), " ", m.Name, " ", m.Number, " ", m.Price);
            }
        }
    }
