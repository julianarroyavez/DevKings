﻿namespace DevSpadeGame
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
            this.startmenu.SuspendLayout();
            this.DificultPanel.SuspendLayout();
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
            this.DificultPanel.Location = new System.Drawing.Point(363, 21);
            this.DificultPanel.Name = "DificultPanel";
            this.DificultPanel.Size = new System.Drawing.Size(198, 321);
            this.DificultPanel.TabIndex = 3;
            this.DificultPanel.Visible = false;
            // 
            // Probutton
            // 
            this.Probutton.Location = new System.Drawing.Point(57, 229);
            this.Probutton.Name = "Probutton";
            this.Probutton.Size = new System.Drawing.Size(65, 32);
            this.Probutton.TabIndex = 2;
            this.Probutton.Text = "Pro";
            this.Probutton.UseVisualStyleBackColor = true;
            this.Probutton.Click += new System.EventHandler(this.Probutton_Click_1);
            // 
            // Standardbutton
            // 
            this.Standardbutton.Location = new System.Drawing.Point(57, 130);
            this.Standardbutton.Name = "Standardbutton";
            this.Standardbutton.Size = new System.Drawing.Size(65, 32);
            this.Standardbutton.TabIndex = 1;
            this.Standardbutton.Text = "Standard";
            this.Standardbutton.UseVisualStyleBackColor = true;
            this.Standardbutton.Click += new System.EventHandler(this.Standardbutton_Click);
            // 
            // Eassybutton
            // 
            this.Eassybutton.Location = new System.Drawing.Point(57, 34);
            this.Eassybutton.Name = "Eassybutton";
            this.Eassybutton.Size = new System.Drawing.Size(62, 32);
            this.Eassybutton.TabIndex = 0;
            this.Eassybutton.Text = "Easy";
            this.Eassybutton.UseVisualStyleBackColor = true;
            this.Eassybutton.Click += new System.EventHandler(this.Eassybutton_Click);
            // 
            // bord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(851, 531);
            this.Controls.Add(this.DificultPanel);
            this.Controls.Add(this.startmenu);
            this.Name = "bord";
            this.Text = "bord";
            this.Load += new System.EventHandler(this.Bord_Load);
            this.startmenu.ResumeLayout(false);
            this.DificultPanel.ResumeLayout(false);
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

    }
}