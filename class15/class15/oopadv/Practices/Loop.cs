using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopadv.Practices
{
    public class Loop
    {
        List<string> stringNames = new List<string>() { "Bob", "Jordan", "Zoran", "Goran", "Horvat", "Jill" };
        public void LoopExample()
        {
            //BAD example
            for (int i = 0; i < stringNames.Count; i++)
            {
                if (stringNames[i].Length == stringNames.Count)
                {
                    Console.WriteLine(stringNames[i]);
                }
            }

            //GOOD example
            foreach (string name in stringNames)
            {
                if (name.Length == stringNames.Count)
                {
                    Console.WriteLine(name);
                }
            }
        }

    }
}
