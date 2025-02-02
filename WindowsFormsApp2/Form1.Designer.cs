namespace WindowsFormsApp2
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
            this.BtChange = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.txtWindowTitle = new System.Windows.Forms.TextBox();
            this.txtNewTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtChange
            // 
            this.BtChange.Location = new System.Drawing.Point(53, 201);
            this.BtChange.Name = "BtChange";
            this.BtChange.Size = new System.Drawing.Size(75, 23);
            this.BtChange.TabIndex = 0;
            this.BtChange.Text = "Change";
            this.BtChange.UseVisualStyleBackColor = true;
            this.BtChange.Click += new System.EventHandler(this.BtChange_Click);
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(204, 201);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(75, 23);
            this.BtClose.TabIndex = 1;
            this.BtClose.Text = "Close";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // txtWindowTitle
            // 
            this.txtWindowTitle.Location = new System.Drawing.Point(53, 76);
            this.txtWindowTitle.Name = "txtWindowTitle";
            this.txtWindowTitle.Size = new System.Drawing.Size(100, 22);
            this.txtWindowTitle.TabIndex = 2;
            // 
            // txtNewTitle
            // 
            this.txtNewTitle.Location = new System.Drawing.Point(204, 76);
            this.txtNewTitle.Name = "txtNewTitle";
            this.txtNewTitle.Size = new System.Drawing.Size(100, 22);
            this.txtNewTitle.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNewTitle);
            this.Controls.Add(this.txtWindowTitle);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.BtChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtChange;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.TextBox txtWindowTitle;
        private System.Windows.Forms.TextBox txtNewTitle;
    }
}

