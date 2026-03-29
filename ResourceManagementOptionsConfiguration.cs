using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace TheNeariBlogTheme;

public sealed class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest;

    static ResourceManagementOptionsConfiguration()
    {
        _manifest = new ResourceManifest();

        _manifest
            .DefineScript("TheNeariBlogTheme-bootstrap-bundle")
            //.SetCdn("https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js", "https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.js")
            //.SetCdnIntegrity("sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p", "sha384-8fq7CZc5BnER+jVlJI2Jafpbn4A9320TKhNJfYP33nneHep7sUg/OD30x7fK09pS")
            .SetUrl("~/TheNeariBlogTheme/js/bootstrap.bundle.min.js", "~/TheNeariBlogTheme/js/bootstrap.bundle.js")
            .SetVersion("5.1.3");

        _manifest
            .DefineStyle("TheNeariBlogTheme-bootstrap-oc")
            .SetUrl("~/TheNeariBlogTheme/css/bootstrap-oc.min.css", "~/TheNeariBlogTheme/css/bootstrap-oc.css")
            .SetVersion("1.0.0");

        _manifest
            .DefineScript("TheNeariBlogTheme")
            .SetDependencies("TheNeariBlogTheme-bootstrap-bundle")
            .SetUrl("~/TheNeariBlogTheme/js/scripts.min.js", "~/TheNeariBlogTheme/js/scripts.js")
            .SetVersion("6.0.7");

        _manifest
            .DefineStyle("TheNeariBlogTheme")
            .SetUrl("~/TheNeariBlogTheme/css/styles.min.css", "~/TheNeariBlogTheme/css/styles.css")
            .SetVersion("6.0.7");

        _manifest
            .DefineStyle("FontsGoogle")
            .SetUrl("~/TheNeariBlogTheme/css/fontsgoogle.css")
            .SetVersion("1.0.0");
    }

    public void Configure(ResourceManagementOptions options)
    {
        options.ResourceManifests.Add(_manifest);
    }
}
