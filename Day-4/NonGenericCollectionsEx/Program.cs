using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollectionsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(10);
            al.Add(20);
            al.Add("Hello");
            al.Add(30.5);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Hashtable ht = new Hashtable();

            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, 333);
            ht.Add(4, 4.5);

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Stack st = new Stack();

            st.Push(1);
            st.Push(2);
            st.Pop();
            st.Push(3);
            Console.WriteLine(st.Peek());

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }
    }
}
