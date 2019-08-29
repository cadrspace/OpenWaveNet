using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenWaweNet
{
    public partial class Form1 : Form
    {
        Graphics g; // наше поле
        Random rand = new Random();
        int sizeX;  //желаемые размеры в клетках
        int sizeY;
        int fx; // пикселей на клетку
        int fy;
        int cx;//количество клеток реальное
        int cy;
        int obl_vid;// область видимости в клетках

        public struct intPoint
        {   public int x;
            public int y;
        }

        // клетка
            public struct ev
        {
            public int state; // ее состояние 1/0
            public int time_last_act; // итерация последней активации
            public intPoint[] sp_list; // ее список
        }
        ev[][] ev_arr;
        public Form1()
        {
            InitializeComponent();
        }

        // отрисовать клетку активное состояние 
        private void pix(int x,int y)
        {
            if (x < cx && y < cy)
            {
                g.FillRectangle(Brushes.Red, new Rectangle(x * fx+1, 1+y * fy, (fx)-1, (fy)-1));
            }
        }
        // отрисовать клетку неактивное состояние 
        private void unpix(int x, int y)
        {
            if (x < cx && y < cy)
            {
                g.FillRectangle(Brushes.Black, new Rectangle(x * fx + 1, 1 + y * fy, (fx) - 1, (fy) - 1));
            }
        }
        // отрисовать подсветку  
        private void pixz(int x, int y)
        {
            if (x < cx && y < cy)
            {
                g.FillRectangle(Brushes.Green, new Rectangle(x * fx + 1, 1 + y * fy, (fx) - 1, (fy) - 1));
            }
        }
        // отрисовать подсветку2  
        private void pixb(int x, int y)
        {
            if (x < cx && y < cy)
            {
                g.FillRectangle(Brushes.Blue, new Rectangle(x * fx + 1, 1 + y * fy, (fx) - 1, (fy) - 1));
            }
        }

        // отрисовать зону обзора
        private void obz(int k, int j)
        {
            for (int i = k - obl_vid; i <= k + obl_vid; i++)
            {
                for (int ii = j - obl_vid; ii <= j + obl_vid; ii++)
                {
                    if (i>=0 && j>=0 && (i != k || ii != j))
                    {
                        pixz(i, ii);
                    }
                }
            }
        }

        private void init() {
            sizeX=setka.Value;
            sizeY = sizeX;
            label1.Text = sizeY.ToString();
            g.Clear(Color.Black);
            int x=pb.Size.Width;
            int y= pb.Size.Height;
             fx = x / sizeX;
             fy = y / sizeY;
             cx = x/ fx;
             cy = y/fy;
            for (int i=fx; i<x; i+= fx)
            {
                g.DrawLine(new Pen(Brushes.Bisque, 1), new Point(i, 0), new Point(i, cy*fy));
            }

            for (int i = fy; i < y; i += fy)
            {
                g.DrawLine(new Pen(Brushes.Bisque, 1), new Point(0, i), new Point(cx*fx, i));
            }



            ev_arr = new ev[cx][];
            for (int i = 0; i < cx; i++)
            {
                ev_arr[i] = new ev[cy];
            }


           //приер пикселя с зоной обзора
            int k, j;
            obl_vid = obzor.Value;
            label4.Text = obl_vid.ToString();

            maxactivitis.Maximum = ((obl_vid+ obl_vid+1) * (obl_vid + obl_vid + 1))-1;
            maxactivitis.Value = maxactivitis.Maximum/2+1;
            label16.Text = maxactivitis.Value.ToString();
            k = cx/2; j = cy/2;
            pix(k, j);
            obz(k, j);
            int listsizestr = ((obl_vid * 2 + 1)*(obl_vid * 2 + 1)-1)/2;
            mest.Minimum = 1;
            mest.Maximum = ((obl_vid * 2 + 1) * (obl_vid * 2 + 1) - 1);
            mest.Value = ((obl_vid * 2 + 1) * (obl_vid * 2 + 1) - 1) / 2;
            label6.Text = mest.Value.ToString();

            //массивы.
            listsinit();
    }
        
        // инициализация массивов
        public void listsinit()
        {
            tekiter = 1000;
            for (int i = 0; i < cx; i++)
            {
                for (int ii = 0; ii < cy; ii++)
                {
                   
                        ev_arr[i][ii].state = 0;
                        ev_arr[i][ii].time_last_act = -1;
                        ev_arr[i][ii].sp_list = new intPoint[mest.Value];
                        for (int io = 0; io < mest.Value; io++)
                        {
                            //ev_arr[i][ii].sp_list[io].lastact = -1;
                            ev_arr[i][ii].sp_list[io].x = -1;
                            ev_arr[i][ii].sp_list[io].y = -1;
                        }

                    //начальное заполнение списков клетки (i ii) 
                    for (int io = 0; io < mest.Value; io++)
                    {
                        ev_arr[i][ii].sp_list[io].x =i- obzor.Value + rand.Next(0, (obzor.Value ) * 2);
                        ev_arr[i][ii].sp_list[io].y = ii- obzor.Value + rand.Next(0, (obzor.Value )*2);
                        //некорректные удаляем
                        if (ev_arr[i][ii].sp_list[io].x < 0 || ev_arr[i][ii].sp_list[io].y >=cy || ev_arr[i][ii].sp_list[io].x >=cx || ev_arr[i][ii].sp_list[io].y < 0 || (i == ev_arr[i][ii].sp_list[io].x && ii== ev_arr[i][ii].sp_list[io].y))
                        {
                            ev_arr[i][ii].sp_list[io].x = -1;
                            ev_arr[i][ii].sp_list[io].y = -1;
                        }
                    }
                    //

                }
            }
        }

        int tekiter;//итерация, счет ведем с 1000

        // активировать клетку
        void actpix(int i,int ii) {
            ev_arr[i][ii].time_last_act = tekiter;
            ev_arr[i][ii].state = 1;
            pix(i, ii);
        }

        // рендеринг поля
        void r1()
        {
            label_iter.Text = tekiter.ToString();
            for (int i = 0; i < cx; i++)
            {
                for (int ii = 0; ii < cy; ii++)
                {
                    if (ev_arr[i][ii].state==1)
                    {
                        pix(i, ii);
                        if (tekiter- act_time.Value > ev_arr[i][ii].time_last_act)
                        {
                            ev_arr[i][ii].state = 0;
                            unpix(i, ii);
                        }
                    }
                    else
                    {
                        unpix(i, ii);
                    }
                    if (tekiter > ev_arr[i][ii].time_last_act + act_time.Value + deact_time.Value)
                    {
                        for (int io = 0; io < mest.Value; io++)
                        {
                            int x, y;
                            x = ev_arr[i][ii].sp_list[io].x;
                            y = ev_arr[i][ii].sp_list[io].y;
                            if (x>0 && y>0 && ev_arr[x][y].state == 1 && ev_arr[x][y].time_last_act!=tekiter)
                            {
                                // ограниение этапа
                                int stand = 0;
                                for (int i1 = i - obl_vid; i1 <= i + obl_vid; i1++)
                                {
                                    for (int ii1 = ii - obl_vid; ii1 <= ii + obl_vid; ii1++)
                                    {
                                        if (i1 >= 0 && ii1 >= 0 && (i1 != i || ii1 != ii) && i1<cx && ii1<cy)
                                        {
                                            if (ev_arr[i1][ii1].state == 1) { stand++; }
                                        }
                                    }
                                }
                                //пытаемся активировать но только если рядом мало активных соседей
                                if (stand < maxactivitis.Value)
                                {
                                    actpix(i, ii);
                                }
                                else
                                {
                                    // удаление
                                    for (io = 0; io < mest.Value; io++)
                                    {
                                        if (ev_arr[i][ii].sp_list[io].x < 0 || ev_arr[i][ii].sp_list[io].y >= cy || ev_arr[i][ii].sp_list[io].x >= cx || ev_arr[i][ii].sp_list[io].y < 0 || (i == ev_arr[i][ii].sp_list[io].x && ii == ev_arr[i][ii].sp_list[io].y) && ev_arr[ev_arr[i][ii].sp_list[io].x][ev_arr[i][ii].sp_list[io].y].state == 1)
                                        {
                                            ev_arr[i][ii].sp_list[io].x = -1;
                                            ev_arr[i][ii].sp_list[io].y = -1;
                                        }
                                    }
                                    //
                                }

                            }
                        }
                    }
                    

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g = pb.CreateGraphics();
            init();
            r1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tekiter++;
            r1();
        }

        private void setka_Scroll(object sender, EventArgs e)
        {
            init();
        }

        private void obzor_Scroll(object sender, EventArgs e)
        {
            init();
        }

        private void mest_Scroll(object sender, EventArgs e)
        {
            label6.Text = mest.Value.ToString(); listsinit();
        }

        private void deact_time_Scroll(object sender, EventArgs e)
        {
            label10.Text = deact_time.Value.ToString();
        }

        private void act_time_Scroll(object sender, EventArgs e)
        {
            label9.Text = act_time.Value.ToString();
        }

       

        private void pb_Click(object sender, EventArgs e)
        {
 
        }

        //показать связи клетки
     public void showlinks(int x,int y)
        {
            int i, ii;
            i = x;
            ii = y;
            for (int io = 0; io < mest.Value; io++)
            {
                x = ev_arr[i][ii].sp_list[io].x;
                y = ev_arr[i][ii].sp_list[io].y;
                pixz(x, y);
            }

            x = i; y = ii;
            for (i = 0; i < cx; i++)
            {
                for (ii = 0; ii < cy; ii++)
                {
                    for (int io = 0; io < mest.Value; io++)
                    {
                        if (ev_arr[i][ii].sp_list[io].x == x && ev_arr[i][ii].sp_list[io].y == y) { pixb(i, ii); }

                    }
                }
            }


        }



        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            r1();
            int x = Convert.ToInt32(e.X); // координата по оси X
            int y = Convert.ToInt32(e.Y); // координата по оси Y
            int i, ii;
            i = x/fx;
            ii = y/fy;
            if (i < cx && ii < cy)
            {
                showlinks(i, ii);
            }
        }

        private void pb_MouseClick(object sender, MouseEventArgs e)
        {
            r1();
            int x = Convert.ToInt32(e.X); // координата по оси X
            int y = Convert.ToInt32(e.Y); // координата по оси Y
            int i, ii;
            i = x / fx;
            ii = y / fy;
            if (i < cx && ii < cy)
            {
                actpix(i, ii);
            }
            
        }

        private void maxactivitis_Scroll(object sender, EventArgs e)
        {
            label16.Text = maxactivitis.Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tekiter++;
            r1();
        }
    }
}
