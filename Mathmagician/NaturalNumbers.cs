using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class NaturalNumbers
    {
        protected int first; //data member

        public NaturalNumbers()
        {
            first = 1;
        }

        public virtual int GetNext(int x)
        {
            return x+1;
        }

        public int GetFirst()
        {
            return first;
        }

        public int[] GetSequence()
        {
            return GetSequence(10);
        }

        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }

        public string ToString(int[] array)
        {
            string output = String.Join(" ", array);
            /* For loop method
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array.Last())
                {
                    output += array[i].ToString();
                } else
                {
                    output += array[i].ToString() + " ";
                }
            }
                */
            
            return output;
        }
    }
}
