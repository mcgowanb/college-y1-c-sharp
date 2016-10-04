using System;


namespace ConsoleInput
{
    public static class Input
    {
        public static int GetIntFromConsole(String msg)
        {
            Console.Write("{0,-30}", msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double GetDoubleFromConsole(String msg)
        {
            Console.Write("{0,-30}", msg);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static String GetStringFromConsole(String msg)
        {
            Console.Write("{0,-30}", msg);
            return Console.ReadLine();
        }
        public static void LineBreak()
        {
            Console.WriteLine("=================================================");
        }
    }
}
