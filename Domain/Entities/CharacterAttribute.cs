using System;
using RollTheDie.Domain;
namespace RollTheDie.Domain.Entities
{
	public class CharacterAttribute
	{
		public Guid CharacterId { get; set; }
		public int Forca { get; set; }
		public int Agilidade { get; set; }
		public int Intelecto { get; set; }
		public int Vigor {  get; set; }

		public int Vida {  get; set; }
		public int Sanidade {  get; set; }
		public int Esforco { get; set; }
		public int Determinacao { get; set; }
		public int Defesa { get; set; }
		public int NEX {  get; set; }

		public Classe Classe { get; set; }
		public Trilha Trilha {  get; set; }

		public CharacterAttribute(Guid characterId, int forca, int agilidade, int intelecto, int vigor, int vida, int sanidade, int esforco, int determinacao, int defesa, int nex, Classe classe, Trilha trilha)
		{
			CharacterId = characterId;
			Forca=forca;
			Agilidade = agilidade;
			Intelecto= intelecto;
			Vigor = vigor;
			Vida = vida;
			Sanidade= sanidade;
			Esforco= esforco;
			Defesa= defesa;
			NEX= nex;
			Classe= classe;
			Trilha= trilha;
		}
	}
}
