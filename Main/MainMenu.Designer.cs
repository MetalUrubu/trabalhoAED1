/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 08/10/2019
 * Time: 14:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Main
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button nGame;
		private System.Windows.Forms.Button load;
		private System.Windows.Forms.Button exit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.nGame = new System.Windows.Forms.Button();
			this.load = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nGame
			// 
			this.nGame.Location = new System.Drawing.Point(100, 12);
			this.nGame.Name = "nGame";
			this.nGame.Size = new System.Drawing.Size(75, 23);
			this.nGame.TabIndex = 0;
			this.nGame.Text = "New Game";
			this.nGame.UseVisualStyleBackColor = true;
			this.nGame.Click += new System.EventHandler(this.NGameClick);
			// 
			// load
			// 
			this.load.Location = new System.Drawing.Point(100, 41);
			this.load.Name = "load";
			this.load.Size = new System.Drawing.Size(75, 23);
			this.load.TabIndex = 1;
			this.load.Text = "Load";
			this.load.UseVisualStyleBackColor = true;
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(100, 70);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(75, 23);
			this.exit.TabIndex = 2;
			this.exit.Text = "Exit";
			this.exit.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.load);
			this.Controls.Add(this.nGame);
			this.Name = "MainForm";
			this.Text = "Main";
			this.ResumeLayout(false);

		}
	}
}
