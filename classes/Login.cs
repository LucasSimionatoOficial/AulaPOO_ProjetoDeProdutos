using System;

namespace AulaPOO_ProjetoDeProdutos.classes
{
    public class Login
    {
        private bool Logado { get; set; }
        
        public Login(){
            Logar();
            if(Logado == true){
                GerarMenu();
            }
        }
        public void GerarMenu(){
            Produto prod = new Produto();
            Marca marca = new Marca();
            bool continuar = true;
            while(continuar){
                Console.WriteLine("Digite 1 para cadastrar uma marca");
                Console.WriteLine("Digite 2 para listar marcas");
                Console.WriteLine("Digite 3 para excluir uma marca");
                Console.WriteLine("Digite 4 para cadastrar produtos");
                Console.WriteLine("Digite 5 para listar produtos");
                Console.WriteLine("Digite 6 para excluir produtos");
                Console.WriteLine("Digite 0 para sair");
                switch (Console.ReadLine()){
                    case "1":
                        marca.Cadastrar();
                        break;
                    case "2":
                        marca.Listar();
                        break;
                    case "3":
                        Console.WriteLine("Digite o código do produto");
                        marca.Deletar(int.Parse(Console.ReadLine()));
                        break;
                    case "4":
                        prod.Cadastrar();
                        break;
                    case "5":
                        prod.Listar();
                        break;
                    case "6":
                        Console.WriteLine("Digite o código");
                        prod.Deletar(int.Parse(Console.ReadLine()));
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Digite apenas o número correto");
                        break;
                }
                
            }
        }
        public void Logar(){
            Usuario user = new Usuario();
            bool continuar = true;
            while (continuar){
                Console.WriteLine("Login");
                Console.WriteLine("Digite seu email");
                string _email = Console.ReadLine();
                Console.WriteLine("Digite sua senha");
                string _senha = Console.ReadLine();
                if(_email == user.Email && _senha == user.Senha){
                    Logado = true;
                    Console.WriteLine("Login efetuado");
                    continuar = false;
                }else{
                    Console.WriteLine("Login e/ou senha incorretos");
                }
            }
            
        }
        public string Deslogar(){
            
            return "";
        }
    }
}