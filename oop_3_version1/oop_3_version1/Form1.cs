using System;
namespace oop_3_version1
{
    public partial class Form1 : Form
    {
        static public void Main()
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                double a, b, h;
                int win_count;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                h = Convert.ToDouble(textBox3.Text);
                win_count = Convert.ToInt32(textBox4.Text);

                Appartament room;
                room = Appartament(a, b, h, win_count);


                CreateBuilding();
                if (room != null)
                {
                    MessageBox.Show(room.ToString(), "ќб'Їкт усп≥шно створено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RoomS(room);
                    RoomV(room);

                }
                else
                    MessageBox.Show("¬вед≥ть правильн≥ дан≥", "ќб'Їкт не створено", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



            }

            private Appartament Appartament(double a, double b, double h, int win_count)
            {
                throw new NotImplementedException();
            }

            void RoomS(Appartament room)
            {
                double area = room.Area();
                textBox5.Text = area.ToString();
            }
            void RoomV(Appartament room)
            {
                double volume = room.Volume();
                textBox6.Text = volume.ToString();
            }


            void CreateBuilding()
            {
                double a;
                double b;
                double h;
                int windows;
                Appartament room;

                Double.TryParse(textBox1.Text, out a);
                Double.TryParse(textBox4.Text, out b);
                Double.TryParse(textBox2.Text, out h);
                Int32.TryParse(textBox3.Text, out windows);
                try
                {
                    if (a != ' ' && b != ' ' && h != ' ' && windows != ' ')
                    {
                        if (a > 0 && b > 0 && h > 0 && windows > 0)
                        {
                            room = new Appartament(a, b, h, windows);
                        }
                    }


                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


    }
}

  