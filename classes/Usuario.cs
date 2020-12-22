using System;

namespace AulaPOO_ProjetoDeProdutos.classes
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario(){
            Cadastrar();
        }
        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;

        }

        public void Cadastrar(){
            Console.WriteLine("Digite seu nome");
            Nome = Console.ReadLine();
            bool saidaCorreta = true;
            int _codigo = 0;
            while (saidaCorreta){
                Console.WriteLine("Digite o código");
                if(int.TryParse(Console.ReadLine(), out _codigo)){
                    Codigo = _codigo;
                    saidaCorreta = false;
                }else{
                    Console.WriteLine("Apenas números inteiros");
                }
            }
            Console.WriteLine("Digite seu email");
            Email = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            Senha = Console.ReadLine();
            DataCadastro = DateTime.UtcNow;
            
        }
        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("");
        }
    }
}