using AdventOfCode;
using NUnit.Framework;
using System;

namespace AdventOfCodeTests
{
    public class ElvesCalories
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]        
        public void ShouldShowElvesInventoryCalories()
        {
            var itemsCalories = @"1000
                                  2000
                                  3000

                                  4000

                                  5000
                                  6000

                                  7000
                                  8000
                                  9000

                                  10000";

            var elvesInventory = new ElvesItemsInventory(itemsCalories);           


            Assert.AreEqual(6000, elvesInventory.GetCaloriesOfElve(1));
            Assert.AreEqual(4000, elvesInventory.GetCaloriesOfElve(2));
            Assert.AreEqual(11000, elvesInventory.GetCaloriesOfElve(3));
            Assert.AreEqual(24000, elvesInventory.GetCaloriesOfElve(4));
            Assert.AreEqual(10000, elvesInventory.GetCaloriesOfElve(5));
        }

        [Test]
        public void ShouldShowCaloriesOfElfWithInventoryWithMaxCalories()
        {
            var itemsCalories = @"1000
                                  2000
                                  3000

                                  4000

                                  5000
                                  6000

                                  7000
                                  8000
                                  9000

                                  10000";

            var elvesInventory = new ElvesItemsInventory(itemsCalories);

            Assert.AreEqual(24000, elvesInventory.CaloriesOfElveWithMaxCalories());


        }

        [Test]
        public void ShouldShowCaloriesOfNElvesInventory()
        {
            var itemsCalories = @"1000
                                  2000
                                  3000

                                  4000

                                  5000
                                  6000

                                  7000
                                  8000
                                  9000

                                  10000";

            var elvesInventory = new ElvesItemsInventory(itemsCalories);

            Assert.AreEqual(45000, elvesInventory.SumOfCaloriesOfNElvesWithBiggestCalories(3));


        }



    }

    public class ElveInventoryTests
    {
        [Test]
        public void ShouldShowItemsCalories()
        {
            var itemsCalories = @"1000
                                  2000
                                  3000";
            var elfInventory = ElfInventory.FormStringList(itemsCalories);
            Assert.AreEqual(6000, elfInventory.GetAllCalories());

        }

        [Test]
        [Ignore("Fail")]
        public void ShouldThrowWithInvalidInput()
        {
            var itemsCalories = @"rrr";

            Assert.Throws<ArgumentException>(() => ElfInventory.FormStringList(itemsCalories));   
            Assert.Throws(Is.TypeOf<ArgumentException>().And.Message.EqualTo("Invalid item 'rrrr'. Must Be number"), ()=> ElfInventory.FormStringList(itemsCalories));
        }

    }


    public class ElfInventoryParserTests
    {
        [Test]
        public void ShouldParseItems()
        {
            var itemsCalories = @"1000
                                  2000

                                  3000";

            var parsedItems = ElfInventoryParser.Parse(itemsCalories);


            Assert.AreEqual(2, parsedItems.Count);

            

        }
    }
}