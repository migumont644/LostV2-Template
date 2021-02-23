namespace LostV2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.redImage = new System.Windows.Forms.PictureBox();
            this.sceneImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(24, 28);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(339, 65);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "You are lost in a forest";
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(67, 313);
            this.redLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(257, 23);
            this.redLabel.TabIndex = 3;
            this.redLabel.Text = "North";
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(67, 349);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(257, 23);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Text = "South";
            // 
            // blueImage
            // 
            this.blueImage.Image = global::LostV2.Properties.Resources.blue_50x50;
            this.blueImage.Location = new System.Drawing.Point(24, 339);
            this.blueImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(39, 32);
            this.blueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueImage.TabIndex = 1;
            this.blueImage.TabStop = false;
            // 
            // redImage
            // 
            this.redImage.Image = global::LostV2.Properties.Resources.red_50x50;
            this.redImage.Location = new System.Drawing.Point(24, 303);
            this.redImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(39, 32);
            this.redImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redImage.TabIndex = 0;
            this.redImage.TabStop = false;
            // 
            // sceneImage
            // 
            this.sceneImage.BackgroundImage = global::LostV2.Properties.Resources.deepBrush;
            this.sceneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sceneImage.Location = new System.Drawing.Point(27, 83);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(336, 198);
            this.sceneImage.TabIndex = 5;
            this.sceneImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 422);
            this.Controls.Add(this.sceneImage);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.redImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost in a Forest";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redImage;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.PictureBox sceneImage;
    }
}

