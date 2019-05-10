//---------------------------------------------------------------------------
// <copyright file="ILikeable.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------

namespace Composition_And_Delegation
{
    using System;

    public interface ILikeable
    {
        /// <summary>
        /// Un entero que representa cuánto gusta.
        /// </summary>
        /// <returns>La diferencia entre las veces que se dio "me gusta" mediante <see cref="ILikeable.Like()"/> menos
        /// las veces que se dio "no me gusta" mediante mediante <see cref="ILikeable.Unlike()"/>. Mayor o igual que
        /// cero.</returns>
        int Likes { get; }

        /// <summary>
        /// Permite indicar que "me gusta" y aumenta <see cref="ILikeable.Likes"/> en uno.
        /// </summary>
        void Like();

        /// <summary>
        /// Permite indicar que "no me gusta" y disminuye <see cref="ILikeable.Likes"/> en uno si es mayor que cero.
        /// </summary>
        void Unlike();
    }
}