namespace TestApp
{
    partial class AddForm
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
            Name = new TextBox();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Location = new Point(12, 12);
            Name.Name = "Name";
            Name.PlaceholderText = "Назва";
            Name.Size = new Size(125, 27);
            Name.TabIndex = 0;
            Name.Text = "AddForm";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(143, 12);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Додати";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 54);
            Controls.Add(AddBtn);
            Controls.Add(Name);
            Name.Text = "AddForm";
            FormClosing += AddForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name;
        private Button AddBtn;
    }
}