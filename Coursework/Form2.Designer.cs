namespace Coursework
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            buttonNext = new Button();
            buttonPrev = new Button();
            pictureBoxStack = new PictureBox();
            currElement = new Label();
            pictureBoxResult = new PictureBox();
            currPage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).BeginInit();
            SuspendLayout();
            // 
            // expression
            // 
            expression.AutoSize = true;
            expression.Location = new Point(23, 19);
            expression.Name = "expression";
            expression.Size = new Size(326, 41);
            expression.TabIndex = 0;
            expression.Text = "Исходное выражение:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 129);
            label2.Name = "label2";
            label2.Size = new Size(92, 41);
            label2.TabIndex = 1;
            label2.Text = "stack:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 286);
            label3.Name = "label3";
            label3.Size = new Size(98, 41);
            label3.TabIndex = 2;
            label3.Text = "result:";
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(496, 447);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(194, 53);
            buttonNext.TabIndex = 3;
            buttonNext.Text = "След. стр.";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(155, 447);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(194, 53);
            buttonPrev.TabIndex = 4;
            buttonPrev.Text = "Пред. стр.";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // pictureBoxStack
            // 
            pictureBoxStack.Location = new Point(134, 129);
            pictureBoxStack.Name = "pictureBoxStack";
            pictureBoxStack.Size = new Size(698, 133);
            pictureBoxStack.TabIndex = 5;
            pictureBoxStack.TabStop = false;
            pictureBoxStack.Click += pictureBoxStack_Click;
            // 
            // currElement
            // 
            currElement.AutoSize = true;
            currElement.Location = new Point(23, 68);
            currElement.Name = "currElement";
            currElement.Size = new Size(266, 41);
            currElement.TabIndex = 7;
            currElement.Text = "Текущий элемент:";
            // 
            // pictureBoxResult
            // 
            pictureBoxResult.Location = new Point(134, 286);
            pictureBoxResult.Name = "pictureBoxResult";
            pictureBoxResult.Size = new Size(698, 133);
            pictureBoxResult.TabIndex = 8;
            pictureBoxResult.TabStop = false;
            // 
            // currPage
            // 
            currPage.AutoSize = true;
            currPage.Location = new Point(380, 453);
            currPage.Name = "currPage";
            currPage.Size = new Size(87, 41);
            currPage.TabIndex = 9;
            currPage.Text = "[стр.]";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 512);
            Controls.Add(currPage);
            Controls.Add(pictureBoxResult);
            Controls.Add(currElement);
            Controls.Add(pictureBoxStack);
            Controls.Add(buttonPrev);
            Controls.Add(buttonNext);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(expression);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Form2";
            Text = "Решение преобразования в постфиксную форму";
            ((System.ComponentModel.ISupportInitialize)pictureBoxStack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label expression;
        private Label label2;
        private Label label3;
        private Button buttonNext;
        private Button buttonPrev;
        private PictureBox pictureBoxStack;
        private Label currElement;
        private PictureBox pictureBoxResult;
        private Label currPage;
    }
}