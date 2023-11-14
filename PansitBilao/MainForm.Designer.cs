namespace PansitBilao
{
    partial class MainForm
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
            this.dineBtn = new System.Windows.Forms.Button();
            this.takeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dineBtn
            // 
            this.dineBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dineBtn.Location = new System.Drawing.Point(202, 338);
            this.dineBtn.Name = "dineBtn";
            this.dineBtn.Size = new System.Drawing.Size(146, 67);
            this.dineBtn.TabIndex = 1;
            this.dineBtn.Text = "DINE IN";
            this.dineBtn.UseVisualStyleBackColor = true;
            this.dineBtn.Click += new System.EventHandler(this.dineBtn_Click);
            // 
            // takeBtn
            // 
            this.takeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.takeBtn.Location = new System.Drawing.Point(558, 338);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(146, 67);
            this.takeBtn.TabIndex = 2;
            this.takeBtn.Text = "TAKE OUT";
            this.takeBtn.UseVisualStyleBackColor = true;
            this.takeBtn.Click += new System.EventHandler(this.takeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PansitBilao.Properties.Resources.pansitLogo;
            this.pictureBox1.Location = new System.Drawing.Point(325, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 517);
            this.Controls.Add(this.takeBtn);
            this.Controls.Add(this.dineBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dineBtn;
        private System.Windows.Forms.Button takeBtn;
    }
}