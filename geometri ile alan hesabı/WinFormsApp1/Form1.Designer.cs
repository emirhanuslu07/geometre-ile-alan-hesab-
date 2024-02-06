namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            TabControl1 = new TabControl();
            tabPage2 = new TabPage();
            button_hesapla = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            tabPage1 = new TabPage();
            button1 = new Button();
            label13 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPage3 = new TabPage();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            tabPage4 = new TabPage();
            button3 = new Button();
            label12 = new Label();
            label10 = new Label();
            textBox10 = new TextBox();
            groupBox1.SuspendLayout();
            TabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Highlight;
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(TabControl1);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(34, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 366);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.Image = (Image)resources.GetObject("radioButton4.Image");
            radioButton4.Location = new Point(17, 239);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(66, 49);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Black", 35F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(7, 163);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(86, 66);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "△";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Black", 35F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(7, 91);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(99, 66);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "◯";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Black", 35F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(8, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 66);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "■";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tabPage2);
            TabControl1.Controls.Add(tabPage1);
            TabControl1.Controls.Add(tabPage3);
            TabControl1.Controls.Add(tabPage4);
            TabControl1.Location = new Point(171, 35);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(261, 303);
            TabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button_hesapla);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(253, 275);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kare";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_hesapla
            // 
            button_hesapla.BackColor = Color.Blue;
            button_hesapla.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button_hesapla.ForeColor = SystemColors.ControlLightLight;
            button_hesapla.Location = new Point(22, 150);
            button_hesapla.Name = "button_hesapla";
            button_hesapla.Size = new Size(114, 44);
            button_hesapla.TabIndex = 5;
            button_hesapla.Text = "HESAPLA";
            button_hesapla.UseVisualStyleBackColor = false;
            button_hesapla.Click += button_hesapla_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(102, 46);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(123, 23);
            textBox4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(22, 115);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 2;
            label6.Text = "Sonuç ...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(22, 46);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 0;
            label4.Text = "Kenar";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(253, 275);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Daire";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(79, 147);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Hesaplama";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(21, 72);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(27, 72);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Sonuç=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(17, 70);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Yarıçap";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(textBox9);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(253, 275);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Üçgen";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(87, 180);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(28, 130);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 11;
            label7.Text = "Sonuç=";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(16, 93);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 9;
            label8.Text = "Yükseklik";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(28, 58);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 8;
            label9.Text = "Taban";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(78, 90);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(119, 23);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(78, 55);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(119, 23);
            textBox9.TabIndex = 6;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(textBox10);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(253, 275);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Küp";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(98, 180);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(30, 131);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 5;
            label12.Text = "Sonuç=";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(36, 51);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 3;
            label10.Text = "Kenar";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(88, 51);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TabControl TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Button button_hesapla;
        private Label label2;
        private Label label1;
        private Label label3;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox textBox4;
        private Label label6;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox10;
        private Label label12;
        private Label label13;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}