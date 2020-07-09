using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Earth.Data.IO.ImageUtils.ResizeUtils.Models;

namespace Earth.Data.IO.ImageUtils.ResizeUtils
{
    public class ImageResizeHelper
    {
        //public static byte[] Resize(string path, int newWidthPx, int newHeightPx, ResizeType resizeType = ResizeType.Max)
        //{
        //    path = PathHelper.GetFullPath(path);

        //    byte[] imageBytes = File.ReadAllBytes(path);

        //    return Resize(imageBytes, newWidthPx, newHeightPx, resizeType);
        //}

        //public static byte[] Resize(byte[] imageBytes, int newWidthPx, int newHeightPx, ResizeType resizeType = ResizeType.Max)
        //{
        //    using (MemoryStream inStream = new MemoryStream(imageBytes))
        //    {
        //        using (MemoryStream outStream = new MemoryStream())
        //        {
        //            using (var image = Image.Load<SixLabors.ImageSharp.PixelFormats.Rgba32>(inStream, out var format))
        //            {
        //                image.Mutate(x => x.Resize(new ResizeOptions
        //                {
        //                    Size = new SixLabors.Primitives.Size(newWidthPx, newHeightPx),

        //                    Mode = (ResizeMode)((int)resizeType)
        //                }));

        //                image.Save(outStream, format);

        //                return outStream.ToArray();
        //            }
        //        }
        //    }
        //}
    }
}
