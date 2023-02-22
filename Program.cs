using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using PrimeiroProjeto.Classes;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //int idade = 34;
            //double saldo = 10.35784;
            //string nome = "Maria";
            ////Placeholders
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            ////Interpolation
            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            ////Concatenation + imprimir sem virgula e com um pontinho
            //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";
            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';
            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos:");
            //Console.WriteLine($"{produto1}, cujo o preço é $ {preco1.ToString("F2")}");
            //Console.WriteLine($"{produto2}, cujo preço é $ {preco2.ToString("F2")}");
            //Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            //Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            //Console.WriteLine($"Arredondado (três casas decimais): {medida.ToString("F3")}");
            //Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3",CultureInfo.InvariantCulture)}");

            //Console.WriteLine("Insira o código do produto seguido da quantidade e do preço");

            //string[] prod1 = Console.ReadLine().Split(' ');

            //string cod1 = prod1[0];
            //string qnt1 = prod1[1];
            //string pco1 = prod1[2];

            //string[] prod2 = Console.ReadLine().Split(' ');

            //string cod2 = prod2[0];
            //string qnt2 = prod2[1];
            //string pco2 = prod2[2];

            //Console.WriteLine($"O valor da sua conta é R$ {(double.Parse(qnt1) * double.Parse(pco1)) + (double.Parse(qnt2) * double.Parse(pco2))}");

            //    Console.WriteLine("Entre com o seu nome completo:");
            //    string fullName = Console.ReadLine();
            //    Console.WriteLine("Quantos quartos tem na sua casa?");
            //    string qtos = Console.ReadLine();
            //    Console.WriteLine("Entre com o preço de um produto:");
            //    string pco = Console.ReadLine();
            //    Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            //    string[] dds = Console.ReadLine().Split(' ');
            //    string lastName = dds[0];
            //    int idade = int.Parse(dds[1]);
            //    double altura = double.Parse(dds[2]);

            //    Console.WriteLine(fullName);
            //    Console.WriteLine(qtos);
            //    Console.WriteLine(pco);
            //    Console.WriteLine(lastName);
            //    Console.WriteLine(idade);
            //    Console.WriteLine(altura);
            //
            //Console.WriteLine("Insira dois números inteiros");
            //string[] numeros = Console.ReadLine().Split(' ');
            //int num1 = int.Parse(numeros[0]);
            //int num2 = int.Parse(numeros[1]);
            //Console.WriteLine($"SOMA = {num1 + num2}");

            //Console.WriteLine("Informe o raio do círculo.");
            //string r = Console.ReadLine();
            //double area = Math.Pow(double.Parse(r), 2) * 3.14159;
            //Console.WriteLine($"A = {area.ToString("F4")}");

            //Console.WriteLine("Insira os valores de A, B, C e D separados por espaço");
            //string[] abcd = Console.ReadLine().Split(' ');
            //int A = int.Parse(abcd[0]);
            //int B = int.Parse(abcd[1]);
            //int C = int.Parse(abcd[2]);
            //int D = int.Parse(abcd[3]);

            //Console.WriteLine($"Diferença = {(A*B)-(C*D)}");

            //Console.WriteLine("Insira dois valores inteiros");
            //string[] vlrs = Console.ReadLine().Split(' ');
            //int num1 = int.Parse(vlrs[0]);
            //int num2 = int.Parse(vlrs[1]);

            //if(num1%num2== 0 || num2%num1==0) {
            //    Console.WriteLine("São múltiplos");
            //} 
            //else
            //{
            //    Console.WriteLine("Não são múltiplos");
            //}
            //Console.WriteLine("Olá qual o seu nome?");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Prazer em te conhecer " + nome);
            //Console.WriteLine("Você tem irmãos?");
            //string resp1 = Console.ReadLine();
            //string sim = "sim";

            //if(resp1 == sim) {
            //    Console.WriteLine("Quantos irmãos você tem?");
            //} 
            //else
            //{
            //    Console.WriteLine("Quantos amigos você tem?");
            //}
            //int qntdIrmaos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual o nome do seu irmmão?");
            //string nomeIrmao = Console.ReadLine();
            //Console.WriteLine("Que legal adorei os seus nomes!");
            //Console.WriteLine(nome + " respeite o " + nomeIrmao + " porque ele te ama muito e será o seu melhor amigo!");

            //Console.Write("Quantos números inteiros você vai digitar? ");
            //int N = int.Parse(Console.ReadLine());
            //int soma = 0;
            //for(int i = 1; i <= N; i++) 
            //{
            //    Console.WriteLine("Valor #" + i + ":");
            //    int valor = int.Parse(Console.ReadLine());
            //    soma += valor;
            //}
            //Console.WriteLine("Soma = " + soma);

            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //p1.nome = "Maria";
            //p1.idade = 17;

            //p2.nome = "João";
            //p2.idade = 16;

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.WriteLine($"Nome: {p1.nome}");
            //Console.WriteLine($"Idade: {p1.idade}");
            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.WriteLine($"Nome: {p2.nome}");
            //Console.WriteLine($"Idade: {p2.idade}");
            //if (p1.idade > p2.idade)
            //{
            //    Console.WriteLine($"Pessoa mais velha: {p1.nome} ");
            //}
            //else 
            //{
            //    Console.WriteLine($"Pessoa mais velha: {p2.nome}");
            //}

            //Funcionario f1 = new Funcionario();
            //Funcionario f2 = new Funcionario();

            //f1.nome = "Carlos Silva";
            //f1.salario = 6300;
            //f2.nome = "Ana Marques";
            //f2.salario = 6700;

            //Console.WriteLine("Dados do primeiro funcionário:");
            //Console.WriteLine($"Nome: {f1.nome}");
            //Console.WriteLine($"Salário: {f1.salario}");
            //Console.WriteLine("Dados do segundo funcionário:");
            //Console.WriteLine($"Nome: {f2.nome}");
            //Console.WriteLine($"Idade: {f2.salario}");

            //Console.WriteLine($"Salário médio: {(f1.salario+f2.salario)/2}");

            //Triangulo x = new Triangulo();
            //Triangulo y = new Triangulo();
            //Console.WriteLine("Insira os valores dos lados do triangulo");
            //x.A = double.Parse(Console.ReadLine());
            //x.B = double.Parse(Console.ReadLine());
            //x.C = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Area do triangulo igual a {x.Area()}");

            //Console.WriteLine("Insira os Dados do Produto");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Quantidade: ");
            //int quantidade = int.Parse(Console.ReadLine());
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, quantidade, preco);

            //Console.WriteLine("Dados do produto " + p);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("Insira a quantidade de produtos que vc deseja adicionar ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine("Dados atualizados do produto: " + p);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("Insira a quantidade de produtos que foram venidods: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados do produto: " + p);

            //Retangulo r = new Retangulo();

            //Console.WriteLine("Entre com os lados do retângulo:");
            //r.A = double.Parse(Console.ReadLine());
            //r.B = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Área = " + r.AreaDoRetangulo());
            //Console.WriteLine();
            //Console.WriteLine("Perímetro = " + r.PerimetroDoRetangulo());
            //Console.WriteLine();
            //Console.WriteLine("Diagonal = " + r.DiagonalDoRetangulo());
            //Funcionario p = new Funcionario();
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Salário Bruto: ");
            //p.SalarioBruto = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Imposto: ");
            //p.Imposto = double.Parse(Console.ReadLine());

            //Console.WriteLine("Funcionário " + p);
            //Console.WriteLine();
            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double porcentagem = double.Parse(Console.ReadLine());
            //p.AumentarSalario(porcentagem);
            //Console.WriteLine();
            //Console.WriteLine("Dados Atualizados do Funcionário " + p);

            //Aluno p = new Aluno();
            //Console.Write("Nome do Aluno: ");
            //p.Nome = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Insira as notas do aluno:");
            //p.N1 = double.Parse(Console.ReadLine());
            //p.N2 = double.Parse(Console.ReadLine());
            //p.N3 = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine(p.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(p.StatusDoAluno());

            //Console.Write("Qual a cotação do Dolar? ");
            //double cotacao = double.Parse(Console.ReadLine());
            //Console.Write("Quanto que você pretendo comprar de dolar? ");
            //double montante = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("O valor a ser pago em reais é = R$" + ConversorDeMoeda.Conversao(montante, cotacao));

            Banco b = new Banco();
            Console.WriteLine("Vamos criar sua conta?");
            Console.WriteLine("Por favor digite seu nome abaixo.");
            b.Titular = Console.ReadLine();
            Console.Write("Entre com o número da conta: ");
            b.NConta = int.Parse(Console.ReadLine());
            while(b.NConta.ToString().Length < 4)
            {
                Console.WriteLine("O número precisa ter mais do que 4 dígitos. Por favor recomece o processo.");
                Console.WriteLine("Digite um novo número");
                b.NConta = int.Parse(Console.ReadLine());
            }
            Console.Write("Haverá depósito inicial (s/n)? ");
            b.DepInicial = Console.ReadLine();
            if (b.DepInicial == "s" | b.DepInicial == "S")
            {
                Console.Write("Insira o valor do deposito inicial: ");
                b.SaldoDaConta = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Parabéns " + b.Titular + " você acabou de criar sua conta!");
                Console.WriteLine();
                Console.WriteLine("Confira os dados de sua conta abaixo.");
                Console.WriteLine();
            } else
            {
                Console.WriteLine("Parabéns " + b.Titular + " você acabou de criar sua conta!");
                Console.WriteLine();
                Console.WriteLine("Confira os dados de sua conta abaixo.");
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine(b);
            






        }
    }
}