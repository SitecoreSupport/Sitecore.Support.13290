using Sitecore.ContentSearch.ComputedFields;
using Sitecore.ContentSearch;
using Sitecore.Data.Items;

namespace Sitecore.XA.Foundation.Search.ComputedFields
{
    public class ParentName : AbstractComputedIndexField
    {
        public override object ComputeFieldValue(IIndexable indexable)
        {
            Item item = indexable as SitecoreIndexableItem;

            if (item?.Parent == null)
            {
                return false;
            }

            return item.Parent.Name;
        }
    }
}