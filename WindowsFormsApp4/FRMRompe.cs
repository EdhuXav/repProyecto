using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FRMRompe : Form
    {
        List<PictureBox> pictureboxlist = new List<PictureBox>();
        List<Bitmap> images = new List<Bitmap>();
        List<string> locations = new List<string>();
        List<string> current_locations = new List<string>();
        string win_position;
        string current_position;
        Bitmap MainBitmap;
        int movimientos = 0;
        Timer cronometro = new Timer();
        int segundos = 0;

        private FormPrincipal principal;

        public FRMRompe(FormPrincipal principal)
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            cronometro.Interval = 1000; // 1 segundo
            cronometro.Tick += Cronometro_Tick;
            this.principal = principal;
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            segundos++;
            label1.Text = $"Tiempo: {segundos} segundos";
        }

        private void AbrirArchivo(object sender, EventArgs e)
        {
            if (pictureboxlist != null)
            {
                foreach (PictureBox pics in pictureboxlist.ToList())
                {
                    this.Controls.Remove(pics);
                }
                pictureboxlist.Clear();
                images.Clear();
                locations.Clear();
                current_locations.Clear();
                win_position = string.Empty;
                current_position = string.Empty;
                label2.Text = "Movimientos: 0";
                movimientos = 0;
                segundos = 0;
                label1.Text = "Tiempo: 0 segundos";
            }
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Solo Archivos de Imagen | *.jpg; *.jpeg; *.gif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                MainBitmap = new Bitmap(open.FileName);
                CrearPictureBoxes();
                AgregarImagenes();
                cronometro.Start();
            }
        }

        private void CrearPictureBoxes()
        {
            for (int i = 0; i < 9; i++)
            {
                PictureBox temp_pic = new PictureBox();
                temp_pic.Size = new Size(130, 130);
                temp_pic.Tag = i.ToString();
                temp_pic.Click += OnPicClick;
                pictureboxlist.Add(temp_pic);
                locations.Add(temp_pic.Tag.ToString());
            }
        }

        private void OnPicClick(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            PictureBox emptyBox = pictureboxlist.Find(x => x.Tag.ToString() == "0");
            Point pic1 = new Point(pictureBox.Location.X, pictureBox.Location.Y);

            Point pic2 = new Point(emptyBox.Location.X, emptyBox.Location.Y);
            var index1 = this.Controls.IndexOf(pictureBox);
            var index2 = this.Controls.IndexOf(emptyBox);
            if (pictureBox.Right == emptyBox.Left && pictureBox.Location.Y == emptyBox.Location.Y
                || pictureBox.Left == emptyBox.Right && pictureBox.Location.Y == emptyBox.Location.Y

                || pictureBox.Top == emptyBox.Bottom && pictureBox.Location.X == emptyBox.Location.X

                || pictureBox.Bottom == emptyBox.Top && pictureBox.Location.X == emptyBox.Location.X
                )
            {
                pictureBox.Location = pic2;
                emptyBox.Location = pic1;
                this.Controls.SetChildIndex(pictureBox, index2);
                this.Controls.SetChildIndex(emptyBox, index1);
                movimientos++;
                label2.Text = $"Movimientos: {movimientos}";
            }
            current_locations.Clear();
            ComprobarJuego();
        }

        private void CortarImagen(Bitmap main_bitmap, int height, int width)
        {
            int x, y;
            x = 0;
            y = 0;
            for (int blocks = 0; blocks < 9; blocks++)
            {
                Bitmap cropped_image = new Bitmap(height, width);
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        cropped_image.SetPixel(i, j, main_bitmap.GetPixel((i + x), (j + y)));
                    }
                }
                images.Add(cropped_image);
                x += 130;
                if (x == 390)
                {
                    x = 0;
                    y += 130;
                }
            }
        }

        private void AgregarImagenes()
        {
            Bitmap tempBitmap = new Bitmap(MainBitmap, new Size(390, 390));
            CortarImagen(tempBitmap, 130, 130);
            for (int i = 1; i < pictureboxlist.Count; i++)
            {
                pictureboxlist[i].BackgroundImage = (Image)images[i];
            }
            ColocarPictureBoxesEnFormulario();
        }

        private void ColocarPictureBoxesEnFormulario()
        {
            var shuffleImages = pictureboxlist.OrderBy(a => Guid.NewGuid()).ToList();
            pictureboxlist = shuffleImages;
            int x = 200;
            int y = 25;
            for (int i = 0; i < pictureboxlist.Count; i++)
            {
                pictureboxlist[i].BackColor = Color.Gold;
                if (i == 3 || i == 6)
                {
                    y += 130;
                    x = 200;
                }
                pictureboxlist[i].BorderStyle = BorderStyle.FixedSingle;
                pictureboxlist[i].Location = new Point(x, y);
                this.Controls.Add(pictureboxlist[i]);
                x += 130;
                win_position += locations[i];
            }
        }

        private void ComprobarJuego()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    current_locations.Add(x.Tag.ToString());
                }
            }
            current_position = string.Join("", current_locations);
            if (win_position == current_position)
            {
                label2.Text = "¡Juego Completado!";
                cronometro.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (principal != null)
            {
                principal.AbrirObjetivos(new FRMOpcionesSaludMental(principal));
            }
        }
    }
}
