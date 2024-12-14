class Pessoa {
    constructor(nome, idade) {
        this.nome = nome;
        this.idade = idade;
    }

    apresentar() {
        return `Olá, pessoal! O meu nome é ${this.nome} e eu tenho ${this.idade} anos. Estou aprendendo desenvolvimento!`;
    }
}

function validarIdade(idade) {
    return typeof idade === "number" && idade > 0 && idade < 120; // Validação robusta
}

// Uso
const nome = "Letícia Rocha";
const idade = 28;

if (validarIdade(idade)) {
    const pessoa = new Pessoa(nome, idade);
    console.log(pessoa.apresentar());
} else {
    console.log("A idade fornecida é inválida.");
}
