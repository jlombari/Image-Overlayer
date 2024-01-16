
using System.Reflection;

namespace Image_Overlayer
{
    public partial class Form1 : Form
    {
        public string ImagePath;
        public Bitmap WatermarkPath;
        public int imageCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImagePath = ofd.FileName;
                fileTextBox.Text = ImagePath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fn = $"ImageWithOverlay{imageCount}.jpg";
            try
            {
                using (Bitmap image = new Bitmap(ImagePath))
                using (Bitmap watermarkImage = new Bitmap(WatermarkPath))
                using (Graphics imageGraphics = Graphics.FromImage(image))
                {
                    watermarkImage.SetResolution(imageGraphics.DpiX, imageGraphics.DpiY);
                    int x = ((image.Width - watermarkImage.Width) / 2);
                    int y = ((image.Height - watermarkImage.Height) / 2);
                    watermarkImage.MakeTransparent();
                    imageGraphics.DrawImage(watermarkImage, x, y, watermarkImage.Width, watermarkImage.Height);
                    if (!File.Exists(fn))
                    {
                        image.Save(fn);
                    }
                    if (File.Exists(fn))
                    {
                        imageCount++;
                        image.Save(fn);
                    }
                    MessageBox.Show($"Image Saved: {fn}. Opening folder...");
                    System.Diagnostics.Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void oo1Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (oo1Radio.Checked)
            {
                WatermarkPath = Properties.Resources.img_sold_overlay;
            }

        }

        private void oo2Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (oo2Radio.Checked)
            {
                WatermarkPath = Properties.Resources.img_new_overlay;
            }
        }

        private void oo3Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (oo3Radio.Checked)
            {
                WatermarkPath = Properties.Resources.img_comingsoon_overlay;
            }
        }
    }
}
