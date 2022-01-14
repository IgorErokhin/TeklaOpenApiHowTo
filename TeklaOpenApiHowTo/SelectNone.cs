using Tekla.Structures.Model.UI;

namespace TeklaOpenApiHowTo
{
    public class SelectNone_
    {
        public static void SelectNone()
        {
            ModelObjectSelector selector = new ModelObjectSelector();
            selector.Select(new System.Collections.ArrayList { });
        }
    }
}
