using System;
using System.Collections.Generic;

public class Pessoa 
{
	public string Nome {get;set;}
	public DateTime Nascimento {get; set;}
    
    public override string ToString()
		{
			return $"{Nome}, {Nascimento.ToShortDateString()}";
		}
}

public class TreinoFocadoB 
{
	public List<DateTime> GerandoSequencia (int qtd)
	{
		List<DateTime> QtdDatas = new List<DateTime>();
		for (int cont = 0; cont <= qtd; cont++)
		{
			QtdDatas.Add(DateTime.Today.AddDays(cont));
		}
		return QtdDatas;
	}
	public List<DateTime> GerandoSequencia (int qtd, DateTime data)
	{
		List<DateTime> SeqData = new List<DateTime>();
		for( int cont = 0; cont <= qtd; cont++)
		{
			SeqData.Add(data.AddDays(cont));
		}
		return SeqData;
	}
		public List<DateTime> SequenciaPar(int qtd)
		{
			List<DateTime> SeqDatas = new List<DateTime>();
			for(int cont = 0; cont <= qtd; cont++)
			{
				if (DateTime.Today.AddDays(cont).Day % 2 == 0)
					SeqDatas.Add(DateTime.Today.AddDays(cont));
			}
			return SeqDatas;
		}
	private string Signo (DateTime Nasc)
	{
		string signo = string.Empty;
	
		if (Nasc.Day >= 21 && Nasc.Month == 03 || Nasc.Day <= 20 && Nasc.Month == 04)
			signo = "Áries";
		
		else if (Nasc.Day >= 21 && Nasc.Month == 04 || Nasc.Day <= 20 && Nasc.Month == 05)
			signo = "Touro";
		
		else if (Nasc.Day >= 21 && Nasc.Month == 05 || Nasc.Day <= 20 && Nasc.Month == 06)
			signo = "Gêmeos";
		
		else if (Nasc.Day >= 21 && Nasc.Month == 06 || Nasc.Day <= 22 && Nasc.Month == 07)
			signo = "Câncer";
		
		else if (Nasc.Day >= 23 && Nasc.Month == 07 || Nasc.Day <= 22 && Nasc.Month == 08)
			signo = "Leão";
		
		else if(Nasc.Day >= 23 && Nasc.Month == 08 || Nasc.Day <= 22 && Nasc.Month == 09)
			signo = "Virgem";
		
		else if(Nasc.Day >= 23 && Nasc.Month == 09 || Nasc.Day <= 22 && Nasc.Month == 10)
			signo = "Libra";
		
		else if (Nasc.Day >= 23 && Nasc.Month == 10 || Nasc.Day <= 21 && Nasc.Month == 11)
			signo = "Escorpião";
		
		else if (Nasc.Day >= 22 && Nasc.Month == 11 || Nasc.Day <= 21 && Nasc.Month == 12)
			signo = "Sagitário";
		
		else if (Nasc.Day >= 22 && Nasc.Month == 12 || Nasc.Day <= 20 && Nasc.Month == 01)
			signo = "Capricórnio";
		
		else if (Nasc.Day >= 21 && Nasc.Month == 01 || Nasc.Day <= 18 && Nasc.Month == 02)
			signo = "Aquário";
		
		else 
			signo = "Peixes";
		
		return signo;
	}

	public List<string> QualSigno (List<DateTime> Nasc)
	{
		List<string>signo = new List<string>();
		for (int cont = 0; cont < Nasc.Count; cont++)
		{
			signo.Add(Signo(Nasc[cont]));
		}
		return signo;
	}
	
	public List<Pessoa> FiltrarMaiores (List<Pessoa> P)
	{
		List<Pessoa> Pessu = new List<Pessoa>();
		for (int cont = 0; cont < P.Count; cont++)
		{
			Pessoa pessu = P[cont];
			TimeSpan dif = DateTime.Today - pessu.Nascimento;
			if ((dif.TotalDays / 365) >= 18)
				Pessu.Add(pessu);
		}
		return Pessu;
	}
	
	public bool Maiores18(List<Pessoa> P)
	{
		bool Maior18 = true;
		for (int cont = 0; cont < P.Count; cont++)
		{
		Pessoa pessu = P[cont];
			if ((DateTime.Today - pessu.Nascimento).TotalDays / 365 <= 18)
			Maior18 = false;
				
		}
		return Maior18;
	}
}

TreinoFocadoB TFB = new TreinoFocadoB();

int[] fim = new int[10];
fim[1] = 2;

List<DateTime> Datas = TFB.GerandoSequencia(fim[1]);
Console.WriteLine(string.Join("|", Datas));

fim[2] = 2;
List<DateTime> Datas2 = TFB.GerandoSequencia(fim[2], DateTime.Today);
Console.WriteLine(string.Join("|", Datas2));

fim[3] = 4;
List<DateTime> DatasPar = TFB.SequenciaPar(fim[3]);
Console.WriteLine(string.Join("|", DatasPar));

fim[4] = 5;

string[] ValoresPraFuncoes = new string[10];
List<DateTime> DataNasc = new List<DateTime>();
DataNasc.Add(DateTime.Today);
List<string> signo = TFB.QualSigno(DataNasc);

Console.WriteLine(string.Join("|", signo));

List<Pessoa> p = new List<Pessoa>() {
	new Pessoa() {Nome = "Kus", Nascimento = new DateTime (1890, 03, 14)},
	new Pessoa() {Nome = "Kalax", Nascimento = new DateTime(2000, 05, 18)},
	new Pessoa() {Nome = "kdks", Nascimento = new DateTime (1989, 06, 27)}
};

List<Pessoa> Pessu = TFB.FiltrarMaiores(p);
Console.WriteLine(string.Join("|", Pessu));

bool DeMaior = TFB.Maiores18(p);
Console.WriteLine(DeMaior);
//Console.WriteLine(TFB.Signo(new DateTime (2008, 12, 25)));