using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns1
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; // memento
        }
        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
    public class Demo
    {

        static void Main()
        {
            var j = new Journal();
            j.AddEntry("Today was a good day");
            j.AddEntry("Lakers beat the supersonic");
            WriteLine(j);
            ReadKey();
        }
    }
}

