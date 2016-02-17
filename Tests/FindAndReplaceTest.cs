using System.Collections.Generic;
using Xunit;
namespace FindAndReplace.Objects
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void Test1_IfInput2ReplacesInput3_ReturnInput3()
    {
      //Arrange
      string input1 = "Hello";
      string input2 = "Hello";
      string input3 = "Goodbye";
      FindAndReplaceWord testWord = new FindAndReplaceWord(input1, input2, input3);

      //Act
      string result = testWord.GetResults();

      //Assert
      Assert.Equal("Goodbye", result);
    }
    [Fact]
    public void Test2_IfInput2ReplacesMultipleInputs_ReturnInput3()
    {
      //Arrange
      string input1 = "Once upon a time there was a dude named Simon. simon was really cool.";
      string input2 = "Simon";
      string input3 = "Will";
      FindAndReplaceWord testWord = new FindAndReplaceWord(input1, input2, input3);

      //Act
      string result = testWord.GetResults();

      //Assert
      Assert.Equal("Once upon a time there was a dude named Will. Will was really cool.", result);
    }
  }
}
