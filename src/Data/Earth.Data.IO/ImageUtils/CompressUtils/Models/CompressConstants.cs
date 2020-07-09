
namespace Earth.Data.IO.ImageUtils.CompressUtils.Models
{
    internal class CompressConstants
    {
        public const int DefaultPngQualityPercent = 62;

        public const int DefaultJpegQualityPercent = 62;

        public const int DefaultGifQualityPercent = 62;

        public const int TimeoutMillisecond = 600000;

        // PNG

        public const string PngWorkerFileNameWindows = "Earth_ImageCompressor_PNG.exe";

        public const string PngWorkerFileNameLinux = "Earth_ImageCompressor_PNG";

        // JPEG

        public const string JpegWorkerFileNameWindows = "Earth_ImageCompressor_JPEG.exe";
        public const string JpegLibFileNameWindows = "libjpeg-62.dll";

        // JPEG Lossless

        public const string JpegLosslessWorkerFileNameWindows = "Earth_ImageCompressor_JPEG_Lossless.exe";

        public const string JpegLosslessWorkerFileNameLinux = "Earth_ImageCompressor_JPEG_Lossless";

        // GIF

        public const string GifWorkerFileNameWindows = "Earth_ImageCompressor_GIF.exe";

        public const string GifWorkerFileNameLinux = "Earth_ImageCompressor_GIF";
    }
}
