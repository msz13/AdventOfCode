namespace AdventOfCode
{
    public class ElfInventoryParser
    {
        public static List<ElfInventory>? Parse(string elvesInventories)
        {
            return elvesInventories.Split(new String[] {Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Select(items => ElfInventory.FormStringList(items)).ToList();
           
        }
    }
}