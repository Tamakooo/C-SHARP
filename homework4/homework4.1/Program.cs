namespace homework4._1
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                AlarmClock clock = new AlarmClock(); //时钟
                clock.AlarmTime = new ClockTime(DateTime.Now.Hour,
                              DateTime.Now.Minute,
                              DateTime.Now.Second + 5);
                clock.AlarmEvent += PlayMusic;
                int sum = 0;
                clock.TickEvent += (c => Count(c, ref sum));
                new Thread(clock.Run).Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Count(AlarmClock sender, ref int sum)
        {
            ClockTime time = sender.CurrentTime;
            sum = sum + 1;
            Console.WriteLine($"Tick Event:{time.Hour}:{time.Minute}:{time.Second}, Sum= {sum}");
        }

        public static void PlayMusic(AlarmClock sender)
        {
            ClockTime time = sender.CurrentTime;
            Console.WriteLine($"Alarm Event: {time.Hour}:{time.Minute}:{time.Second}");
            Console.WriteLine("Playing music....");
        }
    }
}
