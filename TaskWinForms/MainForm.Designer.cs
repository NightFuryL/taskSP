namespace TaskWinForms
{
    partial class MainForm
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
            btnTask123 = new Button();
            btnTask4 = new Button();
            SuspendLayout();
            // 
            // btnTask123
            // 
            btnTask123.Location = new Point(12, 12);
            btnTask123.Name = "btnTask123";
            btnTask123.Size = new Size(776, 158);
            btnTask123.TabIndex = 0;
            btnTask123.Text = "Exercise 1 2 3 ";
            btnTask123.UseVisualStyleBackColor = true;
            btnTask123.Click += btnTask123_Click;
            // 
            // btnTask4
            // 
            btnTask4.Location = new Point(12, 176);
            btnTask4.Name = "btnTask4";
            btnTask4.Size = new Size(776, 158);
            btnTask4.TabIndex = 1;
            btnTask4.Text = "Exercise 4";
            btnTask4.UseVisualStyleBackColor = true;
            btnTask4.Click += btnTask4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 346);
            Controls.Add(btnTask4);
            Controls.Add(btnTask123);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTask123;
        private Button btnTask4;
    }
}