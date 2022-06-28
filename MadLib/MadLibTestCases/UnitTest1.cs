
namespace MadLibTestCases
{
    public class Tests
    {
        MadLib mL;
        string name;
        string color;
        [SetUp]
        public void Setup()
        {
            name = "Austin";
            color = "Green";
            mL = new MadLib();
        }

        [Test]
        public void NameTest()
        {
            string sentance = mL.MakeSentance(name, color, name, color, name);
            if (sentance.Contains(" " + name)) Assert.Pass();
            else Assert.Fail("Your sentance does not include the 'name' variable or does not use proper spacing.");
        }
    }
}