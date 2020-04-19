using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanbeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanbeCancelledBy_SameUserCancellingTheReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation();
            reservation.MadeBy = user;

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CanbeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();
            var user = new User();

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
