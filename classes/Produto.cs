using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.classes
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string NomeProduto { get; set; }
        private float Preco;
        private DateTime DataCadastro { get; set; }
        private Marca Marca { get; set; }
        private Usuario CadastradoPor { get; set; }
        List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){
            Produto NovoProduto = new Produto();
            Console.WriteLine("Digite o nome do produto");
            NovoProduto.NomeProduto = Console.ReadLine();
            int _codigo = 0;
            bool erro = true;
            while (erro){
                Console.WriteLine("Digite o código do produto");
                if(int.TryParse(Console.ReadLine(), out _codigo)){
                    NovoProduto.Codigo = _codigo;
                    erro = false;
                }else{
                    Console.WriteLine("Apenas números inteiros");
                }
            }
            int _preco = 0;
            bool erro2 = true;
            while (erro2){
                Console.WriteLine("Digite o preço do produto");
                if(int.TryParse(Console.ReadLine(), out _preco)){
                    NovoProduto.Codigo = _preco;
                    erro2 = false;
                }else{
                    Console.WriteLine("Apenas números");
                }
            }
            Marca marca = new Marca();
            NovoProduto.DataCadastro = DateTime.UtcNow;
            NovoProduto.Marca = marca.Cadastrar();
            NovoProduto.CadastradoPor = new Usuario();
            ListaDeProdutos.Add(NovoProduto);
        }
        public void Listar(){
            if (ListaDeProdutos != null){
                foreach (var item in ListaDeProdutos){
                    Console.WriteLine("Nome do produto: "+item.NomeProduto);
                    Console.WriteLine("Código: "+item.Codigo);
                    Console.WriteLine("Preço: "+item.Preco);
                    Console.WriteLine("Data do cadastro: "+item.DataCadastro);
                    Console.WriteLine("Marca: "+item.Marca);
                }
            }else{
                Console.WriteLine("Nenhum produto cadastrado");
            }
        }
        public void Deletar(int cod){
            Produto deletar = ListaDeProdutos.Find(x => x.Codigo == cod);
            ListaDeProdutos.Remove(deletar);
        }
    }
}