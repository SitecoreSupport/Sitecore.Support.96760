namespace Sitecore.Support.Data.SqlServer
{
    using Sitecore.Data.Items;
    using Sitecore.Diagnostics;
    using Sitecore.Links;
    public class SqlServerLinkDatabase : Sitecore.Data.SqlServer.SqlServerLinkDatabase
    {
        public SqlServerLinkDatabase(string connectionString) : base(connectionString)
        {
        }

        public override void UpdateItemVersionReferences(Item item)
        {
            Assert.ArgumentNotNull(item, "item");
            ItemLink[] allLinks = item.Links.GetAllLinks();
            this.UpdateItemVersionLinks(item, allLinks);
        }
    }
}