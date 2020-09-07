using System;

namespace AppRetiros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Banco Mañanero su Monto disponible es de RD$18,765.43 Desea retirar? y/n");

            string retiro = Console.ReadLine();

            if (retiro == "y")
            {
                Console.WriteLine("Digite el monto que desea Retirar");
                string Valmonto = Console.ReadLine();
                double monto = Convert.ToDouble(Valmonto);

                if (monto > 18765.43)
                {
                    Console.WriteLine("No puede retirar esta Cantidad debido a que excede lo que tiene");
                }
                else if (monto < 18765.43)
                {
                    Console.WriteLine("Usted a elegido retirar {0} Correcto? y/n",monto);
                    string yesno = Console.ReadLine();

                    if (yesno == "y")
                    {
                        Console.WriteLine("Retire su dinero");
                        Console.WriteLine("Su nuevo monto es de: {0}", 18765.43 - monto);
                        Console.WriteLine("Gracias por preferirnos.");
                    }
                    else
                    {
                        Console.WriteLine("Gracias por preferirnos");
                    }
                }
                else if (monto == 18765.43)
                {
                    Console.WriteLine("Usted a retirado todo su dinero, su nuevo monto es de 0");
                }
                else {
                    Console.WriteLine("Favor ingrese un monto valido");
                }
            }
            else {
                Console.WriteLine("Gracias por preferir al Banco Mañanero tenga feliz dia");
            }
        }
    }
}
