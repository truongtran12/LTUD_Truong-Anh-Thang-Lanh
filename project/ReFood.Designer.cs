﻿namespace project
{
    partial class ReFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReFood));
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cbbCountReF = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbbTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCountReF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxA
            // 
            this.groupBoxA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxA.Controls.Add(this.btnAccept);
            this.groupBoxA.Controls.Add(this.cbbCountReF);
            this.groupBoxA.Controls.Add(this.label6);
            this.groupBoxA.Controls.Add(this.cbbCount);
            this.groupBoxA.Controls.Add(this.label5);
            this.groupBoxA.Controls.Add(this.cbbFood);
            this.groupBoxA.Controls.Add(this.label2);
            this.groupBoxA.Controls.Add(this.label4);
            this.groupBoxA.Controls.Add(this.label3);
            this.groupBoxA.Controls.Add(this.txtTotal);
            this.groupBoxA.Controls.Add(this.cbbTable);
            this.groupBoxA.Controls.Add(this.label1);
            this.groupBoxA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(434, 248);
            this.groupBoxA.TabIndex = 25;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Đổi trả:";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Silver;
            this.btnAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccept.BackgroundImage")));
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccept.Location = new System.Drawing.Point(333, 162);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(59, 51);
            this.btnAccept.TabIndex = 26;
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // cbbCountReF
            // 
            this.cbbCountReF.BackColor = System.Drawing.Color.White;
            this.cbbCountReF.Location = new System.Drawing.Point(124, 187);
            this.cbbCountReF.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cbbCountReF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbbCountReF.Name = "cbbCountReF";
            this.cbbCountReF.Size = new System.Drawing.Size(174, 24);
            this.cbbCountReF.TabIndex = 31;
            this.cbbCountReF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(50, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Trả lại:";
            // 
            // cbbCount
            // 
            this.cbbCount.BackColor = System.Drawing.Color.White;
            this.cbbCount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cbbCount.Location = new System.Drawing.Point(124, 153);
            this.cbbCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cbbCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbbCount.Name = "cbbCount";
            this.cbbCount.Size = new System.Drawing.Size(174, 24);
            this.cbbCount.TabIndex = 29;
            this.cbbCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(25, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Số lượng:";
            // 
            // cbbFood
            // 
            this.cbbFood.BackColor = System.Drawing.Color.Silver;
            this.cbbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(124, 119);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(288, 25);
            this.cbbFood.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(38, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Món trả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "VNĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(42, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tổng:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(110, 82);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(241, 17);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbbTable
            // 
            this.cbbTable.BackColor = System.Drawing.Color.Silver;
            this.cbbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Location = new System.Drawing.Point(110, 36);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(302, 25);
            this.cbbTable.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số bàn:";
            // 
            // ReFood
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(459, 279);
            this.Controls.Add(this.groupBoxA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReFood";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi trả món";
            this.TopMost = true;
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCountReF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbbTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown cbbCount;
        public System.Windows.Forms.NumericUpDown cbbCountReF;
        private System.Windows.Forms.Label label6;
    }
}