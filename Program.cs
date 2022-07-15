using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Contador contador = new Contador();
            int i = 0;
            while(i != 4){
                i = Convert.ToInt32(Console.ReadLine()); //converte p/int
                switch (i)
                {
                    case 1:
                        contador.zerar();
                        break;
                    case 2:
                        contador.incrementar();
                        break;
                    case 3:
                        Console.WriteLine(contador.retorno());
                        break;
                
                }
            }

        }
    }

    class Contador
    {
        int numero = 0;
        public void zerar ()
        {
            numero = 0;
        }
        public void incrementar ()
        {
            numero++;
        }
        public int retorno()
        {
            return numero;
        }


    }
}
