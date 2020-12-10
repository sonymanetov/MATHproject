namespace matesha228
{
    partial class poetry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(poetry));
            this.yt_Button1 = new KidFormApp.yt_Button();
            this.SuspendLayout();
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.yt_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yt_Button1.Font = new System.Drawing.Font("Arial Unicode MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yt_Button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.yt_Button1.Location = new System.Drawing.Point(872, 82);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.Rounding = 100;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(102, 52);
            this.yt_Button1.TabIndex = 0;
            this.yt_Button1.Text = "В меню";
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // poetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 620);
            this.ControlBox = false;
            this.Controls.Add(this.yt_Button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "poetry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "poetry";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.poetry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private KidFormApp.yt_Button yt_Button1;
    }
}