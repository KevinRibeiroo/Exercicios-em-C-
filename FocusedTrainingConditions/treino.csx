


public class Calculo

{

    public double Valor1 {get; set;}

    public double Valor2 {get; set;}

    public string Operacao {get; set;}

}

  

public class Triangulo

{

    public double LadoA {get; set;}

    public double LadoB {get; set;}

    public double LadoC {get; set;}

}

  

public class Pessoa

{

    public string Nome {get; set;}

    public double Altura {get; set;}

    public double peso {get; set;}

}

  

public class Nota

{

    public double Nota1 {get; set;}

    public double Nota2 {get; set;}

    public double Nota3 {get; set;}

}

  

public class TreinoFocadoA

{

    public double Calculadora (Calculo calc)

    {

        double Calculando = 0;

        if (calc.Operacao == "Soma")

            Calculando = calc.Valor1 + calc.Valor2;

        else if (calc.Operacao == "Subtração")

            Calculando = calc.Valor1 - calc.Valor2;

        else if (calc.Operacao == "Multiplicação")

            Calculando = calc.Valor1 * calc.Valor2;

        else 

        {

            if (calc.Operacao == "Potenciação")

                Calculando = Math.Pow(calc.Valor1, calc.Valor2);

      else if (calc.Operacao == "Divisão")

        Calculando = calc.Valor1 / calc.Valor2;

        }

        return Calculando;

    }

    public string Termometro (double GrauCelsius)

    {

        string Situacao = string.Empty;

        if (GrauCelsius >= 35 && GrauCelsius <= 36.9)

          Situacao = $"Meu amigo você está com uma temperatura média de {GrauCelsius}C°, isso é extremamente normal";

        else if (GrauCelsius >= 37 && GrauCelsius <= 39)

            Situacao = $"Carambolas se cuida você está com uma temperatura média de {GrauCelsius}C°, você está com febre não se esforce muito";

        else 

        {

            if (GrauCelsius >= 39.1)

            Situacao = $"Procure um médico urgente você está com {GrauCelsius}C°, isso é classificado como febre alta";

            if (GrauCelsius <= 34.9)

                Situacao = $"Procure um médico imediatamente você está com temperatura do corpo em {GrauCelsius}C°, isso é perigoso e é classificado como hipotermia";

        }

        return Situacao;

    }

    public string LucroOuPrejuizo(double Lucro, double gastos)

    {

        double Resul = Lucro - gastos;

        string Situacao = string.Empty;

        string Positivo = Resul < 0

            ? $"Seu saldo é de {Math.Abs(Resul)} só que negativo 🙄"

            : $"Seu saldo é de {Resul} positivos";

        return Positivo;

    }

    public double ArrendodarEmmeia(double nota)

    {

        double CasaDecimal = Math.Round(nota -Math.Truncate(nota), 2);

        if (CasaDecimal >= 0.00 && CasaDecimal <= 0.25)

            nota = Math.Floor(nota);

        else if (CasaDecimal >= 0.26 && CasaDecimal <= 0.74)

            nota = Math.Floor(nota) + 0.50;

        else 

            nota = Math.Ceiling(nota);

        return nota;

    }

    public string Passou (Nota nt)

    {

        double media = (nt.Nota1 + nt.Nota2 + nt.Nota3) /3;

        string passou = string.Empty;

        if (media >= 5)

            passou = $"Eita, Ave Maria dodio você passou";

        else if (media == 4)

            passou = $"Se é loko hein fi, vai repetir se continuar nesse ritimo, você tem a chance de fazer a recuperação";

    else 

      passou = $"Reproavdo";

        return passou;

    }

    public string Passou (Nota nt, long Falta)

    {

        double media = (nt.Nota1 + nt.Nota2 + nt.Nota3) /3;

        string passou = string.Empty;

        if (media >= 5)

            passou = $"Eita, Ave Maria dodio você passou";

        else if (media == 4)

            passou = $"Se é loko hein fi, vai repetir se continuar nesse ritimo, você tem a chance de fazer a recuperação por conta de sua nota";

            else if (Falta == 24)

                passou = $"Boaaa, ficou de recuperação por falta";

           else if ( Falta == 24 && media == 4)

               passou = $"Ficou de recuperação por nota e falta hein";

        if (media < 4)

            passou = "reprovado por falta";

         if (Falta > 25)

        passou = $"Reprovado por falta";

        else 

            passou = $"Foi reprovado por falta e nota";

        return passou;

    }

    public string FormaTriangulo(Triangulo tri)

    {

        string triangulo = string.Empty;

        if (tri.LadoA != tri.LadoB && tri.LadoA != tri.LadoC

                             &&

            tri.LadoC != tri.LadoB)

            triangulo = $"Triângulo é escaleno";

        else if (tri.LadoA == tri.LadoB && tri.LadoA == tri.LadoC

                             &&

            tri.LadoC == tri.LadoB)

            triangulo = $"Triangulo é equilátero";

        else

         triangulo = "Triângulo é isóceles";

        return triangulo;

    }

  public string IMC (Pessoa humano)

  {

    string Situacao = string.Empty;

    double calcIMC = (humano.peso) / Math.Pow(humano.Altura, 2);

    if (calcIMC <= 18.5)

      Situacao = $"{humano.Nome} você está abaixo do peso";

    else if (calcIMC >= 18.6 && calcIMC <= 24.9)

      Situacao = $"{humano.Nome} você está no peso normal";

    else if (calcIMC >= 25 && calcIMC <= 29.9)

      Situacao = $"{humano.Nome} você está em sobrepeso";

    else if (calcIMC >= 30 && calcIMC <= 34.9)

      Situacao = $"{humano.Nome} você está em obeso de grau um";

    else if (calcIMC >= 35 && calcIMC <= 39.9)

      Situacao = $"{humano.Nome} você está em obeso de grau dois";

    else if (calcIMC > 40)

      Situacao = $"{humano.Nome} você está um grau de obsidade mórbida";

    return Situacao;

}

  

}

Calculo calc1 = new Calculo();

calc1.Valor1 = 6;

calc1.Valor2 = 2;

calc1.Operacao = "Multiplicação";

  

Triangulo triang = new Triangulo();

triang.LadoA = 1;

triang.LadoB = 7;

triang.LadoC = 6;

  

Pessoa p = new Pessoa ();

p.Nome = "Teteu";

p.Altura = 1.46;

p.peso = 102;

  

Nota nt = new Nota();

  nt.Nota1 = 3;

nt.Nota2 = 3;

nt.Nota3 = 3;

  

TreinoFocadoA TFA = new TreinoFocadoA();

  

Console.WriteLine(TFA.Calculadora(calc1));

Console.WriteLine(TFA.Termometro(42));

Console.WriteLine(TFA.LucroOuPrejuizo(12, 18));

Console.WriteLine(TFA.ArrendodarEmmeia(23.77));

Console.WriteLine(TFA.Passou(nt));

Console.WriteLine(TFA.Passou(nt, 24));

//Console WriteLine(TFA.FormaTriangulo(triang));

Console.WriteLine(TFA.IMC(p));



