using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Coursework
{
    public static class Calculator
    {
        private static Stack<double>? stack;
        private static double num1, num2;
        private static CalculatorHistoryElement historyEl;
        private static Stack<double> stackClone;
        public static double Calculate(List<string> postfix, List<CalculatorHistoryElement> calculatorHistory)
        {
            stack = new Stack<double>();
            foreach (string element in postfix)
            {
                if (Converter.isOperator(element))
                {
                    try
                    {
                        AddHistoryElement(element, calculatorHistory, -2);

                        num1 = stack.Pop();
                        num2 = stack.Pop();
                        stack.Push(Converter.operators[element[0]](num2, num1));

                        AddHistoryElement(element, calculatorHistory, 1);
                    }
                    catch
                    {
                        throw new Exception("Слишком много операторов");
                    }
                }
                else
                {
                    stack.Push(Convert.ToDouble(element));

                    AddHistoryElement(element, calculatorHistory, 1);
                }
            }
            if (stack.Count != 1)
            {
                throw new Exception("Слишком много чисел");
            }
            AddHistoryElement("(ответ)", calculatorHistory, 0);

            return stack.Pop();
        }
        private static void AddHistoryElement(string element, List<CalculatorHistoryElement> converterHistory, int actionStack)
        {
            stackClone = Interpreter.CloneDoubleStack(stack);
            historyEl = new CalculatorHistoryElement(element, stackClone, actionStack);
            converterHistory.Add(historyEl);
        }
    }

    public struct CalculatorHistoryElement
    {
        public static string? postfix;
        public string element;
        public Stack<double> stack;
        public int actionStack;
        public CalculatorHistoryElement(string element, Stack<double> stack, int actionStack)
        {
            this.element = element;
            this.stack = stack;
            this.actionStack = actionStack;
        }
    }
}
