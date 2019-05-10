//------------------------------------------------------------------------------
// <copyright file="LikesTracker.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Twitter;


namespace Composition_And_Delegation
{
    /// <summary>
    /// Un ayudante para llevar la cuenta de veces que "me gusta" algo.
    /// </summary>
    public class LikesTracker
    {
        private Int32 count;

        private string tracked;

        private string image;

        const string ConsumerKey = "<insert coin here>";
        const string ConsumerKeySecret = "<insert coin here>";
        const string AccessToken = "<insert coin here>";
        const string AccessTokenSecret = "<insert coin here>";

        // private TwitterApi twitter = new TwitterApi(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
        private TwitterImage twitter = new TwitterImage(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);

        /// <summary>
        /// Crea una nueva instancia.
        /// </summary>
        /// <param name="tracked">El nombre del elemento sobre el que contar los "me gusta".</param>
        /// <param name="image">La imagen delemento sobre el que contar los "me gusta".</param>
        public LikesTracker(string tracked, string image)
        {
            this.tracked = tracked;
            this.image = image;
        }

        /// <summary>
        /// Un entero que representa cuánto gusta.
        /// </summary>
        /// <returns>La diferencia entre las veces que se agregó un "me gusta" mediante <see cref="LikesTracker.Add"/>
        /// menos las veces que se quitó un me gusta" mediante mediante <see cref="LikesTracker.Remove"/>. Mayor o igual
        /// que cero.</returns>
        public Int32 Count
        {
            get
            {
                return this.count;
            }
        }

        /// <summary>
        /// Aumenta <see cref="LikesTracker.Count"/> en uno y lo publica en Twitter.
        /// </summary>
        public void Add()
        {
            this.count = this.count + 1;
            // this.twitter.Tweet($"{this.tracked} tiene un nuevo like! :)").Wait();
            this.twitter.PublishToTwitter($"{this.tracked} tiene un nuevo like! :)", this.image);
        }

        /// <summary>
        /// Disminuye <see cref="LikesTracker.Count"/> en uno si es mayor que cero y lo publica en Twitter.
        /// </summary>
        public void Remove()
        {
            if (this.count > 0)
            {
                this.count = this.count - 1;
                // this.twitter.Tweet($"{this.tracked} tiene un like menos :(").Wait();
                this.twitter.PublishToTwitter($"{this.tracked} tiene un like menos :(", this.image);

            }
        }
    }
}