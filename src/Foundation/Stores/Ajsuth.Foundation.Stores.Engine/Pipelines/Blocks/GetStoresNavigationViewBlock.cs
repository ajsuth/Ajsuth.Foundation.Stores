using Ajsuth.Foundation.Stores.Engine.Policies;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.EntityViews;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System.Threading.Tasks;

namespace Ajsuth.Foundation.Stores.Engine.Pipelines.Blocks
{
	[PipelineDisplayName(Constants.Pipelines.Blocks.GetStoresNavigationView)]
	public class GetStoresNavigationViewBlock : PipelineBlock<EntityView, EntityView, CommercePipelineExecutionContext>
	{
		public override Task<EntityView> Run(EntityView entityView, CommercePipelineExecutionContext context)
		{
			Condition.Requires(entityView).IsNotNull($"{Name}: The argument cannot be null.");
			
			var dashboardName = context.GetPolicy<KnownStoresViewsPolicy>().StoresDashboard;
			var storesDashboardView = new EntityView()
			{
				Name = dashboardName,
				ItemId = dashboardName,
				Icon = Views.Constants.Icons.MarketStand,
				DisplayRank = 6
			};
			entityView.ChildViews.Add(storesDashboardView);

			return Task.FromResult(entityView);
		}

		public GetStoresNavigationViewBlock()
		  : base(null)
		{
		}
	}
}