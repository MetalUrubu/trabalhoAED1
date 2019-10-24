using System;

namespace Main
{
	public class Player //Player.getClas
	{
		string name;
		string race; 
		string classe;
		public Atributos status = new Atributos();
		Inventory equips;
		public Player()
		{
			//nothing
		}
		public void Inicio()
		{
			switch(race)
			{
				case "Troll":
					status.addAtributo("Strength",3);
					status.addAtributo("Agility",4);
					status.addAtributo("Intelect",3);
					break;
				case "Humano":
					status.addAtributo("Strength",3);
					status.addAtributo("Agility",3);
					status.addAtributo("Intelect",4);
					break;
				case "Tritão":
					status.addAtributo("Strength",5);
					status.addAtributo("Agility",2);
					status.addAtributo("Intelect",3);
					break;
				case "Elfo":
					status.addAtributo("Strength",2);
					status.addAtributo("Agility",3);
					status.addAtributo("Intelect",5);
					break;
			}
		}
		
		public void defName(string nome)
		{
			name = nome;
		}
		public void defRace(string raca)
		{
			race = raca;
		}
		public void defClasse(string clas)
		{
			classe = clas;
		}
		public string getClass()
		{
			return classe;
		}
	}
}
