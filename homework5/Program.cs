using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

  class MainClass {
    public static void Main() {
      try {
        Customer customer1 = new Customer(1, "Customer1");
        Customer customer2 = new Customer(2, "Customer2");

        Goods banana = new Goods(1, "banana", 1f);
        Goods peach = new Goods(2, "peach", 2f);
        Goods apple = new Goods(3, "apple", 3f);

        Order order1 = new Order(1, customer1);
        order1.AddDetails(new OrderDetail(apple, 8));
        order1.AddDetails(new OrderDetail(peach, 10));
        //order1.AddDetails(new OrderDetail(peach, 8));
        //order1.AddDetails(new OrderDetail(banana, 10));

        Order order2 = new Order(2, customer2);
        order2.AddDetails(new OrderDetail(peach, 10));
        order2.AddDetails(new OrderDetail(banana, 10));

        Order order3 = new Order(3, customer2);
        order3.AddDetails(new OrderDetail(peach, 100));

        OrderService orderService = new OrderService();
        orderService.AddOrder(order1);
        orderService.AddOrder(order2);
        orderService.AddOrder(order3);

        Console.WriteLine("\n GetById");
        Console.WriteLine(orderService.GetById(1));
        Console.WriteLine(orderService.GetById(5));

        Console.WriteLine("\nGetAllOrders");
        List<Order> orders = orderService.QueryAll();
        orders.ForEach(o => Console.WriteLine(o));

        Console.WriteLine("\nGetOrdersByCustomerName:'Customer2'");
        orders = orderService.QueryByCustomerName("Customer2");
        orders.ForEach(o => Console.WriteLine(o));

        Console.WriteLine("\nGetOrdersByGoodsName:'peach'");
        orders = orderService.QueryByGoodsName("peach");
        orders.ForEach(o => Console.WriteLine(o));

        Console.WriteLine("\nGetOrdersTotalAmount:1000");
        orders = orderService.QueryByTotalAmount(1000);
        orders.ForEach(o => Console.WriteLine(o));

        Console.WriteLine("\nRemove order(id=2) and qurey all");
        orderService.RemoveOrder(2);
        orderService.QueryAll().ForEach(
            o => Console.WriteLine(o));

        Console.WriteLine("\n order by Amount");
        orderService.Sort(
          (o1, o2) => o2.TotalAmount.CompareTo(o1.TotalAmount));
        orderService.QueryAll().ForEach(
            o => Console.WriteLine(o));

        Console.WriteLine("\n query by an lambda");
        orderService.Query(o => o.Customer.Name == "Customer2");

      }
      catch (Exception e) {
        Console.WriteLine(e.Message);
      }

    }
  }
}
