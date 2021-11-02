using NUnit.Framework;

namespace ClassLibrary.TestSuite
{
    public class CoreTest
    {
        Core TestObject { get; set; }

        /// <summary>
        /// Succesfull start of game
        /// </summary>
        [Test]
        public void GameStart_Score()
        {
            Core testObj = new Core();

            Assert.True("0-0" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for 1 point scored by PlayerOne
        /// </summary>
        [Test]
        public void Player1_Score()
        {
            Core testObj = new Core();

            testObj.PlayerOneScore();

            Assert.True("15-0" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for 1 point scored by PlayerTwo
        /// </summary>
        [Test]
        public void Player2_Score()
        {
            Core testObj = new Core();

            testObj.PlayerTwoScore();

            Assert.True("0-15" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for 3 point scored by PlayerOne
        /// </summary>
        [Test]
        public void Player1_Score_x3()
        {
            Core testObj = new Core();

            testObj.PlayerOneScore();
            testObj.PlayerOneScore();
            testObj.PlayerOneScore();

            Assert.True("40-0" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for 3 point scored by PlayerTwo
        /// </summary>
        [Test]
        public void Player2_Score_x3()
        {
            Core testObj = new Core();

            testObj.PlayerTwoScore();
            testObj.PlayerTwoScore();
            testObj.PlayerTwoScore();

            Assert.True("0-40" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for Deuce
        /// </summary>
        [Test]
        public void Deuce()
        {
            Core testObj = new Core();

            testObj.PlayerOneScore(); 
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            Assert.True("Deuce" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for Server wins game
        /// </summary>
        [Test]
        public void ServerWinsGame()
        {
            Core testObj = new Core();

            testObj.PlayerOneScore();
            testObj.PlayerOneScore();
            testObj.PlayerOneScore();
            testObj.PlayerOneScore();

            Assert.True("Server wins game" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for Server loses game
        /// </summary>
        [Test]
        public void ServerLosesGame()
        {
            Core testObj = new Core();

            testObj.PlayerTwoScore();
            testObj.PlayerTwoScore();
            testObj.PlayerTwoScore();
            testObj.PlayerTwoScore();

            Assert.True("Server loses game" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for Advantage server
        /// </summary>
        [Test]
        public void AdvantageServer()
        {
            Core testObj = new Core();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerOneScore();


            Assert.True("Advantage server" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for Advantage non-server
        /// </summary>
        [Test]
        public void AdvantageNonServer()
        {
            Core testObj = new Core();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerTwoScore();
            testObj.PlayerTwoScore();

            Assert.True("Advantage non-server" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for Deuce after Advantage server
        /// </summary>
        [Test]
        public void DeuceAfterAdvantageServer()
        {
            Core testObj = new Core();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerOneScore();

            testObj.PlayerTwoScore();

            Assert.True("Deuce" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for Deice after Advantage non-server
        /// </summary>
        [Test]
        public void DeuceAfterAdvantageNonServer()
        {
            Core testObj = new Core();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerTwoScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();

            Assert.True("Deuce" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for Advantage server
        /// </summary>
        [Test]
        public void WinAfterAdvantageServer()
        {
            Core testObj = new Core();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerOneScore();

            testObj.PlayerOneScore();

            Assert.True("Server wins game" == testObj.GetScore());
        }

        /// <summary>
        /// Succesfull test for Advantage non-server
        /// </summary>
        [Test]
        public void LossAfterAdvantageNonServer()
        {
            Core testObj = new Core();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerOneScore();
            testObj.PlayerTwoScore();

            testObj.PlayerTwoScore();
            testObj.PlayerTwoScore();

            testObj.PlayerTwoScore();

            Assert.True("Server loses game" == testObj.GetScore());
        }
    }
}