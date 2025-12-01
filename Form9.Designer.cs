namespace UnAmigoMas
{
    partial class Form9
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMinV = new FontAwesome.Sharp.IconButton();
            this.btnMaxV = new FontAwesome.Sharp.IconButton();
            this.lblTituloHj = new System.Windows.Forms.Label();
            this.currentPage = new FontAwesome.Sharp.IconPictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnMinV);
            this.panel3.Controls.Add(this.btnMaxV);
            this.panel3.Controls.Add(this.lblTituloHj);
            this.panel3.Controls.Add(this.currentPage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1142, 75);
            this.panel3.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(1101, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 47);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnMinV
            // 
            this.btnMinV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinV.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMinV.FlatAppearance.BorderSize = 0;
            this.btnMinV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinV.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinV.IconColor = System.Drawing.Color.White;
            this.btnMinV.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinV.IconSize = 30;
            this.btnMinV.Location = new System.Drawing.Point(1018, 21);
            this.btnMinV.Name = "btnMinV";
            this.btnMinV.Size = new System.Drawing.Size(29, 47);
            this.btnMinV.TabIndex = 11;
            this.btnMinV.UseVisualStyleBackColor = false;
            // 
            // btnMaxV
            // 
            this.btnMaxV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxV.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMaxV.FlatAppearance.BorderSize = 0;
            this.btnMaxV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxV.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaxV.IconColor = System.Drawing.Color.White;
            this.btnMaxV.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaxV.IconSize = 30;
            this.btnMaxV.Location = new System.Drawing.Point(1057, 21);
            this.btnMaxV.Name = "btnMaxV";
            this.btnMaxV.Size = new System.Drawing.Size(34, 47);
            this.btnMaxV.TabIndex = 10;
            this.btnMaxV.UseVisualStyleBackColor = false;
            // 
            // lblTituloHj
            // 
            this.lblTituloHj.AutoSize = true;
            this.lblTituloHj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHj.ForeColor = System.Drawing.Color.White;
            this.lblTituloHj.Location = new System.Drawing.Point(78, 33);
            this.lblTituloHj.Name = "lblTituloHj";
            this.lblTituloHj.Size = new System.Drawing.Size(97, 20);
            this.lblTituloHj.TabIndex = 8;
            this.lblTituloHj.Text = "Conóceme";
            // 
            // currentPage
            // 
            this.currentPage.BackColor = System.Drawing.Color.Transparent;
            this.currentPage.IconChar = FontAwesome.Sharp.IconChar.Bone;
            this.currentPage.IconColor = System.Drawing.Color.White;
            this.currentPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentPage.IconSize = 40;
            this.currentPage.Location = new System.Drawing.Point(31, 22);
            this.currentPage.Name = "currentPage";
            this.currentPage.Size = new System.Drawing.Size(41, 40);
            this.currentPage.TabIndex = 7;
            this.currentPage.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 707);
            this.Controls.Add(this.panel3);
            this.Name = "Form9";
            this.Text = "Conoceme";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinV;
        private FontAwesome.Sharp.IconButton btnMaxV;
        private System.Windows.Forms.Label lblTituloHj;
        private FontAwesome.Sharp.IconPictureBox currentPage;
    }
}