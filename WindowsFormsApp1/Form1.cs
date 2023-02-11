using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Bitmap origin = null;
        private Bitmap result = null;
        private Bitmap si; 
        private int ancho, alto;

        public Form1()
        {
            InitializeComponent();
            btns();
            reescalarnb();
            result = new Bitmap(800, 400);

            ancho = 800;
            alto = 450;
        }

        private void btns()
        {
            pnsubarchivos.Visible = false;
            subfiltros.Visible = false;
            submatriz.Visible = false;
        }

        private void reescalarnb()
        {
            btnescalar.Enabled = false;
        }

        private void hide()
        {
            if (pnsubarchivos.Visible == true)
                pnsubarchivos.Visible = false;
            if (subfiltros.Visible == true)
                subfiltros.Visible = false;
            if (submatriz.Visible == true)
            {
                submatriz.Visible = false;
            }      
            if(panel4.Visible == true)
            {
                panel4.Visible = false;
            }
            reescalarnb();
        }

        private void show(Panel sub)
        {
            if (sub.Visible == false)
            {
                hide();
                sub.Visible = true;
            }
            else
                sub.Visible = false;

        }

        private void btnarchivo_Click(object sender, EventArgs e)
        {
            show(pnsubarchivos);
        }    

        private void btnup_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origin = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                si = origin;
                ancho = origin.Width;
                alto = origin.Height;

                result = origin;

                Invalidate();
            }
            hide();
            reescalarnb();
        }
        
        private void btnfilt_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
            {
                show(subfiltros);
                panel4.Visible = true;
            }
            else
                show(subfiltros);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(result != null)
            {
                Graphics g = e.Graphics;

                AutoScrollMinSize = new Size(ancho, alto);

                int ch, at;
                

                if(result.Width > 470 || result.Height > 300)
                {
                    ch = result.Width * 2;
                    at = result.Height * 2;
                    if(ch > 470 || at > 300)
                    {
                        ch = result.Width;
                        at = result.Height;      
                    }
                    if(result.Width > 2500 || result.Height > 1800)
                    {
                        ch = result.Width / 8;
                        at = result.Height / 8;
                    }
                }
                else
                {
                    ch = result.Width;
                    at = result.Height;
                }
                
                g.DrawImage(result, new Rectangle(AutoScrollPosition.X + 250, AutoScrollPosition.Y + 125, ch, at));
            }
        }

        private int[,] Extra3()
        {
            int n = 3;
            int[,] matriz1 = new int[n, n];

            matriz1 = new int[,] { {Convert.ToInt32(n1.Text), Convert.ToInt32(n2.Text), Convert.ToInt32(n3.Text)},
                        {Convert.ToInt32(n6.Text), Convert.ToInt32(n7.Text), Convert.ToInt32(n8.Text)},
                        {Convert.ToInt32(n11.Text), Convert.ToInt32(n12.Text), Convert.ToInt32(n13.Text)}};

            return matriz1;
        }
        private void Final3(int [,] matriz1)
        {
            s1.Text = Convert.ToString(matriz1[0, 0]);
            s2.Text = Convert.ToString(matriz1[0, 1]);
            s3.Text = Convert.ToString(matriz1[0, 2]);
            s6.Text = Convert.ToString(matriz1[1, 0]);
            s7.Text = Convert.ToString(matriz1[1, 1]);
            s8.Text = Convert.ToString(matriz1[1, 2]);
            s11.Text = Convert.ToString(matriz1[2, 0]);
            s12.Text = Convert.ToString(matriz1[2, 1]);
            s13.Text = Convert.ToString(matriz1[2, 2]);
        }
        private int[,] Extra4()
        {
            int n = 4;
            int[,] matriz1 = new int[n, n];

            matriz1 = new int[,] { { Convert.ToInt32(n1.Text), Convert.ToInt32(n2.Text), Convert.ToInt32(n3.Text) , Convert.ToInt32(n4.Text) },
                        { Convert.ToInt32(n6.Text), Convert.ToInt32(n7.Text), Convert.ToInt32(n8.Text) , Convert.ToInt32(n9.Text)},
                        {Convert.ToInt32(n11.Text), Convert.ToInt32(n12.Text), Convert.ToInt32(n13.Text), Convert.ToInt32(n14.Text)},
                        {Convert.ToInt32(n16.Text), Convert.ToInt32(n17.Text), Convert.ToInt32(n18.Text), Convert.ToInt32(n19.Text)}};

            return matriz1;
        }
        private void Final4(int[,] matriz1)
        {
            s1.Text = Convert.ToString(matriz1[0, 0]);
            s2.Text = Convert.ToString(matriz1[0, 1]);
            s3.Text = Convert.ToString(matriz1[0, 2]);
            s4.Text = Convert.ToString(matriz1[0, 3]);
            s6.Text = Convert.ToString(matriz1[1, 0]);
            s7.Text = Convert.ToString(matriz1[1, 1]);
            s8.Text = Convert.ToString(matriz1[1, 2]);
            s9.Text = Convert.ToString(matriz1[1, 3]);
            s11.Text = Convert.ToString(matriz1[2, 0]);
            s12.Text = Convert.ToString(matriz1[2, 1]);
            s13.Text = Convert.ToString(matriz1[2, 2]);
            s14.Text = Convert.ToString(matriz1[2, 3]);
            s16.Text = Convert.ToString(matriz1[3, 0]);
            s17.Text = Convert.ToString(matriz1[3, 1]);
            s18.Text = Convert.ToString(matriz1[3, 2]);
            s19.Text = Convert.ToString(matriz1[3, 3]);
        }
        private int[,] Extra5()
        {
            int n = 5;
            int[,] matriz1 = new int[n, n];
            matriz1 = new int[,] { { Convert.ToInt32(n1.Text), Convert.ToInt32(n2.Text), Convert.ToInt32(n3.Text) , Convert.ToInt32(n4.Text), Convert.ToInt32(n5.Text) },
                        {Convert.ToInt32(n6.Text), Convert.ToInt32(n7.Text), Convert.ToInt32(n8.Text) , Convert.ToInt32(n9.Text), Convert.ToInt32(n10.Text)},
                        {Convert.ToInt32(n11.Text), Convert.ToInt32(n12.Text), Convert.ToInt32(n13.Text), Convert.ToInt32(n14.Text), Convert.ToInt32(n15.Text)},
                        {Convert.ToInt32(n16.Text), Convert.ToInt32(n17.Text), Convert.ToInt32(n18.Text), Convert.ToInt32(n19.Text), Convert.ToInt32(n20.Text)},
                        {Convert.ToInt32(n21.Text), Convert.ToInt32(n22.Text), Convert.ToInt32(n23.Text), Convert.ToInt32(n24.Text), Convert.ToInt32(n25.Text)}};

            return matriz1;
        }
        private void Final5(int[,] matriz1)
        {
            s1.Text = Convert.ToString(matriz1[0, 0]);
            s2.Text = Convert.ToString(matriz1[0, 1]);
            s3.Text = Convert.ToString(matriz1[0, 2]);
            s4.Text = Convert.ToString(matriz1[0, 3]);
            s5.Text = Convert.ToString(matriz1[0, 4]);
            s6.Text = Convert.ToString(matriz1[1, 0]);
            s7.Text = Convert.ToString(matriz1[1, 1]);
            s8.Text = Convert.ToString(matriz1[1, 2]);
            s9.Text = Convert.ToString(matriz1[1, 3]);
            s10.Text = Convert.ToString(matriz1[1, 4]);
            s11.Text = Convert.ToString(matriz1[2, 0]);
            s12.Text = Convert.ToString(matriz1[2, 1]);
            s13.Text = Convert.ToString(matriz1[2, 2]);
            s14.Text = Convert.ToString(matriz1[2, 3]);
            s15.Text = Convert.ToString(matriz1[2, 4]);
            s16.Text = Convert.ToString(matriz1[3, 0]);
            s17.Text = Convert.ToString(matriz1[3, 1]);
            s18.Text = Convert.ToString(matriz1[3, 2]);
            s19.Text = Convert.ToString(matriz1[3, 3]);
            s20.Text = Convert.ToString(matriz1[3, 4]);
            s21.Text = Convert.ToString(matriz1[4, 0]);
            s22.Text = Convert.ToString(matriz1[4, 1]);
            s23.Text = Convert.ToString(matriz1[4, 2]);
            s24.Text = Convert.ToString(matriz1[4, 3]);
            s25.Text = Convert.ToString(matriz1[4, 4]);
        }
        private int[,] Matricesmedia(int[,] matriz1, int n, int[,] mascara)
        {
            int[,] Result = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    float suma = 0;
                    for (int a = -1; a < 2; a++)
                    {
                        for (int b = -1; b < 2; b++)
                        {
                            if (i + a >= 0 && j + b >= 0 && i + a < n && j + b < n)
                            {
                                suma = suma + matriz1[i + a, j + b]*mascara[a+1, b+1];
                            }
                        }
                    }
                    Result[i, j] = Convert.ToInt32(Math.Round(suma / 9, MidpointRounding.AwayFromZero));
                }
            }

            return Result;
        }
        private void btnmedia_Click(object sender, EventArgs e)
        {
            reescalarnb();
            if(panel4.Visible == true)
            {
                int[,] mascara = new int[3, 3];
                mascara = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
                if (BTN3.Enabled == true)
                {
                    int n = 3;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra3();
                    matriz1 = Matricesmedia(matriz1, n, mascara);
                    Final3(matriz1);
                }
                if(BTN4.Enabled == true)
                {
                    int n = 4;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra4();
                    matriz1 = Matricesmedia(matriz1, n, mascara);
                    Final4(matriz1);
                }
                if (BTN5.Enabled == true)
                {
                    int n = 5;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra5();
                    matriz1 = Matricesmedia(matriz1, n, mascara);
                    Final5(matriz1);  
                }
            }
            else
            {
                if (origin != null)
                {
                    int[,] mascara = new int[3, 3];
                    mascara = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

                    int x = 0; int y = 0;
                    int a = 0; int b = 0;

                    Color ocolor;

                    int sumaR = 0; int sumaG = 0; int sumaB = 0;

                    for (x = 1; x < origin.Width - 1; x++)
                    {
                        for (y = 1; y < origin.Height - 1; y++)
                        {
                            sumaR = 0;
                            sumaG = 0;
                            sumaB = 0;

                            for (a = -1; a < 2; a++)
                            {
                                for (b = -1; b < 2; b++)
                                {
                                    ocolor = origin.GetPixel(x + a, y + b);

                                    sumaR = sumaR + (ocolor.R * mascara[a + 1, b + 1]);
                                    sumaG = sumaG + (ocolor.G * mascara[a + 1, b + 1]);
                                    sumaB = sumaB + (ocolor.B * mascara[a + 1, b + 1]);
                                }
                            }

                            sumaR = sumaR / 9;
                            sumaG = sumaG / 9;
                            sumaB = sumaB / 9;

                            if (sumaR > 255) sumaR = 255;
                            else if (sumaR < 0) sumaR = 0;

                            if (sumaG > 255) sumaG = 255;
                            else if (sumaG < 0) sumaG = 0;

                            if (sumaB > 255) sumaB = 255;
                            else if (sumaB < 0) sumaB = 0;

                            result.SetPixel(x, y, Color.FromArgb(sumaR, sumaG, sumaB));
                        }
                    }

                    Invalidate();
                    reescalarnb();
                }
            }
        }
        private int [,] Matricesmediana(int [,]matriz1, int n)
        {
            int[,] Result = new int[n, n];
            List<int> temp = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp.Clear();
                    for (int a = -1; a < 2; a++)
                    {
                        for (int b = -1; b < 2; b++)
                        {
                            if (i + a >= 0 && j + b >= 0 && i + a < n && j + b < n)
                            {
                                temp.Add(matriz1[i + a, j + b]);
                            }
                        }
                    }
                    int[] array = temp.ToArray();
                   
                    array = Burbuja(array);
                    int can = array.Length;
                    float imp = (array[(can / 2) - 1] + (array[can / 2])) / (float)2;
                    if (can % 2 != 0) Result[i, j] = array[can/2];
                    else Result[i, j] = Convert.ToInt32(Math.Round(imp, MidpointRounding.AwayFromZero)); 
                }
            }

            return Result;
        }
        private void btnmediana_Click(object sender, EventArgs e)
        {
            reescalarnb();
            if(panel4.Visible == true)
            {
                if (BTN3.Enabled == true)
                {
                    int n = 3;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra3();
                    matriz1 = Matricesmediana(matriz1, n);
                    Final3(matriz1);
                }
                if (BTN4.Enabled == true)
                {
                    int n = 4;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra4();
                    matriz1 = Matricesmediana(matriz1, n);
                    Final4(matriz1);
                }
                if (BTN5.Enabled == true)
                {
                    int n = 5;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra5();
                    matriz1 = Matricesmediana(matriz1, n);
                    Final5(matriz1);
                }
            }
            else
            {
                if (origin != null)
                {
                    int x = 0; int y = 0;
                    int a = 0; int b = 0;

                    Color ocolor;

                    List<int> listaR = new List<int>();
                    List<int> listaG = new List<int>();
                    List<int> listaB = new List<int>();

                    for (x = 1; x < origin.Width - 1; x++)
                    {
                        for (y = 1; y < origin.Height - 1; y++)
                        {
                            listaR.Clear();
                            listaG.Clear();
                            listaB.Clear();

                            for (a = -1; a < 2; a++)
                            {
                                for (b = -1; b < 2; b++)
                                {
                                    ocolor = origin.GetPixel(x + a, y + b);

                                    listaR.Add(ocolor.R);
                                    listaG.Add(ocolor.G);
                                    listaB.Add(ocolor.B);
                                }
                            }
                            int[] arrayR = listaR.ToArray();
                            int[] arrayG = listaG.ToArray();
                            int[] arrayB = listaB.ToArray();

                            arrayR = Burbuja(arrayR);
                            arrayG = Burbuja(arrayG);
                            arrayB = Burbuja(arrayB);


                            int R = 0; int G = 0; int B = 0;

                            if (arrayR.Length % 2 != 0) R = arrayR[4];
                            else R = (arrayR[3] + arrayR[4]) / 2;

                            if (arrayG.Length % 2 != 0) G = arrayG[4];
                            else G = (arrayG[3] + arrayG[4]) / 2;

                            if (arrayB.Length % 2 != 0) B = arrayB[4];
                            else B = (arrayB[3] + arrayB[4]) / 2;

                            result.SetPixel(x, y, Color.FromArgb(R, G, B));
                        }
                    }
                    Invalidate();
                    reescalarnb();
                }
            }
        }

        private int[] Burbuja(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }

            return arr;
        }
        private int[,] MatricesLaplaceSobel(int[,] matriz1, int n, int[,] mascara)
        {
            int[,] Result = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    float suma = 0;
                    for (int a = -1; a < 2; a++)
                    {
                        for (int b = -1; b < 2; b++)
                        {
                            if (i + a >= 0 && j + b >= 0 && i + a < n && j + b < n)
                            {
                                suma = suma + matriz1[i + a, j + b] * mascara[a + 1, b + 1];
                            }
                        }
                    }
                    Result[i, j] = Convert.ToInt32(Math.Round(suma));
                }
            }
            return Result;
        }
        private void btnlaplace_Click(object sender, EventArgs e)
        {
            if(panel4.Visible == true)
            {
                int[,] mascara = new int[3, 3];
                mascara = new int[,] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
                if (BTN3.Enabled == true)
                {
                    int n = 3;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra3();
                    matriz1 = MatricesLaplaceSobel(matriz1, n, mascara);
                    Final3(matriz1);
                }
                if (BTN4.Enabled == true)
                {
                    int n = 4;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra4();
                    matriz1 = MatricesLaplaceSobel(matriz1, n, mascara);
                    Final4(matriz1);
                }
                if (BTN5.Enabled == true)
                {
                    int n = 5;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra5();
                    matriz1 = MatricesLaplaceSobel(matriz1, n, mascara);
                    Final5(matriz1);
                }
            }
            else
            {
                if (origin != null)
                {
                    int[,] mascara = new int[3, 3];
                    mascara = new int[,] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
                    int col = 0;
                    int x = 0; int y = 0;
                    int a = 0; int b = 0;

                    Color ocolor;

                    int sumaR = 0; int sumaG = 0; int sumaB = 0;

                    for (x = 1; x < origin.Width - 1; x++)
                    {
                        for (y = 1; y < origin.Height - 1; y++)
                        {
                            sumaR = 0;
                            sumaG = 0;
                            sumaB = 0;

                            for (a = -1; a < 2; a++)
                            {
                                for (b = -1; b < 2; b++)
                                {
                                    ocolor = origin.GetPixel(x + a, y + b);

                                    sumaR = sumaR + (ocolor.R * mascara[a + 1, b + 1]);
                                    sumaG = sumaG + (ocolor.G * mascara[a + 1, b + 1]);
                                    sumaB = sumaB + (ocolor.B * mascara[a + 1, b + 1]);
                                }
                            }

                            col = (sumaR + sumaG + sumaB) / 3;

                            if (col > 255) col = 255;
                            else if (col < 0) col = 0;

                            result.SetPixel(x, y, Color.FromArgb(col, col, col));
                        }
                    }

                    Invalidate();
                }
            }
            btnescalar.Enabled = true;
        }

        private void btnsobel_Click(object sender, EventArgs e)
        {
            if(panel4.Visible == true)
            {
                int[,] mascara = new int[3, 3];
                mascara = new int[,] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
                if (BTN3.Enabled == true)
                {
                    int n = 3;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra3();
                    matriz1 = MatricesLaplaceSobel(matriz1, n, mascara);
                    Final3(matriz1);
                }
                if (BTN4.Enabled == true)
                {
                    int n = 4;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra4();
                    matriz1 = MatricesLaplaceSobel(matriz1, n, mascara);
                    Final4(matriz1);
                }
                if (BTN5.Enabled == true)
                {
                    int n = 5;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra5();
                    matriz1 = MatricesLaplaceSobel(matriz1, n, mascara);
                    Final5(matriz1);
                }
            }
            else
            {
                if (origin != null)
                {
                    int[,] mascara = new int[3, 3];
                    mascara = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
                    int col = 0;
                    int x = 0; int y = 0;
                    int a = 0; int b = 0;

                    Color ocolor;

                    int sumaR = 0; int sumaG = 0; int sumaB = 0;

                    for (x = 1; x < origin.Width - 1; x++)
                    {
                        for (y = 1; y < origin.Height - 1; y++)
                        {
                            sumaR = 0;
                            sumaG = 0;
                            sumaB = 0;

                            for (a = -1; a < 2; a++)
                            {
                                for (b = -1; b < 2; b++)
                                {
                                    ocolor = origin.GetPixel(x + a, y + b);

                                    sumaR = sumaR + (ocolor.R * mascara[a + 1, b + 1]);
                                    sumaG = sumaG + (ocolor.G * mascara[a + 1, b + 1]);
                                    sumaB = sumaB + (ocolor.B * mascara[a + 1, b + 1]);
                                }
                            }

                            col = (sumaR + sumaG + sumaB) / 3;

                            if (col > 255) col = 255;
                            else if (col < 0) col = 0;

                            result.SetPixel(x, y, Color.FromArgb(col, col, col));
                        }
                    }

                    Invalidate();
                }
            }
            btnescalar.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap keep = si;
            result = keep;
            keep = si;
            Invalidate();
        }
        private void btnMatriz_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
            {
                show(submatriz);
                panel4.Visible = true;
            }
            else
                show(submatriz);
        }
        private void LimpiarMatriz()
        {
            n1.Text = "0";
            n2.Text = "0";
            n3.Text = "0";
            n4.Text = "0";
            n5.Text = "0";
            n6.Text = "0";
            n7.Text = "0";
            n8.Text = "0";
            n9.Text = "0";
            n10.Text = "0";
            n11.Text = "0";
            n12.Text = "0";
            n13.Text = "0";
            n14.Text = "0";
            n15.Text = "0";
            n16.Text = "0";
            n17.Text = "0";
            n18.Text = "0";
            n19.Text = "0";
            n20.Text = "0";
            n21.Text = "0";
            n22.Text = "0";
            n23.Text = "0";
            n24.Text = "0";
            n25.Text = "0";
        }
        private void ocultartodo()
        {
            n1.Visible = false;
            n2.Visible = false;
            n3.Visible = false;
            n4.Visible = false;
            n5.Visible = false;
            n6.Visible = false;
            n7.Visible = false;
            n8.Visible = false;
            n9.Visible = false;
            n10.Visible = false;
            n11.Visible = false;
            n12.Visible = false;
            n13.Visible = false;
            n14.Visible = false;
            n15.Visible = false;
            n16.Visible = false;
            n17.Visible = false;
            n18.Visible = false;
            n19.Visible = false;
            n20.Visible = false;
            n21.Visible = false;
            n22.Visible = false;
            n23.Visible = false;
            n24.Visible = false;
            n25.Visible = false;

            s1.Visible = false;
            s2.Visible = false;
            s3.Visible = false;
            s4.Visible = false;
            s5.Visible = false;
            s6.Visible = false;
            s7.Visible = false;
            s8.Visible = false;
            s9.Visible = false;
            s10.Visible = false;
            s11.Visible = false;
            s12.Visible = false;
            s13.Visible = false;
            s14.Visible = false;
            s15.Visible = false;
            s16.Visible = false;
            s17.Visible = false;
            s18.Visible = false;
            s19.Visible = false;
            s20.Visible = false;
            s21.Visible = false;
            s22.Visible = false;
            s23.Visible = false;
            s24.Visible = false;
            s25.Visible = false;

            r1.Visible = false;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            r8.Visible = false;
            r9.Visible = false;
            r10.Visible = false;
            r11.Visible = false;
            r12.Visible = false;
            r13.Visible = false;
            r14.Visible = false;
            r15.Visible = false;
            r16.Visible = false;
            r17.Visible = false;
            r18.Visible = false;
            r19.Visible = false;
            r20.Visible = false;
            r21.Visible = false;
            r22.Visible = false;
            r23.Visible = false;
            r24.Visible = false;
            r25.Visible = false;
        }
        private void Mostrar3()
        {
            ocultartodo();
            n1.Visible = true; s1.Visible = true;
            n2.Visible = true; s2.Visible = true;
            n3.Visible = true; s3.Visible = true;
            n6.Visible = true; s6.Visible = true;
            n7.Visible = true; s7.Visible = true;
            n8.Visible = true; s8.Visible = true;
            n11.Visible = true; s11.Visible = true;
            n12.Visible = true; s12.Visible = true;
            n13.Visible = true; s13.Visible = true;
        }
        private void Mostrar3Reescala()
        {
            r1.Visible = true;
            r2.Visible = true; 
            r3.Visible = true; 
            r6.Visible = true;
            r7.Visible = true; 
            r8.Visible = true; 
            r11.Visible = true; 
            r12.Visible = true; 
            r13.Visible = true; 
        }
        private void Mostrar4()
        {
            ocultartodo();
            Mostrar3();
            n4.Visible = true; s4.Visible = true;
            n9.Visible = true; s9.Visible = true;
            n14.Visible = true; s14.Visible = true;
            n16.Visible = true; s16.Visible = true;
            n17.Visible = true; s17.Visible = true;
            n18.Visible = true; s18.Visible = true;
            n19.Visible = true; s19.Visible = true;
        }
        private void Mostrar4Reescala()
        {
            Mostrar3Reescala();
            r4.Visible = true; 
            r9.Visible = true; 
            r14.Visible = true; 
            r16.Visible = true; 
            r17.Visible = true; 
            r18.Visible = true; 
            r19.Visible = true; 
        }
        private void Mostrar5()
        {
            ocultartodo();
            Mostrar4();
            n5.Visible = true; s5.Visible = true;
            n10.Visible = true; s10.Visible = true;
            n15.Visible = true; s15.Visible = true;
            n20.Visible = true; s20.Visible = true;
            n21.Visible = true; s21.Visible = true;
            n22.Visible = true; s22.Visible = true;
            n23.Visible = true; s23.Visible = true;
            n24.Visible = true; s24.Visible = true;
            n25.Visible = true; s25.Visible = true;
        }
        private void Mostrar5Reescala()
        {
            Mostrar4Reescala();
            r5.Visible = true;
            r10.Visible = true;
            r15.Visible = true; 
            r20.Visible = true; 
            r21.Visible = true; 
            r22.Visible = true; 
            r23.Visible = true; 
            r24.Visible = true;
            r25.Visible = true; 
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            hide();
            Close();
        }

        private void ENB()
        {
            BTN3.Enabled = false;
            BTN4.Enabled = false;
            BTN5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            Mostrar3();
            ENB();
            BTN3.Enabled = true;
            LimpiarMatriz();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LimpiarMatriz();
        }
        private int[,] Extra3Final()
        {
            int n = 3;
            int[,] matriz1 = new int[n, n];

            matriz1 = new int[,] { {Convert.ToInt32(s1.Text), Convert.ToInt32(s2.Text), Convert.ToInt32(s3.Text)},
                        {Convert.ToInt32(s6.Text), Convert.ToInt32(s7.Text), Convert.ToInt32(s8.Text)},
                        {Convert.ToInt32(s11.Text), Convert.ToInt32(s12.Text), Convert.ToInt32(s13.Text)}};

            return matriz1;
        }
        private void FinalReescala3(int[,] matriz1)
        {
            r1.Text = Convert.ToString(matriz1[0, 0]);
            r2.Text = Convert.ToString(matriz1[0, 1]);
            r3.Text = Convert.ToString(matriz1[0, 2]);
            r6.Text = Convert.ToString(matriz1[1, 0]);
            r7.Text = Convert.ToString(matriz1[1, 1]);
            r8.Text = Convert.ToString(matriz1[1, 2]);
            r11.Text = Convert.ToString(matriz1[2, 0]);
            r12.Text = Convert.ToString(matriz1[2, 1]);
            r13.Text = Convert.ToString(matriz1[2, 2]);
        }
        private int[,] Extra4Final()
        {
            int n = 4;
            int[,] matriz1 = new int[n, n];

            matriz1 = new int[,] { { Convert.ToInt32(s1.Text), Convert.ToInt32(s2.Text), Convert.ToInt32(s3.Text) , Convert.ToInt32(s4.Text) },
                        { Convert.ToInt32(s6.Text), Convert.ToInt32(s7.Text), Convert.ToInt32(s8.Text) , Convert.ToInt32(s9.Text)},
                        {Convert.ToInt32(s11.Text), Convert.ToInt32(s12.Text), Convert.ToInt32(s13.Text), Convert.ToInt32(s14.Text)},
                        {Convert.ToInt32(s16.Text), Convert.ToInt32(s17.Text), Convert.ToInt32(s18.Text), Convert.ToInt32(s19.Text)}};

            return matriz1;
        }
        private void FinalReescala4(int[,] matriz1)
        {
            r1.Text = Convert.ToString(matriz1[0, 0]);
            r2.Text = Convert.ToString(matriz1[0, 1]);
            r3.Text = Convert.ToString(matriz1[0, 2]);
            r4.Text = Convert.ToString(matriz1[0, 3]);
            r6.Text = Convert.ToString(matriz1[1, 0]);
            r7.Text = Convert.ToString(matriz1[1, 1]);
            r8.Text = Convert.ToString(matriz1[1, 2]);
            r9.Text = Convert.ToString(matriz1[1, 3]);
            r11.Text = Convert.ToString(matriz1[2, 0]);
            r12.Text = Convert.ToString(matriz1[2, 1]);
            r13.Text = Convert.ToString(matriz1[2, 2]);
            r14.Text = Convert.ToString(matriz1[2, 3]);
            r16.Text = Convert.ToString(matriz1[3, 0]);
            r17.Text = Convert.ToString(matriz1[3, 1]);
            r18.Text = Convert.ToString(matriz1[3, 2]);
            r19.Text = Convert.ToString(matriz1[3, 3]);
        }
        private int[,] Extra5Final()
        {
            int n = 5;
            int[,] matriz1 = new int[n, n];
            matriz1 = new int[,] { { Convert.ToInt32(s1.Text), Convert.ToInt32(s2.Text), Convert.ToInt32(s3.Text) , Convert.ToInt32(s4.Text), Convert.ToInt32(s5.Text) },
                        {Convert.ToInt32(s6.Text), Convert.ToInt32(s7.Text), Convert.ToInt32(s8.Text) , Convert.ToInt32(s9.Text), Convert.ToInt32(s10.Text)},
                        {Convert.ToInt32(s11.Text), Convert.ToInt32(s12.Text), Convert.ToInt32(s13.Text), Convert.ToInt32(s14.Text), Convert.ToInt32(s15.Text)},
                        {Convert.ToInt32(s16.Text), Convert.ToInt32(s17.Text), Convert.ToInt32(s18.Text), Convert.ToInt32(s19.Text), Convert.ToInt32(s20.Text)},
                        {Convert.ToInt32(s21.Text), Convert.ToInt32(s22.Text), Convert.ToInt32(s23.Text), Convert.ToInt32(s24.Text), Convert.ToInt32(s25.Text)}};

            return matriz1;
        }
        private void FinalReescala5(int[,] matriz1)
        {
            r1.Text = Convert.ToString(matriz1[0, 0]);
            r2.Text = Convert.ToString(matriz1[0, 1]);
            r3.Text = Convert.ToString(matriz1[0, 2]);
            r4.Text = Convert.ToString(matriz1[0, 3]);
            r5.Text = Convert.ToString(matriz1[0, 4]);
            r6.Text = Convert.ToString(matriz1[1, 0]);
            r7.Text = Convert.ToString(matriz1[1, 1]);
            r8.Text = Convert.ToString(matriz1[1, 2]);
            r9.Text = Convert.ToString(matriz1[1, 3]);
            r10.Text = Convert.ToString(matriz1[1, 4]);
            r11.Text = Convert.ToString(matriz1[2, 0]);
            r12.Text = Convert.ToString(matriz1[2, 1]);
            r13.Text = Convert.ToString(matriz1[2, 2]);
            r14.Text = Convert.ToString(matriz1[2, 3]);
            r15.Text = Convert.ToString(matriz1[2, 4]);
            r16.Text = Convert.ToString(matriz1[3, 0]);
            r17.Text = Convert.ToString(matriz1[3, 1]);
            r18.Text = Convert.ToString(matriz1[3, 2]);
            r19.Text = Convert.ToString(matriz1[3, 3]);
            r20.Text = Convert.ToString(matriz1[3, 4]);
            r21.Text = Convert.ToString(matriz1[4, 0]);
            r22.Text = Convert.ToString(matriz1[4, 1]);
            r23.Text = Convert.ToString(matriz1[4, 2]);
            r24.Text = Convert.ToString(matriz1[4, 3]);
            r25.Text = Convert.ToString(matriz1[4, 4]);
        }

        private int[,] reescalamiento(int [,]matriz1, int n)
        {
            int[,] Result = new int[n, n];
            if (panel4.Visible == true)
            {
                int mayor = matriz1[0, 0];
                int menor = matriz1[0, 0];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (mayor < matriz1[i, j]) mayor = matriz1[i, j];
                        if (menor > matriz1[i, j]) menor = matriz1[i, j];
                    }
                }
                
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if(mayor == 0 && menor == 0)
                        {
                            Result[i, j] = 0;
                        }
                        else
                        {
                            double calculo = ((7 * matriz1[i, j]) / (float)(mayor - menor)) + ((-7 * menor) / (float)(mayor - menor));
                            Result[i, j] = Convert.ToInt32(Math.Round(calculo, MidpointRounding.AwayFromZero));
                        }
                        
                    }
                }
            }
            return Result;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            Mostrar4();
            ENB();
            BTN4.Enabled = true;
            LimpiarMatriz();        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            Mostrar5();
            ENB();
            BTN5.Enabled = true;
            LimpiarMatriz();
        }

        private void btnescalar_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
            {
                if (BTN3.Enabled == true)
                {
                    Mostrar3Reescala();
                    int n = 3;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra3Final();
                    matriz1 = reescalamiento(matriz1, n);
                    FinalReescala3(matriz1);
                }
                if (BTN4.Enabled == true)
                {
                    Mostrar4Reescala();
                    int n = 4;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra4Final();
                    matriz1 = reescalamiento(matriz1, n);
                    FinalReescala4(matriz1);
                }
                if (BTN5.Enabled == true)
                {
                    Mostrar5Reescala();
                    int n = 5;
                    int[,] matriz1 = new int[n, n];
                    matriz1 = Extra5Final();
                    matriz1 = reescalamiento(matriz1, n);
                    FinalReescala5(matriz1);
                    reescalamiento(matriz1, n);
                }
            }
        }

        private void btndw_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                result.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }

            hide();
        }


    }


}
