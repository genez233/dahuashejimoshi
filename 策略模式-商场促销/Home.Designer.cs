namespace 策略模式_商场促销
{
    partial class Home
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
            this.lab_price = new System.Windows.Forms.Label();
            this.lab_number = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txtbox_list = new System.Windows.Forms.TextBox();
            this.lab_total = new System.Windows.Forms.Label();
            this.lab_totalprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combox_Calculation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lab_price
            // 
            this.lab_price.AutoSize = true;
            this.lab_price.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_price.Location = new System.Drawing.Point(214, 77);
            this.lab_price.Name = "lab_price";
            this.lab_price.Size = new System.Drawing.Size(66, 19);
            this.lab_price.TabIndex = 0;
            this.lab_price.Text = "单价：";
            // 
            // lab_number
            // 
            this.lab_number.AutoSize = true;
            this.lab_number.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_number.Location = new System.Drawing.Point(214, 130);
            this.lab_number.Name = "lab_number";
            this.lab_number.Size = new System.Drawing.Size(66, 19);
            this.lab_number.TabIndex = 1;
            this.lab_number.Text = "数量：";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_price.Location = new System.Drawing.Point(306, 73);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(173, 28);
            this.txt_price.TabIndex = 2;
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_number.Location = new System.Drawing.Point(306, 125);
            this.txt_number.Multiline = true;
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(173, 28);
            this.txt_number.TabIndex = 3;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(551, 73);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 28);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(551, 125);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 28);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // txtbox_list
            // 
            this.txtbox_list.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtbox_list.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbox_list.CausesValidation = false;
            this.txtbox_list.Location = new System.Drawing.Point(218, 217);
            this.txtbox_list.Multiline = true;
            this.txtbox_list.Name = "txtbox_list";
            this.txtbox_list.ReadOnly = true;
            this.txtbox_list.Size = new System.Drawing.Size(408, 116);
            this.txtbox_list.TabIndex = 6;
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_total.Location = new System.Drawing.Point(215, 393);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(56, 16);
            this.lab_total.TabIndex = 7;
            this.lab_total.Text = "总计：";
            // 
            // lab_totalprice
            // 
            this.lab_totalprice.AutoSize = true;
            this.lab_totalprice.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_totalprice.Location = new System.Drawing.Point(396, 393);
            this.lab_totalprice.Name = "lab_totalprice";
            this.lab_totalprice.Size = new System.Drawing.Size(83, 33);
            this.lab_totalprice.TabIndex = 8;
            this.lab_totalprice.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(215, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "计算方式：";
            // 
            // combox_Calculation
            // 
            this.combox_Calculation.FormattingEnabled = true;
            this.combox_Calculation.Location = new System.Drawing.Point(306, 177);
            this.combox_Calculation.Name = "combox_Calculation";
            this.combox_Calculation.Size = new System.Drawing.Size(173, 20);
            this.combox_Calculation.TabIndex = 10;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combox_Calculation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_totalprice);
            this.Controls.Add(this.lab_total);
            this.Controls.Add(this.txtbox_list);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lab_number);
            this.Controls.Add(this.lab_price);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_price;
        private System.Windows.Forms.Label lab_number;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txtbox_list;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.Label lab_totalprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combox_Calculation;
    }
}