using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet7Challenges.Tests;

using NUnit.Framework;

class ChallengesTests
{
    [Test]
    public void TestPositiveAddTillNumber()
    {
        // Arrange
        int n = 5;
        int expectedSum = 15;
        Challenges challenges = new Challenges();

        // Act
        int actualSum = challenges.AddTillNumber(n);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }

    [Test]
    public void TestNegativeAddTillNumber()
    {
        // Arrange
        int n = -5;
        int expectedSum = -15;
        Challenges challenges = new Challenges();

        // Act
        int actualSum = challenges.AddTillNumber(n);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }

    [Test]
    public void TestZeroAddTillNumber()
    {
        // Arrange
        int n = 0;
        int expectedSum = 0;
        Challenges challenges = new Challenges();

        // Act
        int actualSum = challenges.AddTillNumber(n);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }
}