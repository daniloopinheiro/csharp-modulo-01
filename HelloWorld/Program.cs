﻿namespace HelloWorld;

class Program
{
    static void Main()
    {
        char letra = 'a';
        char numero = '1';
        char caracter = '@';
        char espaco = ' ';

        string texto = "Este curso é muito bom";
        
        bool existe = texto.Contains('wellison');

        Console.WriteLine(existe);
    }
}
