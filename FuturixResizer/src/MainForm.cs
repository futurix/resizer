using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Resizer
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnDoIt_Click(object sender, EventArgs e)
		{
			string targetPath = 
				Path.Combine(
					Environment.GetFolderPath(Environment.SpecialFolder.Desktop), 
					String.Format("image_{0}.jpg", Path.GetFileNameWithoutExtension(Path.GetRandomFileName()))
					);
			
			try
			{
				if (dlgOpen.ShowDialog() == DialogResult.OK)
				{
					using (Bitmap bmp = new Bitmap(dlgOpen.FileName))
					{
						int targetSize, targetW, targetH;

						if (rbnTiny.Checked)
							targetSize = 320;
						else if (rbnMiddle.Checked)
							targetSize = 640;
						else if (rbnLarge.Checked)
							targetSize = 1600;
						else
							targetSize = 1024;

						if (bmp.Height > bmp.Width)
						{
							targetH = targetSize;
							targetW = (int)(bmp.Width * ((float)targetSize / (float)bmp.Height));
						}
						else
						{
							targetW = targetSize;
							targetH = (int)(bmp.Height * ((float)targetSize / (float)bmp.Width));
						}

						using (Bitmap res = new Bitmap(targetW, targetH, PixelFormat.Format24bppRgb))
						{
							res.SetResolution(72, 72);

							using (Graphics g = Graphics.FromImage(res))
							{
								g.SmoothingMode = SmoothingMode.AntiAlias;
								g.InterpolationMode = InterpolationMode.HighQualityBicubic;
								g.PixelOffsetMode = PixelOffsetMode.HighQuality;

								g.DrawImage(bmp, new Rectangle(0, 0, targetW, targetH), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);

								// saving
								EncoderParameter quality = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)90);
								ImageCodecInfo codec = GetEncoderInfo("image/jpeg");

								EncoderParameters encoderParams = new EncoderParameters(1);
								encoderParams.Param[0] = quality;
								
								res.Save(targetPath, codec, encoderParams);

								MessageBox.Show("File saved to your desktop as " + Path.GetFileName(targetPath));
							}
						}
					}
				}
			}
			catch
			{
				if (File.Exists(targetPath))
				{
					try
					{
						File.Delete(targetPath);
					}
					catch
					{
					}
				}

				MessageBox.Show("Some mistake! :-(");
			}
		}

		private static ImageCodecInfo GetEncoderInfo(string mimeType)
		{
			ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

			foreach (ImageCodecInfo codec in codecs)
			{
				if (codec.MimeType == mimeType)
					return codec;
			}

			return null;
		} 
	}
}
