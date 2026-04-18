namespace WinFormsTask
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
            txtBoxPath = new TextBox();
            txtBoxExt = new TextBox();
            txtBoxLog = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // txtBoxPath
            // 
            txtBoxPath.Location = new Point(90, 12);
            txtBoxPath.Name = "txtBoxPath";
            txtBoxPath.Size = new Size(698, 27);
            txtBoxPath.TabIndex = 0;
            // 
            // txtBoxExt
            // 
            txtBoxExt.Location = new Point(90, 45);
            txtBoxExt.Name = "txtBoxExt";
            txtBoxExt.Size = new Size(698, 27);
            txtBoxExt.TabIndex = 1;
            // 
            // txtBoxLog
            // 
            txtBoxLog.Location = new Point(12, 112);
            txtBoxLog.Multiline = true;
            txtBoxLog.Name = "txtBoxLog";
            txtBoxLog.ReadOnly = true;
            txtBoxLog.ScrollBars = ScrollBars.Vertical;
            txtBoxLog.Size = new Size(776, 326);
            txtBoxLog.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 3;
            label1.Text = "Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Extension";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 78);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(776, 29);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxLog);
            Controls.Add(txtBoxExt);
            Controls.Add(txtBoxPath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPath;
        private TextBox txtBoxExt;
        private TextBox txtBoxLog;
        private Label label1;
        private Label label2;
        private Button btnStart;
    }
}
