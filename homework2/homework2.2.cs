static void Main(string[] args)
        {
            string s;
            int length;
            Console.WriteLine("请输入数组的元素个数");
            s = Console.ReadLine();
            length = Int32.Parse(s);
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"输入第{i + 1}个数组元素");
                array[i] = Int32.Parse(Console.ReadLine());
            }
            int max, min, average, sum;
            CalcArray(array, out max, out min, out average, out sum);
            Console.WriteLine($"数组的最大值为{max}");
            Console.WriteLine($"数组的最小值为{min}");
            Console.WriteLine($"数组的平均值为{average}");
            Console.WriteLine($"所有数组元素的和为{sum}");
        }

           public static void CalcArray(int[] array, out int max, out int min, out int average, out int sum)
           {
                max = min = array[0];
                sum = 0;
                for(int n=0; n<=array.Length-1;n++)
                {
                    if (array[n]> max)
                    {
                        max = array[n];
                    }
                    if (array[n] < min)
                    {
                        min = array[n];
                    }
                    sum += array[n];
                }
                average = sum / array.Length;
           }
