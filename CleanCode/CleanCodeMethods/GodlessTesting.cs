namespace CleanCodeMethods
{
    public class GodlessTesting
    {
        public string AddStrings(string firstString, string secondString)
        {
            var addedString = firstString + secondString;
            return addedString;

        }

        public bool AddStrings_ReturnOneString()
        {
            //Arrange
            var firstString = "Niklas";
            var secondString = "Hjelm";
            var expected = "NiklasHjelm";

            //Act
            var testString = AddStrings(firstString, secondString);


            //Assert
            if (testString == expected)
            {
                return true;
            }
            return false;
        }
    }
}