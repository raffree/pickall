using System.Linq;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;

namespace PickAll.Internal
{
    static class IHtmlElementExtensions
    {
        public static string FirstChildText(this IHtmlElement element,
            params string[] selectorsGroup)
        {
            foreach (var selectors in selectorsGroup) {
                var selected = element.QuerySelector(selectors);
                if (selected != null) {
                    if (selected.ChildNodes.Count() > 0) {
                        return selected.FirstChild.Text();
                    }
                }
            }
            return string.Empty;
        }
    }
}