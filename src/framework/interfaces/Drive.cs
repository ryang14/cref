using Grapevine.Interfaces.Server;
using Grapevine.Server;
using Grapevine.Server.Attributes;
using Grapevine.Shared;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BaseClasses
{
    [RestResource]
    abstract class Drive
    {
        protected static int _throttle;
        protected static int _steering;

        protected virtual void _SetThrottle(int percent) { }
        protected virtual void _SetSteering(int percent) { }


        [RestRoute(HttpMethod = HttpMethod.GET, PathInfo = "/drive")]
        public IHttpContext HelloWorld(IHttpContext context)
        {
            context.Response.SendResponse(JsonSerializer.Serialize(this));
            return context;
        }


        public int throttle
        {
            get => _throttle;
            set
            {
                _throttle = value;
                this._SetThrottle(value);
            }
        }

        public int steering
        {
            get => _steering;
            set
            {
                _steering = value;
                this._SetSteering(value);
            }
        }
    }
}