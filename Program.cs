﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona objetoPersona = new Persona();
            objetoPersona.rut = "10900099-3";
            objetoPersona.nombre = "Brandon";
            objetoPersona.cargo = "Analista";
            objetoPersona.edad = 27;
            objetoPersona.sueldo = 0;
            Console.WriteLine(objetoPersona.calculoSueldo(objetoPersona.cargo));
            Console.Read();
        }
    }
}
