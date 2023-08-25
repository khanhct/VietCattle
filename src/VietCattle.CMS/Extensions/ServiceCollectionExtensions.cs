using EPiServer.Cms.Shell;
using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.Web;

namespace VietCattle.CMS.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDefaultCms(this IServiceCollection services)
    {
        services
            .AddCmsAspNetIdentity<ApplicationUser>()
            .AddCms()
            .AddAdminUserRegistration()
            .AddEmbeddedLocalization<Startup>();
        
        return services;
    }

    public static IServiceCollection AddDisplayResolutions(this IServiceCollection services)
    {
        services.Configure<DisplayOptions>(options => {
            options
                .Add("displaymode-screen", "Screen", "u-md-sizeScreen", string.Empty, "epi-icon__layout--full")
                .Add("displaymode-full", "Full", "u-md-sizeFull", string.Empty, "epi-icon__layout--full")
                .Add("displaymode-two-thirds", "Wide (2/3)", "u-md-size2of3", string.Empty, "epi -icon__layout--two-thirds")
                .Add("displaymode-half", "Half (1/2)", "u-md-size1of2", string.Empty, "epi-icon__layout--half")
                .Add("displaymode-one-third", "Narrow (1/3)", "u-md-size1of3", string.Empty, "epi-icon__layout--one-third")
                .Add("displaymode-one-sixth", "Extra Narrow (1/6)", "u-md-size1of6", string.Empty, "epi-icon__layout--one-sixth")
                .Add("displaymode-one-quarter", "Quarter (1/4)", "u-md-size1of4", string.Empty, "epi-icon__layout--one-fourth");
        });
        services.AddDetection();
        return services;

    }
}