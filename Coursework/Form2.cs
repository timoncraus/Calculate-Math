using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form2 : Form
    {
        private string path = @"C:\converter";
        private int count = 1;
        private int page = 1;
        List<ConverterHistoryElement> convHistory;
        private string nameStack, nameResult;
        List<string> fileNames = new List<string>();

        public Form2(List<ConverterHistoryElement> converterHistory)
        {
            InitializeComponent();

            if (converterHistory == null)
            {
                throw new Exception("Слишком маленькое выражение");
            }

            convHistory = converterHistory;

            expression.Text = "Исходное выражение: " + ConverterHistoryElement.expression;

            foreach (ConverterHistoryElement histEl in converterHistory)
            {
                nameStack = path + count.ToString() + "stack.jpg";
                Painter.PaintList(Interpreter.ConvertStackToList(histEl.stack), histEl.actionStack, nameStack);
                fileNames.Add(nameStack);

                nameResult = path + count.ToString() + "result.jpg";
                Painter.PaintList(histEl.result, histEl.actionResult, nameResult);
                fileNames.Add(nameResult);

                count++;
            }

            this.refreshPage();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (page < convHistory.Count)
            {
                page++;
                this.refreshPage();
            }

        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                this.refreshPage();
            }

        }
        private void refreshPage()
        {
            currElement.Text = "Текущий элемент: " + convHistory[page - 1].element.ToString();
            currPage.Text = page.ToString() + " / " + convHistory.Count.ToString();
            getImage(pictureBoxStack, path + page.ToString() + "stack.jpg");
            getImage(pictureBoxResult, path + page.ToString() + "result.jpg");
        }

        private void getImage(PictureBox pictureBox, string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                pictureBox.Image = Image.FromStream(stream);
                stream.Dispose();
            }
        }

        public void Form2_FormClosing(object? sender, EventArgs e)
        {
            foreach (string fileName in fileNames)
            {
                File.Delete(fileName);
            }
        }

        private void pictureBoxStack_Click(object sender, EventArgs e)
        {

        }
    }
}
