internal class OrderDetail
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

        public OrderDetail()
        {
            this.Name = string.Empty;
            this.Number = 0;
            this.Price = 0;
        }
        public OrderDetail(string name,int num,double price)
        {
            this.name = name;
            this.number = num;
            this.price = price;
        }

        public double GetPrice()
        {
            return this.number * this.price;
        }
    }
