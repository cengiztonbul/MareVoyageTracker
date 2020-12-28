namespace MarineData
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
			this.imoNumberInput = new System.Windows.Forms.RichTextBox();
			this.imoLabel = new System.Windows.Forms.Label();
			this.processButton = new System.Windows.Forms.Button();
			this.processPercentageLabel = new System.Windows.Forms.Label();
			this.firefoxLocationButton = new System.Windows.Forms.Button();
			this.saveLocationButton = new System.Windows.Forms.Button();
			this.logList = new System.Windows.Forms.ListBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.clearLog = new System.Windows.Forms.Button();
			this.clearImo = new System.Windows.Forms.Button();
			this.openSaveLocationButton = new System.Windows.Forms.Button();
			this.sleepTimeInput = new System.Windows.Forms.NumericUpDown();
			this.retryCountInput = new System.Windows.Forms.NumericUpDown();
			this.sleepTimeLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.sleepTimeInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.retryCountInput)).BeginInit();
			this.SuspendLayout();
			// 
			// imoNumberInput
			// 
			this.imoNumberInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.imoNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.imoNumberInput.DetectUrls = false;
			this.imoNumberInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.imoNumberInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.imoNumberInput.Location = new System.Drawing.Point(10, 37);
			this.imoNumberInput.Name = "imoNumberInput";
			this.imoNumberInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.imoNumberInput.Size = new System.Drawing.Size(83, 264);
			this.imoNumberInput.TabIndex = 0;
			this.imoNumberInput.Text = "";
			this.imoNumberInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imoNumberInput_KeyDown);
			// 
			// imoLabel
			// 
			this.imoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imoLabel.AutoSize = true;
			this.imoLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.imoLabel.Location = new System.Drawing.Point(2, 11);
			this.imoLabel.Name = "imoLabel";
			this.imoLabel.Size = new System.Drawing.Size(107, 17);
			this.imoLabel.TabIndex = 1;
			this.imoLabel.Text = "IMO Listesi";
			this.imoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// processButton
			// 
			this.processButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.processButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.processButton.Location = new System.Drawing.Point(99, 37);
			this.processButton.Name = "processButton";
			this.processButton.Size = new System.Drawing.Size(85, 29);
			this.processButton.TabIndex = 2;
			this.processButton.Text = "Verileri Al";
			this.processButton.UseVisualStyleBackColor = true;
			this.processButton.Click += new System.EventHandler(this.processButton_Click);
			// 
			// processPercentageLabel
			// 
			this.processPercentageLabel.AutoSize = true;
			this.processPercentageLabel.Location = new System.Drawing.Point(190, 45);
			this.processPercentageLabel.Name = "processPercentageLabel";
			this.processPercentageLabel.Size = new System.Drawing.Size(21, 14);
			this.processPercentageLabel.TabIndex = 3;
			this.processPercentageLabel.Text = "0%";
			// 
			// firefoxLocationButton
			// 
			this.firefoxLocationButton.Font = new System.Drawing.Font("Calibri", 9.25F);
			this.firefoxLocationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.firefoxLocationButton.Location = new System.Drawing.Point(420, 60);
			this.firefoxLocationButton.Name = "firefoxLocationButton";
			this.firefoxLocationButton.Size = new System.Drawing.Size(157, 29);
			this.firefoxLocationButton.TabIndex = 4;
			this.firefoxLocationButton.Text = "Firefox Konumunu Seç";
			this.firefoxLocationButton.UseVisualStyleBackColor = true;
			this.firefoxLocationButton.Click += new System.EventHandler(this.firefoxLocationButton_Click);
			// 
			// saveLocationButton
			// 
			this.saveLocationButton.Font = new System.Drawing.Font("Calibri", 9.25F);
			this.saveLocationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.saveLocationButton.Location = new System.Drawing.Point(420, 95);
			this.saveLocationButton.Name = "saveLocationButton";
			this.saveLocationButton.Size = new System.Drawing.Size(157, 29);
			this.saveLocationButton.TabIndex = 5;
			this.saveLocationButton.Text = "Kayıt Konumunu Seç";
			this.saveLocationButton.UseVisualStyleBackColor = true;
			this.saveLocationButton.Click += new System.EventHandler(this.saveLocationButton_Click);
			// 
			// logList
			// 
			this.logList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.logList.Font = new System.Drawing.Font("Courier New", 10F);
			this.logList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.logList.FormattingEnabled = true;
			this.logList.ItemHeight = 16;
			this.logList.Location = new System.Drawing.Point(104, 217);
			this.logList.Name = "logList";
			this.logList.Size = new System.Drawing.Size(473, 84);
			this.logList.TabIndex = 6;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
			this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("Calibri", 12F);
			this.closeButton.ForeColor = System.Drawing.Color.Snow;
			this.closeButton.Location = new System.Drawing.Point(549, 11);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(28, 30);
			this.closeButton.TabIndex = 7;
			this.closeButton.Text = "X";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// clearLog
			// 
			this.clearLog.Font = new System.Drawing.Font("Calibri", 9.25F);
			this.clearLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.clearLog.Location = new System.Drawing.Point(479, 188);
			this.clearLog.Name = "clearLog";
			this.clearLog.Size = new System.Drawing.Size(98, 23);
			this.clearLog.TabIndex = 8;
			this.clearLog.Text = "Log Temizle";
			this.clearLog.UseVisualStyleBackColor = true;
			this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
			// 
			// clearImo
			// 
			this.clearImo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.clearImo.FlatAppearance.BorderSize = 0;
			this.clearImo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearImo.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.clearImo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.clearImo.Location = new System.Drawing.Point(375, 188);
			this.clearImo.Name = "clearImo";
			this.clearImo.Size = new System.Drawing.Size(98, 23);
			this.clearImo.TabIndex = 9;
			this.clearImo.Text = "Imo Temizle";
			this.clearImo.UseVisualStyleBackColor = false;
			this.clearImo.Click += new System.EventHandler(this.clearImo_Click);
			// 
			// openSaveLocationButton
			// 
			this.openSaveLocationButton.Font = new System.Drawing.Font("Calibri", 9.25F);
			this.openSaveLocationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.openSaveLocationButton.Location = new System.Drawing.Point(420, 130);
			this.openSaveLocationButton.Name = "openSaveLocationButton";
			this.openSaveLocationButton.Size = new System.Drawing.Size(157, 29);
			this.openSaveLocationButton.TabIndex = 10;
			this.openSaveLocationButton.Text = "Kayıt Konumunu Aç";
			this.openSaveLocationButton.UseVisualStyleBackColor = true;
			this.openSaveLocationButton.Click += new System.EventHandler(this.openSaveLocation_Click);
			// 
			// sleepTimeInput
			// 
			this.sleepTimeInput.Location = new System.Drawing.Point(104, 162);
			this.sleepTimeInput.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
			this.sleepTimeInput.Name = "sleepTimeInput";
			this.sleepTimeInput.Size = new System.Drawing.Size(85, 20);
			this.sleepTimeInput.TabIndex = 12;
			this.sleepTimeInput.Value = global::MarineData.Properties.Settings.Default.sleepTime;
			// 
			// retryCountInput
			// 
			this.retryCountInput.Location = new System.Drawing.Point(104, 188);
			this.retryCountInput.Name = "retryCountInput";
			this.retryCountInput.Size = new System.Drawing.Size(85, 20);
			this.retryCountInput.TabIndex = 11;
			this.retryCountInput.Value = global::MarineData.Properties.Settings.Default.retryCount;
			// 
			// sleepTimeLabel
			// 
			this.sleepTimeLabel.AutoSize = true;
			this.sleepTimeLabel.Font = new System.Drawing.Font("Calibri", 9F);
			this.sleepTimeLabel.Location = new System.Drawing.Point(195, 168);
			this.sleepTimeLabel.Name = "sleepTimeLabel";
			this.sleepTimeLabel.Size = new System.Drawing.Size(97, 14);
			this.sleepTimeLabel.TabIndex = 13;
			this.sleepTimeLabel.Text = "Uyku Süresi (ms)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 9F);
			this.label1.Location = new System.Drawing.Point(195, 188);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 14);
			this.label1.TabIndex = 14;
			this.label1.Text = "Tekrar Deneme";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.ClientSize = new System.Drawing.Size(589, 316);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sleepTimeLabel);
			this.Controls.Add(this.sleepTimeInput);
			this.Controls.Add(this.retryCountInput);
			this.Controls.Add(this.openSaveLocationButton);
			this.Controls.Add(this.clearImo);
			this.Controls.Add(this.clearLog);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.logList);
			this.Controls.Add(this.saveLocationButton);
			this.Controls.Add(this.firefoxLocationButton);
			this.Controls.Add(this.processPercentageLabel);
			this.Controls.Add(this.processButton);
			this.Controls.Add(this.imoLabel);
			this.Controls.Add(this.imoNumberInput);
			this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "   ";
			((System.ComponentModel.ISupportInitialize)(this.sleepTimeInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.retryCountInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox imoNumberInput;
		private System.Windows.Forms.Label imoLabel;
		private System.Windows.Forms.Button processButton;
		private System.Windows.Forms.Label processPercentageLabel;
		private System.Windows.Forms.Button firefoxLocationButton;
		private System.Windows.Forms.Button saveLocationButton;
		private System.Windows.Forms.ListBox logList;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button clearLog;
		private System.Windows.Forms.Button clearImo;
		private System.Windows.Forms.Button openSaveLocationButton;
		private System.Windows.Forms.NumericUpDown retryCountInput;
		private System.Windows.Forms.NumericUpDown sleepTimeInput;
		private System.Windows.Forms.Label sleepTimeLabel;
		private System.Windows.Forms.Label label1;
	}
}

