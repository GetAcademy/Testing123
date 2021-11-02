using NUnit.Framework;
using Testing123;

namespace TestProject1
{
    public class TrafficLightTest
    {
        [Test]
        public void TestFirstPhaseAgain()
        {
            // arrange
            var trafficLight = new TrafficLight();

            // act
            trafficLight.NextPhase();
            trafficLight.NextPhase();
            trafficLight.NextPhase();
            trafficLight.NextPhase();

            // assert
            Assert.IsTrue(trafficLight.IsRedOn);
            Assert.IsFalse(trafficLight.IsYellowOn);
            Assert.IsFalse(trafficLight.IsGreenOn);
        }


        [Test]
        public void TestFourthPhase()
        {
            // arrange
            var trafficLight = new TrafficLight();

            // act
            trafficLight.NextPhase();
            trafficLight.NextPhase();
            trafficLight.NextPhase();

            // assert
            Assert.IsFalse(trafficLight.IsRedOn);
            Assert.IsTrue(trafficLight.IsYellowOn);
            Assert.IsFalse(trafficLight.IsGreenOn);
        }

        [Test]
        public void TestThirdPhase()
        {
            // arrange
            var trafficLight = new TrafficLight();

            // act
            trafficLight.NextPhase();
            trafficLight.NextPhase();

            // assert
            Assert.IsFalse(trafficLight.IsRedOn);
            Assert.IsFalse(trafficLight.IsYellowOn);
            Assert.IsTrue(trafficLight.IsGreenOn);
        }

        [Test]
        public void TestSecondPhase()
        {
            // arrange
            var trafficLight = new TrafficLight();

            // act
            trafficLight.NextPhase();

            // assert
            Assert.IsTrue(trafficLight.IsRedOn);
            Assert.IsTrue(trafficLight.IsYellowOn);
            Assert.IsFalse(trafficLight.IsGreenOn);
        }

        [Test]
        public void TestNewTrafficLightIsRed()
        {
            // arrange
            var trafficLight = new TrafficLight();

            // act

            // assert
            Assert.IsTrue(trafficLight.IsRedOn);
            Assert.IsFalse(trafficLight.IsYellowOn);
            Assert.IsFalse(trafficLight.IsGreenOn);
        }
    }
}