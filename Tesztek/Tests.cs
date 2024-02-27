namespace Tesztek
{
    public class Tests
    {
        [Fact]
        public void FirstCharTest()
        {
            string input = "alma körte";
            string expected = "lma örte";
            string result = Stringatalakitas.Program.FirstCharacterRemove(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void LastCharTest()
        {
            string input = "alma körte";
            string expected = "alm kört";
            string result = Stringatalakitas.Program.LastCharacterRemove(input);
            Assert.Equal(expected, result);
        }
    }
}