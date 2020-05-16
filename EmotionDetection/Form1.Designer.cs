namespace EmotionDetection
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
            this.button1 = new System.Windows.Forms.Button();
            this.fear_btn = new System.Windows.Forms.Button();
            this.happy_btn = new System.Windows.Forms.Button();
            this.disgusted_btn = new System.Windows.Forms.Button();
            this.picArea = new System.Windows.Forms.PictureBox();
            this.response = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "angry_btn";
            this.button1.BackgroundImage = global::EmotionDetection.Properties.Resources.anrgy_icon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(132, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 153);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.angry_btn_Click);
            // 
            // fear_btn
            // 
            this.fear_btn.BackgroundImage = global::EmotionDetection.Properties.Resources.fear_icon;
            this.fear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fear_btn.Location = new System.Drawing.Point(368, 547);
            this.fear_btn.Name = "fear_btn";
            this.fear_btn.Size = new System.Drawing.Size(99, 153);
            this.fear_btn.TabIndex = 1;
            this.fear_btn.UseVisualStyleBackColor = true;
            this.fear_btn.Click += new System.EventHandler(this.fear_btn_Click);
            // 
            // happy_btn
            // 
            this.happy_btn.BackgroundImage = global::EmotionDetection.Properties.Resources.happy_icon;
            this.happy_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.happy_btn.Location = new System.Drawing.Point(496, 547);
            this.happy_btn.Name = "happy_btn";
            this.happy_btn.Size = new System.Drawing.Size(251, 153);
            this.happy_btn.TabIndex = 2;
            this.happy_btn.UseVisualStyleBackColor = true;
            this.happy_btn.Click += new System.EventHandler(this.happy_btn_Click);
            // 
            // disgusted_btn
            // 
            this.disgusted_btn.BackgroundImage = global::EmotionDetection.Properties.Resources.disgusted_icon;
            this.disgusted_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disgusted_btn.Location = new System.Drawing.Point(781, 547);
            this.disgusted_btn.Name = "disgusted_btn";
            this.disgusted_btn.Size = new System.Drawing.Size(114, 153);
            this.disgusted_btn.TabIndex = 3;
            this.disgusted_btn.UseVisualStyleBackColor = true;
            this.disgusted_btn.Click += new System.EventHandler(this.disgusted_btn_Click);
            // 
            // picArea
            // 
            this.picArea.Image = global::EmotionDetection.Properties.Resources.anrgy1;
            this.picArea.Location = new System.Drawing.Point(132, 27);
            this.picArea.Name = "picArea";
            this.picArea.Size = new System.Drawing.Size(763, 504);
            this.picArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picArea.TabIndex = 4;
            this.picArea.TabStop = false;
            // 
            // response
            // 
            this.response.BackColor = System.Drawing.SystemColors.MenuBar;
            this.response.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.response.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.response.HideSelection = false;
            this.response.Location = new System.Drawing.Point(947, 27);
            this.response.Margin = new System.Windows.Forms.Padding(10);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(304, 504);
            this.response.TabIndex = 5;
            this.response.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.response);
            this.Controls.Add(this.picArea);
            this.Controls.Add(this.disgusted_btn);
            this.Controls.Add(this.happy_btn);
            this.Controls.Add(this.fear_btn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Emotion Detection";
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button fear_btn;
        private System.Windows.Forms.Button happy_btn;
        private System.Windows.Forms.Button disgusted_btn;
        private System.Windows.Forms.PictureBox picArea;
        private System.Windows.Forms.RichTextBox response;
    }
}

