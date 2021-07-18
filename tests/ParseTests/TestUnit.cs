using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class_Scheduler.Tests.ParseTests
{
    [TestClass]
    public class TestUnit
    {
        [TestMethod]
        public void TestUnitOutput()
        {
            //Replace this filename with what file you want to test.
            List<String> fileContents = FileReading.readFile("tests/units.json");

            FileParser fileParser = new FileParser();

            //Checks whether the data is staff or unit.
            String dataType = fileParser.checkDataType(fileContents);

            if (dataType.Equals("unitData"))
            {
                List<Unit> unitList = fileParser.parseUnitData(fileContents);

                foreach (Unit currentUnit in unitList)
                {
                    Console.WriteLine(currentUnit.ToString() + "\n");
                }
            }
            else
            {
                //Add a custom exception here later.
            }
        }
    }
}