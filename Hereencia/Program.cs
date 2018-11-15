using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hereencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal_Acuatico delfin = new Animal_Acuatico();
            Animal_Terrestre elefante = new Animal_Terrestre();
            Kanguro kanguro = new Kanguro();

            List<Animal> animales = new List<Animal>(); 

            Animal tiburon = new Animal_Acuatico();
            tiburon.Nombre = "Tiburon";
            ((Animal_Acuatico)tiburon).Nadar();

            delfin.Nombre = "Delfin";
            elefante.Nombre = "Elefante";

            delfin.Comer();
            delfin.Nadar();

            elefante.Caminar();
            kanguro.SaltarBienAlto();
            kanguro.Comer();

            animales.Add(delfin);
            animales.Add(tiburon);
            animales.Add(elefante);
            animales.Add(kanguro);

            foreach(var animal in animales)
            {
                Console.WriteLine(animal.Nombre);
                if (animal.GetType() == typeof(Animal_Acuatico))
                {
                    ((Animal_Acuatico)animal).Nadar();
                }            }

            Console.ReadLine();
        }
    }
}
