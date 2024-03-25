namespace Tesztek
{
    public class Tests
    {
        [Fact]
        public void FirstCharTest()
        {
            string input = "alma körte barack";
            string expected = "lma örte arack";
            string result = Stringatalakitas.Program.FirstCharacterRemove(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void LastCharTest()
        {
            string input = "alma körte barack";
            string expected = "alm kört barac";
            string result = Stringatalakitas.Program.LastCharacterRemove(input);
            Assert.Equal(expected, result);
        }

        //[Fact]
        //public void WrongCharTest()
        //{
        //    string input = "alma körte barack";
        //    string expected = "alm kört barac";
        //    string result = Stringatalakitas.Program.FirstCharacterRemove(input);
        //    Assert.Equal(expected, result);
        //}
    }
}