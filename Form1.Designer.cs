namespace CSharp_TinhTong
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
            this.lblSo1 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.btntinhtong = new System.Windows.Forms.Button();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSo1
            // 
            this.lblSo1.AutoSize = true;
            this.lblSo1.Location = new System.Drawing.Point(71, 78);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(29, 13);
            this.lblSo1.TabIndex = 0;
            this.lblSo1.Text = "Số 1";
            this.lblSo1.Click += new System.EventHandler(this.lblSo1_Click);
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(143, 75);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 20);
            this.txtSo1.TabIndex = 1;
            // 
            // btntinhtong
            // 
            this.btntinhtong.Location = new System.Drawing.Point(143, 227);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(75, 23);
            this.btntinhtong.TabIndex = 2;
            this.btntinhtong.Text = "KẾT QUẢ";
            this.btntinhtong.UseVisualStyleBackColor = true;
            this.btntinhtong.Click += new System.EventHandler(this.btntinhtong_Click);
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(143, 111);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 20);
            this.txtSo2.TabIndex = 4;
            this.txtSo2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblSo2
            // 
            this.lblSo2.AutoSize = true;
            this.lblSo2.Location = new System.Drawing.Point(71, 118);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(29, 13);
            this.lblSo2.TabIndex = 3;
            this.lblSo2.Text = "Số 2";
            this.lblSo2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.BackColor = System.Drawing.Color.Transparent;
            this.lblKQ.Location = new System.Drawing.Point(140, 187);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(54, 13);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "KẾT QUẢ";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(143, 149);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.lblSo2);
            this.Controls.Add(this.btntinhtong);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lblSo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ỨNG DỤNG TÍNH TỔNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

