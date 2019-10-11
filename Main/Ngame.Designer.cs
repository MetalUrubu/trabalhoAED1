/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 09/10/2019
 * Time: 14:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Main
{
	partial class Ngame
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Submit;
		private System.Windows.Forms.ComboBox Racas;
		private System.Windows.Forms.ComboBox Classes;
		private System.Windows.Forms.TextBox Nome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			this.Submit = new System.Windows.Forms.Button();
			this.Racas = new System.Windows.Forms.ComboBox();
			this.Classes = new System.Windows.Forms.ComboBox();
			this.Nome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Submit
			// 
			this.Submit.Location = new System.Drawing.Point(245, 277);
			this.Submit.Name = "Submit";
			this.Submit.Size = new System.Drawing.Size(75, 23);
			this.Submit.TabIndex = 0;
			this.Submit.Text = "Submit";
			this.Submit.UseVisualStyleBackColor = true;
			this.Submit.Click += new System.EventHandler(this.SubmitClick);
			// 
			// Racas
			// 
			this.Racas.FormattingEnabled = true;
			this.Racas.Items.AddRange(new object[] {
			"Troll",
			"Humano",
			"Tritão",
			"Elfo"});
			this.Racas.Location = new System.Drawing.Point(12, 141);
			this.Racas.Name = "Racas";
			this.Racas.Size = new System.Drawing.Size(121, 21);
			this.Racas.TabIndex = 1;
			this.Racas.SelectedIndexChanged += new System.EventHandler(this.RacasSelectedIndexChanged);
			// 
			// Classes
			// 
			this.Classes.FormattingEnabled = true;
			this.Classes.Items.AddRange(new object[] {
			"Mage",
			"Warrior",
			"Archery",
			"Thief"});
			this.Classes.Location = new System.Drawing.Point(199, 141);
			this.Classes.Name = "Classes";
			this.Classes.Size = new System.Drawing.Size(121, 21);
			this.Classes.TabIndex = 2;
			this.Classes.SelectedIndexChanged += new System.EventHandler(this.ClassesSelectedIndexChanged);
			// 
			// Nome
			// 
			this.Nome.Location = new System.Drawing.Point(12, 92);
			this.Nome.Name = "Nome";
			this.Nome.Size = new System.Drawing.Size(308, 20);
			this.Nome.TabIndex = 3;
			this.Nome.TextChanged += new System.EventHandler(this.NomeTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(112, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nome";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Raças";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(199, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Classes";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// Ngame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 312);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Nome);
			this.Controls.Add(this.Classes);
			this.Controls.Add(this.Racas);
			this.Controls.Add(this.Submit);
			this.Name = "Ngame";
			this.Text = "Ngame";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
