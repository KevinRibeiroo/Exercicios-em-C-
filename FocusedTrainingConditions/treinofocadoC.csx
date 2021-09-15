public class Pessoa

{

    public string Nome {get; set;}

    public DateTime Nascimento {get; set;}

    public string Cidade {get; set;}

}

  

public class TreinoFocadoC

{

    public long Trimestre (DateTime Data)

    {

        long NumeroTrimestre = 0;

        if (Data.Month >= 01 && Data.Month <= 03)

            NumeroTrimestre = 1;

        else if (Data.Month >= 04 && Data.Month <= 06)

            NumeroTrimestre = 2;

        else if (Data.Month >= 07 && Data.Month <= 09)

            NumeroTrimestre = 3;

        else if (Data.Month >= 10 && Data.Month <= 12)

            NumeroTrimestre = 4;

        return NumeroTrimestre;    

    }

    public string Mes(int mes)

    {

        string NomeMes = string.Empty;

        if ( mes == 1)

            NomeMes = "Janeiro";

        else if (mes == 2)

            NomeMes = "Fevereiro";

        else if (mes == 3)

            NomeMes = "Março";

        else if (mes == 4)

            NomeMes = "Abril";

        else if (mes == 5)

            NomeMes = "Maio";

        else if ( mes == 6)

            NomeMes = "Junho";

        else if (mes == 7)

            NomeMes = "Julho";

        else if (mes == 8)

            NomeMes = "Agosto";

        else if (mes == 9)

            NomeMes = "Setembro";

        else if (mes == 10)

            NomeMes = "Outubro";

        else if (mes == 11)

            NomeMes = "Novembro";

        else if (mes == 12)

            NomeMes = "Dezembro";

        return NomeMes;

    }

    public string PeriodoDia (DateTime Data)

    {

        string Periodo = string.Empty;

        if ( Data.Hour >= 06 && Data.Hour < 12)

            Periodo = "Manhã";

        else if ( Data.Hour >= 12 && Data.Hour < 18)

            Periodo = "Tarde";

        else if (Data.Hour >= 18 && Data.Hour < 00)

            Periodo = "Noite";

        else if (Data.Hour >= 00 && Data.Hour < 06)

            Periodo = "Madrugada";

        return Periodo;

    }

    public double DiasVida (DateTime Nascimento)

    {

        TimeSpan dif = DateTime.Today - Nascimento;

        return dif.TotalDays;

    }

    public string QualSigno (DateTime Nascimento)

    {

        string Signo = string.Empty;

        if ( (Nascimento.Day >= 21 && Nascimento.Month >= 03) 

                              && 

            Nascimento.Day <= 20 && Nascimento.Month <= 04 )

            Signo = "Áries";

        else if ((Nascimento.Day >= 21 && Nascimento.Month >= 04)

                       &&

                 Nascimento.Day <= 20 && Nascimento.Month <= 06)

            Signo = "Touro";

        else if ((Nascimento.Day >= 21 && Nascimento.Month >= 06)

                 &&

                 Nascimento.Day <= 22 && Nascimento.Month <= 07)

            Signo = "Câncer";

        else if ((Nascimento.Day >= 23 && Nascimento.Month >= 07)

                  &&

                 Nascimento.Day <= 22 && Nascimento.Month <= 08)

            Signo = "Leão";

        else if ((Nascimento.Day >= 23 && Nascimento.Month >= 08)

                 &&

                 Nascimento.Day <= 22 && Nascimento.Month <= 09)

            Signo = "Virgem";

        else if ((Nascimento.Day >= 23 && Nascimento.Month >= 09)

                 &&

                 Nascimento.Day <= 22 && Nascimento.Month <= 10)

            Signo = "Libra";

        else if ((Nascimento.Day >= 23 && Nascimento.Month >= 10)

                 && 

                 Nascimento.Day <= 21 && Nascimento.Month <= 11)

            Signo = "Escorpião";

        else if (Nascimento.Day >= 22 && Nascimento.Month >= 11

                 &&

                 Nascimento.Day <= 21 && Nascimento.Month <= 12)

            Signo = "Sagitário";

        else if (Nascimento.Day >= 22 && Nascimento.Month >= 12

                 && 

                 Nascimento.Day <= 20 && Nascimento.Month <= 01)

            Signo = "Capricórnio";

        else if (Nascimento.Day >= 21 && Nascimento.Day >= 01

                  &&

                  Nascimento.Day <= 18 && Nascimento.Month <= 02)

                 Signo = "Aquário";

        else if ( Nascimento.Day >= 18 && Nascimento.Month >= 02

        &&

        Nascimento.Day <= 20 && Nascimento.Month <= 03)

            Signo = "Peixes";

        return Signo;

    }

    public string DataPorExtenso (Pessoa P)

    {

    return  $"{P.Nome} você nasceu há {DiasVida(P.Nascimento)} dias, em uma {PeriodoDia(P.Nascimento)} do dia {P.Nascimento.Day} de {Mes(P.Nascimento.Day)} ({Trimestre (P.Nascimento)}º trimestre) de {P.Nascimento.Year}. Seu signo é {QualSigno(P.Nascimento)}.";

  

    }

}

  

Pessoa Humano = new Pessoa();

Humano.Nome = "José do Rio";

Humano.Nascimento = new DateTime (2010, 05, 21);

Humano.Cidade = "Londres";

  

TreinoFocadoC TFC = new TreinoFocadoC();

  

Console.WriteLine(TFC.Trimestre(DateTime.Today));

Console.WriteLine(TFC.Mes(DateTime.Today.Month));

Console.WriteLine(TFC.PeriodoDia(DateTime.Today)); 

Console.WriteLine(TFC.DiasVida(new DateTime (2020, 05, 31)));

Console.WriteLine(TFC.QualSigno(new DateTime (2021, 02, 11)));

Console.WriteLine(TFC.DataPorExtenso(Humano));