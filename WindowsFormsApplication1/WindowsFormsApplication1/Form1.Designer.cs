namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPopForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPopForm
            // 
            this.buttonPopForm.Location = new System.Drawing.Point(92, 99);
            this.buttonPopForm.Name = "buttonPopForm";
            this.buttonPopForm.Size = new System.Drawing.Size(75, 23);
            this.buttonPopForm.TabIndex = 0;
            this.buttonPopForm.Text = "弹框";
            this.buttonPopForm.UseVisualStyleBackColor = true;
            this.buttonPopForm.Click += new System.EventHandler(this.buttonPopForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonPopForm);
            this.Name = "Form1";
            this.Text = "GitTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPopForm;
    }
}

