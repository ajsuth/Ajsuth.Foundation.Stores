using Sitecore.Commerce.Core;

namespace Ajsuth.Foundation.Stores.Engine.Policies
{
    public class KnownStoresViewsPolicy : Policy
	{
		public KnownStoresViewsPolicy()
		{
			StoresDashboard = nameof(StoresDashboard);
		}

		public string StoresDashboard { get; set; }
	}
}
