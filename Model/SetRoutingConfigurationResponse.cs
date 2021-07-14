using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Router.Model.Configuration;

namespace Router.Model
{
    public class SetRoutingConfigurationResponse
    {
        public enum ReturnCode
        {
            Ok,
            BadRequest,
            BadConfiguration,
            InternalServerError
        }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public ReturnCode Code { get; }
        
        public RoutingConfiguration Configuration { get; }
        
        public SetRoutingConfigurationResponse(ReturnCode code, RoutingConfiguration configuration)
        {
            Code = code;
            Configuration = configuration;
        }
    }
}