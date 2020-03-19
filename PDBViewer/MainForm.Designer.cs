namespace PDBViewer
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
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.tspMain = new System.Windows.Forms.ToolStrip();
			this.stsMain = new System.Windows.Forms.StatusStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbOpen = new System.Windows.Forms.ToolStripButton();
			this.lstMain = new System.Windows.Forms.ListView();
			this.mnuMain.SuspendLayout();
			this.tspMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(800, 24);
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "menuStrip1";
			// 
			// tspMain
			// 
			this.tspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen});
			this.tspMain.Location = new System.Drawing.Point(0, 24);
			this.tspMain.Name = "tspMain";
			this.tspMain.Size = new System.Drawing.Size(800, 25);
			this.tspMain.TabIndex = 1;
			this.tspMain.Text = "toolStrip1";
			// 
			// stsMain
			// 
			this.stsMain.Location = new System.Drawing.Point(0, 428);
			this.stsMain.Name = "stsMain";
			this.stsMain.Size = new System.Drawing.Size(800, 22);
			this.stsMain.TabIndex = 2;
			this.stsMain.Text = "statusStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = global::PDBViewer.Properties.Resources.openHS;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// tsbOpen
			// 
			this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbOpen.Image = global::PDBViewer.Properties.Resources.openHS;
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(23, 22);
			this.tsbOpen.Text = "Open";
			this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
			// 
			// lstMain
			// 
			this.lstMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstMain.HideSelection = false;
			this.lstMain.Location = new System.Drawing.Point(0, 49);
			this.lstMain.Name = "lstMain";
			this.lstMain.Size = new System.Drawing.Size(800, 379);
			this.lstMain.TabIndex = 3;
			this.lstMain.UseCompatibleStateImageBehavior = false;
			this.lstMain.View = System.Windows.Forms.View.Details;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lstMain);
			this.Controls.Add(this.stsMain);
			this.Controls.Add(this.tspMain);
			this.Controls.Add(this.mnuMain);
			this.MainMenuStrip = this.mnuMain;
			this.Name = "MainForm";
			this.Text = "PDB Viewer";
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.tspMain.ResumeLayout(false);
			this.tspMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStrip tspMain;
		private System.Windows.Forms.ToolStripButton tsbOpen;
		private System.Windows.Forms.StatusStrip stsMain;
		private System.Windows.Forms.ListView lstMain;
	}
}

