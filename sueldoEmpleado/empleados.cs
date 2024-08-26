/* En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500,
 realizar un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados
cobran entre $100 y $300 y cuántos cobran más de $300.
Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.*/

namespace sueldoEmpleado
{
  public class empleados
  {
        public void sueldo()
        { 
            int empleado = 0;
            string nombre = string.Empty;
            int contador = 1;
            int sueldo = 0;
            int sueldomini = 0;
            int sueldomax=0 ;
            int total = 0;
            try
            {
                Console.WriteLine("digite el numero de empleado que desea ingresar ");
                empleado = Convert.ToInt32(Console.ReadLine());
                while (contador <= empleado)
                {
                    Console.WriteLine("ingrese el nombre del empleados ");
                    nombre = Console.ReadLine();
                    Console.WriteLine($" ingrese el sueldo de : {nombre}");
                     sueldo = Convert.ToInt32(Console.ReadLine());

                    if (sueldo > 500)
                    {  
                        Console.WriteLine("sueldo ingresados es muy alto \n ingrese un sueldo entre 100 y 500");

                    } else if (sueldo < 100)
                    {
                        Console.WriteLine("sueldo ingresados es muy bajito \n ingrese un sueldo entre 100 y 500");

                    } if (sueldo <= 300)
                    {
                        sueldomini++;
                    } else if (sueldo >= 301)
                    {
                        sueldomax++;
                    }
                    if (sueldo > 99 && sueldo < 501)
                    { 
                     total += sueldo;
                    }
                    contador++;


                }
                Console.WriteLine($"persona cobrar mas de 300 :{sueldomax}");
                Console.WriteLine($"persona cobrar menos 0 igual a 300 :{sueldomini}");
                Console.WriteLine($"el sueldo total que la empresa debe de pagar es :{total}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error {ex.Message}");
            }
        }
  }
}
