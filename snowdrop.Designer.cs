namespace matesha228
{
    partial class snowdrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snowdrop));
            this.yt_Button1 = new KidFormApp.yt_Button();
            this.SuspendLayout();
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.yt_Button1.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(1063, 77);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.Rounding = 100;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(107, 52);
            this.yt_Button1.TabIndex = 0;
            this.yt_Button1.Text = "В меню";
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // snowdrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.yt_Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "snowdrop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "snowdrop";
            this.ResumeLayout(false);

        }

        #endregion

        private KidFormApp.yt_Button yt_Button1;
    }
}