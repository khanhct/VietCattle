using EPiServer.Web;
using Wangkanai.Detection.Models;
using Wangkanai.Detection.Services;

namespace VietCattle.CMS.Display;

public class MobileChannel : DisplayChannel
{
    public override string ChannelName => "Mobile";

    public override string? ResolutionId => typeof(IphoneVerticalResolution).FullName;

    public override bool IsActive(HttpContext context)
    {
        var detection = context.RequestServices.GetRequiredService<IDetectionService>();
        return detection.Device.Type == Device.Mobile;
    }
}