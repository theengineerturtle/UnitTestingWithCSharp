# UnitTestingWithCSharp
## Course by Mosh Hamedani

### Fundamentals Of Unit Testing

#### Example Unit Test Method
```
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
```

### Test-driven Development
- Write a failing test.
- Write the simplest code to make the test pass.
- Refactor if necessary.

### Benefits of TDD
- Testable Source Code
- Full Coverage by Tests
- Simpler Implementation
- Test first/code first.

### Characteristic of Good Unit Tests
1- Clean, readable and maintable:less than 10 lines and single responsibility.\
2- No logic in Test for not write a bug in test, logic should be in production code only.\
 ```
if(...){}
else(...){}
foreach(...){}
```
3- Isolated: not call eac other.\
4- Not too specific/general

### Functions : Query & Command
Query functions returns data, so control if it is return true value.\
Command functions : Peroforms an action.Write db,change object in memory, sending a message in message queu\
so you make change in system.Check the outcome of the method.We check the outcome is the right way\
with external dependencies for example adding a new reservation in database and as a external \
dependencies check the db if new reservation added with new id.

### Do not test
You should not test Language features and 3rd-party codes, you should assume that they are properly tested, you should test only your code.\
Test Classes:\
Reservation.cs -> ReservationTests.cs\
Number of tests => Number of Execution Paths

### Bad Tests
Test1()\
SaveCustomerTest()\
GetMovie()

### Test Method Name
[MethodName]_[Scenario]_[ExpectedBehaviour]

### Trustworthy
Writing production code before test code sometimes may be makes bugs.\
If you write your test code after production, make small changes in\
production(not true values) code to check test code is trustworthy, \
if it is still passing it is not trustworthy\
also check the test tests the right thing.\
You shouldn't test private methods!










