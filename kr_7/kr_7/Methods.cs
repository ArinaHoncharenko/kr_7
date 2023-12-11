using System.Drawing;
using System.Windows.Forms;

namespace kr_7
{
    public partial class CircleRingCalculatorForm : Form
    {
        private void DrawCoordinateSystem(Graphics g, PictureBox pictureBox)
        {
            int width = pictureBox.Width;
            int height = pictureBox.Height;
            int centerX = width / 2;
            int centerY = height / 2;

            // Малюємо осі координат
            g.DrawLine(Pens.DarkSlateGray, centerX, 0, centerX, height); // Вертикальна 
            g.DrawLine(Pens.DarkSlateGray, 0, centerY, width, centerY); // Горизонтальна 

            // Кількість позначок на осі та їхні розташування
            int numMarks = 39;
            float stepX = width / (float)numMarks;
            float stepY = height / (float)numMarks;

            //  позначки на вертикальній вісі
            for (int i = -19; i <= numMarks; i++)
            {
                float markX = centerX + i * stepX;
                g.DrawLine(Pens.DarkSlateGray, markX, centerY - 2, markX, centerY + 2);
            }

            //  позначки на горизонтальній вісі
            for (int i = -19; i <= numMarks; i++)
            {
                float markY = centerY + i * stepY;
                g.DrawLine(Pens.DarkSlateGray, centerX - 2, markY, centerX + 2, markY);
            }
        }

        private void DrawPoint(Graphics g, PictureBox pictureBox, double x, double y)
        {
            // Масштаб координати відносно розмірів PictureBox
            int width = pictureBox.Width;
            int height = pictureBox.Height;

            int centerX = width / 2;
            int centerY = height / 2;

            int scaledX = centerX + (int)(x * (width / 39.0));
            int scaledY = centerY - (int)(y * (height / 39.0));

            // Малюємо точку 
            using (Brush brush = new SolidBrush(Color.Black))
            {
                g.FillEllipse(brush, scaledX - 2, scaledY - 2, 3, 3);
            }
        }

        private void DrawCircle(Graphics g, PictureBox pictureBox, Circle circle)
        {
            // Масштабуємо радіус
            int width = pictureBox.Width;
            int scaledRadius = (int)(circle.Radius * (width / 39.0));

            // Масштабуємо координати центра кола відносно розмірів PictureBox
            int centerXCoord = width / 2 + (int)(circle.CenterX * (width / 39.0));
            int centerYCoord = pictureBox.Height / 2 - (int)(circle.CenterY * (pictureBox.Height / 39.0));

            // Малюємо коло з визначеним кольором та розмірами
            using (Pen pen = new Pen(Color.DarkGreen))
            {
                using (Brush brush = new SolidBrush(Color.LightGreen))
                {
                    g.FillEllipse(brush, centerXCoord - scaledRadius, centerYCoord - scaledRadius, 2 * scaledRadius, 2 * scaledRadius);
                }

                g.DrawEllipse(pen, centerXCoord - scaledRadius, centerYCoord - scaledRadius, 2 * scaledRadius, 2 * scaledRadius);
            }

            DrawPoint(g, pictureBox, circle.CenterX, circle.CenterY);
        }

        private void DrawRing(Graphics g, PictureBox pictureBox, Ring ring)
        {
            // Масштабуємо радіус для відображення
            int width = pictureBox.Width;
            int scaledInnerRadius = (int)(ring.InnerRadius * (width / 39.0));
            int scaledOuterRadius = (int)(ring.OuterRadius * (width / 39.0));

            // Масштабуємо координати центра кола відносно розмірів PictureBox
            int centerXCoord = width / 2 + (int)(ring.CenterX * (width / 39.0));
            int centerYCoord = pictureBox.Height / 2 - (int)(ring.CenterY * (pictureBox.Height / 39.0));

            // Малюємо коло з визначеним кольором та розмірами
            using (Pen pen = new Pen(Color.DarkMagenta))
            {
                using (Brush brush = new SolidBrush(Color.Plum))
                {
                    g.FillEllipse(brush, centerXCoord - scaledOuterRadius, centerYCoord - scaledOuterRadius, 2 * scaledOuterRadius, 2 * scaledOuterRadius);
                }

                g.DrawEllipse(pen, centerXCoord - scaledOuterRadius, centerYCoord - scaledOuterRadius, 2 * scaledOuterRadius, 2 * scaledOuterRadius);

                using (Brush brush = new SolidBrush(Color.WhiteSmoke))
                {
                    g.FillEllipse(brush, centerXCoord - scaledInnerRadius, centerYCoord - scaledInnerRadius, 2 * scaledInnerRadius, 2 * scaledInnerRadius);
                }

                g.DrawEllipse(pen, centerXCoord - scaledInnerRadius, centerYCoord - scaledInnerRadius, 2 * scaledInnerRadius, 2 * scaledInnerRadius);
            }

            DrawPoint(g, pictureBox, ring.CenterX, ring.CenterY);
        }
    }
}
