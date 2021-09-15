using System;
using System.Collections.Generic;

public class Retangulo
{
	public double Altura {get; set;}
	public double Basee {get; set;}
}
public class Notas
{
	public double Nota1 {get; set;}
	public double Nota2 {get; set;}
	public double Nota3 {get; set;}
}
public class TreinoFocadoA
{
public List<int> Contagem (int fim)
{
	List<int> Seq = new List<int>();
		for(int x = 0; x <= fim; x++)
		{
			Seq.Add(x);
		}
    return Seq;
}
	public List<int> GerarSequencia(int Inicio, int Fim)
{
	List<int> Seq = new List<int>();
		for(int x = 0; Inicio <= Fim; x++)
		{
			Seq.Add(x);
		}
    return Seq;
	}
	public List<long> GerandoSequenciaPar (long Inicio, long Fim)
	{
		List<long> SeqPar = new List<long>();
		for (int x = 0; Inicio <= Fim; x++)
		{
			if (x % 2 == 0)
			SeqPar.Add(x);
		}
		return SeqPar;
	}
	public int SomarAte(int Fim)
	{
		int NumberNatu = 0;
		for (int x = 0; x <= Fim; x++)
			 {
				 NumberNatu += x;
			 }
		return NumberNatu;
	}
	public double CalcularMedia (List<double> Notas)
	{
		double SomaNotas = 0;
		for (int nt = 0; nt < Notas.Count; nt++)
		{
			SomaNotas += Notas[nt];
		}
		return SomaNotas / Notas.Count;
	}
	public List<double> CalcularMedia (List<Notas> Nota)
	{
		List<double> Nt = new List<double>();
		//double nota = 0;
		for (int nt = 0; nt < Nota.Count; nt++)
		{
			Notas nts = Nota[nt];
			Nt.Add((nts.Nota1 + nts.Nota2 + nts.Nota3) / 3);
			
		}
		//Nt.Add(nota);
        return Nt;
	}
	public List<double> CalcularQuadrado (List<double> Numeros)
	{
		List<double> Potencia = new List<double>();
		for (int cont = 0; cont < 1000000; cont++)
		{
			Potencia.Add(Math.Pow(cont,2));
		}
		return Potencia;
	}
	private double AreaRetangulo (Retangulo ret)
	{
		return ret.Altura * ret.Basee;
	}
	public List<double> CalcRetangulos (List<Retangulo> ret)
	{
		List<double> NumberRetangulos = new List<double>();
		for (int Cont = 0; Cont < ret.Count; Cont++)
		{
			Retangulo Ret = ret[Cont];
			//double calcRet = AreaRetangulo(ret[1]);
			NumberRetangulos.Add(AreaRetangulo(Ret));
		}
		return NumberRetangulos;
	}
}
TreinoFocadoA TFA = new TreinoFocadoA();
List<int> Seq = TFA.Contagem(10);
List<int> seq = TFA.GerarSequencia(1,10);

int fim = 10;
int inicio = 0;
List<long> SeqPar = TFA.GerandoSequenciaPar(inicio,fim);
Console.WriteLine(string.Join("-",Seq));
Console.WriteLine(string.Join("-", seq));
Console.WriteLine(string.Join("-", SeqPar));
fim = 100;
Console.WriteLine(TFA.SomarAte(fim));
List<double> Nt = new List<double>();
Nt.Add(7);
Nt.Add(9);
Nt.Add(8);
Nt.Add(8);
Console.WriteLine(TFA.CalcularMedia(Nt));

Notas nota = new Notas();
nota.Nota1 = 1;
nota.Nota2 = 1;
nota.Nota3 = 0;
List<Notas> nt = new List<Notas>();
nt.Add(nota);

List<double> Media = TFA.CalcularMedia(nt);
Console.WriteLine(string.Join("-", Media));

List<double> Numero = new List<double>();
Numero.Add(3);
List<double> Potencia = TFA.CalcularQuadrado(Numero);

Console.WriteLine(string.Join("-", Potencia));

Retangulo ret = new Retangulo();
ret.Altura = 2;
ret.Basee = 2;

//Console.WriteLine(TFA.AreaRetangulo(ret));

List<Retangulo> Retang = new List<Retangulo>();
List<double> CalculandoRetangulo = TFA.CalcRetangulos(Retang);

Console.WriteLine(string.Join("-", CalculandoRetangulo));