using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Labyrinth.Game;

namespace Labyrinth.Tests
{
    [TestFixture]
    public class FriendTest
    {
        [Test]
        public void FriendAndPlayer()
        {
            Friend friend = new Friend(new PointLabirinth(0,0),new IInteractable[,] { { null } });
            Player player = new Player(new ControlStyleMove(new IInteractable[,] { { null } }));
            friend.Interact(player);
            int i = 0;
            Assert.That(i, Is.Not.EqualTo(player.HealPoints));
            //Assert.That(player.HealPoints, Is.Not.EqualTo(player.HealPoints));
        }
    }
}
