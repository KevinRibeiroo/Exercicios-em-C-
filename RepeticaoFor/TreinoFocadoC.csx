using System;
using System.Collections.Generic;

public class Pessoa 
{
	public string Nome {get; set;}
	public DateTime Nascimento {get; set;}
    public string Cidade {get; set;}
}

public class TreinoFocadoC 
{
	public string FraseComTracinho (string frase)
	{
		string resul = string.Empty;
		for (int cont = 0; cont < frase.Length; cont++)
		{
			char corte = frase[cont];
			resul += corte + "-";
		}
		return resul;
	}
public string InvertendoFrase (string frase)
	{
		string resul = string.Empty;
		for (int cont = 0; cont < frase.Length; cont++)
		{
			char corte = frase[cont];
			resul = corte + resul;
		}
		return resul;
	}
	public string TodasVogais (string frase)
	{
		string resul = string.Empty;
		bool FullVogal = false;
		for (int cont = 0; cont < frase.Length; cont++)
		{
			char corte = frase[cont];
			if (corte == 'a' || corte == 'A' || corte == 'e' || corte == 'E' || corte == 'i' || corte == 'I' || corte == 'o' || corte == 'O' || corte == 'u' || corte == 'U')
				FullVogal = true;
			
			else
			{
				FullVogal = false;
				break;
			}
		}
		return FullVogal.ToString();
	}
	private string UltimoNome (string Nome)
	{
		return Nome.Substring(Nome.LastIndexOf(" ") + 1);
	}
	public List<string> LastNames (List<string> Nome)
	{
		List<string> Nm = new List<string>();
		for (int cont = 0; cont < Nome.Count; cont++)
		{
			Nm.Add(UltimoNome(Nome[cont]));
		}
		return Nm;
	}
	
	public bool CoresPrimarias (List<string> Cores)
	{
		bool CoresPrimaria = false;
		for (int cont = 0; cont < Cores.Count; cont++)
		{
			if ( Cores[cont] == "Azul" || Cores[cont] == "Amarelo" || Cores[cont] == "Vermelho")
				CoresPrimaria = true;
			
			else
			{
				CoresPrimaria = false;
				break;
			}
		}
			return CoresPrimaria;
		}

	public bool SenhaForte (string senha)
	{
		bool SenhaFullPower = false;
		
		//for (int cont = 0; cont < senha.Length; cont++)
		
            //char corte = senha[cont];
			int number = 0;
			int CaracEspecial = 0;
			string Numeros = "0123456789";
			string CarcEspecial = "&_@#/\\*()?!:";
			for (int cont = 0; cont < senha.Length; cont++)
			{
				for (int x = 0; x < Numeros.Length; x++)
				{
					
			if (senha[cont] == Numeros[x])
				number += 1;
					
				}
             
				for (int y = 0; y < CarcEspecial.Length; y++)
				{
					
			if(senha[cont] == CarcEspecial[y])
				CaracEspecial += 1;
					
				}
		}
			if(senha.Length == 8 && number == 2 && CaracEspecial == 2)
				SenhaFullPower = true;
		
		return SenhaFullPower;
	}
    }

TreinoFocadoC TFC = new TreinoFocadoC();

string[] ValoresPraFuncoes = new string[10];
ValoresPraFuncoes[0] = "Oi tudo bem?";

string Frase = TFC.FraseComTracinho(ValoresPraFuncoes[0]);
Console.WriteLine(Frase);

//string FraseInversa= TFC.InvertendoFrase(ValoresPraFuncoes[0]);
//Console.WriteLine(FraseInversa)/Console.WriteLine(FraseInversa);

ValoresPraFuncoes[1] = "Ota";

string Vogais = TFC.TodasVogais(ValoresPraFuncoes[1]);
Console.WriteLine(Vogais);

List<string> Nomes = new List<string>() {
	{"oliver queen"},
	{"Carl kis"}
};


List<string> LastName = TFC.LastNames(Nomes);
Console.WriteLine(string.Join("|", LastName));

List<string> Cores = new List<string>() {
	{"Azul"},
	{"Amarelo"},
	{"Preto"}
};

bool CorPrimaria = TFC.CoresPrimarias(Cores);
Console.WriteLine(CorPrimaria);