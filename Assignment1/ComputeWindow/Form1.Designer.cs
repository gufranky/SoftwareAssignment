namespace ComputeWindow
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 30);
            textBox1.TabIndex = 0;
            textBox1.Text = "数字1输入";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(495, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 30);
            textBox2.TabIndex = 1;
            textBox2.Text = "数字2输入";
            // 
            // button1
            // 
            button1.Location = new Point(276, 327);
            button1.Name = "button1";
            button1.Size = new Size(247, 76);
            button1.TabIndex = 2;
            button1.Text = "计算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(75, 159);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 28);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "+";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(225, 159);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(44, 28);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "-";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(495, 159);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(44, 28);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "*";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(650, 159);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(44, 28);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "/";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 280);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 7;
            label1.Text = "答案";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label1;
    }
}