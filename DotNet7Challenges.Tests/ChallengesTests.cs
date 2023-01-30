using NUnit.Framework;

namespace DotNet7Challenges.Tests;


class Challenge1Tests
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

class Challenge2Tests
{
    [Test]
    public void TestReverseStringWithNormalString()
    {
        // Arrange
        string input = "hello";
        string expectedOutput = "olleh";
        Challenges challenges = new Challenges();

        // Act
        string actualOutput = challenges.ReverseString(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void TestReverseStringWithEmptyString()
    {
        // Arrange
        string input = "";
        string expectedOutput = "";
        Challenges challenges = new Challenges();

        // Act
        string actualOutput = challenges.ReverseString(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void TestReverseStringWithPalindrome()
    {
        // Arrange
        string input = "madam";
        string expectedOutput = "madam";
        Challenges challenges = new Challenges();

        // Act
        string actualOutput = challenges.ReverseString(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}

class Challenge3Tests
{
        [Test]
    public void TestFindMissingNumberWithNormalArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 4, 5 };
        int expectedOutput = 3;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindMissingNumber(numbers);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void TestFindMissingNumberWithMissingNumberAtStart()
    {
        // Arrange
        int[] numbers = new int[] { 2, 3, 4 };
        int expectedOutput = 1;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindMissingNumber(numbers);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void TestFindMissingNumberWithMissingNumberAtEnd()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3 };
        int expectedOutput = 4;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindMissingNumber(numbers);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
    [Test]
    public void TestFindMissingNumberWithDuplicateNumbers()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 2, 4 };
        int expectedOutput = 3;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindMissingNumber(numbers);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void TestFindMissingNumberWithNegativeNumbers()
    {
        // Arrange
        int[] numbers = new int[] { -1, -2, -3, -5 };
        int expectedOutput = -4;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindMissingNumber(numbers);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void TestFindMissingNumberWithLongArray()
    {
        // Arrange
        int[] numbers = new int[10000];
        for (int i = 1; i <= 10000; i++)
        {
            if (i != 5000)
                numbers[i - 1] = i;
        }
        int expectedOutput = 5000;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindMissingNumber(numbers);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void TestFindMissingNumberWithSingleNumberArray()
    {
        // Arrange
        int[] numbers = new int[] { 2 };
        int expectedOutput = 1;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindMissingNumber(numbers);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void TestFindMissingNumberWithEmptyArray()
    {
        // Arrange
        int[] numbers = new int[] { };
        Challenges challenges = new Challenges();

        // Act and Assert
        Assert.Throws<ArgumentException>(() => challenges.FindMissingNumber(numbers));
    }

}

class Challenge4Test
{
    [Test]
    public void TestFindLongestSubstringWithoutRepeatingCharacters()
    {
        // Arrange
        string input = "abcabcbb";
        int expectedOutput = 3;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindLongestSubstringWithoutRepeatingCharacters(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
    [Test]
    public void TestFindLongestSubstringWithoutRepeatingCharacters_with_same_characters()
    {
        // Arrange
        string input = "bbbbb";
        int expectedOutput = 1;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindLongestSubstringWithoutRepeatingCharacters(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
    [Test]
    public void TestFindLongestSubstringWithoutRepeatingCharacters_with_no_duplicates()
    {
        // Arrange
        string input = "abcdefghijklmnopqrstuvwxyz";
        int expectedOutput = 26;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindLongestSubstringWithoutRepeatingCharacters(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
    [Test]
    public void TestFindLongestSubstringWithoutRepeatingCharacters_with_mixed_characters()
    {
        // Arrange
        string input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int expectedOutput = 52;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindLongestSubstringWithoutRepeatingCharacters(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
    public void TestFindLongestSubstringWithoutRepeatingCharacters_with_empty_string()
    {
        // Arrange
        string input = "";
        int expectedOutput = 0;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindLongestSubstringWithoutRepeatingCharacters(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
    [Test]
    public void TestFindLongestSubstringWithoutRepeatingCharacters_with_special_characters()
    {
        // Arrange
        string input = "!@#$%^&*()_+=-";
        int expectedOutput = 12;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindLongestSubstringWithoutRepeatingCharacters(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
    [Test]
    public void TestFindLongestSubstringWithoutRepeatingCharacters_with_numbers()
    {
        // Arrange
        string input = "1234567890";
        int expectedOutput = 10;
        Challenges challenges = new Challenges();

        // Act
        int actualOutput = challenges.FindLongestSubstringWithoutRepeatingCharacters(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}