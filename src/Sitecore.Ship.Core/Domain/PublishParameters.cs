namespace Sitecore.Ship.Core.Domain
{
    public class PublishParameters
    {
        public string Mode { get; set; }
        public string Source { get; set; }
        public string[] Targets { get; set; }
        public string[] Languages { get; set; }
        public bool Deep { get; set; }
        public bool Related { get; set; }
    }
}