namespace MyWebServer.Server
{
    using MyWebServer.Server.Routing;
    using System;

    public class GttpServer
    {
        private readonly RoutingTable routingTable;
        private string str;

        public GttpServer(Action<IRoutingTable> routingTableConfiguration)
        {
            routingTableConfiguration(this.routingTable = new RoutingTable());
        }
        //public GttpServer(Action<string> routingTableConfiguration)
        //{
        //    routingTableConfiguration(this.str = new RoutingTable());
        //}

    }

}
