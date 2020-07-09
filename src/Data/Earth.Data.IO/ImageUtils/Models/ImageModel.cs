using Earth.Core.ObjUtils;

namespace Earth.Data.IO.ImageUtils.Models
{
    public class ImageModel : EarthDisposableModel
    {
        public string MimeType { get; set; }

        public string Extension { get; set; }

        public string DominantHexColor { get; set; }

        public int WidthPx { get; set; }

        public int HeightPx { get; set; }
    }
}
