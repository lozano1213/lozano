using System;
/// <summary>
/// Santiago Lozano
/// taller conceptual
/// Sueldo 
/// </summary>
namespace taller_conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            int iTituloUniversitario;
            double bSueldo;
            double bQuincena =1050000;
            double bQuncena2;
            double bSeguroColectivo;
            double bEPS;
            double bParoForzoso;
            double bCajaCompensacion;
            double bBonoAlimentacion;
            int iDiasLaborados;
            double bBonoTransporte =120000;

            Console.WriteLine("cuenta con un titulo universitario? (1 = SI / 2 = NO)");
            iTituloUniversitario = Convert.ToInt32(Console.ReadLine());
            if (iTituloUniversitario ==1)
            {
                bQuncena2 = bQuincena * 0.1;
            }
            else
            {
                bQuncena2 = bQuincena * 0;
            }

            Console.WriteLine("¿cuantos dias trabajó?");
            iDiasLaborados = Convert.ToInt32(Console.ReadLine());
            
            bBonoAlimentacion = iDiasLaborados * 25000;
            bEPS = bQuincena * 0.02;
            bParoForzoso = bQuincena * 0.01;
            bCajaCompensacion = bQuincena * 0.02;
            bSeguroColectivo = bQuincena * 0.02;
            
            bSueldo = bQuincena + bQuncena2 + bBonoTransporte + bBonoAlimentacion -bEPS-bParoForzoso-bSeguroColectivo-bCajaCompensacion;
            
            Console.WriteLine("su sueldo quincenal es de"+bSueldo+"$");
            
           
            Console.ReadKey();
             
               
        }
    }
}
