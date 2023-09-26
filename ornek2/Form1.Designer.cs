namespace ornek2
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
            this.btnGalatasaray = new System.Windows.Forms.Button();
            this.btnTrabzon = new System.Windows.Forms.Button();
            this.btnBeşiktaş = new System.Windows.Forms.Button();
            this.lblTakım = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGalatasaray
            // 
            this.btnGalatasaray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGalatasaray.Location = new System.Drawing.Point(52, 32);
            this.btnGalatasaray.Name = "btnGalatasaray";
            this.btnGalatasaray.Size = new System.Drawing.Size(119, 49);
            this.btnGalatasaray.TabIndex = 0;
            this.btnGalatasaray.Text = "Galatasaray";
            this.btnGalatasaray.UseVisualStyleBackColor = true;
            this.btnGalatasaray.Click += new System.EventHandler(this.btnGalatasaray_Click);
            // 
            // btnTrabzon
            // 
            this.btnTrabzon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrabzon.Location = new System.Drawing.Point(52, 98);
            this.btnTrabzon.Name = "btnTrabzon";
            this.btnTrabzon.Size = new System.Drawing.Size(119, 49);
            this.btnTrabzon.TabIndex = 1;
            this.btnTrabzon.Text = "Trabzonspor";
            this.btnTrabzon.UseVisualStyleBackColor = true;
            this.btnTrabzon.Click += new System.EventHandler(this.btnTrabzon_Click);
            // 
            // btnBeşiktaş
            // 
            this.btnBeşiktaş.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeşiktaş.Location = new System.Drawing.Point(52, 163);
            this.btnBeşiktaş.Name = "btnBeşiktaş";
            this.btnBeşiktaş.Size = new System.Drawing.Size(119, 49);
            this.btnBeşiktaş.TabIndex = 2;
            this.btnBeşiktaş.Text = "Beşiktaş";
            this.btnBeşiktaş.UseVisualStyleBackColor = true;
            this.btnBeşiktaş.Click += new System.EventHandler(this.btnBeşiktaş_Click);
            // 
            // lblTakım
            // 
            this.lblTakım.AutoSize = true;
            this.lblTakım.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakım.Location = new System.Drawing.Point(272, 108);
            this.lblTakım.Name = "lblTakım";
            this.lblTakım.Size = new System.Drawing.Size(118, 39);
            this.lblTakım.TabIndex = 3;
            this.lblTakım.Text = "Takım";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTakım);
            this.Controls.Add(this.btnBeşiktaş);
            this.Controls.Add(this.btnTrabzon);
            this.Controls.Add(this.btnGalatasaray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGalatasaray;
        private System.Windows.Forms.Button btnTrabzon;
        private System.Windows.Forms.Button btnBeşiktaş;
        private System.Windows.Forms.Label lblTakım;
    }
}

