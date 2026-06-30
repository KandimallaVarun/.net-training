using NamespaceEx.TowerA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceEx
{
    namespace TowerA
    {
        public class SecondFloor
        {
            public static void RoomNo2()
            {
                Console.WriteLine("TowerA-SecondFloor-RoomNo2");
            }
        }
    }
    namespace TowerB
    {
        public class SecondFloor
        {
            public static void RoomNo2()
            {
                Console.WriteLine("TowerB-SecondFloor-RoomNo2");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //TowerA.SecondFloor.RoomNo2(); // Calls TowerA.SecondFloor.RoomNo2() due to using directive
            //TowerB.SecondFloor.RoomNo2(); // Calls TowerB.SecondFloor.RoomNo2() explicitly

            SecondFloor.RoomNo2();
        }
    }
}
