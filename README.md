# Apresentando em Diferentes Linguagens

Este repositório contém implementações de uma apresentação simples utilizando várias linguagens de programação. A ideia é criar um pequeno programa que se apresenta, informando o nome e a idade do usuário, enquanto valida se a idade fornecida está dentro de um intervalo válido. As linguagens utilizadas são:

- **JavaScript**
- **PHP**
- **C#**

Cada linguagem possui uma implementação orientada a objetos, com uma classe `Pessoa` que armazena o nome e a idade, e uma função para validar se a idade está dentro de um intervalo de 0 a 120 anos.

---

## Estrutura do Projeto

### **1. JavaScript**

No arquivo `apresentacao.js`, temos uma implementação simples em **JavaScript**, utilizando **classes** e **template literals** para gerar a apresentação. A função `validarIdade()` verifica se a idade fornecida está no intervalo válido.

- **Objetivo:** Apresentar informações sobre o usuário e validar a idade.
- **Tecnologia:** JavaScript (ES6+)

### **2. PHP**

No arquivo `apresentacao.php`, temos uma versão em **PHP** que usa **tipagem forte** e uma **exceção personalizada** para lidar com idades inválidas. A classe `Pessoa` recebe as informações de nome e idade, e a função `validarIdade()` garante que a idade esteja dentro do intervalo.

- **Objetivo:** Apresentar o nome e idade, com exceção personalizada para idades inválidas.
- **Tecnologia:** PHP 7+ (tipagem forte)

### **3. C#**

No arquivo `Apresentacao.cs`, temos uma implementação em **C#** que também utiliza **classes** e **strings interpoladas** para apresentar a informação. A função `ValidarIdade()` faz a verificação da idade antes de apresentar os dados.

- **Objetivo:** Exibir a apresentação com validação de idade.
- **Tecnologia:** C# (Console Application)

---

## Como Executar

### **1. JavaScript**

Para rodar o código JavaScript, basta ter o **Node.js** instalado em sua máquina. Após isso, você pode rodar o código utilizando o comando:

```bash
node apresentacao.js
```

### **2. PHP**

Para rodar o código PHP, basta ter o **PHP** instalado em sua máquina. Execute o seguinte comando para ver a apresentação no terminal:

```bash
php apresentacao.php
```

### **3. C#**

Para rodar o código C#, você pode usar o **.NET Core** (SDK) para compilar e executar o código. Primeiro, crie um novo projeto de Console e substitua o conteúdo do arquivo `Program.cs` pelo código fornecido. Em seguida, rode:

```bash
dotnet run
```

---

## Conclusão

Este repositório é um exemplo simples de como implementar uma apresentação com validação de dados em diferentes linguagens de programação. A ideia principal é demonstrar como utilizar **orientação a objetos** e **validação de dados** nas mais diversas tecnologias.

---

Se precisar de mais detalhes ou quiser contribuir, fique à vontade para abrir um *pull request* ou deixar um comentário! 😄