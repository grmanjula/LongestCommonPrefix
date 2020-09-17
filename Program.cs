using System;

namespace LongestCommonPrefix
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Common prefix is");
             returnPrefix();
        }

        public static void returnPrefix()
        {
           String[] InputStrngs = new String[3] { "Flower", "Flow", "Flowing" };
            var prefix = InputStrngs[0];
            for(int i =1; i< InputStrngs.Length; i++)
            {
                while(InputStrngs[i].IndexOf(prefix)!=0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            Console.WriteLine( prefix);
            
        }
    }
}
