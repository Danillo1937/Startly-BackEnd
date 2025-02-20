namespace Startly.Domains
{
    public class StartupVideo
    {
        public int Id { get; set; }
        public int StartupId { get; set; }
        public required Startup Startup { get; set; }
        public string LinkVideo { get; set; } = string.Empty;

    }
}
