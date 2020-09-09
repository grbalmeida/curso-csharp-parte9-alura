﻿using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO; // IO - Input e Output

namespace ByteBankImportacaoExportacao
{
    partial class Program 
    { 
        static void Main(string[] args) 
        {
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            var bytesArquivo = File.ReadAllBytes("contas.txt");

            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

            var linhas = File.ReadAllLines("contas.txt");

            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();
        }
    }
} 
 