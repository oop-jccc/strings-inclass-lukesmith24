### In-Class Programming Assignment: Email Validator

#### Objective
Create a test class to validate email addresses. You will use the `Contains` and `EndsWith` methods to check for the '@' symbol and domain names.

#### Requirements

1. You are provided with a starter code. Your task is to complete the `IsValidEmailTest` method.
2. In the test method, validate the email address by checking:
    - If it contains the '@' symbol.
    - If it ends with a specific domain like ".com".

#### Starter Code

```csharp
using System.Diagnostics.CodeAnalysis;

namespace email_validator_tests;

[TestFixture]
[SuppressMessage("Performance", "CA1847:Use char literal for a single character lookup")]
public class EmailValidatorTest
{
    [Test]
    public void IsValidEmailTest()
    {
        const string email = "example@example.com";
        var isValid = false; // TODO: use Contains "@" && EndsWith ".com" to check if email is valid
        Assert.That(isValid, Is.True);
    }
}
```