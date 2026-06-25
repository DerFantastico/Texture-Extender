namespace Texture_Extender
{
    partial class frmTextureExtender
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnChooseImage = new Button();
            tbxWidth = new TextBox();
            tbxHeight = new TextBox();
            lblWidth = new Label();
            lblHeight = new Label();
            btnSaveImage = new Button();
            btnWidthPlus = new Button();
            btnWidthMinus = new Button();
            btnHeightMinus = new Button();
            btnHeightPlus = new Button();
            SuspendLayout();
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(12, 12);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(123, 33);
            btnChooseImage.TabIndex = 0;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // tbxWidth
            // 
            tbxWidth.Location = new Point(12, 82);
            tbxWidth.Name = "tbxWidth";
            tbxWidth.Size = new Size(123, 23);
            tbxWidth.TabIndex = 1;
            tbxWidth.Text = "1";
            // 
            // tbxHeight
            // 
            tbxHeight.Location = new Point(12, 141);
            tbxHeight.Name = "tbxHeight";
            tbxHeight.Size = new Size(123, 23);
            tbxHeight.TabIndex = 2;
            tbxHeight.Text = "1";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(12, 64);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(39, 15);
            lblWidth.TabIndex = 3;
            lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(12, 123);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 15);
            lblHeight.TabIndex = 4;
            lblHeight.Text = "Height";
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new Point(12, 191);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(123, 33);
            btnSaveImage.TabIndex = 5;
            btnSaveImage.Text = "Save Iamge";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // btnWidthPlus
            // 
            btnWidthPlus.Location = new Point(141, 82);
            btnWidthPlus.Name = "btnWidthPlus";
            btnWidthPlus.Size = new Size(23, 23);
            btnWidthPlus.TabIndex = 6;
            btnWidthPlus.Text = "+";
            btnWidthPlus.UseVisualStyleBackColor = true;
            btnWidthPlus.Click += btnWidthPlus_Click;
            // 
            // btnWidthMinus
            // 
            btnWidthMinus.Location = new Point(170, 82);
            btnWidthMinus.Name = "btnWidthMinus";
            btnWidthMinus.Size = new Size(23, 23);
            btnWidthMinus.TabIndex = 7;
            btnWidthMinus.Text = "-";
            btnWidthMinus.UseVisualStyleBackColor = true;
            btnWidthMinus.Click += btnWidthMinus_Click;
            // 
            // btnHeightMinus
            // 
            btnHeightMinus.Location = new Point(170, 141);
            btnHeightMinus.Name = "btnHeightMinus";
            btnHeightMinus.Size = new Size(23, 23);
            btnHeightMinus.TabIndex = 9;
            btnHeightMinus.Text = "-";
            btnHeightMinus.UseVisualStyleBackColor = true;
            btnHeightMinus.Click += btnHeightMinus_Click;
            // 
            // btnHeightPlus
            // 
            btnHeightPlus.Location = new Point(141, 141);
            btnHeightPlus.Name = "btnHeightPlus";
            btnHeightPlus.Size = new Size(23, 23);
            btnHeightPlus.TabIndex = 8;
            btnHeightPlus.Text = "+";
            btnHeightPlus.UseVisualStyleBackColor = true;
            btnHeightPlus.Click += btnHeightPlus_Click;
            // 
            // frmTextureExtender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHeightMinus);
            Controls.Add(btnHeightPlus);
            Controls.Add(btnWidthMinus);
            Controls.Add(btnWidthPlus);
            Controls.Add(btnSaveImage);
            Controls.Add(lblHeight);
            Controls.Add(lblWidth);
            Controls.Add(tbxHeight);
            Controls.Add(tbxWidth);
            Controls.Add(btnChooseImage);
            Name = "frmTextureExtender";
            Text = "Texture Extender";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChooseImage;
        private TextBox tbxWidth;
        private TextBox tbxHeight;
        private Label lblWidth;
        private Label lblHeight;
        private Button btnSaveImage;
        private Button btnWidthPlus;
        private Button btnWidthMinus;
        private Button btnHeightMinus;
        private Button btnHeightPlus;
    }
}
