using NUnit.Framework;
using System;
using System.Numerics;
using System.Xml.Linq;

namespace FootballTeam.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase("asd", 15)]
        [TestCase("aoiufhdv", 20)]
        public void ConstructorTest(string name, int capacity)
        {
            FootballTeam ft = new FootballTeam(name, capacity);
            Assert.AreEqual(name, ft.Name);
            Assert.AreEqual(capacity, ft.Capacity);
        }

        [TestCase("")]
        [TestCase(null)]
        public void NameTest_ShouldThrow(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FootballTeam ft = new FootballTeam(name, 20);
            });
        }

        [TestCase(0)]
        [TestCase(14)]
        public void CapacityTest_ShouldThrow(int value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FootballTeam ft = new FootballTeam("name", value);
            });
        }

        [Test]
        public void AddPlayerTests()
        {
            FootballTeam ft = new FootballTeam("asd", 15);
            ft.AddNewPlayer(new FootballPlayer("asdf", 7, "Forward"));
            Assert.AreEqual(1, ft.Players.Count);
        }

        [Test]
        public void AddPlayerTests_Invalid()
        {
            string message = "";
            FootballTeam ft = new FootballTeam("asd", 15);
            for (int i = 0; i < 16; i++)
            {
                message = ft.AddNewPlayer(new FootballPlayer("asdf", 7, "Forward"));
            }
            Assert.AreEqual("No more positions available!", message);
        }

        [Test]
        public void PlayerScore()
        {
            FootballPlayer player1 = new FootballPlayer("asd", 7, "Forward");
            FootballPlayer player2 = new FootballPlayer("safdf", 8, "Forward");
            FootballTeam ft = new FootballTeam("asd", 20);
            ft.AddNewPlayer(player1);
            ft.AddNewPlayer(player2);
            Assert.AreEqual(player1, ft.PickPlayer("asd"));
            Assert.AreEqual($"{player1.Name} scored and now has {player1.ScoredGoals + 1} for this season!", ft.PlayerScore(7));
        }

        [TestCase(0)]
        [TestCase(22)]
        public void PlayerNumberTests_ShouldThrow(int n)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FootballPlayer player = new FootballPlayer("sad", n, "Forward");
            });
        }

        [TestCase(1)]
        [TestCase(21)]
        [TestCase(7)]
        public void PlayerNumberValid(int n)
        {
            FootballPlayer player = new FootballPlayer("sad", n, "Forward");
            Assert.AreEqual(n, player.PlayerNumber);
        }

        [TestCase("Goalkeeper")]
        [TestCase("Midfielder")]
        [TestCase("Forward")]
        public void PossitionTestValid(string possition)
        {
            FootballPlayer player = new FootballPlayer("saf", 7, possition);
            Assert.AreEqual(possition, player.Position);
        }

        [TestCase("Goalkesdeper")]
        [TestCase("Midfafielder")]
        [TestCase("Forwagrrwvard")]
        public void PossitionTestInValid(string possition)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FootballPlayer player = new FootballPlayer("saf", 7, possition);
            });
        }

        [Test]
        public void ScoreMethod()
        {
            FootballPlayer player = new FootballPlayer("sad", 7, "Forward");
            for (int i = 0; i < 7; i++)
            {
                player.Score();
            }
            Assert.AreEqual(7, player.ScoredGoals);
        }
    }
}