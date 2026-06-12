# POO com C# 💳

Projeto de estudos de **Programação Orientada a Objetos (POO)** em C#.

Simula um sistema bancário simples com contas correntes e poupanças, aplicando conceitos como **herança**, **encapsulamento** e **polimorfismo**.

---

## 📚 Conceitos praticados

- **Classes e objetos**
- **Herança**: `ContaCorrente` e `ContaPoupanca` herdam de `Conta`, que herda de `Cliente`
- **Encapsulamento**: propriedades com getters e setters
- **Polimorfismo**: sobrescrita do método `ToString()`

---

## 🏗️ Estrutura do projeto

```
Poo/
├── Cliente.cs          # Classe base com dados do cliente
├── Conta.cs            # Classe base das contas bancárias
├── ContaCorrente.cs    # Conta corrente com saque e depósito
├── ContaPoupanca.cs    # Conta poupança com rendimento de 10%
├── Programa.cs         # Ponto de entrada da aplicação
└── Main.csproj         # Arquivo de projeto .NET
```

---

## 🚀 Como executar

Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
# Clonar o repositório
git clone https://github.com/mrcosvinicius/poo-c-.git

# Acessar a pasta do projeto
cd poo-c-

# Compilar e executar
dotnet run
```

---

## 💡 Exemplo de uso

No `Programa.cs`, uma conta corrente é criada e um saque é realizado:

```csharp
ContaCorrente contaVinicius = new ContaCorrente("Vinicius", 20, false, 101, 200, "001");
contaVinicius.sacar(12);
Console.Write(contaVinicius.ToString());
```

Saída esperada:

```
SAQUE: R$12 sacado com sucesso
Prezado(a) cliente Vinicius, seu saldo atual de R$188
```

---

## 🛠️ Tecnologias

- C#
- .NET 10

---

## 📝 Licença

Projeto de uso educacional. Sinta-se livre para estudar e modificar.
