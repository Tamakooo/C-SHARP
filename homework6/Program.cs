internal class Program
    {
        static void Main(string[] args)
        {
            OrderService order = new OrderService();
            bool judge = true;
            while (judge)
            {
                Console.WriteLine("Enter : 1->add order ; 2->remove order ; 3->search order ; 4->show all orders ; 5->export; 6->import; 7->exit");
                string c = Console.ReadLine();
                switch (c)
                {
                    case "1": order.AddOrder(); break;
                    case "2": order.RemoveOrder(); break;
                    case "3": order.SearchOrder(2); break;
                    case "4": order.ShowOrder(); break;
                    case "5": order.export(); break;
                    case "6": order.import(); break;
                    case "7": judge = false; break;
                    default: Console.WriteLine("Enter error."); break;
                }
            }
        }
    }
