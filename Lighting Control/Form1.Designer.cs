namespace Lighting_Control {
	partial class Form1 {
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
			this.button1 = new System.Windows.Forms.Button();
			this.groupBoxLighting = new System.Windows.Forms.GroupBox();
			this.listboxRooms = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listboxLights = new System.Windows.Forms.ListBox();
			this.btnUpdateLights = new System.Windows.Forms.Button();
			this.btnChangeColor = new System.Windows.Forms.Button();
			this.groupBoxLighting.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(34, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Search For Bridges";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBoxLighting
			// 
			this.groupBoxLighting.Controls.Add(this.label2);
			this.groupBoxLighting.Controls.Add(this.listboxLights);
			this.groupBoxLighting.Controls.Add(this.label1);
			this.groupBoxLighting.Controls.Add(this.listboxRooms);
			this.groupBoxLighting.Location = new System.Drawing.Point(51, 103);
			this.groupBoxLighting.Name = "groupBoxLighting";
			this.groupBoxLighting.Size = new System.Drawing.Size(374, 154);
			this.groupBoxLighting.TabIndex = 1;
			this.groupBoxLighting.TabStop = false;
			this.groupBoxLighting.Text = "Light Assignments";
			// 
			// listboxRooms
			// 
			this.listboxRooms.FormattingEnabled = true;
			this.listboxRooms.Location = new System.Drawing.Point(20, 39);
			this.listboxRooms.Name = "listboxRooms";
			this.listboxRooms.Size = new System.Drawing.Size(155, 95);
			this.listboxRooms.TabIndex = 0;
			this.listboxRooms.SelectedIndexChanged += new System.EventHandler(this.listboxRooms_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Rooms";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(195, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Lights";
			// 
			// listboxLights
			// 
			this.listboxLights.FormattingEnabled = true;
			this.listboxLights.Location = new System.Drawing.Point(198, 39);
			this.listboxLights.Name = "listboxLights";
			this.listboxLights.Size = new System.Drawing.Size(155, 95);
			this.listboxLights.TabIndex = 2;
			// 
			// btnUpdateLights
			// 
			this.btnUpdateLights.Location = new System.Drawing.Point(34, 56);
			this.btnUpdateLights.Name = "btnUpdateLights";
			this.btnUpdateLights.Size = new System.Drawing.Size(94, 23);
			this.btnUpdateLights.TabIndex = 2;
			this.btnUpdateLights.Text = "Update Lights";
			this.btnUpdateLights.UseVisualStyleBackColor = true;
			this.btnUpdateLights.Click += new System.EventHandler(this.btnUpdateLights_Click);
			// 
			// btnChangeColor
			// 
			this.btnChangeColor.Location = new System.Drawing.Point(270, 27);
			this.btnChangeColor.Name = "btnChangeColor";
			this.btnChangeColor.Size = new System.Drawing.Size(95, 23);
			this.btnChangeColor.TabIndex = 3;
			this.btnChangeColor.Text = "Change Color";
			this.btnChangeColor.UseVisualStyleBackColor = true;
			this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 408);
			this.Controls.Add(this.btnChangeColor);
			this.Controls.Add(this.btnUpdateLights);
			this.Controls.Add(this.groupBoxLighting);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBoxLighting.ResumeLayout(false);
			this.groupBoxLighting.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBoxLighting;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listboxLights;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listboxRooms;
		private System.Windows.Forms.Button btnUpdateLights;
		private System.Windows.Forms.Button btnChangeColor;
	}
}

