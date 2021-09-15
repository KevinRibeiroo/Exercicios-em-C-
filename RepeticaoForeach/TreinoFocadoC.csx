using System;
using System.Collections.Generic;

public class Pessoa
{
	public string Nome {get; set;}
	public DateTime Nasc {get; set;}
	public string Cidade {get; set;}
	
	public override string ToString()
	{
		return $"{Nome}, {Nasc}, {Cidade}";
	}
}

public class TreinoFocadoC 
{
	public string FraseComTracinho (string frase)
	{
		string FraseSeparada = string.Empty;
		
		foreach (char cont in frase)
		{
			FraseSeparada +=  cont + "-";
		}
		return FraseSeparada;
	}
	
	public List<int> CodigoAscii (string frase)
	{
		List<int> Ascii = new List<int>();
		
		foreach (char cont in frase)
		{
			Ascii.Add(Convert.ToInt32(cont));
		}
		return Ascii;
	}
	
	public bool TodasVogais (string frase)
	{
		bool AllVogais = true;
		
		foreach (char cont in frase)
		{
			if (cont != 'A' && cont != 'a' && cont != 'E' && cont != 'e' &&
               cont != 'I' && cont != 'i' && cont != 'O' && cont != 'o' &&
				cont != 'U' && cont != 'u')
			{
                AllVogais = false;
				break;
			}
		}
		
		return AllVogais;
	}
		
		public string Alternar (Pessoa P)
		{
			string FraseAlternada = string.Empty;
			//char anterior = ' ';
			int num = 0;
			foreach (char cont in P.Nome)
			{
					//if (anterior == ' ')
						//FraseAlternada += cont.ToString().ToUpper();
						
					if (num % 2 == 0)
						FraseAlternada += cont.ToString().ToLower();
				
				
				else 
					FraseAlternada += cont.ToString().ToUpper();
					
				num += 1;
			}
			return FraseAlternada;
		}

						
	public string Inverter (string frase)
	{
		string FraseInvertida = string.Empty;
		
		foreach (char cont in frase)
		{
			FraseInvertida = cont + FraseInvertida;
		}
		return FraseInvertida;
	
	}
	
	public bool Palindromo (string frase)
	{
		return Inverter(frase).ToLower() == frase.ToLower();
	}
}

TreinoFocadoC TFC = new TreinoFocadoC ();

string[] ValoresPraFuncoes = new string[10];
ValoresPraFuncoes[1] = "oi tudo bem?";

Console.WriteLine(TFC.FraseComTracinho(ValoresPraFuncoes[1]));

ValoresPraFuncoes[0] = "oieeeeee";
List<int> CodificacaoAscii = TFC.CodigoAscii(ValoresPraFuncoes[0]);

Console.WriteLine(string.Join(" | ", CodificacaoAscii));

ValoresPraFuncoes[2] = "oiié";

Console.WriteLine(TFC.TodasVogais(ValoresPraFuncoes[2]));

Pessoa P1 = new Pessoa();
P1.Nome = "Alex pouse";
P1.Nasc = DateTime.Today;
P1.Cidade = "SP";

string Alternado = TFC.Alternar(P1);

Console.WriteLine(TFC.Alternar(P1));

ValoresPraFuncoes[4] = "Ana";

string Invertendo = TFC.Inverter(ValoresPraFuncoes[4]);

Console.WriteLine(TFC.Inverter(ValoresPraFuncoes[4]));

bool palindromo = TFC.Palindromo(ValoresPraFuncoes[4]);
Console.WriteLine(TFC.Palindromo(ValoresPraFuncoes[4]));