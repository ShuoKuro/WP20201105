namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.pb_3 = new System.Windows.Forms.PictureBox();
            this.pb_2 = new System.Windows.Forms.PictureBox();
            this.pb_4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_4)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_1
            // 
            this.tb_1.Font = new System.Drawing.Font("新細明體", 20F);
            this.tb_1.Location = new System.Drawing.Point(58, 26);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(200, 39);
            this.tb_1.TabIndex = 0;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(301, 22);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(200, 50);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "button1";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // pb_1
            // 
            this.pb_1.Location = new System.Drawing.Point(58, 92);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(200, 200);
            this.pb_1.TabIndex = 2;
            this.pb_1.TabStop = false;
            // 
            // pb_3
            // 
            this.pb_3.Location = new System.Drawing.Point(58, 331);
            this.pb_3.Name = "pb_3";
            this.pb_3.Size = new System.Drawing.Size(200, 200);
            this.pb_3.TabIndex = 3;
            this.pb_3.TabStop = false;
            // 
            // pb_2
            // 
            this.pb_2.Location = new System.Drawing.Point(301, 92);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(200, 200);
            this.pb_2.TabIndex = 4;
            this.pb_2.TabStop = false;
            // 
            // pb_4
            // 
            this.pb_4.Location = new System.Drawing.Point(301, 331);
            this.pb_4.Name = "pb_4";
            this.pb_4.Size = new System.Drawing.Size(200, 200);
            this.pb_4.TabIndex = 5;
            this.pb_4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 543);
            this.Controls.Add(this.pb_4);
            this.Controls.Add(this.pb_2);
            this.Controls.Add(this.pb_3);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.tb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.PictureBox pb_1;
        private System.Windows.Forms.PictureBox pb_3;
        private System.Windows.Forms.PictureBox pb_2;
        private System.Windows.Forms.PictureBox pb_4;
    }
}

