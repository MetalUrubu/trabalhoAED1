using System;

namespace Main
{
	public class Atributos
	{
		int Pontos;
		int strength;
		int agility;
		int intelect;
		int speed;
		int armor;
		int teste;
		
		public Atributos()
		{
			Pontos += 10;
		}
		public int getStrength{get;}
		public void addAtributo(string atributo, int num)
		{
			switch(atributo)
			{
				case "Strength":
					strength += num;
					break;
				case "Agility":
					agility += num;
					break;
				case "Intelect":
					intelect += num;
					break;
			}
		}
		public string getStringPoint()
		{
			return Convert.ToString(Pontos);
		}
		public void MPoint(string m, int num)
		{
			if(m == "Add")
			{
				Pontos += num;
			}
			else
			{
				Pontos -= num;
			}
		}
		public int getPontos()
		{
			return Pontos;
		}
	}
}
