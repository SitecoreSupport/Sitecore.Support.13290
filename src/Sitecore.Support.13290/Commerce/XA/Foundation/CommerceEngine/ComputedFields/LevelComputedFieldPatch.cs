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
            object obj2 = base.ComputeFieldValue(indexable);
            if ((obj2 != null) && typeof(int).IsAssignableFrom(obj2.GetType()))
            {
                return obj2;
            }
            return 0;
        }
    }
}