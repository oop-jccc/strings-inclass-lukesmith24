using System.Text;

namespace greeting_builder_tests;

internal record Person
{
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
}

public class GreetingTests
{
    private const string ExpectedGreeting = "Hello, John Wayne";

    private readonly Person _person = new()
    {
        FirstName = "John",
        LastName = "Wayne"
    };

    [Test]
    public void PlusOverloadOperatorTest()
    {
        var actualGreeting = "Hello, " + _person.FirstName + " " + _person.LastName;
        Assert.That(actualGreeting, Is.EqualTo(ExpectedGreeting));
    }

    [Test]
    public void ConcatTest()
    {
        var actualGreeting = string.Concat("Hello, ", _person.FirstName, " ", _person.LastName); // TODO: Use string.Concat to create the greeting
        Assert.That(actualGreeting, Is.EqualTo(ExpectedGreeting));
    }

    [Test]
    public void FormatTest()
    {
        var actualGreeting = string.Format("Hello, {0} {1}", _person.FirstName, _person.LastName); // TODO: Use string.Format to create the greeting
        Assert.That(actualGreeting, Is.EqualTo(ExpectedGreeting));
    }

    [Test]
    public void StringBuilderTest()
    {
        var actualGreeting = ""; // TODO: Use StringBuilder to create the greeting
        Assert.That(actualGreeting, Is.EqualTo(ExpectedGreeting));
    }

    [Test]
    public void InterpolationTest()
    {
        var actualGreeting = ""; // TODO: Use string interpolation to create the greeting
        Assert.That(actualGreeting, Is.EqualTo(ExpectedGreeting));
    }
}