namespace Router.Model.Configuration
{
    public class RouteTargetConfiguration
    {
        public RouteTargetConfigurationEntry[] Entries { get; }
        
        public RouteTargetConfiguration(RouteTargetConfigurationEntry[] entries)
        {
            Entries = entries;
        }
    }
}