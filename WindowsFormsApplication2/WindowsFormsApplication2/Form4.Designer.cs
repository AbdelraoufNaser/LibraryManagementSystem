﻿namespace WindowsFormsApplication2
{
    partial class Form4
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
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Snow;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(140, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 33);
            this.label9.TabIndex = 20;
            this.label9.Text = "Insertion into tables Section";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(96, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 65);
            this.button1.TabIndex = 21;
            this.button1.Text = "Click to insert into Student_Faculty";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Location = new System.Drawing.Point(354, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 65);
            this.button2.TabIndex = 22;
            this.button2.Text = "Click to insert into Genre";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SpringGreen;
            this.button3.Location = new System.Drawing.Point(233, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 65);
            this.button3.TabIndex = 23;
            this.button3.Text = " Click to insert into Book";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SpringGreen;
            this.button4.Location = new System.Drawing.Point(475, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 65);
            this.button4.TabIndex = 24;
            this.button4.Text = " Click to insert into Book_Copy";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SpringGreen;
            this.button5.Location = new System.Drawing.Point(96, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 58);
            this.button5.TabIndex = 25;
            this.button5.Text = " Click to insert into Author";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SpringGreen;
            this.button6.Location = new System.Drawing.Point(354, 200);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 58);
            this.button6.TabIndex = 26;
            this.button6.Text = " Click to insert into Borrow";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SpringGreen;
            this.button7.Location = new System.Drawing.Point(233, 200);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 58);
            this.button7.TabIndex = 27;
            this.button7.Text = " Click to insert into Keywords";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button8.Location = new System.Drawing.Point(683, 269);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 50);
            this.button8.TabIndex = 28;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(832, 345);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Name = "Form4";
            this.Text = "T";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}