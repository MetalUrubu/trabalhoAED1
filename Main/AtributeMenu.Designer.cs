
namespace Main
{
	partial class AtributeMenu
	{

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label Classe;
		private System.Windows.Forms.Label StrLabel;
		private System.Windows.Forms.Label AgiLabel;
		private System.Windows.Forms.Label IntLabel;
		private System.Windows.Forms.Button Submit;
		private System.Windows.Forms.Label Pontos;
		private System.Windows.Forms.Label PontosNum;
		private System.Windows.Forms.Button StrMin;
		private System.Windows.Forms.Button StrPlus;
		private System.Windows.Forms.Label StrNum;
		private System.Windows.Forms.Label AgiNum;
		private System.Windows.Forms.Label IntNum;
		private System.Windows.Forms.Button AgiPlus;
		private System.Windows.Forms.Button AgiMin;
		private System.Windows.Forms.Button IntPlus;
		private System.Windows.Forms.Button IntMin;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.Classe = new System.Windows.Forms.Label();
			this.StrLabel = new System.Windows.Forms.Label();
			this.AgiLabel = new System.Windows.Forms.Label();
			this.IntLabel = new System.Windows.Forms.Label();
			this.Submit = new System.Windows.Forms.Button();
			this.Pontos = new System.Windows.Forms.Label();
			this.PontosNum = new System.Windows.Forms.Label();
			this.StrMin = new System.Windows.Forms.Button();
			this.StrPlus = new System.Windows.Forms.Button();
			this.StrNum = new System.Windows.Forms.Label();
			this.AgiNum = new System.Windows.Forms.Label();
			this.IntNum = new System.Windows.Forms.Label();
			this.AgiPlus = new System.Windows.Forms.Button();
			this.AgiMin = new System.Windows.Forms.Button();
			this.IntPlus = new System.Windows.Forms.Button();
			this.IntMin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Classe
			// 
			this.Classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Classe.Location = new System.Drawing.Point(93, 9);
			this.Classe.Name = "Classe";
			this.Classe.Size = new System.Drawing.Size(100, 23);
			this.Classe.TabIndex = 0;
			this.Classe.Text = "Classe";
			this.Classe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StrLabel
			// 
			this.StrLabel.Location = new System.Drawing.Point(12, 81);
			this.StrLabel.Name = "StrLabel";
			this.StrLabel.Size = new System.Drawing.Size(58, 23);
			this.StrLabel.TabIndex = 1;
			this.StrLabel.Text = "Strength";
			// 
			// AgiLabel
			// 
			this.AgiLabel.Location = new System.Drawing.Point(12, 104);
			this.AgiLabel.Name = "AgiLabel";
			this.AgiLabel.Size = new System.Drawing.Size(58, 23);
			this.AgiLabel.TabIndex = 2;
			this.AgiLabel.Text = "Agility";
			// 
			// IntLabel
			// 
			this.IntLabel.Location = new System.Drawing.Point(12, 127);
			this.IntLabel.Name = "IntLabel";
			this.IntLabel.Size = new System.Drawing.Size(58, 23);
			this.IntLabel.TabIndex = 3;
			this.IntLabel.Text = "Intelect";
			// 
			// Submit
			// 
			this.Submit.Location = new System.Drawing.Point(197, 226);
			this.Submit.Name = "Submit";
			this.Submit.Size = new System.Drawing.Size(75, 23);
			this.Submit.TabIndex = 11;
			this.Submit.Text = "Submit";
			this.Submit.UseVisualStyleBackColor = true;
			// 
			// Pontos
			// 
			this.Pontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pontos.Location = new System.Drawing.Point(12, 43);
			this.Pontos.Name = "Pontos";
			this.Pontos.Size = new System.Drawing.Size(117, 23);
			this.Pontos.TabIndex = 12;
			this.Pontos.Text = "Pontos:";
			this.Pontos.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// PontosNum
			// 
			this.PontosNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PontosNum.Location = new System.Drawing.Point(136, 43);
			this.PontosNum.Name = "PontosNum";
			this.PontosNum.Size = new System.Drawing.Size(136, 23);
			this.PontosNum.TabIndex = 13;
			this.PontosNum.Text = "P";
			// 
			// StrMin
			// 
			this.StrMin.Location = new System.Drawing.Point(136, 77);
			this.StrMin.Name = "StrMin";
			this.StrMin.Size = new System.Drawing.Size(20, 20);
			this.StrMin.TabIndex = 14;
			this.StrMin.Text = "-";
			this.StrMin.UseVisualStyleBackColor = true;
			this.StrMin.Click += new System.EventHandler(this.StrMinClick);
			// 
			// StrPlus
			// 
			this.StrPlus.Location = new System.Drawing.Point(76, 77);
			this.StrPlus.Name = "StrPlus";
			this.StrPlus.Size = new System.Drawing.Size(20, 20);
			this.StrPlus.TabIndex = 15;
			this.StrPlus.Text = "+";
			this.StrPlus.UseVisualStyleBackColor = true;
			this.StrPlus.Click += new System.EventHandler(this.StrPlusClick);
			// 
			// StrNum
			// 
			this.StrNum.Location = new System.Drawing.Point(106, 76);
			this.StrNum.Name = "StrNum";
			this.StrNum.Size = new System.Drawing.Size(20, 20);
			this.StrNum.TabIndex = 16;
			this.StrNum.Text = "0";
			this.StrNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AgiNum
			// 
			this.AgiNum.Location = new System.Drawing.Point(106, 100);
			this.AgiNum.Name = "AgiNum";
			this.AgiNum.Size = new System.Drawing.Size(20, 20);
			this.AgiNum.TabIndex = 17;
			this.AgiNum.Text = "0";
			this.AgiNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IntNum
			// 
			this.IntNum.Location = new System.Drawing.Point(106, 123);
			this.IntNum.Name = "IntNum";
			this.IntNum.Size = new System.Drawing.Size(20, 20);
			this.IntNum.TabIndex = 18;
			this.IntNum.Text = "0";
			this.IntNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AgiPlus
			// 
			this.AgiPlus.Location = new System.Drawing.Point(76, 100);
			this.AgiPlus.Name = "AgiPlus";
			this.AgiPlus.Size = new System.Drawing.Size(20, 20);
			this.AgiPlus.TabIndex = 19;
			this.AgiPlus.Text = "+";
			this.AgiPlus.UseVisualStyleBackColor = true;
			this.AgiPlus.Click += new System.EventHandler(this.AgiPlusClick);
			// 
			// AgiMin
			// 
			this.AgiMin.Location = new System.Drawing.Point(136, 100);
			this.AgiMin.Name = "AgiMin";
			this.AgiMin.Size = new System.Drawing.Size(20, 20);
			this.AgiMin.TabIndex = 20;
			this.AgiMin.Text = "-";
			this.AgiMin.UseVisualStyleBackColor = true;
			this.AgiMin.Click += new System.EventHandler(this.AgiMinClick);
			// 
			// IntPlus
			// 
			this.IntPlus.Location = new System.Drawing.Point(76, 123);
			this.IntPlus.Name = "IntPlus";
			this.IntPlus.Size = new System.Drawing.Size(20, 20);
			this.IntPlus.TabIndex = 21;
			this.IntPlus.Text = "+";
			this.IntPlus.UseVisualStyleBackColor = true;
			this.IntPlus.Click += new System.EventHandler(this.IntPlusClick);
			// 
			// IntMin
			// 
			this.IntMin.Location = new System.Drawing.Point(136, 123);
			this.IntMin.Name = "IntMin";
			this.IntMin.Size = new System.Drawing.Size(20, 20);
			this.IntMin.TabIndex = 22;
			this.IntMin.Text = "-";
			this.IntMin.UseVisualStyleBackColor = true;
			this.IntMin.Click += new System.EventHandler(this.IntMinClick);
			// 
			// AtributeMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.IntMin);
			this.Controls.Add(this.IntPlus);
			this.Controls.Add(this.AgiMin);
			this.Controls.Add(this.AgiPlus);
			this.Controls.Add(this.IntNum);
			this.Controls.Add(this.AgiNum);
			this.Controls.Add(this.StrNum);
			this.Controls.Add(this.StrPlus);
			this.Controls.Add(this.StrMin);
			this.Controls.Add(this.PontosNum);
			this.Controls.Add(this.Pontos);
			this.Controls.Add(this.Submit);
			this.Controls.Add(this.IntLabel);
			this.Controls.Add(this.AgiLabel);
			this.Controls.Add(this.StrLabel);
			this.Controls.Add(this.Classe);
			this.Name = "AtributeMenu";
			this.Text = "AtributeMenu";
			this.Load += new System.EventHandler(this.AtributeMenuLoad);
			this.ResumeLayout(false);

		}
	}
}
