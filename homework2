static void Main(string[] args)
        {
            string s;
            Console.WriteLine("输入指定数据");
            s = Console.ReadLine();
            int num = Int32.Parse(s);
            if (num <= 1)
                Console.WriteLine("输入的数据没有素数因子");
            else
            {
                {
                    Console.WriteLine("数据的素数因子为：");
                    for (int i = 2; i <= num; i++)
                    {
                        //i为num的因数且i为质数，则输出i。
                        if (num % i == 0 && IsPrimeNum(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
           bool IsPrimeNum(int number)
            {
                int i;
                int j;
                j = 0;
                for (i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                        j += 1;
                }
                if (j == 1)
                    return true;
                else
                    return false;
            }

        }
