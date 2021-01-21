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
            int hp = player.HealPoints;
            friend.Interact(player);
            Assert.That(hp, Is.Not.EqualTo(player.HealPoints));
        }
    }
}
