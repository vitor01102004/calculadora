using System;
using System.Reflection.Emit;

class Program
{
    

    static void Main()
    {
        inicio:

        int numero1;
        int numero2;
        char operacao;
        int resultado;

        Console.WriteLine("digite um numero");
        numero1 = int.Parse(Console.ReadLine());//vai transformar string em int 

        Console.WriteLine("digite outro numero");
        numero2 = int.Parse(Console.ReadLine());//vai transformar string em int 

        Console.WriteLine("qual operacao voce deseja:  '*' '+' '-' '/' ");
        operacao = char.Parse(Console.ReadLine()); //posso usar o (.parse) ou o (convert)

        

        if (operacao == '-')//o resto tem q ser o else if, ja que quando o programa da true, ele pula fora do while. é o elif do python
        {
            resultado = numero1 - numero2;
            Console.WriteLine("o resultado da sua subtração é: "+ resultado);
        }

        else if (operacao == '*')
        {
            resultado = numero1 * numero2;

            Console.WriteLine("o resultado da sua multiplicação é: "+ resultado);
        }

        else if (operacao == '/')
        {
            if(numero2!=0)
            {
                resultado = numero1 / numero2;
                Console.WriteLine("o resultado da sua divisão é: "+ resultado);

            }
            else{
                Console.WriteLine("não é possivel a divisão por 0");

            }
            
        }

        else if (operacao == '+')
        {
            resultado = numero1 + numero2;
            Console.WriteLine("o resultado da sua adição é: "+ resultado);
        }

        else{
            Console.WriteLine("operação invalida");
            goto inicio;
           
        }
        Console.WriteLine("fim do programa");
        
     
    

            

    }
    

}