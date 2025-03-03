namespace 单例模式_有些类也需要计划生育
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
            this.btn_Tool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Tool
            // 
            this.btn_Tool.Location = new System.Drawing.Point(145, 71);
            this.btn_Tool.Name = "btn_Tool";
            this.btn_Tool.Size = new System.Drawing.Size(100, 35);
            this.btn_Tool.TabIndex = 1;
            this.btn_Tool.Text = "工具箱";
            this.btn_Tool.UseVisualStyleBackColor = true;
            this.btn_Tool.Click += new System.EventHandler(this.Btn_Tool_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Tool);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Tool;
    }
}