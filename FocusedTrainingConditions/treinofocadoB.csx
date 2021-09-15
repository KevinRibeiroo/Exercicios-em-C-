public class PecaDominio

{ 

    public double LadoA {get; set;}

    public double LadoB {get; set;}

}

  

public class Semaforo

{

    public bool LuzVermelha {get; set;}

    public bool LuzAmarelo {get; set;}

    public bool LuzVerde {get; set;}

}

  

public class Recuperacao

{

   public string Email {get; set;}

    public string Telefone {get; set;}

}

  

public class TreinoFocadoB

{

    public bool CorPrimaria (string Cor)

    {

        bool corPrimaria = Cor == "Azul" || Cor == "Amarelo" || Cor == "Vermelho"

              ? true

               : false;

        return corPrimaria;

    }

    public string CombinacaoCorPrimaria( string Cor1, string Cor2)

    {

        string Combinacao = string.Empty;

        if (Cor1 == "Azul" && Cor2 == "Amarelo" || Cor1 == "Amarelo" && Cor2 == "Azul")

            Combinacao = "Verde";

        else if (Cor1 == "Azul" && Cor2 == "Vermelho" || Cor1 == "Vermelho" && Cor2 == "Azul")

            Combinacao = "Roxo";

        else if (Cor1 == "Vermelho" && Cor2 == "Amarelo" || Cor1 == "Amarelo" && Cor2 == "Vermelho")

            Combinacao = "Laranja";

    else 

      Combinacao = "Não é uma cor primaria";

        return Combinacao;

    }

    public string PrimeiroNome (string Nome)

    {

        string primalNome = Nome.Contains(" ")

            ? Nome.Substring(0, Nome.IndexOf(" "))

            : Nome;

        return primalNome;

    }

    public bool DobreDomino (PecaDominio Peca)

    {

        bool Dobre = Peca.LadoA == Peca.LadoB

            ? true

            :false;

        return Dobre;

    }

    public bool PecaEncaixa (PecaDominio Peca1, PecaDominio Peca2)

    {

        bool Encaixa = Peca2.LadoA == Peca1.LadoA || Peca2.LadoB == Peca1.LadoA

                                      ||

            Peca2.LadoA == Peca1.LadoB || Peca2.LadoB == Peca1.LadoB

            ?true

            :false;

        return Encaixa;

    }

    public string RecuperacaoSenha (Recuperacao Rec)

    {

        return $"Você receberá um e-mail do {Rec.Email} para resetar a senha. Um código também foi enviado  para o número {Rec.Telefone}. Sendo {Rec.Email.Substring(Rec.Email.IndexOf("@"))} o domínio  e {Rec.Telefone.Substring(Rec.Telefone.LastIndexOf("-"))} apenas o final do telefone";

    }

    public Semaforo InicializandoSemaforo ()

    {

        Semaforo Semaf = new Semaforo();

        Semaf.LuzVermelha = true;

        Semaf.LuzAmarelo = false;

        Semaf.LuzVerde = false;

        return Semaf;

    }

    public Semaforo ControlandoSemaforo (Semaforo Semaf)

    {

        if (Semaf.LuzVermelha)

        {

            Semaf.LuzVermelha = true;

            Semaf.LuzAmarelo = false;

            Semaf.LuzVerde = false;

        }

        else if (Semaf.LuzVerde)

        {

                Semaf.LuzVermelha = false;

            Semaf.LuzAmarelo = false;

            Semaf.LuzVerde = true;    

        }

        else if (Semaf.LuzAmarelo)

        {

                Semaf.LuzVermelha = false;

            Semaf.LuzAmarelo = true;

            Semaf.LuzVerde = false;

        }

       return Semaf;

    }

}

  

PecaDominio Peca = new PecaDominio();

Peca.LadoA = 3;

Peca.LadoB = 4;

PecaDominio Peca2 = new PecaDominio();

Peca2.LadoA = 5;

Peca2.LadoB = 1;

  
  

Recuperacao Rec = new Recuperacao();

Rec.Email = "BRNEXLOUCO@gmail.com";

Rec.Telefone = "(11)95678-1243";

TreinoFocadoB TFB = new TreinoFocadoB();

Console.WriteLine(TFB.CorPrimaria("Amarelo"));

Console.WriteLine(TFB.CombinacaoCorPrimaria("Azul", "Verde"));

Console.WriteLine(TFB.PrimeiroNome("Bruxe"));

Console.WriteLine(TFB.DobreDomino(Peca));

Console.WriteLine(TFB.PecaEncaixa(Peca, Peca2));

Console.WriteLine(TFB.RecuperacaoSenha(Rec));

  

Semaforo Semaf =  TFB.InicializandoSemaforo();

  

Console.WriteLine(TFB.InicializandoSemaforo());

Semaf = TFB.ControlandoSemaforo(Semaf);

Console.WriteLine($"Vermelho {Semaf.LuzVermelha} - Verde {Semaf.LuzVerde} - Amarelo {Semaf.LuzAmarelo}");

Semaf = TFB.ControlandoSemaforo(Semaf);

Console.WriteLine($"Vermelho {Semaf.LuzVermelha} - Verde {Semaf.LuzVerde} - Amarelo {Semaf.LuzAmarelo}");

Semaf = TFB.ControlandoSemaforo(Semaf);

Console.WriteLine($"Vermelho {Semaf.LuzVermelha} - Verde {Semaf.LuzVerde} - Amarelo {Semaf.LuzAmarelo}");