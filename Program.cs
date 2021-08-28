using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace cs_con_framework_pdfsharp {
    class Program {
        static void Main(string[] args)
        {
			PdfSharp.Fonts.GlobalFontSettings.FontResolver = new FontResolver();

			PdfDocument document = new PdfDocument();
			document.Info.Title = "PDFSharp でテキストを位置指定で出力";

			PdfPage page = document.AddPage();
			page.Size = PageSize.A4;
			page.Orientation = PageOrientation.Portrait;

			XGraphics gfx = XGraphics.FromPdfPage(page);

			XPen pen = new XPen(XColors.Black, 1.0);

			// 輪郭黒・背景塗り潰し 長方形
			gfx.DrawRectangle(pen, XBrushes.Cornsilk, 30, 40, 537, 140);
			// 輪郭黒・長方形
			gfx.DrawRectangle(pen, 30, 200, 537, 500);

			XFont font = new XFont("ラノベPOP", 40, XFontStyle.Regular);
			XFont font2 = new XFont("ラノベPOP", 24, XFontStyle.Regular);

			string[] text = {
				"ある日の事でございます。御釈迦様は極楽の",
				"蓮池のふちを、独りでぶらぶら御歩きになっ",
				"ていらっしゃいました。池の中に咲いている",
				"蓮の花は、みんな玉のようにまっ白で、その",
				"まん中にある金色の蕊からは、何とも云えな",
				"い好い匂が、絶間なくあたりへ溢れて居りま",
				"す。極楽は丁度朝なのでございましょう。" 
			};

			gfx.DrawString("日本語フリーフォント", font, XBrushes.Black, 50, font.Height + 50);
			gfx.DrawString("ラノベPOP", font, XBrushes.Red, 50, font.Height + 100);
			gfx.DrawString(text[0], font2, XBrushes.Black, 50, font.Height + 200);
			gfx.DrawString(text[1], font2, XBrushes.Black, 50, font.Height + 250);
			gfx.DrawString(text[2], font2, XBrushes.Black, 50, font.Height + 300);
			gfx.DrawString(text[3], font2, XBrushes.Black, 50, font.Height + 350);
			gfx.DrawString(text[4], font2, XBrushes.Black, 50, font.Height + 400);
			gfx.DrawString(text[5], font2, XBrushes.Black, 50, font.Height + 450);
			gfx.DrawString(text[6], font2, XBrushes.Black, 50, font.Height + 500);
			document.Save("sample.pdf");
		}
    }
}
