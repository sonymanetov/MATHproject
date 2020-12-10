namespace matesha228
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yt_Button5 = new KidFormApp.yt_Button();
            this.yt_Button4 = new KidFormApp.yt_Button();
            this.yt_Button3 = new KidFormApp.yt_Button();
            this.yt_Button2 = new KidFormApp.yt_Button();
            this.yt_Button1 = new KidFormApp.yt_Button();
            this.SuspendLayout();
            // 
            // yt_Button5
            // 
            this.yt_Button5.BackColor = System.Drawing.Color.GhostWhite;
            this.yt_Button5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button5.ForeColor = System.Drawing.Color.Black;
            this.yt_Button5.Location = new System.Drawing.Point(23, 18);
            this.yt_Button5.Name = "yt_Button5";
            this.yt_Button5.Rounding = 100;
            this.yt_Button5.RoundingEnable = true;
            this.yt_Button5.Size = new System.Drawing.Size(142, 57);
            this.yt_Button5.TabIndex = 4;
            this.yt_Button5.Text = "О программе";
            this.yt_Button5.UseVisualStyleBackColor = false;
            this.yt_Button5.Click += new System.EventHandler(this.yt_Button5_Click);
            // 
            // yt_Button4
            // 
            this.yt_Button4.BackColor = System.Drawing.Color.GhostWhite;
            this.yt_Button4.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button4.ForeColor = System.Drawing.Color.Black;
            this.yt_Button4.Location = new System.Drawing.Point(1021, 18);
            this.yt_Button4.Name = "yt_Button4";
            this.yt_Button4.Rounding = 100;
            this.yt_Button4.RoundingEnable = true;
            this.yt_Button4.Size = new System.Drawing.Size(149, 57);
            this.yt_Button4.TabIndex = 3;
            this.yt_Button4.Text = "Выход";
            this.yt_Button4.UseVisualStyleBackColor = false;
            this.yt_Button4.Click += new System.EventHandler(this.yt_Button4_Click);
            // 
            // yt_Button3
            // 
            this.yt_Button3.BackColor = System.Drawing.Color.GhostWhite;
            this.yt_Button3.Font = new System.Drawing.Font("Arial Unicode MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button3.ForeColor = System.Drawing.Color.Black;
            this.yt_Button3.Location = new System.Drawing.Point(-45, 165);
            this.yt_Button3.Name = "yt_Button3";
            this.yt_Button3.Rounding = 100;
            this.yt_Button3.RoundingEnable = true;
            this.yt_Button3.Size = new System.Drawing.Size(1270, 72);
            this.yt_Button3.TabIndex = 2;
            this.yt_Button3.Text = "   снежинка Коха";
            this.yt_Button3.UseVisualStyleBackColor = false;
            this.yt_Button3.Click += new System.EventHandler(this.yt_Button3_Click);
            // 
            // yt_Button2
            // 
            this.yt_Button2.BackColor = System.Drawing.Color.GhostWhite;
            this.yt_Button2.Font = new System.Drawing.Font("Arial Unicode MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button2.ForeColor = System.Drawing.Color.Black;
            this.yt_Button2.Location = new System.Drawing.Point(-19, 348);
            this.yt_Button2.Name = "yt_Button2";
            this.yt_Button2.Rounding = 100;
            this.yt_Button2.RoundingEnable = true;
            this.yt_Button2.Size = new System.Drawing.Size(1252, 76);
            this.yt_Button2.TabIndex = 1;
            this.yt_Button2.Text = "  авторское стихотворение";
            this.yt_Button2.UseVisualStyleBackColor = false;
            this.yt_Button2.Click += new System.EventHandler(this.yt_Button2_Click);
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.GhostWhite;
            this.yt_Button1.Font = new System.Drawing.Font("Arial Unicode MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button1.ForeColor = System.Drawing.Color.Black;
            this.yt_Button1.Location = new System.Drawing.Point(-19, 529);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.Rounding = 100;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(1302, 80);
            this.yt_Button1.TabIndex = 0;
            this.yt_Button1.Text = "математический кроссворд";
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.yt_Button5);
            this.Controls.Add(this.yt_Button4);
            this.Controls.Add(this.yt_Button3);
            this.Controls.Add(this.yt_Button2);
            this.Controls.Add(this.yt_Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Математическая снежинка";
            this.ResumeLayout(false);

        }

        #endregion

        private KidFormApp.yt_Button yt_Button1;
        private KidFormApp.yt_Button yt_Button2;
        private KidFormApp.yt_Button yt_Button3;
        private KidFormApp.yt_Button yt_Button4;
        private KidFormApp.yt_Button yt_Button5;
    }
}

