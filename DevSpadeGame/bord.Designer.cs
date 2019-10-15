namespace DevSpadeGame
{
    partial class bord
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.startmenu = new System.Windows.Forms.Panel();
            this.DificultPanel = new System.Windows.Forms.Panel();
            this.Probutton = new System.Windows.Forms.Button();
            this.Standardbutton = new System.Windows.Forms.Button();
            this.Eassybutton = new System.Windows.Forms.Button();
            this.BidPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.startmenu.SuspendLayout();
            this.DificultPanel.SuspendLayout();
            this.BidPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rules";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // startmenu
            // 
            this.startmenu.Controls.Add(this.button2);
            this.startmenu.Controls.Add(this.button1);
            this.startmenu.Location = new System.Drawing.Point(402, 47);
            this.startmenu.Name = "startmenu";
            this.startmenu.Size = new System.Drawing.Size(118, 275);
            this.startmenu.TabIndex = 2;
            // 
            // DificultPanel
            // 
            this.DificultPanel.Controls.Add(this.Probutton);
            this.DificultPanel.Controls.Add(this.Standardbutton);
            this.DificultPanel.Controls.Add(this.Eassybutton);
            this.DificultPanel.Location = new System.Drawing.Point(338, 95);
            this.DificultPanel.Name = "DificultPanel";
            this.DificultPanel.Size = new System.Drawing.Size(145, 292);
            this.DificultPanel.TabIndex = 3;
            this.DificultPanel.Visible = false;
            // 
            // Probutton
            // 
            this.Probutton.Location = new System.Drawing.Point(39, 233);
            this.Probutton.Name = "Probutton";
            this.Probutton.Size = new System.Drawing.Size(65, 32);
            this.Probutton.TabIndex = 2;
            this.Probutton.Text = "Pro";
            this.Probutton.UseVisualStyleBackColor = true;
            this.Probutton.Click += new System.EventHandler(this.Probutton_Click_1);
            // 
            // Standardbutton
            // 
            this.Standardbutton.Location = new System.Drawing.Point(39, 127);
            this.Standardbutton.Name = "Standardbutton";
            this.Standardbutton.Size = new System.Drawing.Size(65, 32);
            this.Standardbutton.TabIndex = 1;
            this.Standardbutton.Text = "Standard";
            this.Standardbutton.UseVisualStyleBackColor = true;
            this.Standardbutton.Click += new System.EventHandler(this.Standardbutton_Click);
            // 
            // Eassybutton
            // 
            this.Eassybutton.Location = new System.Drawing.Point(42, 34);
            this.Eassybutton.Name = "Eassybutton";
            this.Eassybutton.Size = new System.Drawing.Size(62, 32);
            this.Eassybutton.TabIndex = 0;
            this.Eassybutton.Text = "Easy";
            this.Eassybutton.UseVisualStyleBackColor = true;
            this.Eassybutton.Click += new System.EventHandler(this.Eassybutton_Click);
            // 
            // BidPanel
            // 
            this.BidPanel.Controls.Add(this.BackButton);
            this.BidPanel.Controls.Add(this.richTextBox1);
            this.BidPanel.Controls.Add(this.button16);
            this.BidPanel.Controls.Add(this.button15);
            this.BidPanel.Controls.Add(this.button14);
            this.BidPanel.Controls.Add(this.button13);
            this.BidPanel.Controls.Add(this.button12);
            this.BidPanel.Controls.Add(this.button11);
            this.BidPanel.Controls.Add(this.button10);
            this.BidPanel.Controls.Add(this.button9);
            this.BidPanel.Controls.Add(this.button8);
            this.BidPanel.Controls.Add(this.button7);
            this.BidPanel.Controls.Add(this.button6);
            this.BidPanel.Controls.Add(this.button5);
            this.BidPanel.Controls.Add(this.button3);
            this.BidPanel.Location = new System.Drawing.Point(82, 125);
            this.BidPanel.Name = "BidPanel";
            this.BidPanel.Size = new System.Drawing.Size(664, 313);
            this.BidPanel.TabIndex = 4;
            this.BidPanel.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Black;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Location = new System.Drawing.Point(18, 22);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(50, 25);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(256, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(157, 28);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "Make a Bid:";
            // 
            // button16
            // 
            this.button16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button16.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(80, 327);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(56, 49);
            this.button16.TabIndex = 13;
            this.button16.Text = "9";
            this.button16.UseMnemonic = false;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button15.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(462, 203);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(56, 49);
            this.button15.TabIndex = 12;
            this.button15.Text = "8";
            this.button15.UseMnemonic = false;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button14.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(198, 101);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 49);
            this.button14.TabIndex = 11;
            this.button14.Text = "2";
            this.button14.UseMnemonic = false;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button13.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(302, 101);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(56, 49);
            this.button13.TabIndex = 10;
            this.button13.Text = "3";
            this.button13.UseMnemonic = false;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button12.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(411, 101);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 49);
            this.button12.TabIndex = 9;
            this.button12.Text = "4";
            this.button12.UseMnemonic = false;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(519, 101);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 49);
            this.button11.TabIndex = 8;
            this.button11.Text = "5";
            this.button11.UseMnemonic = false;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(137, 203);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 49);
            this.button10.TabIndex = 7;
            this.button10.Text = "6";
            this.button10.UseMnemonic = false;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(302, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 49);
            this.button9.TabIndex = 6;
            this.button9.Text = "7";
            this.button9.UseMnemonic = false;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(411, 327);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 49);
            this.button8.TabIndex = 5;
            this.button8.Text = "12";
            this.button8.UseMnemonic = false;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(198, 327);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 49);
            this.button7.TabIndex = 4;
            this.button7.Text = "10";
            this.button7.UseMnemonic = false;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(302, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 49);
            this.button6.TabIndex = 3;
            this.button6.Text = "11";
            this.button6.UseMnemonic = false;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(519, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 49);
            this.button5.TabIndex = 2;
            this.button5.Text = "13";
            this.button5.UseMnemonic = false;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(80, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 49);
            this.button3.TabIndex = 0;
            this.button3.Text = "1";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // bord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DificultPanel);
            this.Controls.Add(this.startmenu);
            this.Controls.Add(this.BidPanel);
            this.Name = "bord";
            this.Text = "bord";
            this.Load += new System.EventHandler(this.Bord_Load);
            this.startmenu.ResumeLayout(false);
            this.DificultPanel.ResumeLayout(false);
            this.BidPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel startmenu;
        private System.Windows.Forms.Panel DificultPanel;
        private System.Windows.Forms.Button Probutton;
        private System.Windows.Forms.Button Standardbutton;
        private System.Windows.Forms.Button Eassybutton;
        private System.Windows.Forms.Panel BidPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BackButton;
    }
}