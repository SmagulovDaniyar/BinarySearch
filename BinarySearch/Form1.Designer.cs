
namespace BinarySearch
{
    partial class MyForm
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
            this.InputNumber = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputNumber
            // 
            this.InputNumber.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputNumber.Location = new System.Drawing.Point(311, 74);
            this.InputNumber.MaxLength = 2;
            this.InputNumber.Name = "InputNumber";
            this.InputNumber.Size = new System.Drawing.Size(100, 23);
            this.InputNumber.TabIndex = 0;
            this.InputNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputNumber_KeyPress);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLabel.Location = new System.Drawing.Point(12, 70);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(285, 28);
            this.InputLabel.TabIndex = 1;
            this.InputLabel.Text = "Введите искомое число";
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Execute.Location = new System.Drawing.Point(426, 50);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(166, 67);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Найти";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 153);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputNumber);
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BinarySearch";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputNumber;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Button Execute;
    }
}

