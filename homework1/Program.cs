static void Main(string[] args)
        {
            string s;
            double a;
            double b;
            int c;
            Console.WriteLine("请输入第一个数字");
            s = Console.ReadLine();
            a = Double.Parse(s);
            Console.WriteLine("请输入第二个数字");
            s = Console.ReadLine();
            b = Double.Parse(s);
            Console.WriteLine("请选择要进行的运算");
            Console.WriteLine("1.加法");
            Console.WriteLine("2.减法");
            Console.WriteLine("3.乘法");
            Console.WriteLine("4.除法");
            s = Console.ReadLine();
            c =Int32.Parse(s);
            switch (c)
            {
                case 1: Console.WriteLine(a+b);break;
                case 2: Console.WriteLine(a-b); break;
                case 3: Console.WriteLine(a*b); break;
                case 4: Console.WriteLine(a/b); break;

            }

        }
