namespace CleanCodeMethods
{
    public class GodlessTesting
    {
        //public string AddStrings(string firstString, string secondString)
        //{
        //    var addedString = firstString + secondString;
        //    return addedString;
        //}

        //public bool AddStrings_ReturnOneString()
        //{
        //    //Arrange
        //    var firstString = "Niklas";
        //    var secondString = "Hjelm";
        //    var expected = "NiklasHjelm";

        //    //Act
        //    var testString = AddStrings(firstString, secondString);


        //    //Assert
        //    if (testString == expected)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public int ThreesInArray(int[] array)
        {
            int result = 0;

            foreach (var number in array)
            {
                if (number == 3)
                {
                    result++;
                }
            }
            return result;
        }

        public bool ThreesInArray_ReturnsNumberOfThrees()
        {
            //Arrange
            int[] array = {3, 3, 3, 2, 1, 5 ,3};
            var expected = 4;

            //Act
            var result = ThreesInArray(array);

            //Assert
            if (expected == result)
            {
                return true;
            }
            return false;
        }

        public int[] ArrayOfThreesGenerator(int numberOfThreesDesired)
        {
            var result = new List<int>();

            for (int i = 0; i < numberOfThreesDesired; i++)
            {
                result.Add(3);
            }

            return result.ToArray();
        }

        public bool ArrayOfThreesGenerator_ReturnsCorrectArray()
        {
            //Arrange
            int numberOfThrees = 5;
            var expected = new [] { 3, 3, 3, 3, 3 };

            //Act
            var result = ArrayOfThreesGenerator(numberOfThrees);

            //Assert
            if (expected.Length != result.Length)
            {
                return false;
            }

            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != result[i])
                {
                    return false;
                }
            }

            return true;
        }

        public int[] ReverseArray(int[] array)
        {
            return array.Reverse().ToArray();
        }

        public bool ReverseArray_ArrayReversed()
        {
            //Arrange 
            var array = new[] { 1, 2, 3, 4, 5, 6 };
            var expected = new[] { 6, 5, 4, 3, 2, 1 };

            //Act
            var result = ReverseArray(array);

            //Assert
            if (expected.Length != result.Length)
            {
                return false;
            }

            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != result[i])
                {
                    return false;
                }
            }

            return true;
        }

        public int CalculateDaysLived(DateTime dateOfBirth)
        {
            return (DateTime.Today - dateOfBirth).Days;
        }

        public bool CalculateDaysLived_CalculatesDays()
        {
            //Arrange
            DateTime dob = new DateTime(year:1991, month:1, day:1);
            var expected = 12007;
            
            //Act
            var result = CalculateDaysLived(dob);

            //Assert
            if (expected == result)
            {
                return true;
            }
            return false;
        }

        public List<int> RandomHundredInts()
        {
            var randomList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                randomList.Add(0);
            }

            return randomList;
        }

        public bool RandomHundredInts_ReturnsExpectedList()
        {
            //Arrange

            //Act
            var randomList = RandomHundredInts();

            //Assert

            if (randomList.Count != 100)
            {
                return false;
            }

            foreach (var number in randomList)
            {
                if (1 > number || number > 100)
                {
                    return false;
                }
            }

            return true;
        }

    }
}