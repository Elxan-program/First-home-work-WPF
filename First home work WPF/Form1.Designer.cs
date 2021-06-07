
namespace First_home_work_WPF
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
            this.TimeText = new System.Windows.Forms.Label();
            this.Azerri_Time_Zone = new System.Windows.Forms.Button();
            this.England_Time_Zone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.Location = new System.Drawing.Point(359, 47);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(64, 17);
            this.TimeText.TabIndex = 0;
            this.TimeText.Text = "00:00:00";
            // 
            // Azerri_Time_Zone
            // 
            this.Azerri_Time_Zone.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Azerri_Time_Zone.Location = new System.Drawing.Point(181, 249);
            this.Azerri_Time_Zone.Name = "Azerri_Time_Zone";
            this.Azerri_Time_Zone.Size = new System.Drawing.Size(122, 95);
            this.Azerri_Time_Zone.TabIndex = 1;
            this.Azerri_Time_Zone.Text = "Azerbaijan";
            this.Azerri_Time_Zone.UseVisualStyleBackColor = true;
            this.Azerri_Time_Zone.Click += new System.EventHandler(this.Azerri_Time_Zone_Click);
            // 
            // England_Time_Zone
            // 
            this.England_Time_Zone.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Italic);
            this.England_Time_Zone.Location = new System.Drawing.Point(455, 249);
            this.England_Time_Zone.Name = "England_Time_Zone";
            this.England_Time_Zone.Size = new System.Drawing.Size(122, 95);
            this.England_Time_Zone.TabIndex = 2;
            this.England_Time_Zone.Text = "England";
            this.England_Time_Zone.UseVisualStyleBackColor = true;
            this.England_Time_Zone.Click += new System.EventHandler(this.England_Time_Zone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::First_home_work_WPF.Properties.Resources.Baku;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.England_Time_Zone);
            this.Controls.Add(this.Azerri_Time_Zone);
            this.Controls.Add(this.TimeText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.Button Azerri_Time_Zone;
        private System.Windows.Forms.Button England_Time_Zone;
    }
}

