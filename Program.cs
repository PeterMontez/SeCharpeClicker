using System;
using System.Collections.Generic;

var teste = (Console.ReadKey());
Console.WriteLine(teste);

Player jogador = new Player();

while(true)
{
    Sistema.Rodar(jogador);
}

public class Player
{
    public float Click { get; set; } = 1;
    public float Money { get; set; } = 0;

    public void Receive(float incremento, int valor)
    {
        this.Money -= valor;
        this.Click += incremento;
    }
}

public abstract class Maquinas
{
    public int Valor { get; set; }
    public float Incremento { get; set; }
    public int Qtd { get; set; }

    public abstract void Agir(int quantia, Player target);
}

public class Maquina1 : Maquinas
{
    public Maquina1()
    {
        this.Valor = 20;
        this.Incremento = 1;
        this.Qtd = 0;
    }

    public override void Agir(int quantia, Player target)
    {
        int custo = this.Valor * quantia;
        float incrTotal = this.Incremento * quantia;
        this.Qtd += quantia;
        target.Receive(incrTotal, custo);
    }

}

public class Maquina2 : Maquinas
{
    public Maquina2()
    {
        this.Valor = 40;
        this.Incremento = 2;
        this.Qtd = 0;
    }

    public override void Agir(int quantia, Player target)
    {
        int custo = this.Valor * quantia;
        float incrTotal = this.Incremento * quantia;
        target.Receive(incrTotal, custo);
    }
}

public class Maquina3 : Maquinas
{
    public Maquina3()
    {
        this.Valor = 100;
        this.Incremento = 5;
        this.Qtd = 0;
    }

    public override void Agir(int quantia, Player target)
    {
        int custo = this.Valor * quantia;
        float incrTotal = this.Incremento * quantia;
        target.Receive(incrTotal, custo);
    }
}

public class Maquina4 : Maquinas
{
    public Maquina4()
    {
        this.Valor = 1000;
        this.Incremento = 50;
        this.Qtd = 0;
    }

    public override void Agir(int quantia, Player target)
    {
        int custo = this.Valor * quantia;
        float incrTotal = this.Incremento * quantia;
        target.Receive(incrTotal, custo);
    }
}

public class Maquina5 : Maquinas
{
    public Maquina5()
    {
        this.Valor = 10000;
        this.Incremento = 0;
        this.Qtd = 0;
    }

    public override void Agir(int quantia, Player target)
    {
        this.Incremento = target.Click * ((float)0.1);
        int custo = this.Valor * quantia;
        float incrTotal = this.Incremento * quantia;
        target.Receive(incrTotal, custo);
    }
}

public static class Sistema
{
    public static void Rodar(Player target)
    {
        while(true)
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.D0)
            {
                target.Money += target.Click;
            }
            else if (tecla.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Qual máquina você deseja comprar (1 - 5)? ");
                int choice = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Quantas máquinas? ");
                int quantia = Convert.ToInt16(Console.ReadLine());
                // switch (choice)
                // {
                //     case 1:
                        
                //     case 2:
                        
                // }
            }
        }
    }
}

// PAREI NA PARTE DE DETECTAR SE O PLAYER TEM DINHEIRO SUFICIENTE!