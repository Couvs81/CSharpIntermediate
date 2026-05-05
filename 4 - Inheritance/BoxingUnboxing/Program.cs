using System.Collections;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();  // list of objects. not type safe
            list.Add(1);        // boxing happens (value)
            list.Add("Rich");   // boxing doesn't happen (class
            list.Add(DateTime.Today);   // boxing happens (struct)

            var number = (int) list[1];

            var anotherList = new List<int>();

        }
    }
}
