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
		public int Presenca{get;  set; }

		public int Vida  {  get;  private set; }
		public int vidaAtual {  get;  set; }
		
		public int Sanidade {  get; private set; }
		public int SanidadeAtual {  get;  set; }
		
		public int Esforco { get; private set; }
		public int EsforcoAtual {  get;  set; }
		
		public int Determinacao { get; private set; }
		public int DeterminacaoAtual {  get;  set; }
		
		public int Defesa { get; private set; }
		public int NEX { get; set; }

		public Classe Classe { get; set; }
		public Trilha Trilha {  get; set; }

		public CharacterAttribute(Guid characterId, int forca, int agilidade, int intelecto, int vigor,int presenca, int defesa, int nex, Classe classe, Trilha trilha)
		{
			CharacterId = characterId;
			Forca=forca;
			Agilidade = agilidade;
			Intelecto= intelecto;
			Vigor = vigor;
			Presenca = presenca;
			vidaAtual = Vida;
			SanidadeAtual= Sanidade;
			EsforcoAtual= Esforco;
			DeterminacaoAtual= Determinacao;
			Defesa= defesa;
			NEX= nex;
			Classe= classe;
			Trilha= trilha;
		}
		
	}
}
