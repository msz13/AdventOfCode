namespace AdventOfCode
{
    public class ElvesItemsInventory
    {
        private List<ElfInventory> itemsCalories;

        public ElvesItemsInventory(string itemsCalories)
        {
            this.itemsCalories = ElfInventoryParser.Parse(itemsCalories); 
        }

        public int CaloriesOfElveWithMaxCalories()
        {
            return this.itemsCalories.Select(inventory => inventory.GetAllCalories()).Max();
        }

        public double GetCaloriesOfElve(int elveNumber)
        {
            return itemsCalories[elveNumber-1].GetAllCalories();
        }

    }      
}