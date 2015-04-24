namespace ApplicationVerstionSample
{
    partial class frmMain
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
            this.lVersion = new System.Windows.Forms.Label();
            this.lVersionValue = new System.Windows.Forms.Label();
            this.lBuildOn = new System.Windows.Forms.Label();
            this.lBuildOnValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVersion.Location = new System.Drawing.Point(12, 23);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(147, 24);
            this.lVersion.TabIndex = 0;
            this.lVersion.Text = "Current Version:";
            // 
            // lVersionValue
            // 
            this.lVersionValue.AutoSize = true;
            this.lVersionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVersionValue.ForeColor = System.Drawing.Color.Blue;
            this.lVersionValue.Location = new System.Drawing.Point(166, 22);
            this.lVersionValue.Name = "lVersionValue";
            this.lVersionValue.Size = new System.Drawing.Size(0, 25);
            this.lVersionValue.TabIndex = 1;
            // 
            // lBuildOn
            // 
            this.lBuildOn.AutoSize = true;
            this.lBuildOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBuildOn.Location = new System.Drawing.Point(11, 64);
            this.lBuildOn.Name = "lBuildOn";
            this.lBuildOn.Size = new System.Drawing.Size(100, 25);
            this.lBuildOn.TabIndex = 2;
            this.lBuildOn.Text = "Build On:";
            // 
            // lBuildOnValue
            // 
            this.lBuildOnValue.AutoSize = true;
            this.lBuildOnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBuildOnValue.ForeColor = System.Drawing.Color.Blue;
            this.lBuildOnValue.Location = new System.Drawing.Point(166, 64);
            this.lBuildOnValue.Name = "lBuildOnValue";
            this.lBuildOnValue.Size = new System.Drawing.Size(0, 25);
            this.lBuildOnValue.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 118);
            this.Controls.Add(this.lBuildOnValue);
            this.Controls.Add(this.lBuildOn);
            this.Controls.Add(this.lVersionValue);
            this.Controls.Add(this.lVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Application Version Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Label lVersionValue;
        private System.Windows.Forms.Label lBuildOn;
        private System.Windows.Forms.Label lBuildOnValue;
    }
}

