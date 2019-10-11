using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
	public partial class Ngame : Form
	{
		public static Player jogador = new Player();
		string race, nome, classe;
		public Ngame()
		{
			InitializeComponent();
		}
		void RacasSelectedIndexChanged(object sender, EventArgs e)
		{
			race = Racas.GetItemText(Racas.SelectedItem);
		}
		void ClassesSelectedIndexChanged(object sender, EventArgs e)
		{
			classe = Classes.GetItemText(Classes.SelectedItem);
		}
		void NomeTextChanged(object sender, EventArgs e)
		{
			nome = Nome.Text;
		}
		void SubmitClick(object sender, EventArgs e)
		{
			jogador.defClasse(classe);
			jogador.defName(nome);
			jogador.defRace(race);
			jogador.Inicio();
			AtributeMenu status = new AtributeMenu();
			status.Show();
			Close();
		}
	}
}
