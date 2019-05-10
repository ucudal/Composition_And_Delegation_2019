using System;
using Xunit;
using Composition_And_Delegation;

namespace Composition_And_Delegation.Tests
{
    public class TechnicianTests
    {
        [Fact]
        public void TestNewActorHasZeroLikes()
        {
            const string name = "Técnico";
            ILikeable actor = new Technician(name, "");

            Assert.Equal(0, actor.Likes);
        }

        [Fact]
        public void TestLikeAddLikes()
        {
            const string name = "Técnico";
            ILikeable actor = new Technician(name, "");

            actor.Like();

            Assert.Equal(1, actor.Likes);
        }

        [Fact]
        public void TestUnlikeRemoveLikes()
        {
            const string name = "Técnico";
            ILikeable actor = new Technician(name, "");

            actor.Like();
            actor.Unlike();

            Assert.Equal(0, actor.Likes);

            actor.Unlike();

            Assert.Equal(0, actor.Likes);
        }
    }
}
