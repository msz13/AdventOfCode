namespace AdventOfCode
{
    public class ElfInventory
    {
        private IEnumerable<int> itemsCaloriesList;

        public ElfInventory()
        {
        }

        public ElfInventory(string itemsCaloriesList)
        {
            this.itemsCaloriesList = itemsCaloriesList.Split(Environment.NewLine).Select(item => ParseItemCalories(item));
        }

        private static int ParseItemCalories(string item)
        {
            var result = Int32.TryParse(item, out var itemCalories);
            if (result == false)
            {
                throw new ArgumentException(item);
            }
            return itemCalories;
        }

        public int GetAllCalories()
        {
            return itemsCaloriesList.Sum();
        }

        public static ElfInventory FormStringList(string itemsCaloriesList)
        {
            return new ElfInventory(itemsCaloriesList);
        }

    }
}