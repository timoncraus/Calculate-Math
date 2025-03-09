using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Drawing.Imaging;

namespace Coursework
{
    public partial class Form1 : Form
    {
        const string allowedCharacters = "0123456789,.+-*/:^ ()";
        List<string>? elements;
        double answer;
        Form2 form2;
        Form3 form3;
        List<ConverterHistoryElement> converterHistory;
        List<CalculatorHistoryElement> calculatorHistory;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            converterHistory = new List<ConverterHistoryElement>();
            calculatorHistory = new List<CalculatorHistoryElement>();

            ConverterHistoryElement.expression = textBox1.Text;
            elements = new List<string>();
            try
            {
                elements = Converter.InfixToPostfix(textBox1.Text, converterHistory);
                postfix.Text = "Постфиксное выражение: " + string.Join(" ", elements.ToArray());
            }
            catch (Exception exc)
            {
                postfix.Text = exc.Message.ToString();
            }

            
            CalculatorHistoryElement.postfix = string.Join(" ", elements.ToArray());
            try 
            {
                answer = Calculator.Calculate(elements, calculatorHistory);
                output.Text = "Вычисленное значение: " + answer.ToString();
            }
            catch (Exception exc)
            {
                output.Text = exc.Message.ToString();
            }

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            // Является разрешенным символом или Backspace
            if (!(allowedCharacters.Contains(c) || (int)c == 8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                form2 = new Form2(converterHistory);
                form2.Closed += form2.Form2_FormClosing;
                form2.Show();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                form3 = new Form3(calculatorHistory);
                form3.Closed += form3.Form3_FormClosing;
                form3.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            
        }
    }
}