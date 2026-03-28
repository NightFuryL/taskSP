namespace TaskWinForms
{
    partial class Task_123
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
            txtInterval = new TextBox();
            label1 = new Label();
            btnStart = new Button();
            txtInfo = new TextBox();
            btnKill = new Button();
            btnInfo = new Button();
            btnLoad = new Button();
            listBox1 = new ListBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtInterval
            // 
            txtInterval.Location = new Point(12, 207);
            txtInterval.Name = "txtInterval";
            txtInterval.Size = new Size(776, 27);
            txtInterval.TabIndex = 18;
            txtInterval.Text = "Interval: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 184);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 17;
            label1.Text = "Interval";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 152);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(776, 29);
            btnStart.TabIndex = 16;
            btnStart.Text = "Start ( interval )";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(12, 240);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(776, 91);
            txtInfo.TabIndex = 15;
            txtInfo.Text = "Info: ";
            // 
            // btnKill
            // 
            btnKill.Location = new Point(12, 117);
            btnKill.Name = "btnKill";
            btnKill.Size = new Size(776, 29);
            btnKill.TabIndex = 14;
            btnKill.Text = "Kill";
            btnKill.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(12, 82);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(776, 29);
            btnInfo.TabIndex = 13;
            btnInfo.Text = "Info";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 47);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(776, 29);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 337);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 244);
            listBox1.TabIndex = 11;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(776, 29);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Task_123
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 590);
            Controls.Add(btnBack);
            Controls.Add(txtInterval);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(txtInfo);
            Controls.Add(btnKill);
            Controls.Add(btnInfo);
            Controls.Add(btnLoad);
            Controls.Add(listBox1);
            Name = "Task_123";
            Text = "Task_123";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInterval;
        private Label label1;
        private Button btnStart;
        private TextBox txtInfo;
        private Button btnKill;
        private Button btnInfo;
        private Button btnLoad;
        private ListBox listBox1;
        private Button btnBack;
    }
}