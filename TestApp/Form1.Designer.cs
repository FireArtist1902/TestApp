namespace TestApp
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
            LoginTB = new TextBox();
            PasswordTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            StudentRB = new RadioButton();
            TeacherRB = new RadioButton();
            RegisterBtn = new Button();
            SuspendLayout();
            // 
            // LoginTB
            // 
            LoginTB.Location = new Point(83, 2);
            LoginTB.Name = "LoginTB";
            LoginTB.Size = new Size(125, 27);
            LoginTB.TabIndex = 0;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(83, 50);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(125, 27);
            PasswordTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 2;
            label1.Text = "Логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // StudentRB
            // 
            StudentRB.AutoSize = true;
            StudentRB.Location = new Point(21, 83);
            StudentRB.Name = "StudentRB";
            StudentRB.Size = new Size(83, 24);
            StudentRB.TabIndex = 4;
            StudentRB.TabStop = true;
            StudentRB.Text = "Я учень";
            StudentRB.UseVisualStyleBackColor = true;
            // 
            // TeacherRB
            // 
            TeacherRB.AutoSize = true;
            TeacherRB.Location = new Point(110, 83);
            TeacherRB.Name = "TeacherRB";
            TeacherRB.Size = new Size(98, 24);
            TeacherRB.TabIndex = 5;
            TeacherRB.TabStop = true;
            TeacherRB.Text = "Я вчитель";
            TeacherRB.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            RegisterBtn.AutoSize = true;
            RegisterBtn.Location = new Point(21, 113);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(183, 30);
            RegisterBtn.TabIndex = 6;
            RegisterBtn.Text = "Зареєструватись/увійти";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(320, 150);
            Controls.Add(RegisterBtn);
            Controls.Add(TeacherRB);
            Controls.Add(StudentRB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTB);
            Controls.Add(LoginTB);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реєстрація/вхід";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTB;
        private TextBox PasswordTB;
        private Label label1;
        private Label label2;
        private RadioButton StudentRB;
        private RadioButton TeacherRB;
        private Button RegisterBtn;
    }
}