//--------------------------------------------------------------------------
// <copyright file="Song.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------

namespace Composition_And_Delegation
{
    using System;

    /// <summary>
    /// Un entregable que me puede gustar o no.
    /// </summary>
    public class Deliverable : ILikeable
    {
        private String name;

        private string thumbnail;

        private Technician author;

        /// <summary>
        /// Crea un nuevo entregable con los valores pasados como parámetro.
        /// </summary>
        /// <param name="name">El nombre del entregable.</param>
        /// <param name="author">El autor del entregable.</param>
        /// <returns>El entregable recién creado.</returns>
        public Deliverable(String name, Technician author, string thumbnail)
        {
            this.name = name;
            this.author = author;
            this.thumbnail = thumbnail;
        }

        /// <summary>
        /// Nombre del entregable.
        /// </summary>
        /// <returns>El nombre del entregable.</returns>
        public String Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Autor del entregable.
        /// </summary>
        /// <returns>El autor del entregable.</returns>
        public Technician Author
        {
            get
            {
                return this.author;
            }
        }

        public void Like()
        {

        }

        public void Unlike()
        {

        }

        public int Likes
        {
            get
            {
                return 0;
            }
        }
    }
}