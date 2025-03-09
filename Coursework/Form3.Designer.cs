namespace Coursework
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            expression = new Label();
            currElement = new Label();
            label2 = new Label();
            pictureBoxStack = new PictureBox();
            currPage = new Label();
            buttonPrev = new Button();
            buttonNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStack).BeginInit();
            SuspendLayout();
            // 
            // expression
            // 
            expression.AutoSize = true;
            expression.Location = new Point(25, 21);
            expression.Name = "expression";
            expression.Size = new Size(326, 41);
            expression.TabIndex = 1;
            expression.Text = "Исходное выражение:";
            // 
            // currElement
            // 
            currElement.AutoSize = true;
            currElement.Location = new Point(25, 75);
            currElement.Name = "currElement";
            currElement.Size = new Size(266, 41);
            currElement.TabIndex = 8;
            currElement.Text = "Текущий элемент:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 142);
            label2.Name = "label2";
            label2.Size = new Size(92, 41);
            label2.TabIndex = 9;
            label2.Text = "stack:";
            // 
            // pictureBoxStack
            // 
            pictureBoxStack.Location = new Point(150, 142);
            pictureBoxStack.Name = "pictureBoxStack";
            pictureBoxStack.Size = new Size(698, 133);
            pictureBoxStack.TabIndex = 10;
            pictureBoxStack.TabStop = false;
            // 
            // currPage
            // 
            currPage.AutoSize = true;
            currPage.Location = new Point(431, 383);
            currPage.Name = "currPage";
            currPage.Size = new Size(87, 41);
            currPage.TabIndex = 13;
            currPage.Text = "[стр.]";
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(206, 377);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(194, 53);
            buttonPrev.TabIndex = 12;
            buttonPrev.Text = "Пред. стр.";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click_1;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(547, 377);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(194, 53);
            buttonNext.TabIndex = 11;
            buttonNext.Text = "След. стр.";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 442);
            Controls.Add(currPage);
            Controls.Add(buttonPrev);
            Controls.Add(buttonNext);
            Controls.Add(pictureBoxStack);
            Controls.Add(label2);
            Controls.Add(currElement);
            Controls.Add(expression);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Form3";
            Text = "Решение вычисления";
            ((System.ComponentModel.ISupportInitialize)pictureBoxStack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label expression;
        private Label currElement;
        private Label label2;
        private PictureBox pictureBoxStack;
        private Label currPage;
        private Button buttonPrev;
        private Button buttonNext;
    }
}