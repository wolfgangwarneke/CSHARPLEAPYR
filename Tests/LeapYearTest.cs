using Xunit;
namespace LeapYear
{
  public class LeapYearTest
  {
    [Fact]
    public void IsLeapYear_ForNumberNotDivisibleByFour_false()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(false, testLeapYear.IsLeapYear(1999));
    }
    [Fact]
    public void IsLeapYear_ForMultiolesOfOneHundred_false()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(false, testLeapYear.IsLeapYear(1900));
    }
    [Fact]
    public void IsLeapYear_ForMultiplesOfFourHundred_true()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true, testLeapYear.IsLeapYear(1600));
    }
  }
}
