using System;
using System.Windows.Forms;
using X_ray_Images.Classes;


using System.Drawing;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using iTextSharp.text;
using iTextSharp.text.pdf;
using NAudio.Wave;
using NAudio.Lame;

namespace X_ray_Images.Classes
{
    public class Compressor
    {
        //Compress image function
        public static void CompressImage(string sourcePath, string destinationPath, long quality)
        {
            try
            {
                // Load the source image
                using (Bitmap sourceImage = new Bitmap(sourcePath))
                {
                    // Create an encoder parameter for the image quality
                    EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, quality);
                    // Get the JPEG codec
                    ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");

                    if (jpegCodec == null)
                    {
                        throw new Exception("JPEG codec not found");
                    }

                    // Create an encoder parameters array
                    EncoderParameters encoderParams = new EncoderParameters(1);
                    encoderParams.Param[0] = qualityParam;

                    // Save the image using the JPEG codec and the quality parameter
                    sourceImage.Save(destinationPath, jpegCodec, encoderParams);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error compressing image: {ex.Message}");
            }
        }
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.MimeType == mimeType)
                {
                    return codec;
                }
            }
            return null;
        }

        //Compress pdf file
        public static void CompressPdf(string srcFile, string destFile)
        {
            PdfReader reader = new PdfReader(srcFile);
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destFile, FileMode.Create, FileAccess.Write));
            writer.SetFullCompression();
            writer.CompressionLevel = PdfStream.BEST_COMPRESSION;
            document.Open();
            PdfContentByte cb = writer.DirectContent;
            int totalPages = reader.NumberOfPages;
            for (int i = 1; i <= totalPages; i++)
            {
                document.NewPage();
                document.SetPageSize(reader.GetPageSizeWithRotation(i));
                PdfImportedPage page = writer.GetImportedPage(reader, i);
                int rotation = reader.GetPageRotation(i);
                if (rotation == 90 || rotation == 270)
                {
                    cb.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
                }
                else
                {
                    cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                }
            }

            document.Close();
            reader.Close();
        }

        //Compress audio file 
        public static void CompressAudioFile(string inputFile, string outputFile)
        {
            using (var reader = new AudioFileReader(inputFile))
            {
                var outFormat = new WaveFormat(44100, reader.WaveFormat.Channels);
                using (var resampler = new MediaFoundationResampler(reader, outFormat))
                {
                    resampler.ResamplerQuality = 60; // Set resampler quality (1-60)

                    using (var writer = new LameMP3FileWriter(outputFile, resampler.WaveFormat, LAMEPreset.STANDARD))
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead;
                        while ((bytesRead = resampler.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            writer.Write(buffer, 0, bytesRead);
                        }
                    }
                }
            }
        }

    }
}