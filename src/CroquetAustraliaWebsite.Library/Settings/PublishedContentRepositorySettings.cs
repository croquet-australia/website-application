using System.Web;

namespace CroquetAustraliaWebsite.Library.Settings
{
    public class PublishedContentRepositorySettings : AppSettings
    {
        public PublishedContentRepositorySettings(HttpServerUtility server)
            : base("Content:PublishedRepository")
        {
            Directory = GetDirectory("FullDirectoryPath", server);
        }

        public string Directory { get; set; }
    }
}