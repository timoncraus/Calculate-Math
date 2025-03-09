 namespace Coursework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            postfix = new Label();
            label2 = new Label();
            output = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(postfix);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(output);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(30, 30);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(1038, 573);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(55, 480);
            button2.Name = "button2";
            button2.Size = new Size(905, 53);
            button2.TabIndex = 6;
            button2.Text = "Открыть решение вычисления";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(55, 308);
            button1.Name = "button1";
            button1.Size = new Size(905, 53);
            button1.TabIndex = 5;
            button1.Text = "Открыть решение преобразования в постфиксную форму";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // postfix
            // 
            postfix.AutoSize = true;
            postfix.Location = new Point(55, 238);
            postfix.Name = "postfix";
            postfix.Size = new Size(374, 41);
            postfix.TabIndex = 4;
            postfix.Text = "Постфиксное выражение:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 57);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(542, 41);
            label2.TabIndex = 3;
            label2.Text = "Введите арифметическое выражение:";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(55, 402);
            output.Margin = new Padding(6, 0, 6, 0);
            output.Name = "output";
            output.Size = new Size(355, 41);
            output.TabIndex = 2;
            output.Text = "Вычисленное значение: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 149);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(905, 47);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 631);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Калькулятор арифметического выражения";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;  
        private Label output;
        private TextBox textBox1;
        private Label label2;
        private Label postfix;
        private Button button1;
        private Button button2;
    }
}
