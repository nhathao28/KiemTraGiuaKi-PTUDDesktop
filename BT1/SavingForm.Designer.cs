﻿namespace BT1
{
    partial class SavingForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(210, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 176);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 6;
            label1.Text = "Phone Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 149);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 92);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Account ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 122);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 9;
            label4.Text = "Name:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(210, 147);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // SavingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 277);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "SavingForm";
            Text = "SavingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
    }
}