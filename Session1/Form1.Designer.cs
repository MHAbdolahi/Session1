namespace Session1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtPrintNumbers = new System.Windows.Forms.TextBox();
            this.btnPrintNumbers = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.numericZojFard = new System.Windows.Forms.NumericUpDown();
            this.btnZojFard = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericZojFard)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(616, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "آبی";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 397);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "تغییر رنگ زمینه ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(616, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "مشکی";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(616, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "سفید";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(616, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "قرمز";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تنظیمات خروج ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(472, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(272, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "آیا میخواهید پیش از خروج ، نسخه پشتیبان تهیه شود ؟";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "بازی با اعداد ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(20, 49);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeftLayout = true;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(724, 302);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtPrintNumbers);
            this.tabPage4.Controls.Add(this.btnPrintNumbers);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(716, 276);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "چاپ اعداد یک تا هزار";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtPrintNumbers
            // 
            this.txtPrintNumbers.Location = new System.Drawing.Point(242, 25);
            this.txtPrintNumbers.Multiline = true;
            this.txtPrintNumbers.Name = "txtPrintNumbers";
            this.txtPrintNumbers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrintNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrintNumbers.Size = new System.Drawing.Size(227, 242);
            this.txtPrintNumbers.TabIndex = 1;
            // 
            // btnPrintNumbers
            // 
            this.btnPrintNumbers.Location = new System.Drawing.Point(475, 25);
            this.btnPrintNumbers.Name = "btnPrintNumbers";
            this.btnPrintNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnPrintNumbers.TabIndex = 0;
            this.btnPrintNumbers.Text = "چاپ";
            this.btnPrintNumbers.UseVisualStyleBackColor = true;
            this.btnPrintNumbers.Click += new System.EventHandler(this.btnPrintNumbers_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.numericZojFard);
            this.tabPage5.Controls.Add(this.btnZojFard);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(716, 276);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "تشخیص زوج و فرد";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // numericZojFard
            // 
            this.numericZojFard.Location = new System.Drawing.Point(311, 20);
            this.numericZojFard.Name = "numericZojFard";
            this.numericZojFard.Size = new System.Drawing.Size(120, 20);
            this.numericZojFard.TabIndex = 3;
            // 
            // btnZojFard
            // 
            this.btnZojFard.Location = new System.Drawing.Point(437, 17);
            this.btnZojFard.Name = "btnZojFard";
            this.btnZojFard.Size = new System.Drawing.Size(141, 23);
            this.btnZojFard.TabIndex = 2;
            this.btnZojFard.Text = "تشخیص زوج و فرد";
            this.btnZojFard.UseVisualStyleBackColor = true;
            this.btnZojFard.Click += new System.EventHandler(this.btnZojFard_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(716, 276);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "چاپ جدول ضرب";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.l4);
            this.tabPage7.Controls.Add(this.l3);
            this.tabPage7.Controls.Add(this.l2);
            this.tabPage7.Controls.Add(this.l1);
            this.tabPage7.Controls.Add(this.lblColor);
            this.tabPage7.Controls.Add(this.btnStop);
            this.tabPage7.Controls.Add(this.btnStart);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(716, 276);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "رنگ بندی";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // l4
            // 
            this.l4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.l4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.ForeColor = System.Drawing.Color.White;
            this.l4.Location = new System.Drawing.Point(374, 179);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(18, 18);
            this.l4.TabIndex = 8;
            this.l4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l4.Visible = false;
            // 
            // l3
            // 
            this.l3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.l3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.White;
            this.l3.Location = new System.Drawing.Point(350, 179);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(18, 18);
            this.l3.TabIndex = 7;
            this.l3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l3.Visible = false;
            // 
            // l2
            // 
            this.l2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.l2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.White;
            this.l2.Location = new System.Drawing.Point(326, 179);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(18, 18);
            this.l2.TabIndex = 6;
            this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l2.Visible = false;
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.l1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(302, 179);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(18, 18);
            this.l1.TabIndex = 5;
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l1.Visible = false;
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(43, 68);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(95, 86);
            this.lblColor.TabIndex = 3;
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(560, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(141, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "توقف";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(560, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "شروع";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(616, 204);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 37);
            this.button6.TabIndex = 5;
            this.button6.Text = "صورتی";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ok;iuyyuiyou";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericZojFard)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtPrintNumbers;
        private System.Windows.Forms.Button btnPrintNumbers;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.NumericUpDown numericZojFard;
        private System.Windows.Forms.Button btnZojFard;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button button6;
    }
}

