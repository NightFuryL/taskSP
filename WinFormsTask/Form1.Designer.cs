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
            btnStart = new Button();
            txtCoffee = new TextBox();
            txtEggs = new TextBox();
            txtBacon = new TextBox();
            txtToast = new TextBox();
            txtJuice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(14, 209);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(887, 31);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtCoffee
            // 
            txtCoffee.Location = new Point(72, 16);
            txtCoffee.Margin = new Padding(3, 4, 3, 4);
            txtCoffee.Name = "txtCoffee";
            txtCoffee.ReadOnly = true;
            txtCoffee.Size = new Size(828, 27);
            txtCoffee.TabIndex = 1;
            // 
            // txtEggs
            // 
            txtEggs.Location = new Point(72, 55);
            txtEggs.Margin = new Padding(3, 4, 3, 4);
            txtEggs.Name = "txtEggs";
            txtEggs.ReadOnly = true;
            txtEggs.Size = new Size(828, 27);
            txtEggs.TabIndex = 2;
            // 
            // txtBacon
            // 
            txtBacon.Location = new Point(72, 93);
            txtBacon.Margin = new Padding(3, 4, 3, 4);
            txtBacon.Name = "txtBacon";
            txtBacon.ReadOnly = true;
            txtBacon.Size = new Size(828, 27);
            txtBacon.TabIndex = 3;
            // 
            // txtToast
            // 
            txtToast.Location = new Point(72, 132);
            txtToast.Margin = new Padding(3, 4, 3, 4);
            txtToast.Name = "txtToast";
            txtToast.ReadOnly = true;
            txtToast.Size = new Size(828, 27);
            txtToast.TabIndex = 4;
            // 
            // txtJuice
            // 
            txtJuice.Location = new Point(72, 171);
            txtJuice.Margin = new Padding(3, 4, 3, 4);
            txtJuice.Name = "txtJuice";
            txtJuice.ReadOnly = true;
            txtJuice.Size = new Size(828, 27);
            txtJuice.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "Coffee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 65);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 7;
            label2.Text = "Eggs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 104);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Bacon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 143);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 9;
            label4.Text = "Toast";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 181);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 10;
            label5.Text = "Juice";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 252);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtJuice);
            Controls.Add(txtToast);
            Controls.Add(txtBacon);
            Controls.Add(txtEggs);
            Controls.Add(txtCoffee);
            Controls.Add(btnStart);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox txtCoffee;
        private TextBox txtEggs;
        private TextBox txtBacon;
        private TextBox txtToast;
        private TextBox txtJuice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
