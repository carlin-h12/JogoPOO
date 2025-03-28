using System;

namespace JogoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro guerreiro = new Guerreiro("Thor", 100, 20);
            Mago mago = new Mago("Merlin", 80, 50);

            Console.WriteLine($"{guerreiro.Nome} ataca e causa {guerreiro.Atacar()} de dano!");
            Console.WriteLine($"{mago.Nome} ataca e causa {mago.Atacar()} de dano!");
        }
    }

    class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }

        public Personagem(string nome, int vida)
        {
            Nome = nome;
            Vida = vida;
        }

        public virtual int Atacar()
        {
            return 10; // Ataque básico
        }
    }

    class Guerreiro : Personagem
    {
        public int Forca { get; set; }

        public Guerreiro(string nome, int vida, int forca) : base(nome, vida)
        {
            Forca = forca;
        }

        public override int Atacar()
        {
            return Forca * 2; // Ataque forte
        }
    }

    class Mago : Personagem
    {
        public int Mana { get; set; }

        public Mago(string nome, int vida, int mana) : base(nome, vida)
        {
            Mana = mana;
        }

        public override int Atacar()
        {
            return Mana / 2; // Ataque mágico
        }
    }
}
