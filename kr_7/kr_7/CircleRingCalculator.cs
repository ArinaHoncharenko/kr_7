using System;
using System.Drawing;
using System.Windows.Forms;

namespace kr_7
{
    public partial class CircleRingCalculatorForm : Form
    {
        private Circle circle; // Додайте поле для об'єкту кола
        private Ring ring;

        public CircleRingCalculatorForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = null;
            try
            {
                // Отримуємо значення координат x та y з текстових полів
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);

                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    DrawPoint(g, pictureBox1, x, y);
                    DrawCoordinateSystem(g, pictureBox1);
                }
            }
            catch (FormatException)
            {
                // Обробка помилки при некоректних вхідних даних
                resultLabel.Text = "Некоректні вхідні дані. Будь ласка, введіть числа для координат x та y.";
            }
        }


        private void btnCalculateCircle_Click(object sender, EventArgs e)
        {
            resultLabel.Text = null;
            try
            {
                // Отримуємо значення радіусу та координат центру з текстових полів
                double radius = double.Parse(txtRadius.Text);
                double centerX = double.Parse(txtX.Text);
                double centerY = double.Parse(txtY.Text);

                // Перевіряємо, чи радіус не менше 0
                if (radius <= 0)
                {
                    resultLabel.Text = "Радіус повинен бути більше 0.";
                    return;
                }

                // Створюємо об'єкт класу Circle
                circle = new Circle(centerX, centerY, radius);

                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    DrawCircle(g, pictureBox1, circle);
                    DrawCoordinateSystem(g, pictureBox1);
                }
            }
            catch (FormatException)
            {
                // Обробка помилки при некоректних вхідних даних
                resultLabel.Text = "Некоректні вхідні дані. Будь ласка, введіть числове значення для радіусу та координат центру.";
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            using (Graphics g = pictureBox1.CreateGraphics())
            {
                g.Clear(Color.WhiteSmoke);
                DrawCoordinateSystem(g, pictureBox1);
            }
            
            resultLabel.Text = null;
            circle = null;
            ring = null;
        }

        private void btnCalculateCircleProperties_Click(object sender, EventArgs e)
        {
            try
            {
                if (circle == null)
                {
                    resultLabel.Text = "Спочатку розрахуйте коло.";
                    return;
                }

                double circumference = Math.Round(2 * Math.PI * circle.Radius, 3);
                double area = Math.Round(Math.PI * Math.Pow(circle.Radius, 2), 3);

                btnCalculateCircle_Click(sender, e);

                // Виведення результатів у resultLabel
                resultLabel.Text = $"Площа кола: {area}\nДовжина кола: {circumference}";
            }
            catch (FormatException)
            {
                // Обробка помилки при некоректних вхідних даних
                resultLabel.Text = "Некоректні вхідні дані. Будь ласка, введіть числове значення для радіусу.";
            }
        }

        private void btnCheckPoint_Click(object sender, EventArgs e)
        {
            try
            {
                if (circle == null)
                {
                    resultLabel.Text = "Спочатку розрахуйте коло.";
                    return;
                }

                // Отримуємо значення координат точки з текстових полів
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);

                // Використовуємо метод класу Circle для перевірки, чи точка знаходиться всередині кола
                bool isInside = circle.IsPointInside(x, y);

                // Виведення результату у resultLabel
                resultLabel.Text = isInside ? "Точка знаходиться всередині кола." : "Точка знаходиться поза межами кола.";
            }
            catch (FormatException)
            {
                // Обробка помилки при некоректних вхідних даних
                resultLabel.Text = "Некоректні вхідні дані. Будь ласка, введіть числові значення для координат та радіусу.";
            }
        }

        private void btnCalculateRing_Click(object sender, EventArgs e)
        {
            resultLabel.Text = null;
            try
            {
                // Отримуємо значення радіусу та координат центру з текстових полів
                double innerRadius = double.Parse(txtInnerRadius.Text);
                double outerRadius = double.Parse(txtOuterRadius.Text);
                double centerX = double.Parse(txtX.Text);
                double centerY = double.Parse(txtY.Text);

                // Перевіряємо, чи радіус не менше 0
                if (innerRadius <= 0 || outerRadius <= 0)
                {
                    resultLabel.Text = "Радіус повинен бути більше 0.";
                    return;
                }
                else if (innerRadius > outerRadius)
                {
                    resultLabel.Text = "Внутрішній радіус повинен бути меньший за зовнішній.";
                    return;
                }

                // Створюємо об'єкт класу Circle
                ring = new Ring(centerX, centerY, outerRadius, innerRadius);

                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    DrawRing(g, pictureBox1, ring);
                    DrawCoordinateSystem(g, pictureBox1);
                }
            }
            catch (FormatException)
            {
                // Обробка помилки при некоректних вхідних даних
                resultLabel.Text = "Некоректні вхідні дані. Будь ласка, введіть числове значення для радіусів та координат центру.";
            }
        }

        private void btnCalculateRingProperties_Click(object sender, EventArgs e)
        {
            try
            {
                if (ring == null)
                {
                    resultLabel.Text = "Спочатку розрахуйте кільце.";
                    return;
                }

                double area = Math.Round(Math.PI * Math.Pow(ring.OuterRadius, 2)- Math.PI * Math.Pow(ring.InnerRadius, 2), 3);


                // Виведення результатів у resultLabel
                resultLabel.Text = $"Площа кільця: {area}";
            }
            catch (FormatException)
            {
                // Обробка помилки при некоректних вхідних даних
                resultLabel.Text = "Некоректні вхідні дані. Будь ласка, введіть числове значення для радіусу.";
            }

        }

        private void btnCheckPointRing_Click(object sender, EventArgs e)
        {
            try
            {
                if (ring == null)
                {
                    resultLabel.Text = "Спочатку розрахуйте кільце.";
                    return;
                }

                // Отримуємо значення координат точки з текстових полів
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);

                bool isInside = ring.IsPointInside(x, y);

                // Виведення результату у resultLabel
                resultLabel.Text = isInside ? "Точка знаходиться всередині кільця." : "Точка знаходиться поза межами кільця.";
            }
            catch (FormatException)
            {
                // Обробка помилки при некоректних вхідних даних
                resultLabel.Text = "Некоректні вхідні дані. Будь ласка, введіть числові значення для координат та радіусу.";
            }

        }
    }

}
