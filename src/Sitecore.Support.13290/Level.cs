using Sitecore.ContentSearch.ComputedFields;
using Sitecore.ContentSearch;
using Sitecore.Data.Items;

namespace Sitecore.Support.XA.Foundation.Search.ComputedFields
{
  public class Level : AbstractComputedIndexField
  {
    public override object ComputeFieldValue(IIndexable indexable)
    {
      Item item = indexable as SitecoreIndexableItem;

      if (item?.Parent == null)
      {
        return 0;
      }

      return item.Axes.Level;
    }
  }
}