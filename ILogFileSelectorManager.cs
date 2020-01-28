using System.IO;
namespace logcpy
{
    public interface ILogFileSelectorManager
    {
        /// <summary>
        /// finds the oldest log file not yet copied to destination location.
        /// returns a <see cref="FileInfo"/> object
        /// </summary>
        /// <returns>null if nothing found, i.e nothing to do</returns>
        FileInfo GetNextSourceFileInfo();
    }
}