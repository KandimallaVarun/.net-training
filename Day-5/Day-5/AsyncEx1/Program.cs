using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncEx1
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            string res = await DownloadFile();
            await Task.Delay(2000);
            Console.WriteLine("Completed..."+res);
        }

        async static Task<string> DownloadFile()
        {
            await Task.Delay(5000);
            Console.WriteLine("File Downloaded");
            return "asd";
        }
    }
}
