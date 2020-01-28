namespace logcpy
{
    public interface IConfigSettings
    {
        public string SourceFilePath { get; set; }
        public string SourceFilePattern { get; set; }
        public string TargetFilePath { get; set; }
        public string TargetFileBaseName { get; set; }
    }
}