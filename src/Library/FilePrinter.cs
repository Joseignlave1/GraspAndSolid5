using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(ItextPrinter itextPrinter)
        {
            File.WriteAllText("Recipe.txt", itextPrinter.GetTextToPrint());
        }
    }
}