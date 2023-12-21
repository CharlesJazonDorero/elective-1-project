namespace Fund_tracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(151, 292);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 292);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Don't have account?";
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Fax", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(99, 248);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 83);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "&Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 139);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "&Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 157);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(44, 20);
            label4.Name = "label4";
            label4.Size = new Size(179, 28);
            label4.TabIndex = 6;
            label4.Text = "FUND TRACKER";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(277, 330);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fund Tracker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
    }
}