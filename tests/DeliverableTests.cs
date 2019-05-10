using System;
using Xunit;
using Composition_And_Delegation;

namespace Composition_And_Delegation.Tests
{
    public class DeliverableTests
    {
        private static Technician technician = new Technician("Entregable", "");

        [Fact]
        public void TestNewSongHasZeroLikes()
        {
            const string name = "Entregable";
            ILikeable song = new Deliverable(name, technician, "");

            Assert.Equal(0, song.Likes);
        }

        [Fact]
        public void TestLikeAddLikes()
        {
            const string name = "Entregable";
            ILikeable song = new Deliverable(name, technician, "");

            song.Like();

            Assert.Equal(1, song.Likes);
        }

        [Fact]
        public void TestUnlikeRemoveLikes()
        {
            const string name = "Entregable";
            ILikeable song = new Deliverable(name, technician, "");

            song.Like();
            song.Unlike();

            Assert.Equal(0, song.Likes);

            song.Unlike();

            Assert.Equal(0, song.Likes);
        }
    }
}
