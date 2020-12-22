using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.classes
{
    public class Marca
    {
        List<Marca> ListaDeMarcas = new List<Marca>();
        private int Codigo { get; set; }
        private string NomeMarca{ get; set; }
        private DateTime DataCadastro { get; set; }

        public Marca Cadastrar(){
            Marca nova = new Marca();
            bool continuar = true;
            int _codigo = 0;
            while (continuar){
                Console.WriteLine("Digite o código da marca");
                if (int.TryParse(Console.ReadLine(), out _codigo)){
                    nova.Codigo = _codigo;
                    continuar = false;
                }else{
                    Console.WriteLine("Apenas números inteiros permitidos");
                }
            }
            Console.WriteLine("Digite o nome da marca");
            nova.NomeMarca = Console.ReadLine();
            ListaDeMarcas.Add(nova);
            return nova;
        }
        public void Listar(){
            if(ListaDeMarcas != null){
                foreach (var item in ListaDeMarcas){
                    Console.WriteLine($"Marca: {item.NomeMarca} Código: {item.Codigo}");
                }
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhuma marca cadastrada");
                Console.ResetColor();
            }
        }
        public void Deletar(int cod){
            Marca deletar = ListaDeMarcas.Find(x=> x.Codigo == cod);
            ListaDeMarcas.Remove(deletar);
        }
    }
}