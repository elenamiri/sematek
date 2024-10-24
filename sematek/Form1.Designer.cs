namespace sematek
{
    partial class Form1
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
            this.RegisterButton1 = new System.Windows.Forms.Button();
            this.FirstNameTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.LastNameTextBox2 = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NationalCodeTextBox4 = new System.Windows.Forms.TextBox();
            this.NationalCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterButton1
            // 
            this.RegisterButton1.Location = new System.Drawing.Point(134, 193);
            this.RegisterButton1.Name = "RegisterButton1";
            this.RegisterButton1.Size = new System.Drawing.Size(170, 29);
            this.RegisterButton1.TabIndex = 0;
            this.RegisterButton1.Text = "Register";
            this.RegisterButton1.UseVisualStyleBackColor = true;
            this.RegisterButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstNameTextBox1
            // 
            this.FirstNameTextBox1.Location = new System.Drawing.Point(201, 27);
            this.FirstNameTextBox1.Name = "FirstNameTextBox1";
            this.FirstNameTextBox1.Size = new System.Drawing.Size(125, 27);
            this.FirstNameTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(97, 67);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(75, 20);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "LastName";
            // 
            // LastNameTextBox2
            // 
            this.LastNameTextBox2.Location = new System.Drawing.Point(201, 60);
            this.LastNameTextBox2.Name = "LastNameTextBox2";
            this.LastNameTextBox2.Size = new System.Drawing.Size(125, 27);
            this.LastNameTextBox2.TabIndex = 5;
            // 
            // PhoneNumberTextBox3
            // 
            this.PhoneNumberTextBox3.AllowDrop = true;
            this.PhoneNumberTextBox3.Location = new System.Drawing.Point(201, 93);
            this.PhoneNumberTextBox3.Name = "PhoneNumberTextBox3";
            this.PhoneNumberTextBox3.Size = new System.Drawing.Size(125, 27);
            this.PhoneNumberTextBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "PhoneNumber";
            // 
            // NationalCodeTextBox4
            // 
            this.NationalCodeTextBox4.Location = new System.Drawing.Point(201, 129);
            this.NationalCodeTextBox4.Name = "NationalCodeTextBox4";
            this.NationalCodeTextBox4.Size = new System.Drawing.Size(125, 27);
            this.NationalCodeTextBox4.TabIndex = 8;
            // 
            // NationalCode
            // 
            this.NationalCode.AutoSize = true;
            this.NationalCode.Location = new System.Drawing.Point(97, 132);
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.Size = new System.Drawing.Size(101, 20);
            this.NationalCode.TabIndex = 10;
            this.NationalCode.Text = "NationalCode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NationalCode);
            this.Controls.Add(this.NationalCodeTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneNumberTextBox3);
            this.Controls.Add(this.LastNameTextBox2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameTextBox1);
            this.Controls.Add(this.RegisterButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RegisterButton1;
        private TextBox FirstNameTextBox1;
        private Label label1;
        private Label label2;
        internal Label LastName;
        private TextBox LastNameTextBox2;
        private TextBox PhoneNumberTextBox3;
        private Label label4;
        private TextBox NationalCodeTextBox4;
        private Label NationalCode;
    }
}