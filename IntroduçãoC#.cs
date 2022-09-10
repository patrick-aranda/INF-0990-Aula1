using System;
//faz referência ao namespace System
class Hello
{
    static void Main()
    //Método Main é o único membro da classe Hello aqui presente
    //O método Main é declarado como modificador static
    //Métodos estáticos operam sem referência a um objeto específico
    {
        Console.WriteLine("Hello, World");
        //Classe Console dentro de System
        //O método WriteLine da classe Console no namespace System produz a saída do programa
    }
}