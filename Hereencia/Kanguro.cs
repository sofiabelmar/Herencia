﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hereencia
{
    public class Kanguro : Animal_Terrestre
    {

        public Kanguro()
        {
            Nombre = "Kanguro";
        }

        public void SaltarBienAlto()
        {
            
            Console.WriteLine("Hola soy un " + Nombre + " y estoy saltando bien alto");
        }
    }
}
