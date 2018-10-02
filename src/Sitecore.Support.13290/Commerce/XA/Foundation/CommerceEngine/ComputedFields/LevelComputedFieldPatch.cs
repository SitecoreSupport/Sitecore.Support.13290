using Sitecore.ContentSearch;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.Search.ComputedFields;
using System;

namespace Sitecore.Support.Commerce.XA.Foundation.CommerceEngine.ComputedFields
{
    public class LevelComputedFieldPatch : Level
    {
        public override object ComputeFieldValue(IIndexable indexable)
        {
            #region - modified part to use patched ComputeFieldValue method
            object obj2 = this.SupportComputeFieldValue(indexable);
            #endregion
            if ((obj2 != null) && typeof(int).IsAssignableFrom(obj2.GetType()))
            {
                return obj2;
            }
            return 0;
        }

        #region patched method to return 0 instead of false when item is Sitecore root item
        public object SupportComputeFieldValue(IIndexable indexable)
        {
            Item item = indexable as SitecoreIndexableItem;

            if (item?.Parent == null)
            {
                return 0;
            }

            return item.Axes.Level;
        }
        #endregion
    }
}