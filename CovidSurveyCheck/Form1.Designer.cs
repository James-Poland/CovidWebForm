using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace CovidSurveyCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB1 = new System.Windows.Forms.CheckBox();
            this.CB2 = new System.Windows.Forms.CheckBox();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB4 = new System.Windows.Forms.CheckBox();
            this.CB3 = new System.Windows.Forms.CheckBox();
            this.CB10 = new System.Windows.Forms.CheckBox();
            this.CB9 = new System.Windows.Forms.CheckBox();
            this.CB5 = new System.Windows.Forms.CheckBox();
            this.CB8 = new System.Windows.Forms.CheckBox();
            this.CB7 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CB6 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CB12 = new System.Windows.Forms.CheckBox();
            this.CB11 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.\tDo you have symptoms of cough, fever, high temperature, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "sore throat, runny nose, breathlessness or flu like symptoms ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "now or in the past 14 days? ";
            // 
            // CB1
            // 
            this.CB1.AutoSize = true;
            this.CB1.Location = new System.Drawing.Point(506, 69);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(44, 17);
            this.CB1.TabIndex = 3;
            this.CB1.Text = "Yes";
            this.CB1.UseVisualStyleBackColor = true;
            // 
            // CB2
            // 
            this.CB2.AutoSize = true;
            this.CB2.Location = new System.Drawing.Point(593, 69);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(40, 17);
            this.CB2.TabIndex = 4;
            this.CB2.Text = "No";
            this.CB2.UseVisualStyleBackColor = true;
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveItem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveItem.Location = new System.Drawing.Point(549, 523);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(97, 33);
            this.btnSaveItem.TabIndex = 25;
            this.btnSaveItem.Text = "Submit";
            this.btnSaveItem.UseVisualStyleBackColor = false;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "2.\tHave you been diagnosed with confirmed or suspected ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "COVID-19 infection in the last 14 days? ";
            // 
            // CB4
            // 
            this.CB4.AutoSize = true;
            this.CB4.Location = new System.Drawing.Point(593, 130);
            this.CB4.Name = "CB4";
            this.CB4.Size = new System.Drawing.Size(40, 17);
            this.CB4.TabIndex = 29;
            this.CB4.Text = "No";
            this.CB4.UseVisualStyleBackColor = true;
            // 
            // CB3
            // 
            this.CB3.AutoSize = true;
            this.CB3.Location = new System.Drawing.Point(506, 130);
            this.CB3.Name = "CB3";
            this.CB3.Size = new System.Drawing.Size(44, 17);
            this.CB3.TabIndex = 28;
            this.CB3.Text = "Yes";
            this.CB3.UseVisualStyleBackColor = true;
            // 
            // CB10
            // 
            this.CB10.AutoSize = true;
            this.CB10.Location = new System.Drawing.Point(593, 269);
            this.CB10.Name = "CB10";
            this.CB10.Size = new System.Drawing.Size(40, 17);
            this.CB10.TabIndex = 31;
            this.CB10.Text = "No";
            this.CB10.UseVisualStyleBackColor = true;
            // 
            // CB9
            // 
            this.CB9.AutoSize = true;
            this.CB9.Location = new System.Drawing.Point(506, 269);
            this.CB9.Name = "CB9";
            this.CB9.Size = new System.Drawing.Size(44, 17);
            this.CB9.TabIndex = 30;
            this.CB9.Text = "Yes";
            this.CB9.UseVisualStyleBackColor = true;
            // 
            // CB5
            // 
            this.CB5.AutoSize = true;
            this.CB5.Location = new System.Drawing.Point(506, 204);
            this.CB5.Name = "CB5";
            this.CB5.Size = new System.Drawing.Size(44, 17);
            this.CB5.TabIndex = 32;
            this.CB5.Text = "Yes";
            this.CB5.UseVisualStyleBackColor = true;
            // 
            // CB8
            // 
            this.CB8.AutoSize = true;
            this.CB8.Location = new System.Drawing.Point(593, 235);
            this.CB8.Name = "CB8";
            this.CB8.Size = new System.Drawing.Size(40, 17);
            this.CB8.TabIndex = 35;
            this.CB8.Text = "No";
            this.CB8.UseVisualStyleBackColor = true;
            // 
            // CB7
            // 
            this.CB7.AutoSize = true;
            this.CB7.Location = new System.Drawing.Point(506, 235);
            this.CB7.Name = "CB7";
            this.CB7.Size = new System.Drawing.Size(44, 17);
            this.CB7.TabIndex = 34;
            this.CB7.Text = "Yes";
            this.CB7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(460, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "4.\tHave you been advised by a doctor to self-isolate at this time? ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(432, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "5.\tHave you been advised by a doctor to cocoon at this time?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(477, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "(i.e. less than 2m for more than 15 minutes accumulative in 1 day)?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "or suspected case of COVID-19 in the past 14 days ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(406, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "3.\tAre you a close contact of a person who is a confirmed";
            // 
            // CB6
            // 
            this.CB6.AutoSize = true;
            this.CB6.Location = new System.Drawing.Point(593, 205);
            this.CB6.Name = "CB6";
            this.CB6.Size = new System.Drawing.Size(40, 17);
            this.CB6.TabIndex = 33;
            this.CB6.Text = "No";
            this.CB6.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 348);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(614, 168);
            this.richTextBox1.TabIndex = 41;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(216, 532);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(262, 17);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.Text = "I have read and understand the statements above";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(437, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "6. Have you downloaded and installed Government Covid-19 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "tracing app for your mobile device?";
            // 
            // CB12
            // 
            this.CB12.AutoSize = true;
            this.CB12.Location = new System.Drawing.Point(593, 306);
            this.CB12.Name = "CB12";
            this.CB12.Size = new System.Drawing.Size(40, 17);
            this.CB12.TabIndex = 46;
            this.CB12.Text = "No";
            this.CB12.UseVisualStyleBackColor = true;
            // 
            // CB11
            // 
            this.CB11.AutoSize = true;
            this.CB11.Location = new System.Drawing.Point(506, 306);
            this.CB11.Name = "CB11";
            this.CB11.Size = new System.Drawing.Size(44, 17);
            this.CB11.TabIndex = 45;
            this.CB11.Text = "Yes";
            this.CB11.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(449, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "Currently Logged in User:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 566);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CB12);
            this.Controls.Add(this.CB11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB8);
            this.Controls.Add(this.CB7);
            this.Controls.Add(this.CB6);
            this.Controls.Add(this.CB5);
            this.Controls.Add(this.CB10);
            this.Controls.Add(this.CB9);
            this.Controls.Add(this.CB4);
            this.Controls.Add(this.CB3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.CB2);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Covid RTW Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox CB1;
        private CheckBox CB2;
        private Button btnSaveItem;
        private Label label4;
        private Label label5;
        private CheckBox CB4;
        private CheckBox CB3;
        private CheckBox CB10;
        private CheckBox CB9;
        private CheckBox CB5;
        private CheckBox CB8;
        private CheckBox CB7;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private CheckBox CB6;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private Label label11;
        private Label label12;
        private CheckBox CB12;
        private CheckBox CB11;
        private Label label13;
    }
}

