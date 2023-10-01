class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de vitórias do jogador: ");
        int vitorias = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a quantidade de derrotas do jogador: ");
        int derrotas = Convert.ToInt32(Console.ReadLine());

        int saldoVitorias = CalcularSaldoVitorias(vitorias, derrotas);
        string nivel = DeterminarNivel(saldoVitorias);

        Console.WriteLine($"O Herói tem um saldo de {saldoVitorias} e está no nível de {nivel}");
    }

    static int CalcularSaldoVitorias(int vitorias, int derrotas)
    {
        return vitorias - derrotas;
    }

    static string DeterminarNivel(int saldoVitorias)
    {
        if (saldoVitorias < 10)
            return "Ferro";
        else if (saldoVitorias <= 20)
            return "Bronze";
        else if (saldoVitorias <= 50)
            return "Prata";
        else if (saldoVitorias <= 80)
            return "Ouro";
        else if (saldoVitorias <= 90)
            return "Diamante";
        else if (saldoVitorias <= 100)
            return "Lendário";
        else
            return "Imortal";
    }
}
