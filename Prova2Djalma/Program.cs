using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2Djalma
{
    class Program
    {
        static void Main(string[] args)
        {
            ////NOME: Rita de Cassia Franca Faria      RA: 6322054

            ////2 – Fazer um programa para que mostre uma lista de cidades para o usuário e que ele informe o código da cidade escolhida.
            ////Em seguida pedir uma data para o usuário. Ao final deve ser apresentada em tela a data completa em formato extenso longo,
            ////juntamente com a cidade escolhida. 

            ////Exemplo: Bragança Paulista, 29 de junho de 2022.

            ////A relação das cidades é a seguinte:

            ////1 – Atibaia
            ////2 – Bragança Paulista
            ////3 – Mairiporã
            ////4 – Nazaré
            ////5 – Terra Preta
            ////6 – Extrema
            ////7 – Vargem

            ////Requisitos: Criar uma função para converter a data em extenso.

            double codi ;

            Console.WriteLine("\t Dentre as cidades proposta, informe o codico da cidade escolhida :\n\n Atibaia(1) : Bragança Paulista(2) : Mairiporã(3) : Nazaré(4) : Terra Preta(5) : Extrama(6) : Vargem(7)");
            codi = int.Parse(Console.ReadLine());

            string mesextenso = null;
            Console.WriteLine("Digite a data desejada em números separados por barra (Ex: 28/03/2021): ");
            var datan = Convert.ToDateTime(Console.ReadLine());

            int datames, datadia, dataano;
            datames = datan.Month;
            datadia = datan.Day;
            dataano = datan.Year;

            switch (datames)
            {
                case 1:
                    mesextenso = "Janeiro";
                    break;
                case 2:
                    mesextenso = "Fevereiro";
                    break;
                case 3:
                    mesextenso = "Março";
                    break;
                case 4:
                    mesextenso = "Abril";
                    break;
                case 5:
                    mesextenso = "Maio";
                    break;
                case 6:
                    mesextenso = "Junho";
                    break;
                case 7:
                    mesextenso = "Julho";
                    break;
                case 8:
                    mesextenso = "Agosto";
                    break;
                case 9:
                    mesextenso = "Setembro";
                    break;
                case 10:
                    mesextenso = "Outubro";
                    break;
                case 11:
                    mesextenso = "Novembro";
                    break;
                case 12:
                    mesextenso = "Dezembro";
                    break;
            }


            if (codi == 1)
            {
                Console.WriteLine($"\n \t Atibaia,  {datadia} de {mesextenso} de {dataano}");
            }
            if (codi == 2)
            {
                Console.WriteLine($"\n \t Bragança Paulista,  {datadia} de {mesextenso} de {dataano}");
            }
            if (codi == 3)
            {
                Console.WriteLine($"\n \t Maitiporã,  {datadia} de {mesextenso} de {dataano}");
            }
            if (codi == 4)
            {
                Console.WriteLine($"\n \t Nazaré,  {datadia} de {mesextenso} de {dataano}");
            }
            if (codi == 5)
            {
                Console.WriteLine($"\n \t Terra Preta,  {datadia} de {mesextenso} de {dataano}");
            }
            if (codi == 6)
            {
                Console.WriteLine($"\n \t Extrema, {datadia} de {mesextenso} de {dataano}.");
            }
            if (codi == 7)
            {
                Console.WriteLine($"\n \t Vargem,  {datadia} de {mesextenso} de {dataano}.");
            }


            Console.ReadKey();
        }
    }
}
