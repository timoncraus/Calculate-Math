using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form3 : Form
    {
        private string path = @"C:\calculator";
        private int count = 1;
        private int page = 1;
        List<CalculatorHistoryElement> calcHistory;
        private string nameStack, nameResult;
        List<string> fileNames = new List<string>();
        public Form3(List<CalculatorHistoryElement> calculatorHistory)
        {
            InitializeComponent();

            if (calculatorHistory == null)
            {
                throw new Exception("Слишком маленькое выражение");
            }

            calcHistory = calculatorHistory;

            expression.Text = "Исходное выражение: " + CalculatorHistoryElement.postfix;

            foreach (CalculatorHistoryElement histEl in calculatorHistory)
            {
                nameStack = path + count.ToString() + "stack.jpg";
                Painter.PaintList(Interpreter.ConvertDoubleStackToReversedList(histEl.stack), histEl.actionStack, nameStack);
                fileNames.Add(nameStack);

                count++;
            }

            this.refreshPage();
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            if (page < calcHistory.Count)
            {
                page++;
                this.refreshPage();
            }

        }

        private void buttonPrev_Click_1(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                this.refreshPage();
            }

        }
        private void refreshPage()
        {
            currElement.Text = "Текущий элемент: " + calcHistory[page - 1].element.ToString();
            currPage.Text = page.ToString() + " / " + calcHistory.Count.ToString();
            getImage(pictureBoxStack, path + page.ToString() + "stack.jpg");
        }

        private void getImage(PictureBox pictureBox, string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                pictureBox.Image = Image.FromStream(stream);
                stream.Dispose();
            }
        }

        public void Form3_FormClosing(object? sender, EventArgs e)
        {
            foreach (string fileName in fileNames)
            {
                File.Delete(fileName);
            }
        }
    }
}
