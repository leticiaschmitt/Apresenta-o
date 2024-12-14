using System;

class Pessoa {
    public string Nome { get; private set; } // Propriedade automática com setter privado
    public int Idade { get; private set; }   // Propriedade automática com setter privado

    public Pessoa(string nome, int idade) {
        Nome = nome;
        Idade = idade;
    }

    public string Apresentar() {
        return $"Olá, pessoal! O meu nome é {Nome} e eu tenho {Idade} anos. Estou aprendendo desenvolvimento!";
    }
}

class Program {
    static bool ValidarIdade(int idade) {
        return idade > 0 && idade < 120; // Regras básicas para idade válida
    }

    static void Main() {
        const string nome = "Letícia Rocha"; // Nome é constante
        const int idade = 28;

        if (ValidarIdade(idade)) {
            Pessoa pessoa = new Pessoa(nome, idade);
            Console.WriteLine(pessoa.Apresentar());
        } else {
            Console.WriteLine("A idade fornecida é inválida.");
        }
    }
}
