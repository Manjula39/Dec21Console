using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec21Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("D:\\mphasis\\Dec21\\first.txt"))
            {
                sw.WriteLine();
                sw.Close();// any junk in stream is thrown out 
                           //  sw = null;// making it as null no value
         }// here sw object released
           // sw.WriteLine();
            Directory.CreateDirectory("D:\\mphasis\\hello");
            Directory.Delete("D:\\mphasis\\hello");
            DateTime dt1 = Directory.GetCreationTime("D:\\mphasis\\hello");
            Console.WriteLine(dt1);
            for (int i = 0; i < 10; i++)
           // {// print hello 10 times
             //  Console.WriteLine("hello "+i);
            Console.WriteLine("");
            //}
           int[] nums = { 10, 20, 30, 40,100 };
            foreach (var item in nums)
            //{
           // Console.WriteLine(item);
             Console.WriteLine();
            //}
        }
    }
}
