using System.IO;

namespace logcpy
{
    public class LogFileSelectorManager : ILogFileSelectorManager
    {
        private ILogListHandler LogListHandler; 
        private IConfigSettings ConfigSettings;
        public LogFileSelectorManager(ILogListHandler logListHndl, IConfigSettings cfg)
        {
            this.LogListHandler = logListHndl;
            this.ConfigSettings = cfg;
        }
        public FileInfo GetNextSourceFileInfo()
        {
            var srcList = this.LogListHandler.GetSortedList(this.ConfigSettings.SourceFilePath, this.ConfigSettings.SourceFilePattern);
            var trgList = this.LogListHandler.GetSortedList(this.ConfigSettings.TargetFilePath, "*.*");
            //magic logic to pick next
            FileInfo nextLogFile = null; // magic code here
            return nextLogFile;
        }
    }
}