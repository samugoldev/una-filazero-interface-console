Este é um guia básico para o seu projeto **FilaZero**. O código apresenta uma estrutura inicial de um sistema de autenticação via console utilizando C#.

---

# 🛡️ FilaZero - Sistema de Login

O **FilaZero** é um algoritmo simples desenvolvido em C# para simular uma interface de autenticação de usuário via terminal (Console Application). Ele valida as credenciais inseridas contra dados pré-definidos no código.

## 🚀 Funcionalidades

* **Interface Customizada:** Altera o título da janela do console e define a codificação para UTF-8 (suporte a acentos).
* **Identidade Visual:** Desenha um cabeçalho estilizado para melhor experiência do usuário.
* **Validação de Credenciais:** Sistema de verificação de `username` e `password`.
* **Feedback em Tempo Real:** Informa ao usuário se o acesso foi concedido ou negado.

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** .NET (Console Application)

## 📋 Como funciona o algoritmo

O fluxo do programa segue três etapas principais:

1.  **Configuração:** Define o título da aplicação como "FilaZero - Sistema de Login" e limpa a tela.
2.  **Entrada de Dados:** Solicita que o usuário digite o nome de usuário e a senha.
3.  **Processamento:** Compara os dados inseridos com as credenciais padrão:
    * **Usuário:** `admin`
    * **Senha:** `senha123`

---

## 💻 Exemplo de Uso

Ao iniciar o programa, você verá a seguinte interface:

```text
=====================================
         Fila Zero - Login           
=====================================
Digite seu nome de usuário: admin
Digite sua senha: [sua_senha]
```

---

## ⚙️ Como Executar

1.  Certifique-se de ter o **SDK do .NET** instalado em sua máquina.
2.  Copie o código para um arquivo chamado `Program.cs`.
3.  Abra o terminal na pasta do arquivo e execute:
    ```bash
    dotnet run
    ```

## 📝 Observações
Este projeto é uma **simulação**. Em um cenário real, as senhas nunca devem ser armazenadas em texto puro (hardcoded) ou comparadas diretamente sem criptografia (hashing).
