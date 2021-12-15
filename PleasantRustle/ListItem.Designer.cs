
namespace PleasantRustle
{
    partial class ListItem
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Type1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameAgent1 = new System.Windows.Forms.Label();
            this.CountSail1 = new System.Windows.Forms.Label();
            this.NomebrPhone1 = new System.Windows.Forms.Label();
            this.Priority1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Type1
            // 
            this.Type1.AutoSize = true;
            this.Type1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type1.Location = new System.Drawing.Point(251, 19);
            this.Type1.Name = "Type1";
            this.Type1.Size = new System.Drawing.Size(63, 24);
            this.Type1.TabIndex = 1;
            this.Type1.Text = "Type1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(314, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "|";
            // 
            // NameAgent1
            // 
            this.NameAgent1.AutoSize = true;
            this.NameAgent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAgent1.Location = new System.Drawing.Point(352, 19);
            this.NameAgent1.Name = "NameAgent1";
            this.NameAgent1.Size = new System.Drawing.Size(113, 24);
            this.NameAgent1.TabIndex = 3;
            this.NameAgent1.Text = "Name agent";
            // 
            // CountSail1
            // 
            this.CountSail1.AutoSize = true;
            this.CountSail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountSail1.Location = new System.Drawing.Point(251, 67);
            this.CountSail1.Name = "CountSail1";
            this.CountSail1.Size = new System.Drawing.Size(91, 24);
            this.CountSail1.TabIndex = 4;
            this.CountSail1.Text = "Coun Sail";
            // 
            // NomebrPhone1
            // 
            this.NomebrPhone1.AutoSize = true;
            this.NomebrPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NomebrPhone1.Location = new System.Drawing.Point(251, 104);
            this.NomebrPhone1.Name = "NomebrPhone1";
            this.NomebrPhone1.Size = new System.Drawing.Size(124, 24);
            this.NomebrPhone1.TabIndex = 5;
            this.NomebrPhone1.Text = "Nober Phone";
            // 
            // Priority1
            // 
            this.Priority1.AutoSize = true;
            this.Priority1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Priority1.Location = new System.Drawing.Point(254, 139);
            this.Priority1.Name = "Priority1";
            this.Priority1.Size = new System.Drawing.Size(71, 24);
            this.Priority1.TabIndex = 6;
            this.Priority1.Text = "Pryority";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Priority1);
            this.Controls.Add(this.NomebrPhone1);
            this.Controls.Add(this.CountSail1);
            this.Controls.Add(this.NameAgent1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Type1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(741, 196);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Type1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameAgent1;
        private System.Windows.Forms.Label CountSail1;
        private System.Windows.Forms.Label NomebrPhone1;
        private System.Windows.Forms.Label Priority1;
    }
}
