//--------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------

namespace Composition_And_Delegation
{
    using System;

    /// <summary>
    /// Programa principal.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// El código del programa principal.
        /// </summary>
        /// <param name="args">Un vector de argumentos pasdados al programa principal.</param>
        public static void Main(String[] args)
        {
            String name;

            name = "Técnico";
            Technician technician = new Technician(name);
            technician.Like();
            technician.Unlike();

            Console.WriteLine("{0} tiene {1} me gusta", name, technician.Likes);

            name = "Entregable";
            ILikeable song = new Deliverable(name, technician);
            song.Like();
            song.Like();

            Console.WriteLine("{0} tiene {1} me gusta", name, song.Likes);
        }
    }
}