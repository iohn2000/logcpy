using System.Collections.Generic;
using System.IO;
namespace logcpy
{
    public interface ILogListHandler
    {
        List<FileInfo> GetSortedList(string path, string pattern);
    }
}