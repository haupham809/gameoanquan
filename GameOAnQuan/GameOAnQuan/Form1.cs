using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOAnQuan
{
    public partial class Game : Form
    {
        public Game()
        {

            InitializeComponent();

            nguoichoi.Text = "Lược chơi của người";
        }
        public static int diemmay = 0;
        public static int diemnguoi = 0;
        public static int conchucuamay = 0;
        public static int luachoncuamay = 0;
        public static int conchucuanguoi = 0;
        public static int luachoncuanguoi = 0;

        public static int conchucuamay1 = 0; public static int conchucuanguoi1 = 0;
        private void reset()
        {
            btn1.BackColor = Color.Transparent;
            btn2.BackColor = Color.Transparent;
            btn3.BackColor = Color.Transparent;
            btn4.BackColor = Color.Transparent;
            btn5.BackColor = Color.Transparent;
            btn6.BackColor = Color.Transparent;
            btn7.BackColor = Color.Transparent;
            btn8.BackColor = Color.Transparent;
            btn9.BackColor = Color.Transparent;
            btn10.BackColor = Color.Transparent;
            btn11.BackColor = Color.Transparent;
            btn12.BackColor = Color.Transparent;
        }

        private bool isZero(string text)
        {
            if (Convert.ToInt32(text) == 0)
                return true;
            else
                return false;
        }

        private bool kiemtra()
        {
            if (isZero(btn1.Text) && isZero(btn2.Text) && isZero(btn3.Text) && isZero(btn4.Text) && isZero(btn5.Text) && isZero(btn7.Text) && isZero(btn8.Text) && isZero(btn9.Text) && isZero(btn10.Text) && isZero(btn11.Text))
                return true;
            if (isZero(btn1.Text) && isZero(btn2.Text) && isZero(btn3.Text) && isZero(btn4.Text) && isZero(btn5.Text))
                return true;
            else if (isZero(btn7.Text) && isZero(btn8.Text) && isZero(btn9.Text) && isZero(btn10.Text) && isZero(btn11.Text))
                return true;
            return false;
        }

        int[] tempSoi;

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private int choinguocchieu(string btn, int soluongsoi, bool isCalculating)
        {
            if (!isCalculating)
            {
                wait(500);
                replaceimage();
            }

            if (luachoncuanguoi == 1 && !isCalculating)
            {
                if (isZero(btn1.Text) && isZero(btn2.Text) && isZero(btn3.Text)
                && isZero(btn4.Text) && isZero(btn5.Text) && isZero(btn7.Text) && isZero(btn8.Text) && isZero(btn9.Text)
                && isZero(btn10.Text) && isZero(btn11.Text))
                    return 0;


            }
            else if (luachoncuamay == 1 && !isCalculating)
            {
                if (isZero(btn1.Text) && isZero(btn2.Text) && isZero(btn3.Text)
               && isZero(btn4.Text) && isZero(btn5.Text) && isZero(btn7.Text) && isZero(btn8.Text) && isZero(btn9.Text)
               && isZero(btn10.Text) && isZero(btn11.Text))
                    return 0;
            }


            int x = 0;
            if (!isCalculating)
            {
                if (soluongsoi > 0)
                {
                    reset();
                    int vitrichon = Convert.ToInt32(btn.Replace("btn", ""));


                    if (vitrichon == 1)
                    {
                        btn2.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn2.Text = (Convert.ToInt32(btn2.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn3.Text))
                            {
                                x = Convert.ToInt32(btn4.Text);
                                btn4.Text = "0";
                                if (isZero(btn5.Text))
                                    return x + choinguocchieu("btn5", Convert.ToInt32(btn5.Text), false);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn3.Text);
                            btn3.Text = "0";
                            return choinguocchieu("btn3", a, false);

                        }
                        else
                        {
                            return choinguocchieu("btn2", soluongsoi, false);
                        }



                    }
                    else if (vitrichon == 2)
                    {
                        btn3.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn3.Text = (Convert.ToInt32(btn3.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn4.Text))
                            {
                                x = Convert.ToInt32(btn5.Text);
                                btn5.Text = "0";
                                if (isZero(btn6.Text))
                                {
                                    return x + choinguocchieu("btn6", Convert.ToInt32(btn6.Text), false);
                                }
                                else return x;


                            }
                            int a = Convert.ToInt32(btn4.Text);
                            btn4.Text = "0";
                            return choinguocchieu("btn4", a, false);

                        }
                        else
                        {
                            return choinguocchieu("btn3", soluongsoi, false);
                        }
                    }
                    else if (vitrichon == 3)
                    {
                        btn4.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn4.Text = (Convert.ToInt32(btn4.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn5.Text))
                            {
                                if (conchucuanguoi1 == 0)
                                {
                                    if (luachoncuamay == 0)
                                    {
                                        conchucuanguoi = conchucuanguoi + 9;

                                    }
                                    else
                                    {
                                        conchucuamay = conchucuamay + 9;
                                    }
                                    conchucuanguoi1 = 1;
                                }

                                x = Convert.ToInt32(btn6.Text);
                                btn6.Text = "0";

                                if (isZero(btn7.Text))
                                    return x + choinguocchieu("btn7", Convert.ToInt32(btn7.Text), false);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn5.Text);
                            btn5.Text = "0";
                            return choinguocchieu("btn5", a, false);

                        }
                        else
                        {
                            return choinguocchieu("btn4", soluongsoi, false);
                        }
                    }
                    else if (vitrichon == 4)
                    {
                        btn5.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn5.Text = (Convert.ToInt32(btn5.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn6.Text))
                            {
                                x = Convert.ToInt32(btn7.Text);
                                btn7.Text = "0";
                                if (isZero(btn8.Text))
                                    return x + choinguocchieu("btn8", Convert.ToInt32(btn8.Text), false);
                                else return x;

                            }

                        }
                        else
                        {
                            return choinguocchieu("btn5", soluongsoi, false);
                        }
                    }
                    else if (vitrichon == 5)
                    {
                        btn6.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn6.Text = (Convert.ToInt32(btn6.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn7.Text))
                            {
                                x = Convert.ToInt32(btn8.Text);
                                btn8.Text = "0";
                                if (isZero(btn9.Text))
                                    return x + choinguocchieu("btn9", Convert.ToInt32(btn9.Text), false);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn7.Text);
                            btn7.Text = "0";
                            return choinguocchieu("btn7", a, false);

                        }
                        else
                        {
                            return choinguocchieu("btn6", soluongsoi, false);
                        }

                    }
                    else if (vitrichon == 6)
                    {
                        btn7.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn7.Text = (Convert.ToInt32(btn7.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn8.Text))
                            {
                                x = Convert.ToInt32(btn9.Text);
                                btn9.Text = "0";
                                if (isZero(btn10.Text))
                                    return x + choinguocchieu("btn10", Convert.ToInt32(btn10.Text), false);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn8.Text);
                            btn8.Text = "0";
                            return choinguocchieu("btn8", a, false);

                        }
                        else
                        {
                            return choinguocchieu("btn7", soluongsoi, false);
                        }
                    }
                    else if (vitrichon == 7)
                    {
                        btn8.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn8.Text = (Convert.ToInt32(btn8.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn9.Text))
                            {
                                x = Convert.ToInt32(btn10.Text);
                                btn10.Text = "0";
                                if (isZero(btn11.Text))
                                    return x + choinguocchieu("btn11", Convert.ToInt32(btn11.Text), false);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn9.Text);
                            btn9.Text = "0";
                            return choinguocchieu("btn9", a, false);

                        }
                        else
                        {
                            return choinguocchieu("btn8", soluongsoi, false);
                        }
                    }
                    else if (vitrichon == 8)
                    {
                        btn9.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn9.Text = (Convert.ToInt32(btn9.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn10.Text))
                            {
                                x = Convert.ToInt32(btn11.Text);
                                btn11.Text = "0";
                                if (isZero(btn12.Text))
                                {
                                    return x + choinguocchieu("btn12", Convert.ToInt32(btn12.Text), false);
                                }
                                else return x;


                            }
                            int a = Convert.ToInt32(btn10.Text);
                            btn10.Text = "0";
                            return choinguocchieu("btn10", a, false);

                        }
                        else
                        {
                            return choinguocchieu("btn9", soluongsoi, false);
                        }
                    }
                    else if (vitrichon == 9)
                    {
                        btn10.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn10.Text = (Convert.ToInt32(btn10.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn11.Text))
                            {

                                if (conchucuamay1 == 0)
                                {
                                    if (luachoncuamay == 0)
                                    {
                                        conchucuanguoi = conchucuanguoi + 9;

                                    }
                                    else
                                    {
                                        conchucuamay = conchucuamay + 9;
                                    }
                                    conchucuamay1 = 1;
                                }

                                x = Convert.ToInt32(btn12.Text);
                                btn12.Text = "0";
                                if (isZero(btn1.Text))
                                    return x + choinguocchieu("btn1", Convert.ToInt32(btn1.Text), false);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn11.Text);
                            btn11.Text = "0";
                            return choinguocchieu("btn11", a, false);

                        }
                        else
                        {
                            return choinguocchieu("btn10", soluongsoi, false);
                        }
                    }
                    else if (vitrichon == 10)
                    {
                        btn11.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn11.Text = (Convert.ToInt32(btn11.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn12.Text))
                            {
                                x = Convert.ToInt32(btn1.Text);
                                btn1.Text = "0";
                                if (isZero(btn2.Text))
                                    return x + choinguocchieu("btn2", Convert.ToInt32(btn2.Text), false);
                                else return x;

                            }
                        }
                        else
                        {
                            return choinguocchieu("btn11", soluongsoi, false);
                        }
                    }
                    else if (vitrichon == 11)
                    {
                        btn12.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn12.Text = (Convert.ToInt32(btn12.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn1.Text))
                            {
                                x = Convert.ToInt32(btn2.Text);
                                btn2.Text = "0";
                                if (isZero(btn3.Text))
                                    return x + choinguocchieu("btn3", Convert.ToInt32(btn3.Text), false);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn1.Text);
                            btn1.Text = "0";
                            return choinguocchieu("btn1", a, false);

                        }
                        else
                        {
                            return choinguocchieu("btn12", soluongsoi, false);
                        }
                    }
                    else if (vitrichon == 12)
                    {
                        btn1.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn1.Text = (Convert.ToInt32(btn1.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (isZero(btn2.Text))
                            {
                                x = Convert.ToInt32(btn3.Text);
                                btn3.Text = "0";
                                if (isZero(btn4.Text))
                                    return x + choinguocchieu("btn4", Convert.ToInt32(btn4.Text), false);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn2.Text);
                            btn2.Text = "0";
                            return choinguocchieu("btn2", a, false);

                        }
                        else
                        {
                            return choinguocchieu("btn1", soluongsoi, false);
                        }
                    }

                }
                else if (soluongsoi == 0)
                {

                    reset();
                    int vitrichon = Convert.ToInt32(btn.Replace("btn", ""));
                    if (vitrichon == 1)
                    {
                        int a = Convert.ToInt32(btn2.Text);
                        btn2.Text = "0";
                        if (isZero(btn3.Text))
                            return a + choinguocchieu("btn3", Convert.ToInt32(btn3.Text), false);
                        else return a;
                    }
                    else if (vitrichon == 2)
                    {
                        int a = Convert.ToInt32(btn3.Text);
                        btn3.Text = "0";
                        if (isZero(btn4.Text))
                            return a + choinguocchieu("btn4", Convert.ToInt32(btn4.Text), false);
                        else return a;
                    }
                    else if (vitrichon == 3)
                    {
                        int a = Convert.ToInt32(btn4.Text);
                        btn4.Text = "0";
                        if (isZero(btn5.Text))
                            return a + choinguocchieu("btn5", Convert.ToInt32(btn5.Text), false);
                        else return a;
                    }
                    else if (vitrichon == 4)
                    {
                        int a = Convert.ToInt32(btn5.Text);
                        btn5.Text = "0";
                        return a;
                    }
                    else if (vitrichon == 5)
                    {
                        int a = Convert.ToInt32(btn6.Text);
                        if (conchucuanguoi1 == 0)
                        {
                            if (luachoncuamay == 0)
                            {
                                conchucuanguoi = conchucuanguoi + 9;

                            }
                            else
                            {
                                conchucuamay = conchucuamay + 9;
                            }
                            conchucuanguoi1 = 1;
                        }
                        btn6.Text = "0";
                        if (isZero(btn7.Text))
                            return a + choinguocchieu("btn7", Convert.ToInt32(btn7.Text), false);
                        else return a;
                    }
                    else if (vitrichon == 6)
                    {
                        int a = Convert.ToInt32(btn7.Text);
                        btn7.Text = "0";
                        if (isZero(btn8.Text))
                            return a + choinguocchieu("btn8", Convert.ToInt32(btn8.Text), false);
                        else return a;
                    }
                    else if (vitrichon == 7)
                    {
                        int a = Convert.ToInt32(btn8.Text);
                        btn8.Text = "0";
                        if (isZero(btn9.Text))
                            return a + choinguocchieu("btn9", Convert.ToInt32(btn9.Text), false);
                        else return a;
                    }
                    else if (vitrichon == 8)
                    {
                        int a = Convert.ToInt32(btn9.Text);
                        btn9.Text = "0";
                        if (isZero(btn10.Text))
                            return a + choinguocchieu("btn10", Convert.ToInt32(btn10.Text), false);
                        else return a;
                    }
                    else if (vitrichon == 9)
                    {
                        int a = Convert.ToInt32(btn10.Text);
                        btn10.Text = "0";
                        if (isZero(btn11.Text))
                            return a + choinguocchieu("btn11", Convert.ToInt32(btn11.Text), false);
                        else return a;
                    }
                    else if (vitrichon == 10)
                    {
                        int a = Convert.ToInt32(btn11.Text);
                        btn11.Text = "0";
                        return a;
                    }
                    else if (vitrichon == 11)
                    {
                        int a = Convert.ToInt32(btn12.Text);
                        if (conchucuamay1 == 0)
                        {
                            if (luachoncuamay == 0)
                            {
                                conchucuanguoi = conchucuanguoi + 9;

                            }
                            else
                            {
                                conchucuamay = conchucuamay + 9;
                            }
                            conchucuamay1 = 1;
                        }
                        btn12.Text = "0";
                        if (isZero(btn1.Text))
                            return a + choinguocchieu("btn1", Convert.ToInt32(btn1.Text), false);
                        else return a;
                    }
                    else if (vitrichon == 12)
                    {
                        int a = Convert.ToInt32(btn1.Text);
                        btn1.Text = "0";
                        if (isZero(btn2.Text))
                            return a + choinguocchieu("btn2", Convert.ToInt32(btn2.Text), false);
                        else return a;
                    }
                }
            }
            else
            {
                /*int[] tempOfTheSoi = null;
                if (!thelordofthetempsoi)
                {
                    thelordofthetempsoi = true;
                    tempOfTheSoi = (int[])tempSoi.Clone();
                }*/

                //create a temp that will recover later            
                if (soluongsoi > 0)
                {
                    reset();
                    int vitrichon = Convert.ToInt32(btn.Replace("btn", ""));

                    if (vitrichon == 1)
                    {
                        btn2.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn2.Text = (Convert.ToInt32(btn2.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn3.Text))
                            {
                                x = Convert.ToInt32(btn4.Text);
                                btn4.Text = "0";
                                if (isZero(btn5.Text))
                                    return x + choinguocchieu("btn5", Convert.ToInt32(btn5.Text), true);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn3.Text);
                            btn3.Text = "0";
                            return choinguocchieu("btn3", a, true);

                        }
                        else
                        {
                            return choinguocchieu("btn2", soluongsoi, true);
                        }



                    }
                    else if (vitrichon == 2)
                    {
                        btn3.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn3.Text = (Convert.ToInt32(btn3.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn4.Text))
                            {
                                x = Convert.ToInt32(btn5.Text);
                                btn5.Text = "0";
                                if (isZero(btn6.Text))
                                {
                                    return x + choinguocchieu("btn6", Convert.ToInt32(btn6.Text), true);
                                }
                                else return x;


                            }
                            int a = Convert.ToInt32(btn4.Text);
                            btn4.Text = "0";
                            return choinguocchieu("btn4", a, true);

                        }
                        else
                        {
                            return choinguocchieu("btn3", soluongsoi, true);
                        }
                    }
                    else if (vitrichon == 3)
                    {
                        btn4.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn4.Text = (Convert.ToInt32(btn4.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn5.Text))
                            {
                                x = Convert.ToInt32(btn6.Text);
                                btn6.Text = "0";

                                if (isZero(btn7.Text))
                                    return x + choinguocchieu("btn7", Convert.ToInt32(btn7.Text), true);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn5.Text);
                            btn5.Text = "0";
                            return choinguocchieu("btn5", a, true);

                        }
                        else
                        {
                            return choinguocchieu("btn4", soluongsoi, true);
                        }
                    }
                    else if (vitrichon == 4)
                    {
                        btn5.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn5.Text = (Convert.ToInt32(btn5.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn6.Text))
                            {
                                x = Convert.ToInt32(btn7.Text);
                                btn7.Text = "0";
                                if (isZero(btn8.Text))
                                    return x + choinguocchieu("btn8", Convert.ToInt32(btn8.Text), true);
                                else return x;

                            }

                        }
                        else
                        {
                            return choinguocchieu("btn5", soluongsoi, true);
                        }
                    }
                    else if (vitrichon == 5)
                    {
                        btn6.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn6.Text = (Convert.ToInt32(btn6.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn7.Text))
                            {
                                x = Convert.ToInt32(btn8.Text);
                                btn8.Text = "0";
                                if (isZero(btn9.Text))
                                    return x + choinguocchieu("btn9", Convert.ToInt32(btn9.Text), true);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn7.Text);
                            btn7.Text = "0";
                            return choinguocchieu("btn7", a, true);

                        }
                        else
                        {
                            return choinguocchieu("btn6", soluongsoi, true);
                        }

                    }
                    else if (vitrichon == 6)
                    {
                        btn7.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn7.Text = (Convert.ToInt32(btn7.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn8.Text))
                            {
                                x = Convert.ToInt32(btn9.Text);
                                btn9.Text = "0";
                                if (isZero(btn10.Text))
                                    return x + choinguocchieu("btn10", Convert.ToInt32(btn10.Text), true);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn8.Text);
                            btn8.Text = "0";
                            return choinguocchieu("btn8", a, true);

                        }
                        else
                        {
                            return choinguocchieu("btn7", soluongsoi, true);
                        }
                    }
                    else if (vitrichon == 7)
                    {
                        soluongsoi = soluongsoi - 1;
                        btn8.Text = (Convert.ToInt32(btn8.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn9.Text))
                            {
                                x = Convert.ToInt32(btn10.Text);
                                btn10.Text = "0";
                                if (isZero(btn11.Text))
                                    return x + choinguocchieu("btn11", Convert.ToInt32(btn11.Text), true);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn9.Text);
                            btn9.Text = "0";
                            return choinguocchieu("btn9", a, true);

                        }
                        else
                        {
                            return choinguocchieu("btn8", soluongsoi, true);
                        }
                    }
                    else if (vitrichon == 8)
                    {
                        btn9.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn9.Text = (Convert.ToInt32(btn9.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn10.Text))
                            {
                                x = Convert.ToInt32(btn11.Text);
                                btn11.Text = "0";
                                if (isZero(btn12.Text))
                                {
                                    return x + choinguocchieu("btn12", Convert.ToInt32(btn12.Text), true);
                                }
                                else return x;


                            }
                            int a = Convert.ToInt32(btn10.Text);
                            btn10.Text = "0";
                            return choinguocchieu("btn10", a, true);

                        }
                        else
                        {
                            return choinguocchieu("btn9", soluongsoi, true);
                        }
                    }
                    else if (vitrichon == 9)
                    {
                        btn10.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn10.Text = (Convert.ToInt32(btn10.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn11.Text))
                            {
                                x = Convert.ToInt32(btn12.Text);
                                btn12.Text = "0";
                                if (isZero(btn1.Text))
                                    return x + choinguocchieu("btn1", Convert.ToInt32(btn1.Text), true);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn11.Text);
                            btn11.Text = "0";
                            return choinguocchieu("btn11", a, true);

                        }
                        else
                        {
                            return choinguocchieu("btn10", soluongsoi, true);
                        }
                    }
                    else if (vitrichon == 10)
                    {
                        btn11.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn11.Text = (Convert.ToInt32(btn11.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn12.Text))
                            {
                                x = Convert.ToInt32(btn1.Text);
                                btn1.Text = "0";
                                if (isZero(btn2.Text))
                                    return x + choinguocchieu("btn2", Convert.ToInt32(btn2.Text), true);
                                else return x;

                            }
                        }
                        else
                        {
                            return choinguocchieu("btn11", soluongsoi, true);
                        }
                    }
                    else if (vitrichon == 11)
                    {
                        btn12.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn12.Text = (Convert.ToInt32(btn12.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn1.Text))
                            {
                                x = Convert.ToInt32(btn2.Text);
                                btn2.Text = "0";
                                if (isZero(btn3.Text))
                                    return x + choinguocchieu("btn3", Convert.ToInt32(btn3.Text), true);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn1.Text);
                            btn1.Text = "0";
                            return choinguocchieu("btn1", a, true);

                        }
                        else
                        {
                            return choinguocchieu("btn12", soluongsoi, true);
                        }
                    }
                    else if (vitrichon == 12)
                    {
                        btn1.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn1.Text = (Convert.ToInt32(btn1.Text) + 1).ToString();

                        if (soluongsoi == 0)
                        {
                            if (isZero(btn2.Text))
                            {
                                x = Convert.ToInt32(btn3.Text);
                                btn3.Text = "0";
                                if (isZero(btn4.Text))
                                    return x + choinguocchieu("btn4", Convert.ToInt32(btn4.Text), true);
                                else return x;
                            }
                            int a = Convert.ToInt32(btn2.Text);
                            btn2.Text = "0";
                            return choinguocchieu("btn2", a, true);

                        }
                        else
                        {
                            return choinguocchieu("btn1", soluongsoi, true);
                        }
                    }

                }
                else if (soluongsoi == 0)
                {

                    reset();
                    int vitrichon = Convert.ToInt32(btn.Replace("btn", ""));
                    if (vitrichon == 1)
                    {
                        int a = Convert.ToInt32(btn2.Text);
                        btn2.Text = "0";
                        if (isZero(btn3.Text))
                            return a + choinguocchieu("btn3", Convert.ToInt32(btn3.Text), true);
                        else return a;
                    }
                    else if (vitrichon == 2)
                    {
                        int a = Convert.ToInt32(btn3.Text);
                        btn3.Text = "0";
                        if (isZero(btn4.Text))
                            return a + choinguocchieu("btn4", Convert.ToInt32(btn4.Text), true);
                        else return a;
                    }
                    else if (vitrichon == 3)
                    {
                        int a = Convert.ToInt32(btn4.Text);
                        btn4.Text = "0";
                        if (isZero(btn5.Text))
                            return a + choinguocchieu("btn5", Convert.ToInt32(btn5.Text), true);
                        else return a;
                    }
                    else if (vitrichon == 4)
                    {
                        int a = Convert.ToInt32(btn5.Text);
                        btn5.Text = "0";
                        return a;
                    }
                    else if (vitrichon == 5)
                    {
                        int a = Convert.ToInt32(btn6.Text);
                        btn6.Text = "0";
                        if (isZero(btn7.Text))
                            return a + choinguocchieu("btn7", Convert.ToInt32(btn7.Text), true);
                        else return a;
                    }
                    else if (vitrichon == 6)
                    {
                        int a = Convert.ToInt32(btn7.Text);
                        btn7.Text = "0";
                        if (isZero(btn8.Text))
                            return a + choinguocchieu("btn8", Convert.ToInt32(btn8.Text), true);
                        else return a;
                    }
                    else if (vitrichon == 7)
                    {
                        int a = Convert.ToInt32(btn8.Text);
                        btn8.Text = "0";
                        if (isZero(btn9.Text))
                            return a + choinguocchieu("btn9", Convert.ToInt32(btn9.Text), true);
                        else return a;
                    }
                    else if (vitrichon == 8)
                    {
                        int a = Convert.ToInt32(btn9.Text);
                        btn9.Text = "0";
                        if (isZero(btn10.Text))
                            return a + choinguocchieu("btn10", Convert.ToInt32(btn10.Text), true);
                        else return a;
                    }
                    else if (vitrichon == 9)
                    {
                        int a = Convert.ToInt32(btn10.Text);
                        btn10.Text = "0";
                        if (isZero(btn11.Text))
                            return a + choinguocchieu("btn11", Convert.ToInt32(btn11.Text), true);
                        else return a;
                    }
                    else if (vitrichon == 10)
                    {
                        int a = Convert.ToInt32(btn11.Text);
                        btn11.Text = "0";
                        return a;
                    }
                    else if (vitrichon == 11)
                    {
                        int a = Convert.ToInt32(btn12.Text);
                        btn12.Text = "0";
                        if (isZero(btn1.Text))
                            return a + choinguocchieu("btn1", Convert.ToInt32(btn1.Text), true);
                        else return a;
                    }
                    else if (vitrichon == 12)
                    {
                        int a = Convert.ToInt32(btn1.Text);
                        btn1.Text = "0";
                        if (isZero(btn2.Text))
                            return a + choinguocchieu("btn2", Convert.ToInt32(btn2.Text), true);
                        else return a;
                    }
                }


            }


            /*if (isCalculating)
                resetToOrigin();

            thelordofthetempsoi = false;*/
            return x;
        }

        bool thelordofthetempsoi = false;
        private void resetToOrigin()
        {
            btn1.Text = tempSoi[0].ToString();
            btn2.Text = tempSoi[1].ToString();
            btn3.Text = tempSoi[2].ToString();
            btn4.Text = tempSoi[3].ToString();
            btn5.Text = tempSoi[4].ToString();
            btn6.Text = tempSoi[5].ToString();
            btn7.Text = tempSoi[6].ToString();
            btn8.Text = tempSoi[7].ToString();
            btn9.Text = tempSoi[8].ToString();
            btn10.Text = tempSoi[9].ToString();
            btn11.Text = tempSoi[10].ToString();
            btn12.Text = tempSoi[11].ToString();
        }


        private void EndGame()
        {
            string text = "";
            lbldiemmay.Text = (conchucuamay + Convert.ToInt32(lbldiemmay.Text) + Convert.ToInt32(btn7.Text) + Convert.ToInt32(btn8.Text)
                + Convert.ToInt32(btn9.Text) + Convert.ToInt32(btn10.Text) + Convert.ToInt32(btn11.Text) + Convert.ToInt32(btn12.Text)).ToString();
            lbldiemnguoichoi.Text = (conchucuanguoi + Convert.ToInt32(lbldiemnguoichoi.Text) + Convert.ToInt32(btn1.Text) + Convert.ToInt32(btn2.Text)
                + Convert.ToInt32(btn3.Text) + Convert.ToInt32(btn4.Text) + Convert.ToInt32(btn5.Text) + Convert.ToInt32(btn6.Text)).ToString();

            btn1.Text = "0"; btn2.Text = "0"; btn3.Text = "0"; btn4.Text = "0";
            btn5.Text = "0"; btn6.Text = "0"; btn7.Text = "0"; btn8.Text = "0";
            btn9.Text = "0"; btn10.Text = "0"; btn11.Text = "0"; btn12.Text = "0";
            anh1.Enabled = false;
            anh2.Enabled = false;
            anh3.Enabled = false;
            anh4.Enabled = false;
            anh5.Enabled = false;
            replaceimage();
            if (Convert.ToInt32(lbldiemmay.Text) > Convert.ToInt32(lbldiemnguoichoi.Text))
            {
                t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                text = "Bạn đã thua \n" + "máy:" + lbldiemmay.Text + " điểm" + "\nngười chơi:" + lbldiemnguoichoi.Text + " điểm";
            }
            else if (Convert.ToInt32(lbldiemmay.Text) < Convert.ToInt32(lbldiemnguoichoi.Text))
            {
                t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                text = "Bạn đã thắng \n" + "máy:" + lbldiemmay.Text + " điểm" + "\nngười chơi:" + lbldiemnguoichoi.Text + " điểm";
            }
            else if (Convert.ToInt32(lbldiemmay.Text) == Convert.ToInt32(lbldiemnguoichoi.Text))
            {
                t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                text = "Bạn đã hòa \n" + "máy:" + lbldiemmay.Text + " điểm" + "\nngười chơi:" + lbldiemnguoichoi.Text + " điểm";
            }
            if (MessageBox.Show(text + "\nBạn có muốn chơi lại không !", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                anh1.Enabled = true;
                anh2.Enabled = true;
                anh3.Enabled = true;
                anh4.Enabled = true;
                anh5.Enabled = true;
                lbldiemmay.Text = "0";
                lbldiemnguoichoi.Text = "0";
                btn1.Text = "5"; btn2.Text = "5"; btn3.Text = "5"; btn4.Text = "5";
                btn5.Text = "5"; btn6.Text = "1"; btn7.Text = "5"; btn8.Text = "5";
                btn9.Text = "5"; btn10.Text = "5"; btn11.Text = "5"; btn12.Text = "1";
            }

        }

        /*suck arse AI Algorithm by Tran Duy*/
        static int MAX = 100;
        static int MIN = -100;
        bool isNotified = false;
        private int mySuckArseAlgo(int depth, int[] scores, bool isMax, int h, int alpha, int beta)
        {
            //  point is where AI can move, whe got 5 movable points, and boii of course we start at 0
            //MessageBox.Show(point.ToString());         

            if (depth == h)
            {
                int res;
                try
                {
                    res = Array.IndexOf(scores, scores.Max()) + 1;
                }
                catch { res = 0; }
                if (!isNotified)
                {
                    isNotified = true;
                    //index of number other than 0s
                    /* MessageBox.Show("AI has selected the index of " + res + " other than 0s.", "AI result", MessageBoxButtons.OK, MessageBoxIcon.Information);
             */
                }
                //return Array.IndexOf(scores, scores.Max());
                return Array.IndexOf(scores, scores.Max());
            }

            // get the max move that gives out the best score
            if (isMax)
            {
                int best = MIN;
                /*scores[point] = AIMoveCache(point);
                if (scores[point] == 96)
                {
                    int res = point + 1;
                    if (!isNotified)
                    {
                        isNotified = true;
                        MessageBox.Show("AI has selected the index of " + res + " and will win this round.", "AI result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return point;
                }

                return Math.Max(mySuckArseAlgo(point + 1, depth + 1, scores, true, h, alpha, beta), mySuckArseAlgo(point + 1, depth, scores, false, h, alpha, beta))*/
                ;
                //return mySuckArseAlgo(point + 1, scores, true, h); //false


                for (int i = depth; i <= h; i++)
                {
                    int val = AIMoveCache(i);
                    best = Math.Max(best, val);
                    alpha = Math.Max(alpha, best);

                    // alpha beta pruning
                    if (beta <= alpha)
                    {
                        scores[i] = val;
                        break;
                    }
                }
                return mySuckArseAlgo(depth + 1, scores, false, h, alpha, beta); ;
            }


            // else motherfker < this algo is fked idk how to implement nodes in c# but atleast it runs
            else
            {
                int best = MAX;
                //scores[point] = AIMoveCache(point);
                /* if (scores[point] >= AIMoveCacheP(point))
                    scores[point] = AIMoveCacheP(point);
                if (scores[point] == 96)
                    return point;*/
                //return Math.Min(mySuckArseAlgo(point + 1, scores, true, h), mySuckArseAlgo(point + 1, scores, true, h));
                /*return Math.Min(mySuckArseAlgo(point + 1, depth, scores, false, h, alpha, beta), mySuckArseAlgo(point + 1, depth + 1, scores, true, h, alpha, beta));*/

                for (int i = depth; i <= h; i++)
                {
                    int val = AIMoveCacheP(i);
                    best = Math.Max(best, val);
                    alpha = Math.Max(alpha, best);

                    // alpha beta pruning

                    if (scores[i] == 96)
                        return i;
                    if (beta <= alpha)
                    {
                        scores[i] = val;
                        break;
                    }
                    else if (scores[i] >= AIMoveCacheP(i))
                    {
                        scores[i] = AIMoveCacheP(i);
                        break;
                    }
                }
                return mySuckArseAlgo(depth + 1, scores, true, h, alpha, beta); ;
            }
        }


        private int AIMoveCacheP(int point)
        {
            int AIPointCacheP = 0;
            if (kiemtra())
                return 0;

            if (isZero(btn7.Text))
                return 0;
            else
            {
                int s = 0;
                string btn = null;
                storeOrigin(); for (int i = 0; i <= 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            s = Convert.ToInt32(btn7.Text);
                            btn = "btn1";
                            break;
                        case 1:
                            s = Convert.ToInt32(btn8.Text);
                            btn = "btn2";
                            break;
                        case 2:
                            s = Convert.ToInt32(btn9.Text);
                            btn = "btn3";
                            break;
                        case 3:
                            s = Convert.ToInt32(btn10.Text);
                            btn = "btn4";
                            break;
                        case 4:
                            s = Convert.ToInt32(btn11.Text);
                            btn = "btn5";
                            break;
                        default:
                            break;
                    }

                    luachoncuanguoi = 0;
                    luachoncuamay = 1;

                    int tempAIp = AIMoveCache(point);

                    luachoncuanguoi = 1;
                    luachoncuamay = 0;

                    AIPointCacheP = (choinguocchieu(btn, s, true));
                    resetToOrigin();

                    luachoncuanguoi = 0;
                    luachoncuamay = 1;

                    if (AIPointCacheP <= tempAIp)
                        return i;
                }
                return 0;
            }
        }

        private int AIMoveCache(int point)
        {
            int AIPointCache = 0;
            if (kiemtra())
                return 96;

            if (isZero(btn7.Text))
                return 0;
            else
            {
                int s = 0;
                string btn = null;
                switch (point)
                {
                    case 0:
                        s = Convert.ToInt32(btn7.Text);
                        btn = "btn7";
                        break;
                    case 1:
                        s = Convert.ToInt32(btn8.Text);
                        btn = "btn8";
                        break;
                    case 2:
                        s = Convert.ToInt32(btn9.Text);
                        btn = "btn9";
                        break;
                    case 3:
                        s = Convert.ToInt32(btn10.Text);
                        btn = "btn10";
                        break;
                    case 4:
                        s = Convert.ToInt32(btn11.Text);
                        btn = "btn11";
                        break;
                    default:
                        break;
                }

                storeOrigin();
                AIPointCache = (choinguocchieu(btn, s, true));
                resetToOrigin();
                return AIPointCache;
            }
        }

        private void storeOrigin()
        {
            var trashedList = new List<int>();
            //this will be restored to the origin after calculating
            trashedList.Add(Convert.ToInt32(btn1.Text));
            trashedList.Add(Convert.ToInt32(btn2.Text));
            trashedList.Add(Convert.ToInt32(btn3.Text));
            trashedList.Add(Convert.ToInt32(btn4.Text));
            trashedList.Add(Convert.ToInt32(btn5.Text));
            trashedList.Add(Convert.ToInt32(btn6.Text));
            trashedList.Add(Convert.ToInt32(btn7.Text));
            trashedList.Add(Convert.ToInt32(btn8.Text));
            trashedList.Add(Convert.ToInt32(btn9.Text));
            trashedList.Add(Convert.ToInt32(btn10.Text));
            trashedList.Add(Convert.ToInt32(btn11.Text));
            trashedList.Add(Convert.ToInt32(btn12.Text));
            tempSoi = trashedList.ToArray();
        }
        /*End of AI*/





        private void randommay()
        {
            if (kiemtra())
                EndGame();
            else
            {


                luachoncuanguoi = 0;
                luachoncuamay = 1;
                Random r = new Random();
                List<string> a = new List<string>();
                List<string> b = new List<string>();
                if (Convert.ToInt32(btn7.Text) > 0)
                {
                    a.Add(btn7.Text);
                    b.Add("btn7");
                }
                if (Convert.ToInt32(btn8.Text) > 0)
                {
                    a.Add(btn8.Text);
                    b.Add("btn8");
                }
                if (Convert.ToInt32(btn9.Text) > 0)
                {
                    a.Add(btn9.Text);
                    b.Add("btn9");
                }
                if (Convert.ToInt32(btn10.Text) > 0)
                {
                    a.Add(btn10.Text);
                    b.Add("btn10");
                }
                if (Convert.ToInt32(btn11.Text) > 0)
                {
                    a.Add(btn11.Text);
                    b.Add("btn11");
                }
                //int i = r.Next(0, a.Count-1);
                int[] scoreste = new int[a.Count];
                int i = mySuckArseAlgo(0, scoreste, true, a.Count - 1, MIN, MAX);
                isNotified = false;
                int btnnum = Convert.ToInt32(b[i].Replace("btn", String.Empty)) - 6;
                MessageBox.Show("Máy chọn ô thứ " + btnnum + ".");

                if (b[i] == "btn7")
                {
                    int s = Convert.ToInt32(btn7.Text);
                    btn7.Text = "0";
                    lbldiemmay.Text = (choinguocchieu("btn7", s, false) + Convert.ToInt32(lbldiemmay.Text)).ToString();
                }
                else if (b[i] == "btn8")
                {
                    int s = Convert.ToInt32(btn8.Text);
                    btn8.Text = "0";
                    lbldiemmay.Text = (choinguocchieu("btn8", s, false) + Convert.ToInt32(lbldiemmay.Text)).ToString();
                }
                else if (b[i] == "btn9")
                {
                    int s = Convert.ToInt32(btn9.Text);
                    btn9.Text = "0";
                    lbldiemmay.Text = (choinguocchieu("btn9", s, false) + Convert.ToInt32(lbldiemmay.Text)).ToString();
                }
                else if (b[i] == "btn10")
                {
                    int s = Convert.ToInt32(btn10.Text);
                    btn10.Text = "0";
                    lbldiemmay.Text = (choinguocchieu("btn10", s, false) + Convert.ToInt32(lbldiemmay.Text)).ToString();
                }
                else if (b[i] == "btn11")
                {
                    int s = Convert.ToInt32(btn11.Text);
                    btn11.Text = "0";
                    lbldiemmay.Text = (choinguocchieu("btn11", s, false) + Convert.ToInt32(lbldiemmay.Text)).ToString();
                }
            }
        }





        private void replaceimage()
        {
            Bitmap[] anhoquan = new Bitmap[32];
            anhoquan[0] = global::GameOAnQuan.Properties.Resources.anh0;
            anhoquan[1] = global::GameOAnQuan.Properties.Resources.anh1;
            anhoquan[2] = global::GameOAnQuan.Properties.Resources.anh2;
            anhoquan[3] = global::GameOAnQuan.Properties.Resources.anh3;
            anhoquan[4] = global::GameOAnQuan.Properties.Resources.anh4;
            anhoquan[5] = global::GameOAnQuan.Properties.Resources.anh5;
            anhoquan[6] = global::GameOAnQuan.Properties.Resources.anh6;
            anhoquan[7] = global::GameOAnQuan.Properties.Resources.anh7;
            anhoquan[8] = global::GameOAnQuan.Properties.Resources.anh8;
            anhoquan[9] = global::GameOAnQuan.Properties.Resources.anh9;
            anhoquan[10] = global::GameOAnQuan.Properties.Resources.anh10;
            anhoquan[11] = global::GameOAnQuan.Properties.Resources.anh11;
            anhoquan[12] = global::GameOAnQuan.Properties.Resources.anh12;
            anhoquan[13] = global::GameOAnQuan.Properties.Resources.anh13;
            anhoquan[14] = anhoquan[15] = anhoquan[16] = anhoquan[17] =
                anhoquan[18] = anhoquan[19] = anhoquan[20] = anhoquan[21] =
                anhoquan[22] = anhoquan[23] = anhoquan[24] = anhoquan[25] =
                anhoquan[26] = anhoquan[27] = anhoquan[28] = anhoquan[29] =
                anhoquan[30] = anhoquan[31] = global::GameOAnQuan.Properties.Resources.anh14;

            Bitmap[] anhoquanchu = new Bitmap[30];
            anhoquanchu[0] = global::GameOAnQuan.Properties.Resources.anhchu0;
            anhoquanchu[1] = global::GameOAnQuan.Properties.Resources.anhchu1;
            anhoquanchu[2] = global::GameOAnQuan.Properties.Resources.anhchu2;
            anhoquanchu[3] = global::GameOAnQuan.Properties.Resources.anhchu3;
            anhoquanchu[4] = global::GameOAnQuan.Properties.Resources.anhchu4;
            anhoquanchu[5] = global::GameOAnQuan.Properties.Resources.anhchu5;
            anhoquanchu[6] = global::GameOAnQuan.Properties.Resources.anhchu6;
            anhoquanchu[7] = global::GameOAnQuan.Properties.Resources.anhchu7;
            anhoquanchu[8] = global::GameOAnQuan.Properties.Resources.anhchu8;
            anhoquanchu[9] = global::GameOAnQuan.Properties.Resources.anhchu9;


            Bitmap[] anhoquanchu1 = new Bitmap[30];
            anhoquanchu1[0] = global::GameOAnQuan.Properties.Resources.anhchu0;
            anhoquanchu1[1] = global::GameOAnQuan.Properties.Resources.anhchu1_1;
            anhoquanchu1[2] = global::GameOAnQuan.Properties.Resources.anhchu1_2;
            anhoquanchu1[3] = global::GameOAnQuan.Properties.Resources.anhchu1_3;
            anhoquanchu1[4] = global::GameOAnQuan.Properties.Resources.anhchu1_4;
            anhoquanchu1[5] = global::GameOAnQuan.Properties.Resources.anhchu1_5;
            anhoquanchu1[6] = global::GameOAnQuan.Properties.Resources.anhchu1_6;
            anhoquanchu1[7] = global::GameOAnQuan.Properties.Resources.anhchu1_7;
            anhoquanchu1[8] = global::GameOAnQuan.Properties.Resources.anhchu1_8;
            anhoquanchu1[9] = global::GameOAnQuan.Properties.Resources.anhchu1_9;
            anhoquanchu1[10] = global::GameOAnQuan.Properties.Resources.anhchu1_10;

            Bitmap[] anhoquanchu2 = new Bitmap[30];
            anhoquanchu2[0] = global::GameOAnQuan.Properties.Resources.anhchu0;
            anhoquanchu2[1] = global::GameOAnQuan.Properties.Resources.anhchu2_1;
            anhoquanchu2[2] = global::GameOAnQuan.Properties.Resources.anhchu2_2;
            anhoquanchu2[3] = global::GameOAnQuan.Properties.Resources.anhchu2_3;
            anhoquanchu2[4] = global::GameOAnQuan.Properties.Resources.anhchu2_4;
            anhoquanchu2[5] = global::GameOAnQuan.Properties.Resources.anhchu2_5;
            anhoquanchu2[6] = global::GameOAnQuan.Properties.Resources.anhchu2_6;
            anhoquanchu2[7] = global::GameOAnQuan.Properties.Resources.anhchu2_7;
            anhoquanchu2[8] = global::GameOAnQuan.Properties.Resources.anhchu2_8;
            anhoquanchu2[9] = global::GameOAnQuan.Properties.Resources.anhchu2_9;
            anhoquanchu2[10] = global::GameOAnQuan.Properties.Resources.anhchuu2_10;
            this.anh1.Image = anhoquan[Convert.ToInt32(btn1.Text)];
            this.anh2.Image = anhoquan[Convert.ToInt32(btn2.Text)];
            this.anh3.Image = anhoquan[Convert.ToInt32(btn3.Text)];
            this.anh4.Image = anhoquan[Convert.ToInt32(btn4.Text)];
            this.anh5.Image = anhoquan[Convert.ToInt32(btn5.Text)];
            if (conchucuanguoi1 == 0)
            {
                if (Convert.ToInt32(btn6.Text) < 10) this.anh6.Image = anhoquanchu1[Convert.ToInt32(btn6.Text)];
                else if (Convert.ToInt32(btn6.Text) > 10) this.anh6.Image = anhoquanchu1[10];
            }
            else
            {
                if (Convert.ToInt32(btn6.Text) <= 9) this.anh6.Image = anhoquanchu[Convert.ToInt32(btn6.Text)];
                else if (Convert.ToInt32(btn6.Text) > 9) this.anh6.Image = anhoquanchu[10];
            }
            this.anh7.Image = anhoquan[Convert.ToInt32(btn7.Text)];
            this.anh8.Image = anhoquan[Convert.ToInt32(btn8.Text)];
            this.anh9.Image = anhoquan[Convert.ToInt32(btn9.Text)];
            this.anh10.Image = anhoquan[Convert.ToInt32(btn10.Text)];
            this.anh11.Image = anhoquan[Convert.ToInt32(btn11.Text)];
            if (conchucuamay1 == 0)
            {
                if (Convert.ToInt32(btn12.Text) <= 10) this.anh12.Image = anhoquanchu2[Convert.ToInt32(btn12.Text)];
                else if (Convert.ToInt32(btn12.Text) > 10) this.anh12.Image = anhoquanchu2[10];
            }
            else
            {
                if (Convert.ToInt32(btn12.Text) <= 9) this.anh12.Image = anhoquanchu[Convert.ToInt32(btn12.Text)];
                else if (Convert.ToInt32(btn12.Text) > 9) this.anh12.Image = anhoquanchu[10];
            }

            if (Convert.ToInt32(lbldiemmay.Text) <= 30)
            {
                anhsoluongsoicuamay.Image = anhoquan[Convert.ToInt32(lbldiemmay.Text)];
            }
            else
            {
                anhsoluongsoicuamay.Image = anhoquan[30];
            }

            if (Convert.ToInt32(lbldiemnguoichoi.Text) <= 30)
            {
                anhsoluongsoicuanguoi.Image = anhoquan[Convert.ToInt32(lbldiemnguoichoi.Text)];
            }
            else
            {
                anhsoluongsoicuanguoi.Image = anhoquan[30];
            }
        }




        private void btnchoilai_Click(object sender, EventArgs e)
        {
            anh1.Enabled = true;
            anh2.Enabled = true;
            anh3.Enabled = true;
            anh4.Enabled = true;
            anh5.Enabled = true;
            lbldiemmay.Text = "0";
            lbldiemnguoichoi.Text = "0";
            btn1.Text = "5"; btn2.Text = "5"; btn3.Text = "5"; btn4.Text = "5";
            btn5.Text = "5"; btn6.Text = "1"; btn7.Text = "5"; btn8.Text = "5";
            btn9.Text = "5"; btn10.Text = "5"; btn11.Text = "5"; btn12.Text = "1";
            diemmay = 0;
            diemnguoi = 0;
            conchucuamay = 0;
            luachoncuamay = 0;
            conchucuanguoi = 0;
            luachoncuanguoi = 0;
            conchucuamay1 = 0;
            conchucuanguoi1 = 0;
            replaceimage();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {

            t1.Text = "0";
            t2.Text = "0";
        }



        private void anh1_Click_1(object sender, EventArgs e)
        {
            if (kiemtra())
                EndGame();
            else
            {
                if (isZero(btn1.Text))
                {
                    MessageBox.Show("vui long chon lai");
                }
                else if (Convert.ToInt32(btn1.Text) != 0)
                {
                    int s = Convert.ToInt32(btn1.Text);
                    btn1.Text = "0";
                    luachoncuanguoi = 1;
                    luachoncuamay = 0;
                    nguoichoi.Text = "Lược chơi của người";
                    lbldiemnguoichoi.Text = (choinguocchieu("btn1", s, false) + Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                    replaceimage();
                    wait(1000);
                    nguoichoi.Text = "Lược chơi của máy";
                    randommay();
                    replaceimage();
                    nguoichoi.Text = "Lược chơi của người";
                }
            }
        }

        private void anh2_Click_1(object sender, EventArgs e)
        {
            if (kiemtra())
                EndGame();
            else
            {
                if (isZero(btn2.Text))
                {
                    MessageBox.Show("vui long chon lai");
                }
                else if (Convert.ToInt32(btn2.Text) != 0)
                {
                    int s = Convert.ToInt32(btn2.Text);
                    btn2.Text = "0";

                    luachoncuanguoi = 1;
                    luachoncuamay = 0;
                    nguoichoi.Text = "Lược chơi của người";
                    lbldiemnguoichoi.Text = (choinguocchieu("btn2", s, false) + Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                    replaceimage();
                    wait(1000);
                    nguoichoi.Text = "Lược chơi của máy";
                    randommay();
                    replaceimage();
                    nguoichoi.Text = "Lược chơi của người";
                }
            }
        }
        private void anh3_Click_1(object sender, EventArgs e)
        {
            if (kiemtra())
                EndGame();
            else
            {
                if (isZero(btn3.Text))
                {
                    MessageBox.Show("vui long chon lai");
                }
                else if (Convert.ToInt32(btn3.Text) != 0)
                {
                    int s = Convert.ToInt32(btn3.Text);
                    btn3.Text = "0";

                    luachoncuanguoi = 1;
                    luachoncuamay = 0;
                    nguoichoi.Text = "Lược chơi của người";
                    lbldiemnguoichoi.Text = (choinguocchieu("btn3", s, false) + Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                    replaceimage();
                    wait(1000);
                    nguoichoi.Text = "Lược chơi của máy";
                    randommay();
                    replaceimage();
                    nguoichoi.Text = "Lược chơi của người";
                }
            }
        }

        private void anh4_Click_1(object sender, EventArgs e)
        {
            if (kiemtra())
                EndGame();
            else
            {
                if (isZero(btn4.Text))
                {
                    MessageBox.Show("vui long chon lai");
                }
                else if (Convert.ToInt32(btn4.Text) != 0)
                {
                    int s = Convert.ToInt32(btn4.Text);
                    btn4.Text = "0";

                    luachoncuanguoi = 1;
                    luachoncuamay = 0;
                    nguoichoi.Text = "Lược chơi của người";
                    lbldiemnguoichoi.Text = (choinguocchieu("btn4", s, false) + Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                    replaceimage();
                    wait(1000);
                    nguoichoi.Text = "Lược chơi của máy";
                    randommay();
                    replaceimage();
                    nguoichoi.Text = "Lược chơi của người";
                }
            }
        }
        private void anh5_Click_1(object sender, EventArgs e)
        {
            if (kiemtra())
                EndGame();
            else
            {

                if (isZero(btn5.Text))
                {
                    MessageBox.Show("vui long chon lai");
                }
                else if (Convert.ToInt32(btn5.Text) != 0)
                {
                    int s = Convert.ToInt32(btn5.Text);
                    btn5.Text = "0";

                    luachoncuanguoi = 1;
                    luachoncuamay = 0;
                    nguoichoi.Text = "Lược chơi của người";
                    lbldiemnguoichoi.Text = (choinguocchieu("btn5", s, false) + Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                    replaceimage();
                    wait(1000);
                    nguoichoi.Text = "Lược chơi của máy";
                    randommay();
                    replaceimage();
                    nguoichoi.Text = "Lược chơi của người";
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
