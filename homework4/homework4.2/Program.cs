namespace homework4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(random.Next(1000));
            }

            intlist.ForEach(n => Console.Write(n + "\t"));

            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            intlist.ForEach(n => {
                min = (n < min) ? n : min;
                max = (n > max) ? n : max;
                sum += n;
            });
            Console.WriteLine();
            Console.WriteLine($"min={min},max={max},sum={sum}");
        }

    }
}
