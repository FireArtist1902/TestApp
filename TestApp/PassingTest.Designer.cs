namespace TestApp
{
    partial class PassingTest
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
            TaskLb = new Label();
            AnsCB = new CheckedListBox();
            Scores = new Label();
            AnswerBtn = new Button();
            ListAns = new ListBox();
            SuspendLayout();
            // 
            // TaskLb
            // 
            TaskLb.AutoSize = true;
            TaskLb.Location = new Point(12, 9);
            TaskLb.Name = "TaskLb";
            TaskLb.Size = new Size(50, 20);
            TaskLb.TabIndex = 0;
            TaskLb.Text = "label1";
            // 
            // AnsCB
            // 
            AnsCB.FormattingEnabled = true;
            AnsCB.Location = new Point(12, 97);
            AnsCB.Name = "AnsCB";
            AnsCB.Size = new Size(150, 114);
            AnsCB.TabIndex = 2;
            // 
            // Scores
            // 
            Scores.AutoSize = true;
            Scores.Location = new Point(183, 121);
            Scores.Name = "Scores";
            Scores.Size = new Size(17, 20);
            Scores.TabIndex = 3;
            Scores.Text = "0";
            // 
            // AnswerBtn
            // 
            AnswerBtn.Location = new Point(183, 153);
            AnswerBtn.Name = "AnswerBtn";
            AnswerBtn.Size = new Size(94, 29);
            AnswerBtn.TabIndex = 4;
            AnswerBtn.Text = "Відповісти";
            AnswerBtn.UseVisualStyleBackColor = true;
            AnswerBtn.Click += AnswerBtn_Click;
            // 
            // ListAns
            // 
            ListAns.FormattingEnabled = true;
            ListAns.ItemHeight = 20;
            ListAns.Location = new Point(12, 97);
            ListAns.Name = "ListAns";
            ListAns.Size = new Size(150, 104);
            ListAns.TabIndex = 5;
            // 
            // PassingTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(625, 333);
            Controls.Add(ListAns);
            Controls.Add(AnswerBtn);
            Controls.Add(Scores);
            Controls.Add(AnsCB);
            Controls.Add(TaskLb);
            Name = "PassingTest";
            Text = "PassingTest";
            Load += PassingTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TaskLb;
        private CheckedListBox AnsCB;
        private Label Scores;
        private Button AnswerBtn;
        private ListBox ListAns;
    }
}