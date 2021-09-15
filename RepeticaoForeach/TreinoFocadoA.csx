using System;
using System.Collections.Generic;

public class Retangulo 
{
	public double Altura {get; set;}
	public double Base {get; set;}
}

public class Notas
{
	public double Nota1 {get; set;}
	public double Nota2 {get; set;}
	public double Nota3 {get; set;}
}

public class TreinoFocadoA
{
	public int SomandoImpares (List<int> valor)
	{
		int Soma = 0;
		
		foreach(int cont in valor)
		{
			//int somando = 0;
			if (cont % 2 != 0)
			{
				Soma = Soma += cont;
			}
		}
		return Soma;
	}
	
	public List<int> CalcularCubo (List<int> Number)
	{
		List<int> Numero = new List<int>();
		
		foreach(int num in Number)
		{
             
			Numero.Add(Convert.ToInt32(Math.Pow(num, 3)));
		}
		return Numero;
	}
	
	public List<double> CalcularRaiz (List<double> Number)
	{
		List<double> Raiz = new List<double>();
		
		foreach (double num in Number)
		{
			Raiz.Add(Math.Round(Math.Sqrt(num), 2));
		}
		return Raiz;
	
	}
	
	public int MaiorNumero (List<int> Number)
	{
		int maior = 0;
		foreach (int num in Number)
		{
			if (num > maior)
				maior = num;
		}
		return maior;
	}
	
	public double Media (List<double> Valor)
	{
		double media = 0;
		foreach (double num in Valor)
		{
			media += num;
		}
       return media / Valor.Count;
	}
	
	public List<double> CalcularMedia (List<Notas> Nota)
	{
		List<double> Media = new List<double>();
		foreach (Notas num in Nota)
		{
			Media.Add((num.Nota1 + num.Nota2 + num.Nota3) / 3);
		}
		return Media;
	}
	
	private double AreaRetangulo (Retangulo ret)
	{
		return ret.Base * ret.Altura;
	}

	public List<double> CalcularRetangulo (List<Retangulo> ret)
	{
		List<double> resul = new List<double>();
		
		foreach (Retangulo retang in ret)
		{
			resul.Add(AreaRetangulo(retang));
		}
		return resul;
	}
}

TreinoFocadoA TFA = new TreinoFocadoA();

List<int> ValorFuncao1 = new List<int>() {3,3, 4};

//List<int> SomarImpar = 
int x = TFA.SomandoImpares(ValorFuncao1);
//Console.WriteLine(string.Join("|", SomarImpar));
Console.WriteLine(x);

List<int> ValoresPraElevarCubo = new List<int>();
ValoresPraElevarCubo.Add(2);
List<int> Cubo = TFA.CalcularCubo(ValoresPraElevarCubo);
Console.WriteLine(string.Join("|", Cubo));

List<double> Valor2 = new List<double>(){6, 25, 7};

List<double> Raiz = TFA.CalcularRaiz(Valor2);

Console.WriteLine(string.Join("|", Raiz));

List<int> Valores2 = new List<int>() {67,89,3};

int MaiorNum = TFA.MaiorNumero(Valores2);

Console.WriteLine(MaiorNum);

List<Notas> Nt = new List<Notas> {
	new Notas {Nota1 = 2, Nota2 = 2, Nota3 = 2},
	new Notas {Nota1 = 3, Nota2 = 3, Nota3 = 3}
};

List<double> Medias = TFA.CalcularMedia(Nt);
Console.WriteLine(string.Join("|", Medias));

List<Retangulo> ret = new List<Retangulo>() {
	new Retangulo {Base = 2, Altura = 2},
	new Retangulo {Base = 3, Altura = 3}
};

List<double> CalculandoRetangulo = TFA.CalcularRetangulo(ret);
Console.WriteLine(string.Join("|", CalculandoRetangulo));