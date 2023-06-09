namespace FastEndpointsTemplate.Endpoints;

public abstract class EndpointGroupBase : Group
{
    protected EndpointGroupBase(string groupName, string routePrefix)
    {
        ConfigureBasicParams(groupName, routePrefix);
    }

    private void ConfigureBasicParams(string groupName, string routePrefix)
    {
        Configure(routePrefix, ep => ep.Tags(groupName));
    }
}