//--------------------------------------------------------------------------
// <copyright file="Actor.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------

namespace Composition_And_Delegation
{
    using System;

    /// <summary>
    /// Un técnico que me puede gustar o no.
    /// </summary>
    public class Technician
    {
        private String name;

        private string picture;

        /// <summary>
        /// Crea un nuevo técnico con los valores pasados como argumento.
        /// </summary>
        /// <param name="name">El nombre del técnico a crear.</param>
        public Technician(String name, string picture)
        {
            this.name = name;
            this.picture = picture;
        }

        /// <summary>
        /// Nombre del técnico.
        /// </summary>
        /// <returns>El nombre del técnico.</returns>
        public String Name
        {
            get
            {
                return this.name;
            }
        }
    }
}