namespace TaskWinForms
{
    partial class Task_4
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
            btnNotepad = new Button();
            btnCalc = new Button();
            btnPaint = new Button();
            btnCustomFileDialog = new Button();
            btnCustomPath = new Button();
            txtPathFile = new TextBox();
            btnBack = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnNotepad
            // 
            btnNotepad.Location = new Point(12, 47);
            btnNotepad.Name = "btnNotepad";
            btnNotepad.Size = new Size(776, 29);
            btnNotepad.TabIndex = 0;
            btnNotepad.Text = "Notepad";
            btnNotepad.UseVisualStyleBackColor = true;
            btnNotepad.Click += btnNotepad_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(12, 82);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(776, 29);
            btnCalc.TabIndex = 1;
            btnCalc.Text = "Calc";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnPaint
            // 
            btnPaint.Location = new Point(12, 117);
            btnPaint.Name = "btnPaint";
            btnPaint.Size = new Size(776, 29);
            btnPaint.TabIndex = 2;
            btnPaint.Text = "Paint";
            btnPaint.UseVisualStyleBackColor = true;
            btnPaint.Click += btnPaint_Click;
            // 
            // btnCustomFileDialog
            // 
            btnCustomFileDialog.Location = new Point(12, 152);
            btnCustomFileDialog.Name = "btnCustomFileDialog";
            btnCustomFileDialog.Size = new Size(776, 29);
            btnCustomFileDialog.TabIndex = 3;
            btnCustomFileDialog.Text = "Custom (Open File Dialog)";
            btnCustomFileDialog.UseVisualStyleBackColor = true;
            btnCustomFileDialog.Click += btnCustomFileDialog_Click;
            // 
            // btnCustomPath
            // 
            btnCustomPath.Location = new Point(12, 187);
            btnCustomPath.Name = "btnCustomPath";
            btnCustomPath.Size = new Size(776, 29);
            btnCustomPath.TabIndex = 4;
            btnCustomPath.Text = "Custom (Path)";
            btnCustomPath.UseVisualStyleBackColor = true;
            btnCustomPath.Click += btnCustomPath_Click;
            // 
            // txtPathFile
            // 
            txtPathFile.Location = new Point(12, 220);
            txtPathFile.Name = "txtPathFile";
            txtPathFile.Size = new Size(776, 27);
            txtPathFile.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(776, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Task_4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 260);
            Controls.Add(btnBack);
            Controls.Add(txtPathFile);
            Controls.Add(btnCustomPath);
            Controls.Add(btnCustomFileDialog);
            Controls.Add(btnPaint);
            Controls.Add(btnCalc);
            Controls.Add(btnNotepad);
            Name = "Task_4";
            Text = "Task_4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNotepad;
        private Button btnCalc;
        private Button btnPaint;
        private Button btnCustomFileDialog;
        private Button btnCustomPath;
        private TextBox txtPathFile;
        private Button btnBack;
        private OpenFileDialog openFileDialog1;
    }
}