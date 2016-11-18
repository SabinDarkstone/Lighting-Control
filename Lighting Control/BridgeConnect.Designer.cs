namespace Lighting_Control {
	partial class BridgeConnect {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
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
		private void InitializeComponent() {
			this.listboxBridgesFound = new System.Windows.Forms.ListBox();
			this.btnSearchAgain = new System.Windows.Forms.Button();
			this.btnRegisterApp = new System.Windows.Forms.Button();
			this.btnSelectBridge = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listboxBridgesFound
			// 
			this.listboxBridgesFound.FormattingEnabled = true;
			this.listboxBridgesFound.Location = new System.Drawing.Point(12, 12);
			this.listboxBridgesFound.Name = "listboxBridgesFound";
			this.listboxBridgesFound.Size = new System.Drawing.Size(176, 82);
			this.listboxBridgesFound.TabIndex = 0;
			this.listboxBridgesFound.SelectedIndexChanged += new System.EventHandler(this.listboxBridgesFound_SelectedIndexChanged);
			// 
			// btnSearchAgain
			// 
			this.btnSearchAgain.Location = new System.Drawing.Point(210, 12);
			this.btnSearchAgain.Name = "btnSearchAgain";
			this.btnSearchAgain.Size = new System.Drawing.Size(91, 23);
			this.btnSearchAgain.TabIndex = 1;
			this.btnSearchAgain.Text = "Search Again";
			this.btnSearchAgain.UseVisualStyleBackColor = true;
			this.btnSearchAgain.Click += new System.EventHandler(this.btnSearchAgain_Click);
			// 
			// btnRegisterApp
			// 
			this.btnRegisterApp.Location = new System.Drawing.Point(210, 41);
			this.btnRegisterApp.Name = "btnRegisterApp";
			this.btnRegisterApp.Size = new System.Drawing.Size(91, 23);
			this.btnRegisterApp.TabIndex = 2;
			this.btnRegisterApp.Text = "Register App";
			this.btnRegisterApp.UseVisualStyleBackColor = true;
			this.btnRegisterApp.Click += new System.EventHandler(this.btnRegisterApp_Click);
			// 
			// btnSelectBridge
			// 
			this.btnSelectBridge.Location = new System.Drawing.Point(210, 70);
			this.btnSelectBridge.Name = "btnSelectBridge";
			this.btnSelectBridge.Size = new System.Drawing.Size(91, 23);
			this.btnSelectBridge.TabIndex = 3;
			this.btnSelectBridge.Text = "Select Bridge";
			this.btnSelectBridge.UseVisualStyleBackColor = true;
			this.btnSelectBridge.Click += new System.EventHandler(this.btnSelectBridge_Click);
			// 
			// BridgeConnect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 106);
			this.Controls.Add(this.btnSelectBridge);
			this.Controls.Add(this.btnRegisterApp);
			this.Controls.Add(this.btnSearchAgain);
			this.Controls.Add(this.listboxBridgesFound);
			this.Name = "BridgeConnect";
			this.Text = "BridgeConnect";
			this.Load += new System.EventHandler(this.BridgeConnect_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listboxBridgesFound;
		private System.Windows.Forms.Button btnSearchAgain;
		private System.Windows.Forms.Button btnRegisterApp;
		private System.Windows.Forms.Button btnSelectBridge;
	}
}