﻿namespace CircleAndLineCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TextBox();
            this.tbCx = new System.Windows.Forms.TextBox();
            this.tbCy = new System.Windows.Forms.TextBox();
            this.tbLx1 = new System.Windows.Forms.TextBox();
            this.tbLy1 = new System.Windows.Forms.TextBox();
            this.tbLx2 = new System.Windows.Forms.TextBox();
            this.tbLy2 = new System.Windows.Forms.TextBox();
            this.tbLx3 = new System.Windows.Forms.TextBox();
            this.tbLy3 = new System.Windows.Forms.TextBox();
            this.tbLx4 = new System.Windows.Forms.TextBox();
            this.tbLy4 = new System.Windows.Forms.TextBox();
            this.tbLx5 = new System.Windows.Forms.TextBox();
            this.tbLy5 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbLx6 = new System.Windows.Forms.TextBox();
            this.tbLy6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarAngle = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радиус окружности: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Координаты центра окружности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Координаты точек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y";
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(136, 17);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(100, 20);
            this.tbR.TabIndex = 5;
            this.tbR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbR_KeyPress);
            // 
            // tbCx
            // 
            this.tbCx.Location = new System.Drawing.Point(22, 98);
            this.tbCx.Name = "tbCx";
            this.tbCx.Size = new System.Drawing.Size(100, 20);
            this.tbCx.TabIndex = 6;
            this.tbCx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCx_KeyPress);
            // 
            // tbCy
            // 
            this.tbCy.Location = new System.Drawing.Point(137, 98);
            this.tbCy.Name = "tbCy";
            this.tbCy.Size = new System.Drawing.Size(100, 20);
            this.tbCy.TabIndex = 7;
            this.tbCy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLy1_KeyPress);
            // 
            // tbLx1
            // 
            this.tbLx1.Location = new System.Drawing.Point(22, 165);
            this.tbLx1.Name = "tbLx1";
            this.tbLx1.Size = new System.Drawing.Size(100, 20);
            this.tbLx1.TabIndex = 8;
            this.tbLx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLx1_KeyPress);
            // 
            // tbLy1
            // 
            this.tbLy1.Location = new System.Drawing.Point(137, 165);
            this.tbLy1.Name = "tbLy1";
            this.tbLy1.Size = new System.Drawing.Size(100, 20);
            this.tbLy1.TabIndex = 9;
            this.tbLy1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCy_KeyPress);
            // 
            // tbLx2
            // 
            this.tbLx2.Location = new System.Drawing.Point(22, 197);
            this.tbLx2.Name = "tbLx2";
            this.tbLx2.Size = new System.Drawing.Size(100, 20);
            this.tbLx2.TabIndex = 10;
            this.tbLx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLx3_KeyPress);
            // 
            // tbLy2
            // 
            this.tbLy2.Location = new System.Drawing.Point(137, 197);
            this.tbLy2.Name = "tbLy2";
            this.tbLy2.Size = new System.Drawing.Size(100, 20);
            this.tbLy2.TabIndex = 11;
            this.tbLy2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLy2_KeyPress);
            // 
            // tbLx3
            // 
            this.tbLx3.Location = new System.Drawing.Point(22, 232);
            this.tbLx3.Name = "tbLx3";
            this.tbLx3.Size = new System.Drawing.Size(100, 20);
            this.tbLx3.TabIndex = 12;
            this.tbLx3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLx4_KeyPress);
            // 
            // tbLy3
            // 
            this.tbLy3.Location = new System.Drawing.Point(137, 232);
            this.tbLy3.Name = "tbLy3";
            this.tbLy3.Size = new System.Drawing.Size(100, 20);
            this.tbLy3.TabIndex = 13;
            this.tbLy3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLy3_KeyPress);
            // 
            // tbLx4
            // 
            this.tbLx4.Location = new System.Drawing.Point(22, 268);
            this.tbLx4.Name = "tbLx4";
            this.tbLx4.Size = new System.Drawing.Size(100, 20);
            this.tbLx4.TabIndex = 14;
            this.tbLx4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLy4_KeyPress);
            // 
            // tbLy4
            // 
            this.tbLy4.Location = new System.Drawing.Point(137, 268);
            this.tbLy4.Name = "tbLy4";
            this.tbLy4.Size = new System.Drawing.Size(100, 20);
            this.tbLy4.TabIndex = 15;
            this.tbLy4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLx2_KeyPress);
            // 
            // tbLx5
            // 
            this.tbLx5.Location = new System.Drawing.Point(22, 304);
            this.tbLx5.Name = "tbLx5";
            this.tbLx5.Size = new System.Drawing.Size(100, 20);
            this.tbLx5.TabIndex = 16;
            this.tbLx5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLx5_KeyPress);
            // 
            // tbLy5
            // 
            this.tbLy5.Location = new System.Drawing.Point(137, 304);
            this.tbLy5.Name = "tbLy5";
            this.tbLy5.Size = new System.Drawing.Size(100, 20);
            this.tbLy5.TabIndex = 17;
            this.tbLy5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLy5_KeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(276, 206);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(364, 279);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(276, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 168);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLx6
            // 
            this.tbLx6.Location = new System.Drawing.Point(22, 374);
            this.tbLx6.Name = "tbLx6";
            this.tbLx6.Size = new System.Drawing.Size(100, 20);
            this.tbLx6.TabIndex = 22;
            this.tbLx6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLx6_KeyPress);
            // 
            // tbLy6
            // 
            this.tbLy6.Location = new System.Drawing.Point(137, 374);
            this.tbLy6.Name = "tbLy6";
            this.tbLy6.Size = new System.Drawing.Size(100, 20);
            this.tbLy6.TabIndex = 23;
            this.tbLy6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLy6_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Размер сектора:";
            // 
            // trackBarAngle
            // 
            this.trackBarAngle.Location = new System.Drawing.Point(133, 416);
            this.trackBarAngle.Name = "trackBarAngle";
            this.trackBarAngle.Size = new System.Drawing.Size(104, 45);
            this.trackBarAngle.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Координаты направляющей точки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 497);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBarAngle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbLy6);
            this.Controls.Add(this.tbLx6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbLy5);
            this.Controls.Add(this.tbLx5);
            this.Controls.Add(this.tbLy4);
            this.Controls.Add(this.tbLx4);
            this.Controls.Add(this.tbLy3);
            this.Controls.Add(this.tbLx3);
            this.Controls.Add(this.tbLy2);
            this.Controls.Add(this.tbLx2);
            this.Controls.Add(this.tbLy1);
            this.Controls.Add(this.tbLx1);
            this.Controls.Add(this.tbCy);
            this.Controls.Add(this.tbCx);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Программа";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.TextBox tbCx;
        private System.Windows.Forms.TextBox tbCy;
        private System.Windows.Forms.TextBox tbLx1;
        private System.Windows.Forms.TextBox tbLy1;
        private System.Windows.Forms.TextBox tbLx2;
        private System.Windows.Forms.TextBox tbLy2;
        private System.Windows.Forms.TextBox tbLx3;
        private System.Windows.Forms.TextBox tbLy3;
        private System.Windows.Forms.TextBox tbLx4;
        private System.Windows.Forms.TextBox tbLy4;
        private System.Windows.Forms.TextBox tbLx5;
        private System.Windows.Forms.TextBox tbLy5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbLx6;
        private System.Windows.Forms.TextBox tbLy6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarAngle;
        private System.Windows.Forms.Label label6;
    }
}

