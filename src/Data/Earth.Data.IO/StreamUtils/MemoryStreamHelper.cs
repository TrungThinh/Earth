using System.IO;
using Earth.Core.CheckUtils;

namespace Earth.Data.IO.StreamUtils
{
    public class MemoryStreamHelper
    {
        public static void Save(MemoryStream stream, string path)
        {
            CheckHelper.CheckNullOrWhiteSpace(path, nameof(path));

            path = PathHelper.GetFullPath(path);

            using (var file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                stream.Position = 0;
                stream.CopyTo(file);
            }
        }
    }
}
