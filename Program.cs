using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosEnum
{
    enum Estaciones { Primavera,Verano,Otoño,Invierno};//enum es para crear constantes.
    enum Bonus {bajo = 500,normal = 1000,bueno = 1500,extra = 2000 };
    internal class Program
    {
        static void Main(string[] args)
        {
            Estaciones esta1 = Estaciones.Primavera;
            //string esta2 = esta1.ToString();  de esta manera tambien se puede mostrar la constante por medio de un string.
            Console.WriteLine(esta1);//imprimiendo la variable esta1 para mostrar la constante primavera que se le asigna en ella.

            Bonus bonus1 = Bonus.bajo;
            double bonus2 = (double)bonus1;//casti de esta manera se muestra el valor 500 de la constante bajo.
            Console.WriteLine(bonus2);

            Empleado pepe = new Empleado (Bonus.normal,1500);
            Console.WriteLine("El salario del Empledo es de:" + pepe.Getsalario());         
        }
    }

    class Empleado
    {
        private double Salario, bonus;
        public Empleado(Bonus bonoEmpleado,double salarioE)
        {
            bonus = (double)bonoEmpleado;
            this.Salario = salarioE;
        }

        public double Getsalario()
        {
            return Salario + bonus;
        }
    }
}
