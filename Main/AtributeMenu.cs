using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
	public partial class AtributeMenu : Form
	{
		int max = 10, strmin, agimin, intmin;
		public AtributeMenu()
		{
			InitializeComponent();
		}
		void AtributeMenuLoad(object sender, EventArgs e)
		{
			Classe.Text = Ngame.jogador.getClass();
			PontosNum.Text = Ngame.jogador.status.getStringPoint();
			StrNum.Text = Convert.ToString(Ngame.jogador.status.getStrength());
			AgiNum.Text = Convert.ToString(Ngame.jogador.status.getAgility());
			IntNum.Text = Convert.ToString(Ngame.jogador.status.getIntelect());
			strmin = int.Parse(StrNum.Text);
			agimin = int.Parse(AgiNum.Text);
			intmin = int.Parse(IntNum.Text);
		}
		void StrPlusClick(object sender, EventArgs e)
		{
			if(max != 0)
			{
				Ngame.jogador.status.MPoint("Remove",1);
				max = Ngame.jogador.status.getPontos();
				StrNum.Text = Convert.ToString(int.Parse(StrNum.Text )+1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		void StrMinClick(object sender, EventArgs e)
		{
			if(int.Parse(StrNum.Text) > strmin)
			{
				Ngame.jogador.status.MPoint("Add",1);
				max = Ngame.jogador.status.getPontos();
				StrNum.Text = Convert.ToString(int.Parse(StrNum.Text )-1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		void AgiPlusClick(object sender, EventArgs e)
		{
			if(max != 0)
			{
				Ngame.jogador.status.MPoint("Remove",1);
				max = Ngame.jogador.status.getPontos();
				AgiNum.Text = Convert.ToString(int.Parse(AgiNum.Text )+1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		void AgiMinClick(object sender, EventArgs e)
		{
			if(int.Parse(AgiNum.Text) > agimin)
			{
				Ngame.jogador.status.MPoint("Add",1);
				max = Ngame.jogador.status.getPontos();
				AgiNum.Text = Convert.ToString(int.Parse(AgiNum.Text )-1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		void IntPlusClick(object sender, EventArgs e)
		{
			if(max != 0)
			{
				Ngame.jogador.status.MPoint("Remove",1);
				max = Ngame.jogador.status.getPontos();
				IntNum.Text = Convert.ToString(int.Parse(IntNum.Text )+1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		void IntMinClick(object sender, EventArgs e)
		{
			if(int.Parse(IntNum.Text) > intmin)
			{
				Ngame.jogador.status.MPoint("Add",1);
				max = Ngame.jogador.status.getPontos();
				IntNum.Text = Convert.ToString(int.Parse(IntNum.Text )-1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
	}
}
