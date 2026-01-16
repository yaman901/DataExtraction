using Tesseract;

var imagePath = "C:/Users/asus/Downloads/Screenshot_1.png";

using var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
using var img = Pix.LoadFromFile(imagePath);
using var page = engine.Process(img);

string text = page.GetText();
Console.WriteLine("Extracted Text:");
Console.WriteLine(text);
