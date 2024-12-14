<?php
declare(strict_types=1);

class Pessoa {
    private string $nome;
    private int $idade;

    public function __construct(string $nome, int $idade) {
        $this->nome = $nome;
        $this->idade = $idade;
    }

    public function apresentar(): string {
        return "Olá, pessoal! O meu nome é {$this->nome} e eu tenho {$this->idade} anos. Estou aprendendo desenvolvimento!";
    }
}

function validarIdade(int $idade): bool {
    return $idade > 0 && $idade < 120; // Regras básicas para idade válida
}

// Uso
$nome = "Letícia Rocha";
$idade = 28;

try {
    if (validarIdade($idade)) {
        $pessoa = new Pessoa($nome, $idade);
        echo $pessoa->apresentar();
    } else {
        throw new InvalidArgumentException("A idade fornecida é inválida: $idade");
    }
} catch (InvalidArgumentException $e) {
    echo $e->getMessage();
}

