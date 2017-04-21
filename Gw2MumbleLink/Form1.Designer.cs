namespace Gw2MumbleLink {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.checkUpdate = new System.Windows.Forms.CheckBox();
			this.txtInfo = new System.Windows.Forms.TextBox();
			this.checkAlwaysOnTop = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// checkUpdate
			// 
			this.checkUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkUpdate.AutoSize = true;
			this.checkUpdate.Checked = true;
			this.checkUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkUpdate.Location = new System.Drawing.Point(3, 413);
			this.checkUpdate.Name = "checkUpdate";
			this.checkUpdate.Size = new System.Drawing.Size(123, 17);
			this.checkUpdate.TabIndex = 0;
			this.checkUpdate.Text = "Update Every Frame";
			this.checkUpdate.UseVisualStyleBackColor = true;
			this.checkUpdate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// txtInfo
			// 
			this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtInfo.Location = new System.Drawing.Point(12, 12);
			this.txtInfo.Multiline = true;
			this.txtInfo.Name = "txtInfo";
			this.txtInfo.ReadOnly = true;
			this.txtInfo.Size = new System.Drawing.Size(463, 385);
			this.txtInfo.TabIndex = 2;
			// 
			// checkAlwaysOnTop
			// 
			this.checkAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkAlwaysOnTop.AutoSize = true;
			this.checkAlwaysOnTop.Location = new System.Drawing.Point(147, 413);
			this.checkAlwaysOnTop.Name = "checkAlwaysOnTop";
			this.checkAlwaysOnTop.Size = new System.Drawing.Size(96, 17);
			this.checkAlwaysOnTop.TabIndex = 3;
			this.checkAlwaysOnTop.Text = "Always on Top";
			this.checkAlwaysOnTop.UseVisualStyleBackColor = true;
			this.checkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkAlwaysOnTop_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 433);
			this.Controls.Add(this.checkAlwaysOnTop);
			this.Controls.Add(this.txtInfo);
			this.Controls.Add(this.checkUpdate);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Gw2 Mumbe Link";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkUpdate;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.CheckBox checkAlwaysOnTop;
    }
}

