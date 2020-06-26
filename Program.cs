using System;

namespace Aula4_POOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular Xiamoi = new Celular();
            Xiamoi.marca = "Xiamoi";
            Xiamoi.tamanho = "Medio";
            Xiamoi.cor = "Preto";
            Xiamoi.ligado = true;
            Xiamoi.acao = "---";

            Console.WriteLine(Xiamoi.verMarca());
            Console.WriteLine(Xiamoi.verTamanho());
            Console.WriteLine(Xiamoi.verCor());
            Console.WriteLine(Xiamoi.verLigado());

            // if = se / else = se não
            if(Xiamoi.ligado == false){
            Console.WriteLine("O celular está desligado");

            }else{
            Console.WriteLine("O que deseja fazer? mandar mensagens, fazer ligações ou desligar?");
            }

            Xiamoi.acao = Console.ReadLine();
            if(Xiamoi.acao == "mandar mensagens"){
            Console.WriteLine("Mensagem enviada");
            }else if(Xiamoi.acao == "fazer ligações"){
            Console.WriteLine("Fazendo ligação");
            }
            else{
            Console.WriteLine("Desligando . . .");
        }
    }
}
}