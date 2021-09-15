using System;
using System.Collections.Generic;

public class Pessoa
{
	public string Nome {get; set;}
    public DateTime Nasc {get; set;}
	
	public override string ToString()
	{
		return $"{Nome}, {Nasc}";
	}
}

public class TreinoFocadoB
{
	public List<DateTime> LastDayInMonth (List<DateTime> Data)
	{
		List<DateTime> UltimoDia = new List<DateTime>();
		
		foreach (DateTime dt in Data)
		{
			UltimoDia.Add(new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month)));
		}
		return UltimoDia;
	}
	
	public DateTime MaiorData (List<DateTime> data)
	{
		DateTime Dt = DateTime.Today;
		
		foreach (DateTime dt in data)
		{
			if (dt > Dt)
				Dt = dt;
		}
       return Dt;
	}
	
	public List<Pessoa> FiltrarMaiores18 (List<Pessoa> p)
	{
		List<Pessoa> Humano = new List<Pessoa>();
		
		foreach(Pessoa P in p)
		{
			if ((DateTime.Today - P.Nasc).TotalDays / 365 >= 18)
				Humano.Add(P);
		}
		return Humano;
	}
	
	public bool TodosMaiores18 (List<Pessoa> p)
	{
		bool DeMaior = true;
		
		foreach (Pessoa P in p)
		{
			if ((DateTime.Now - P.Nasc).TotalDays / 365 <= 18)
			{
				DeMaior = false;
				break;
			}
		}
		return DeMaior;
	}
}
TreinoFocadoB TFB = new TreinoFocadoB();

List<DateTime> Data = new List<DateTime>() {
	{DateTime.Today},
	{new DateTime(2023, 08, 13)},
	{new DateTime(1989,02, 12)}
										   
										   };
List<DateTime> LastDayMonth = TFB.LastDayInMonth(Data);
Console.WriteLine(string.Join(" | ", LastDayMonth));

DateTime data = TFB.MaiorData(Data);
Console.WriteLine(data);

List<Pessoa> p = new List<Pessoa> () {
	new Pessoa {Nome = "Oi", Nasc = new DateTime(1980, 06, 13)},
	new Pessoa {Nome = "Hi", Nasc = DateTime.Today},
	new Pessoa {Nome = "Hello world", Nasc = new DateTime(1999, 02, 27)}
};

List<Pessoa> FiltrandoMaiores = TFB.FiltrarMaiores18(p);
Console.WriteLine(string.Join(" | ", FiltrandoMaiores));

bool Maiores18 = TFB.TodosMaiores18(p);
Console.WriteLine(Maiores18);