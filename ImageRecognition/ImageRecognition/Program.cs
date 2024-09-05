using System;
using System.Drawing;
using System.Drawing.Imaging;
using Tesseract;

namespace OCRProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string tessDataPath = @"C:\Program Files\Tesseract-OCR\tessdata";
            string imagePath = @"ENDEREÇO_DA_IMAGEM.PNG/JPG";

            try
            {
                using (var engine = new TesseractEngine(tessDataPath, "eng", EngineMode.Default))
                {
                    Console.WriteLine("Engine carregado com sucesso.");
                    using (var originalImage = new Bitmap(imagePath))
                    {
                        var adjustedImage = AdjustContrastAndBrightness(originalImage);
                        var processedImage = RemoveNoise(adjustedImage);

                        using (var img = PixConverter.ToPix(processedImage))
                        {
                            Console.WriteLine("Imagem carregada com sucesso.");
                            using (var page = engine.Process(img, PageSegMode.Auto))
                            {
                                string text = page.GetText();
                                Console.WriteLine("Texto extraído: " + text);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }

        static Bitmap AdjustContrastAndBrightness(Bitmap original)
        {
            var adjustedImage = new Bitmap(original.Width, original.Height);
            using (var g = Graphics.FromImage(adjustedImage))
            {
                var colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {1.5f, 0, 0, 0, 0},
                    new float[] {0, 1.5f, 0, 0, 0},
                    new float[] {0, 0, 1.5f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
                var attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
            }
            return adjustedImage;
        }

        static Bitmap RemoveNoise(Bitmap original)
        {
            var noiseRemovedImage = new Bitmap(original.Width, original.Height);
            using (var g = Graphics.FromImage(noiseRemovedImage))
            {
                var attributes = new ImageAttributes();
                attributes.SetThreshold(0.5f);
                g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
            }
            return noiseRemovedImage;
        }
    }
}
