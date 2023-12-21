namespace Fund_tracker
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox9 = new TextBox();
            label11 = new Label();
            textBox10 = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Fax", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(19, 466);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Fax", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(251, 466);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.IBeam;
            dateTimePicker1.CustomFormat = "MM/dd/yy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(126, 276);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2023, 8, 19, 15, 34, 27, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(126, 311);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(126, 347);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(126, 379);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 23);
            textBox7.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(126, 414);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(200, 23);
            textBox8.TabIndex = 11;
            textBox8.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 31);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 7;
            label1.Text = "SIGN UP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 99);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 8;
            label2.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 153);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 8;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 185);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 215);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 8;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 282);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 8;
            label6.Text = "Birthday:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 314);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 8;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 347);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 8;
            label8.Text = "Street:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(19, 379);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 8;
            label9.Text = "City:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(19, 414);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 8;
            label10.Text = "Province:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(126, 240);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(200, 23);
            textBox9.TabIndex = 6;
            textBox9.TextChanged += textBox4_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(19, 243);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 8;
            label11.Text = "Gender";
            label11.Click += label11_Click;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(126, 124);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(200, 23);
            textBox10.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(19, 127);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 8;
            label12.Text = "Password:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(372, 518);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox4);
            Controls.Add(textBox7);
            Controls.Add(textBox3);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox10);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox9;
        private Label label11;
        private TextBox textBox10;
        private Label label12;
    }
}