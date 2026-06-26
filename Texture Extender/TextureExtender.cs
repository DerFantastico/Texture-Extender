using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace Texture_Extender
{
    public partial class frmTextureExtender : Form
    {
        string image;
        string extension;
        string imageName;

        public frmTextureExtender()
        {
            InitializeComponent();
        }

        private void btnWidthPlus_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxWidth.Text, "[0-9]"))
            {
                tbxWidth.Text = Convert.ToString(Convert.ToInt32(tbxWidth.Text) + 1);
            }
            else
            {
                tbxWidth.Text = "1";
            }
        }

        private void btnWidthMinus_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxWidth.Text, "[0-9]"))
            {
                if (Convert.ToInt32(tbxWidth.Text) > 1)
                {
                    tbxWidth.Text = Convert.ToString(Convert.ToInt32(tbxWidth.Text) - 1);
                }
            }
            else
            {
                tbxWidth.Text = "1";
            }
        }

        private void btnHeightPlus_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxHeight.Text, "[0-9]"))
            {
                tbxHeight.Text = Convert.ToString(Convert.ToInt32(tbxHeight.Text) + 1);
            }
            else
            {
                tbxHeight.Text = "1";
            }
        }

        private void btnHeightMinus_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxHeight.Text, "[0-9]"))
            {
                if (Convert.ToInt32(tbxHeight.Text) > 1)
                {
                    tbxHeight.Text = Convert.ToString(Convert.ToInt32(tbxHeight.Text) - 1);
                }
            }
            else
            {
                tbxHeight.Text = "1";
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose Image";
            ofd.Filter = "Image Files|*.png;*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = ofd.FileName;
                extension = Path.GetExtension(ofd.FileName);
                imageName = Path.GetFileNameWithoutExtension(ofd.FileName);
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(image))
            {
                MessageBox.Show("No image selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tbxWidth.Text,"[0-9]") || !Regex.IsMatch(tbxHeight.Text, "[0-9]"))
            {
                MessageBox.Show("Width or height is not a number!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Image";
            sfd.Filter = "Image Files|*" + extension;

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = ImageExtender();
                if(extension == ".png")
                {
                    bmp.Save(sfd.FileName, ImageFormat.Png);
                }
                else
                {
                    bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private Bitmap ImageExtender()
        {
            int w = Convert.ToInt32(tbxWidth.Text);
            int h = Convert.ToInt32(tbxHeight.Text);

            Bitmap source = new Bitmap(image);
            Bitmap extended = new Bitmap(source.Width*w, source.Height*h);

            Graphics g = Graphics.FromImage(extended);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

            for(int i = 0; i < h; i++)
            {
                for(int j = 0; j < w; j++)
                {
                    g.DrawImage(
                    source,
                    new Rectangle(j * source.Width, i * source.Height, source.Width, source.Height),
                    0, 0, source.Width, source.Height,
                    GraphicsUnit.Pixel
                    );
                }
            }

            return extended;
        }
    }
}
