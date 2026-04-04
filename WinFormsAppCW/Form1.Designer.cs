namespace WinFormsAppCW
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
            btnStartCPU = new Button();
            btnStartIO = new Button();
            progressBar1 = new ProgressBar();
            txtCPUResult = new TextBox();
            txtIOResult = new TextBox();
            SuspendLayout();
            // 
            // btnStartCPU
            // 
            btnStartCPU.Location = new Point(12, 70);
            btnStartCPU.Name = "btnStartCPU";
            btnStartCPU.Size = new Size(776, 23);
            btnStartCPU.TabIndex = 0;
            btnStartCPU.Text = "StartCPUBound";
            btnStartCPU.UseVisualStyleBackColor = true;
            btnStartCPU.Click += btnStartCPU_Click;
            // 
            // btnStartIO
            // 
            btnStartIO.Location = new Point(12, 128);
            btnStartIO.Name = "btnStartIO";
            btnStartIO.Size = new Size(776, 23);
            btnStartIO.TabIndex = 1;
            btnStartIO.Text = "StartIOBound";
            btnStartIO.UseVisualStyleBackColor = true;
            btnStartIO.Click += btnStartIO_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 2;
            // 
            // txtCPUResult
            // 
            txtCPUResult.Location = new Point(12, 41);
            txtCPUResult.Name = "txtCPUResult";
            txtCPUResult.Size = new Size(776, 23);
            txtCPUResult.TabIndex = 3;
            // 
            // txtIOResult
            // 
            txtIOResult.Location = new Point(12, 99);
            txtIOResult.Name = "txtIOResult";
            txtIOResult.Size = new Size(776, 23);
            txtIOResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 242);
            Controls.Add(txtIOResult);
            Controls.Add(txtCPUResult);
            Controls.Add(progressBar1);
            Controls.Add(btnStartIO);
            Controls.Add(btnStartCPU);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartCPU;
        private Button btnStartIO;
        private ProgressBar progressBar1;
        private TextBox txtCPUResult;
        private TextBox txtIOResult;
    }
}
