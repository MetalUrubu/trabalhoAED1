using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
	public partial class AtributeMenu : Form
	{
		int strvalue,agivalue,intvalue,strmax = 10,agimax = 10,intmax = 10;
		public AtributeMenu()
		{
			InitializeComponent();
		}
		void AtributeMenuLoad(object sender, EventArgs e)
		{
			Classe.Text = Ngame.jogador.getClass();
			PontosNum.Text = Ngame.jogador.status.getStringPoint();
			StrNum.Text = Convert.ToString(Ngame.jogador.status.getstrength());
		}
		void StrPlusClick(object sender, EventArgs e)
		{
			if(strmax != 0)
			{
				Ngame.jogador.status.MPoint("Remove",1);
				strmax = Ngame.jogador.status.getPontos();
				StrNum.Text = Convert.ToString(int.Parse(StrNum.Text )+1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		void StrMinClick(object sender, EventArgs e)
		{
			if(int.Parse(StrNum.Text) > 0)
			{
				Ngame.jogador.status.MPoint("Add",1);
				strmax = Ngame.jogador.status.getPontos();
				StrNum.Text = Convert.ToString(int.Parse(StrNum.Text )-1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		void AgiPlusClick(object sender, EventArgs e)
		{
			if(strmax != 0)
			{
				Ngame.jogador.status.MPoint("Remove",1);
				strmax = Ngame.jogador.status.getPontos();
				agimax = Ngame.jogador.status.getPontos();
				intmax = Ngame.jogador.status.getPontos();
				AgiNum.Text = Convert.ToString(int.Parse(AgiNum.Text )+1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		void AgiMinClick(object sender, EventArgs e)
		{
			if(int.Parse(AgiNum.Text) > 0)
			{
				Ngame.jogador.status.MPoint("Add",1);
				strmax = Ngame.jogador.status.getPontos();
				agimax = Ngame.jogador.status.getPontos();
				intmax = Ngame.jogador.status.getPontos();
				AgiNum.Text = Convert.ToString(int.Parse(AgiNum.Text )-1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		void IntPlusClick(object sender, EventArgs e)
		{
			if(strmax != 0)
			{
				Ngame.jogador.status.MPoint("Remove",1);
				strmax = Ngame.jogador.status.getPontos();
				agimax = Ngame.jogador.status.getPontos();
				intmax = Ngame.jogador.status.getPontos();
				IntNum.Text = Convert.ToString(int.Parse(IntNum.Text )+1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		void IntMinClick(object sender, EventArgs e)
		{
			if(int.Parse(IntNum.Text) > 0)
			{
				Ngame.jogador.status.MPoint("Add",1);
				strmax = Ngame.jogador.status.getPontos();
				agimax = Ngame.jogador.status.getPontos();
				intmax = Ngame.jogador.status.getPontos();
				IntNum.Text = Convert.ToString(int.Parse(IntNum.Text )-1);
				PontosNum.Text = Ngame.jogador.status.getStringPoint();
			}
		}
		
		

	}
}
