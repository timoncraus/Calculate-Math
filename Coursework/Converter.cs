using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Coursework
{
    public static class Converter
    {

        public static Dictionary<char, Func<double, double, double>> operators = new Dictionary<char, Func<double, double, double>>()
        {
            ['+'] = (double a, double b) => a + b,
            ['-'] = (double a, double b) => a - b,
            ['*'] = (double a, double b) => a * b,
            ['/'] = (double a, double b) => a / b,
            ['^'] = (double a, double b) => Math.Pow(a, b),
        };

        private static List<string>? inputList;
        private static Stack<string>? stack;
        private static List<string>? result;
        private static ConverterHistoryElement historyEl;
        private static int count;

        public static List<string> InfixToPostfix(string s, List<ConverterHistoryElement> converterHistory)
        {
            if (s.Length != 0 && s[0] == '-')
            {
                s = '0' + s;
            }
            inputList = SplitElementns(s.Replace('.', ',').Replace(':', '/').Replace("(-", "(0-") + " ");

            int bracketsCorrect = isValid(s);
            if(bracketsCorrect == 2) throw new Exception("Слишком много закрывающихся скобок");
            else if (bracketsCorrect == 1) throw new Exception("Слишком много открывающихся скобок");


            stack = new Stack<string>();
            result = new List<string>();

            foreach (string element in inputList)
            {
                if (element == "(")
                {
                    stack.Push(element);
                    
                    historyEl = new ConverterHistoryElement(element, Interpreter.CloneStack(stack), Interpreter.CloneList(result), 1, 0);
                    converterHistory.Add(historyEl);
                }
                else if (element == ")")
                {
                    historyEl = new ConverterHistoryElement(element, Interpreter.CloneStack(stack), Interpreter.CloneList(result), 0, 0);
                    count = 0;

                    while (stack.Count > 0 && stack.Peek() != "(")
                    {
                        result.Add(stack.Pop());
                        count++;
                    }
                    stack.Pop();

                    historyEl.result = Interpreter.CloneList(result);
                    historyEl.actionResult = count;
                    historyEl.actionStack = -count - 1;
                    converterHistory.Add(historyEl);
                }
                else if (!isOperator(element))
                {
                    result.Add(element);

                    historyEl = new ConverterHistoryElement(element, Interpreter.CloneStack(stack), Interpreter.CloneList(result), 0, 1);
                    converterHistory.Add(historyEl);
                }
                else
                {
                    historyEl = new ConverterHistoryElement(element, Interpreter.CloneStack(stack), Interpreter.CloneList(result), 0, 0);
                    count = 0;

                    while (stack.Count > 0 && (Precedence(element) < Precedence(stack.Peek()) ||
                        Precedence(element) == Precedence(stack.Peek()) &&
                        Associativity(element) == 'L'))
                    {
                        result.Add(stack.Pop());
                        count++;
                    }
                    if(count!=0)
                    {
                        historyEl.result = Interpreter.CloneList(result);
                        historyEl.actionResult = count;
                        historyEl.actionStack = -count;
                        converterHistory.Add(historyEl);
                    }

                    


                    stack.Push(element);

                    historyEl = new ConverterHistoryElement(element, Interpreter.CloneStack(stack), Interpreter.CloneList(result), 1, 0);
                    converterHistory.Add(historyEl);
                }
            }

            historyEl = new ConverterHistoryElement("(конец)", Interpreter.CloneStack(stack), Interpreter.CloneList(result), 0, 0);
            count = 0;

            while (stack.Count > 0)
            {
                result.Add(stack.Pop());
                count++;
            }

            if(count!=0)
            {
                historyEl.result = Interpreter.CloneList(result);
                historyEl.actionResult = count;
                historyEl.actionStack = -count;
                converterHistory.Add(historyEl);
            }

             

            historyEl = new ConverterHistoryElement("(ответ)", Interpreter.CloneStack(stack), Interpreter.CloneList(result), 0, 0);
            converterHistory.Add(historyEl);

            return result;
        }

        public static int isValid(string s)
        {
            var count = 0;
            foreach (var c in s)
            {
                if (c == '(')
                    count++;

                if (c == ')')
                {
                    if (count == 0) return 2;
                    count--;
                }
            }
            return count == 0? 0 : 1;
        }

        public static bool isOperator(string element)
        {
            return element.Length == 1 && operators.ContainsKey(element[0]);
        }

        private static List<string> SplitElementns(string s)
        {
            inputList = new List<string>();
            string subString = "";
            foreach (char c in s)
            {
                if (c >= '0' && c <= '9' || c == '.' || c == ',')
                {
                    subString += c;
                }
                else
                {
                    if (subString.Length > 0)
                    {
                        inputList.Add(subString);
                        subString = "";
                    }
                    if (operators.ContainsKey(c) || c == '(' || c == ')')
                    {
                        inputList.Add(c.ToString());
                    }
                }
            }
            return inputList;
        }

        private static int Precedence(string c)
        {
            if (c == "^")
                return 3;
            else if (c == "/" || c == "*")
                return 2;
            else if (c == "+" || c == "-")
                return 1;
            else
                return -1;
        }

        private static char Associativity(string c)
        {
            if (c == "^")
                return 'R';
            return 'L';
        }

    }

    public struct ConverterHistoryElement
    {
        public static string? expression;
        public string element;
        public Stack<string> stack;
        public List<string> result;
        public int actionStack;
        public int actionResult;
        public ConverterHistoryElement(string element, Stack<string> stack, List<string> result, int actionStack, int actionResult)
        {
            this.element = element;
            this.stack = stack;
            this.result = result;
            this.actionStack = actionStack;
            this.actionResult = actionResult;
        }
    }

}
