using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public static class Interpreter
    {
        public static List<string> ConvertStackToList(Stack<string> stack)
        {
            List<string> list = new List<string>();
            foreach (string item in stack)
            {
                list.Add(item);
            }
            return list;
        }
        public static List<string> ConvertDoubleStackToReversedList(Stack<double> stackDouble)
        {
            List<string> list = new List<string>();
            foreach (double item in stackDouble)
            {
                list.Add(item.ToString());
            }
            list.Reverse();
            return list;
        }
        public static Stack<double> CloneDoubleStack(Stack<double> stack)
        {
            return new Stack<double>(new Stack<double>(stack));
        }

        public static Stack<string> CloneStack(Stack<string> stack)
        {
            return new Stack<string>(new Stack<string>(stack));
        }

        public static List<string> CloneList(List<string> list)
        {
            return new List<string>(new List<string>(list));
        }
    }
}
