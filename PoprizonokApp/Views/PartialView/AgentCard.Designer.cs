namespace PoprizonokApp.Views.PartialView
{
    partial class AgentCard
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
            this.TitleandTypeAgentLbl = new System.Windows.Forms.Label();
            this.SaleLbl = new System.Windows.Forms.Label();
            this.AgetPhoneLbl = new System.Windows.Forms.Label();
            this.AgentPriorityLbl = new System.Windows.Forms.Label();
            this.AgentDiscountLbl = new System.Windows.Forms.Label();
            this.AgentpictureBox = new System.Windows.Forms.PictureBox();
            this.IDLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgentpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleandTypeAgentLbl
            // 
            this.TitleandTypeAgentLbl.AutoSize = true;
            this.TitleandTypeAgentLbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleandTypeAgentLbl.Location = new System.Drawing.Point(353, 27);
            this.TitleandTypeAgentLbl.Name = "TitleandTypeAgentLbl";
            this.TitleandTypeAgentLbl.Size = new System.Drawing.Size(398, 38);
            this.TitleandTypeAgentLbl.TabIndex = 1;
            this.TitleandTypeAgentLbl.Text = "Тип | Наименование агента";
            // 
            // SaleLbl
            // 
            this.SaleLbl.AutoSize = true;
            this.SaleLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaleLbl.Location = new System.Drawing.Point(354, 81);
            this.SaleLbl.Name = "SaleLbl";
            this.SaleLbl.Size = new System.Drawing.Size(215, 33);
            this.SaleLbl.TabIndex = 2;
            this.SaleLbl.Text = "10 Продаж за год";
            // 
            // AgetPhoneLbl
            // 
            this.AgetPhoneLbl.AutoSize = true;
            this.AgetPhoneLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgetPhoneLbl.Location = new System.Drawing.Point(354, 127);
            this.AgetPhoneLbl.Name = "AgetPhoneLbl";
            this.AgetPhoneLbl.Size = new System.Drawing.Size(180, 33);
            this.AgetPhoneLbl.TabIndex = 3;
            this.AgetPhoneLbl.Text = "+7 111 111 11 11";
            // 
            // AgentPriorityLbl
            // 
            this.AgentPriorityLbl.AutoSize = true;
            this.AgentPriorityLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgentPriorityLbl.Location = new System.Drawing.Point(354, 174);
            this.AgentPriorityLbl.Name = "AgentPriorityLbl";
            this.AgentPriorityLbl.Size = new System.Drawing.Size(244, 33);
            this.AgentPriorityLbl.TabIndex = 4;
            this.AgentPriorityLbl.Text = "Приоритетность: 10";
            // 
            // AgentDiscountLbl
            // 
            this.AgentDiscountLbl.AutoSize = true;
            this.AgentDiscountLbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgentDiscountLbl.Location = new System.Drawing.Point(1224, 27);
            this.AgentDiscountLbl.Name = "AgentDiscountLbl";
            this.AgentDiscountLbl.Size = new System.Drawing.Size(71, 38);
            this.AgentDiscountLbl.TabIndex = 5;
            this.AgentDiscountLbl.Text = "10%";
            // 
            // AgentpictureBox
            // 
            this.AgentpictureBox.Image = global::PoprizonokApp.Properties.Resources.picture;
            this.AgentpictureBox.Location = new System.Drawing.Point(15, 13);
            this.AgentpictureBox.Name = "AgentpictureBox";
            this.AgentpictureBox.Size = new System.Drawing.Size(300, 226);
            this.AgentpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AgentpictureBox.TabIndex = 0;
            this.AgentpictureBox.TabStop = false;
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLbl.Location = new System.Drawing.Point(1297, 242);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(28, 15);
            this.IDLbl.TabIndex = 6;
            this.IDLbl.Text = "10%";
            this.IDLbl.Visible = false;
            // 
            // AgentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.AgentDiscountLbl);
            this.Controls.Add(this.AgentPriorityLbl);
            this.Controls.Add(this.AgetPhoneLbl);
            this.Controls.Add(this.SaleLbl);
            this.Controls.Add(this.TitleandTypeAgentLbl);
            this.Controls.Add(this.AgentpictureBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(1324, 257);
            ((System.ComponentModel.ISupportInitialize)(this.AgentpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AgentpictureBox;
        private System.Windows.Forms.Label TitleandTypeAgentLbl;
        private System.Windows.Forms.Label SaleLbl;
        private System.Windows.Forms.Label AgetPhoneLbl;
        private System.Windows.Forms.Label AgentPriorityLbl;
        private System.Windows.Forms.Label AgentDiscountLbl;
        public System.Windows.Forms.Label IDLbl;
    }
}
