using EPiServer.Web;
using Wangkanai.Detection.Models;
using Wangkanai.Detection.Services;

namespace VietCattle.CMS.Display;

public class WebChannel : DisplayChannel
{
    public override string ChannelName => "Web";
    
    public override bool IsActive(HttpContext context)
    {
        var detection = context.RequestServices.GetRequiredService<IDetectionService>();
        return detection.Device.Type == Device.Desktop;
    }
}