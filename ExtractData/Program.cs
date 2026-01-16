using Tesseract;

var imagePath = "D:\\DataExtraction\\ExtractData\\Images\\Screenshot_5.png";

using var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
using var img = Pix.LoadFromFile(imagePath);
using var page = engine.Process(img);

string text = page.GetText();
Console.WriteLine("Extracted Text:");
Console.WriteLine(text);
