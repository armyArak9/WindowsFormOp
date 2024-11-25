namespace WindowsFormOp
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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 44);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 50);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 44);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 117);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 44);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 42);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 44);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Location = new Point(726, 148);
            label1.Name = "label1";
            label1.Size = new Size(303, 182);
            label1.TabIndex = 5;
            label1.Text = "แสดงผลลัพท์";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(325, 39);
            button1.Name = "button1";
            button1.Size = new Size(164, 44);
            button1.TabIndex = 6;
            button1.Text = "คำนวณพื้นที่วงกลม";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 51);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 7;
            label2.Text = "รัศมี";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 61);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 8;
            label3.Text = "ความสูง";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 128);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 9;
            label4.Text = "ความยาวฐาน";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 49);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 10;
            label5.Text = "ความยาว";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(73, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 125);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่วงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MistyRose;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(73, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(513, 218);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGreen;
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(73, 402);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(513, 125);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวณพื้นที่รูปหกเหลี่ยม";
            // 
            // button2
            // 
            button2.Location = new Point(325, 83);
            button2.Name = "button2";
            button2.Size = new Size(164, 44);
            button2.TabIndex = 10;
            button2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(325, 42);
            button3.Name = "button3";
            button3.Size = new Size(164, 44);
            button3.TabIndex = 11;
            button3.Text = "คำนวณพื้นที่รูปหกเหลี่ยม";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(726, 106);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 14;
            label6.Text = "พื้นที่ (ตารางต่อหน่วย)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 539);
            Controls.Add(label6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private GroupBox groupBox3;
        private Button button3;
        private Label label6;
    }
}
