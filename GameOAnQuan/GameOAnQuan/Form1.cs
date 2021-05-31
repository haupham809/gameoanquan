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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int diemmay = 0;
        public static int diemnguoi = 0;
        public static int conchucuamay = 0;
        public static int luachoncuamay = 0;
        public static int conchucuanguoi = 0;
        public static int luachoncuanguoi = 0;
        private void reset()
        {
            btn1.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn4.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
            btn6.BackColor = Color.Red;
            btn7.BackColor = Color.Red;
            btn8.BackColor = Color.Red;
            btn9.BackColor = Color.Red;
            btn10.BackColor = Color.Red;
            btn11.BackColor = Color.Red;
            btn12.BackColor = Color.Red;
        }
        private bool kiemtra()
        {
            if (Convert.ToInt32(btn1.Text) == 0 && Convert.ToInt32(btn2.Text) == 0 && Convert.ToInt32(btn3.Text) == 0
                && Convert.ToInt32(btn4.Text) == 0 && Convert.ToInt32(btn5.Text) == 0)
                return true;
            else if (Convert.ToInt32(btn7.Text) == 0 && Convert.ToInt32(btn8.Text) == 0 && Convert.ToInt32(btn9.Text) == 0
                && Convert.ToInt32(btn10.Text) == 0 && Convert.ToInt32(btn11.Text) == 0)
                return true;
            return false;
        }
        private int choinguocchieu(string btn, int soluongsoi)
        {
            if (luachoncuanguoi == 1)
            {
MessageBox.Show("Người\n"+" so luong "+soluongsoi);
            }
            else if (luachoncuamay == 1)
            {
                MessageBox.Show("máy\n" + " so luong " + soluongsoi);
            }


            int x = 0;
            if (!kiemtra())
            { if (soluongsoi > 0) {
                    reset();
                    int vitrichon = Convert.ToInt32(btn.Replace("btn", ""));


                    if (vitrichon == 1)
                    {
                        btn2.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn2.Text = (Convert.ToInt32(btn2.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn3.Text) == 0)
                            {
                                x = Convert.ToInt32(btn4.Text);
                                btn4.Text = "0";
                                if (Convert.ToInt32(btn5.Text) == 0)
                                    return x + choinguocchieu("btn5", Convert.ToInt32(btn5.Text));
                                else return x;
                            }
                            int a = Convert.ToInt32(btn3.Text);
                            btn3.Text = "0";
                            return choinguocchieu("btn3", a);

                        }
                        else
                        {
                            return choinguocchieu("btn2", soluongsoi);
                        }



                    }
                    else if (vitrichon == 2)
                    {
                        btn3.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn3.Text = (Convert.ToInt32(btn3.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn4.Text) == 0)
                            {
                                x = Convert.ToInt32(btn5.Text);
                                btn5.Text = "0";
                                if (Convert.ToInt32(btn6.Text) == 0)
                                {
                                    return x + choinguocchieu("btn6", Convert.ToInt32(btn6.Text));
                                }
                                else return x;


                            }
                            int a = Convert.ToInt32(btn4.Text);
                            btn4.Text = "0";
                            return choinguocchieu("btn4", a);

                        }
                        else
                        {
                            return choinguocchieu("btn3", soluongsoi);
                        }
                    }
                    else if (vitrichon == 3)
                    {
                        btn4.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn4.Text = (Convert.ToInt32(btn4.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn5.Text) == 0)
                            {
                                if (conchucuanguoi == 0)
                                {
                                    if (luachoncuanguoi == 1)
                                    {
                                        conchucuanguoi = 9;
                                    }
                                }
                                if (conchucuamay == 0)
                                {
                                    if (luachoncuamay == 1)
                                    {
                                        conchucuamay = 9;
                                    }
                                }

                                x = Convert.ToInt32(btn6.Text);
                                btn6.Text = "0";
                                
                                if (Convert.ToInt32(btn7.Text) == 0)
                                    return x + choinguocchieu("btn7", Convert.ToInt32(btn7.Text));
                                else return x;
                            }
                            int a = Convert.ToInt32(btn5.Text);
                            btn5.Text = "0";
                            return choinguocchieu("btn5", a);

                        }
                        else
                        {
                            return choinguocchieu("btn4", soluongsoi);
                        }
                    }
                    else if (vitrichon == 4)
                    {
                        btn5.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn5.Text = (Convert.ToInt32(btn5.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn6.Text) == 0)
                            {
                                x = Convert.ToInt32(btn7.Text);
                                btn7.Text = "0";
                                if (Convert.ToInt32(btn8.Text) == 0)
                                    return x + choinguocchieu("btn8", Convert.ToInt32(btn8.Text));
                                else return x;

                            }

                        } else
                        {
                            return choinguocchieu("btn5", soluongsoi);
                        }
                    }
                    else if (vitrichon == 5)
                    {
                        btn6.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn6.Text = (Convert.ToInt32(btn6.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn7.Text) == 0)
                            {
                                x = Convert.ToInt32(btn8.Text);
                                btn8.Text = "0";
                                if (Convert.ToInt32(btn9.Text) == 0)
                                    return x + choinguocchieu("btn9", Convert.ToInt32(btn9.Text));
                                else return x;
                            }
                            int a = Convert.ToInt32(btn7.Text);
                            btn7.Text = "0";
                            return choinguocchieu("btn7", a);

                        }
                        else
                        {
                            return choinguocchieu("btn6", soluongsoi);
                        }

                    }
                    else if (vitrichon == 6)
                    {
                        btn7.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn7.Text = (Convert.ToInt32(btn7.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn8.Text) == 0)
                            {
                                x = Convert.ToInt32(btn9.Text);
                                btn9.Text = "0";
                                if (Convert.ToInt32(btn10.Text) == 0)
                                    return x + choinguocchieu("btn10", Convert.ToInt32(btn10.Text));
                                else return x;
                            }
                            int a = Convert.ToInt32(btn8.Text);
                            btn8.Text = "0";
                            return choinguocchieu("btn8", a);

                        }
                        else
                        {
                            return choinguocchieu("btn7", soluongsoi);
                        }
                    }
                    else if (vitrichon == 7)
                    {
                        btn8.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn8.Text = (Convert.ToInt32(btn8.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn9.Text) == 0)
                            {
                                x = Convert.ToInt32(btn10.Text);
                                btn10.Text = "0";
                                if (Convert.ToInt32(btn11.Text) == 0)
                                    return x + choinguocchieu("btn11", Convert.ToInt32(btn11.Text));
                                else return x;
                            }
                            int a = Convert.ToInt32(btn9.Text);
                            btn9.Text = "0";
                            return choinguocchieu("btn9", a);

                        }
                        else
                        {
                            return choinguocchieu("btn8", soluongsoi);
                        }
                    }
                    else if (vitrichon == 8)
                    {
                        btn9.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn9.Text = (Convert.ToInt32(btn9.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn10.Text) == 0)
                            {
                                x = Convert.ToInt32(btn11.Text);
                                btn11.Text = "0";
                                if (Convert.ToInt32(btn12.Text) == 0)
                                {
                                    return x + choinguocchieu("btn12", Convert.ToInt32(btn12.Text));
                                }
                                else return x;


                            }
                            int a = Convert.ToInt32(btn10.Text);
                            btn10.Text = "0";
                            return choinguocchieu("btn10", a);

                        }
                        else
                        {
                            return choinguocchieu("btn9", soluongsoi);
                        }
                    }
                    else if (vitrichon == 9)
                    {
                        btn10.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn10.Text = (Convert.ToInt32(btn10.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn11.Text) == 0)
                            {
                                if (conchucuanguoi == 0)
                                {
                                    if (luachoncuanguoi == 1)
                                    {
                                        conchucuanguoi = 9;
                                    }
                                }
                                if (conchucuamay == 0)
                                {
                                    if (luachoncuamay == 1)
                                    {
                                        conchucuamay = 9;
                                    }
                                }
                                x = Convert.ToInt32(btn12.Text);
                                btn12.Text = "0";
                                if (Convert.ToInt32(btn1.Text) == 0)
                                    return x + choinguocchieu("btn1", Convert.ToInt32(btn1.Text));
                                else return x;
                            }
                            int a = Convert.ToInt32(btn11.Text);
                            btn11.Text = "0";
                            return choinguocchieu("btn11", a);

                        }
                        else
                        {
                            return choinguocchieu("btn10", soluongsoi);
                        }
                    }
                    else if (vitrichon == 10)
                    {
                        btn11.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn11.Text = (Convert.ToInt32(btn11.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn12.Text) == 0)
                            {
                                x = Convert.ToInt32(btn1.Text);
                                btn1.Text = "0";
                                if (Convert.ToInt32(btn2.Text) == 0)
                                    return x + choinguocchieu("btn2", Convert.ToInt32(btn2.Text));
                                else return x;

                            }
                        }
                        else
                        {
                            return choinguocchieu("btn11", soluongsoi);
                        }
                    }
                    else if (vitrichon == 11)
                    {
                        btn12.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn12.Text = (Convert.ToInt32(btn12.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn1.Text) == 0)
                            {
                                x = Convert.ToInt32(btn2.Text);
                                btn2.Text = "0";
                                if (Convert.ToInt32(btn3.Text) == 0)
                                    return x + choinguocchieu("btn3", Convert.ToInt32(btn3.Text));
                                else return x;
                            }
                            int a = Convert.ToInt32(btn1.Text);
                            btn1.Text = "0";
                            return choinguocchieu("btn1", a);

                        }
                        else
                        {
                            return choinguocchieu("btn12", soluongsoi);
                        }
                    }
                    else if (vitrichon == 12)
                    {
                        btn1.BackColor = Color.White;
                        soluongsoi = soluongsoi - 1;
                        btn1.Text = (Convert.ToInt32(btn1.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn2.Text) == 0)
                            {
                                x = Convert.ToInt32(btn3.Text);
                                btn3.Text = "0";
                                if (Convert.ToInt32(btn4.Text) == 0)
                                    return x + choinguocchieu("btn4", Convert.ToInt32(btn4.Text));
                                else return x;
                            }
                            int a = Convert.ToInt32(btn2.Text);
                            btn2.Text = "0";
                            return choinguocchieu("btn2", a);

                        }
                        else
                        {
                            return choinguocchieu("btn1", soluongsoi);
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
                        if (Convert.ToInt32(btn3.Text) == 0)
                            return a + choinguocchieu("btn3", Convert.ToInt32(btn3.Text));
                        else return a;
                    }
                    else if (vitrichon == 2)
                    {
                        int a = Convert.ToInt32(btn3.Text);
                        btn3.Text = "0";
                        if (Convert.ToInt32(btn4.Text) == 0)
                            return a + choinguocchieu("btn4", Convert.ToInt32(btn4.Text));
                        else return a;
                    }
                    else if (vitrichon == 3)
                    {
                        int a = Convert.ToInt32(btn4.Text);
                        btn4.Text = "0";
                        if (Convert.ToInt32(btn5.Text) == 0)
                            return a + choinguocchieu("btn5", Convert.ToInt32(btn5.Text));
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
                        if (Convert.ToInt32(btn7.Text) == 0)
                            return a + choinguocchieu("btn7", Convert.ToInt32(btn7.Text));
                        else return a;
                    }
                    else if (vitrichon == 6)
                    {
                        int a = Convert.ToInt32(btn7.Text);
                        btn7.Text = "0";
                        if (Convert.ToInt32(btn8.Text) == 0)
                            return a + choinguocchieu("btn8", Convert.ToInt32(btn8.Text));
                        else return a;
                    }
                    else if (vitrichon == 7)
                    {
                        int a = Convert.ToInt32(btn8.Text);
                        btn8.Text = "0";
                        if (Convert.ToInt32(btn9.Text) == 0)
                            return a + choinguocchieu("btn9", Convert.ToInt32(btn9.Text));
                        else return a;
                    }
                    else if (vitrichon == 8)
                    {
                        int a = Convert.ToInt32(btn9.Text);
                        btn9.Text = "0";
                        if (Convert.ToInt32(btn10.Text) == 0)
                            return a + choinguocchieu("btn10", Convert.ToInt32(btn10.Text));
                        else return a;
                    }
                    else if (vitrichon == 9)
                    {
                        int a = Convert.ToInt32(btn10.Text);
                        btn10.Text = "0";
                        if (Convert.ToInt32(btn11.Text) == 0)
                            return a + choinguocchieu("btn11", Convert.ToInt32(btn11.Text));
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
                        if (Convert.ToInt32(btn1.Text) == 0)
                            return a + choinguocchieu("btn1", Convert.ToInt32(btn1.Text));
                        else return a;
                    }
                    else if (vitrichon == 12)
                    {
                        int a = Convert.ToInt32(btn1.Text);
                        btn1.Text = "0";
                        if (Convert.ToInt32(btn2.Text) == 0)
                            return a + choinguocchieu("btn2", Convert.ToInt32(btn2.Text));
                        else return a;
                    }
                }

            }
            else if (kiemtra())
            {
                string text = "";
                int a = 0;int  b = 0;
                if(conchucuamay==0)
                {
                    a = 9;
                }
                if (conchucuanguoi == 0)
                {
                    b = 9;
                }
                lbldiemmay.Text = (a+Convert.ToInt32(lbldiemmay.Text) + Convert.ToInt32(btn7.Text) + Convert.ToInt32(btn8.Text)
                    + Convert.ToInt32(btn9.Text) + Convert.ToInt32(btn10.Text) + Convert.ToInt32(btn11.Text) + Convert.ToInt32(btn12.Text)).ToString();
                lbldiemnguoichoi.Text = (b=Convert.ToInt32(lbldiemnguoichoi.Text) + Convert.ToInt32(btn1.Text) + Convert.ToInt32(btn2.Text)
                    + Convert.ToInt32(btn3.Text) + Convert.ToInt32(btn4.Text) + Convert.ToInt32(btn5.Text) + Convert.ToInt32(btn6.Text)).ToString();
                if (Convert.ToInt32(lbldiemmay.Text) > Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    text = " Bạn đã thua /n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemmay.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) < Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã thắng \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã hòa \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                if (MessageBox.Show(text+"\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    lbldiemmay.Text = "";
                    lbldiemnguoichoi.Text = "";
                    btn1.Text = "5"; btn2.Text = "5"; btn3.Text = "5"; btn4.Text = "5";
                    btn5.Text = "5"; btn6.Text = "1"; btn7.Text = "5"; btn8.Text = "5";
                    btn9.Text = "5"; btn10.Text = "5"; btn11.Text = "5"; btn12.Text = "1";
                }
                else if(MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    btn1.Text = ""; btn2.Text = ""; btn3.Text = ""; btn4.Text = "";
                    btn5.Text = ""; btn6.Text = ""; btn7.Text = ""; btn8.Text = "";
                    btn9.Text = ""; btn10.Text = ""; btn11.Text = ""; btn12.Text = "";

                }
                
            }
            return x;

            }
       
        private void btn1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btn1.Text) == 0)
            {
                MessageBox.Show("vui long chon lai");
            }
            else if (Convert.ToInt32(btn1.Text) != 0)
            {
                int s = Convert.ToInt32(btn1.Text);
                btn1.Text = "0";
                luachoncuanguoi = 1;
                luachoncuamay = 0;
                lbldiemnguoichoi.Text=(choinguocchieu("btn1", s)+ Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                randommay();
            }

        }
        private void randommay()
        {

            luachoncuanguoi = 0;
            luachoncuamay = 1;
            Random r = new Random();
            int i = r.Next(7, 11);
            while (true)
            {
                if (i == 7)
                {
                    int s = Convert.ToInt32(btn7.Text);
                    if (s == 0) i = r.Next(7, 11);
                    else break;
                }
                else if (i == 8)
                {
                    int s = Convert.ToInt32(btn8.Text);
                    if (s == 0) i = r.Next(7, 11);
                    else break;
                }
                else if (i == 9)
                {
                    int s = Convert.ToInt32(btn9.Text);
                    if (s == 0) i = r.Next(7, 11);
                    else break;
                }
                else if (i == 10)
                {
                    int s = Convert.ToInt32(btn10.Text);
                    if (s == 0) i = r.Next(7, 11);
                    else break;
                }
                else if (i == 11)
                {
                    int s = Convert.ToInt32(btn11.Text);
                    if (s == 0) i = r.Next(7, 11);
                    else break;
                }
            }

            if (i == 7)
            {
                int s = Convert.ToInt32(btn7.Text);
                btn7.Text = "0";
                lbldiemmay.Text = (choinguocchieu("btn7", s) + Convert.ToInt32(lbldiemmay.Text)).ToString();
            }
            else if (i == 8)
            {
                int s = Convert.ToInt32(btn8.Text);
                btn8.Text = "0";
                lbldiemmay.Text = (choinguocchieu("btn8", s) + Convert.ToInt32(lbldiemmay.Text)).ToString();
            }
            else if (i == 9)
            {
                int s = Convert.ToInt32(btn9.Text);
                btn9.Text = "0";
                lbldiemmay.Text = (choinguocchieu("btn9", s) + Convert.ToInt32(lbldiemmay.Text)).ToString();
            }
            else if (i == 10)
            {
                int s = Convert.ToInt32(btn10.Text);
                btn10.Text = "0";
                lbldiemmay.Text = (choinguocchieu("btn10", s) + Convert.ToInt32(lbldiemmay.Text)).ToString();
            }
            else if (i == 11)
            {
                int s = Convert.ToInt32(btn11.Text);
                btn11.Text = "0";
                lbldiemmay.Text = (choinguocchieu("btn11", s) + Convert.ToInt32(lbldiemmay.Text)).ToString();
            }

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btn2.Text) == 0)
            {
                MessageBox.Show("vui long chon lai");
            }
            else if (Convert.ToInt32(btn2.Text) != 0)
            {
                int s = Convert.ToInt32(btn2.Text);
                btn2.Text = "0";

                luachoncuanguoi = 1;
                luachoncuamay = 0;
                lbldiemnguoichoi.Text = (choinguocchieu("btn2", s) + Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                randommay();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btn3.Text) == 0)
            {
                MessageBox.Show("vui long chon lai");
            }
            else if (Convert.ToInt32(btn3.Text) != 0)
            {
                int s = Convert.ToInt32(btn3.Text);
                btn3.Text = "0";

                luachoncuanguoi = 1;
                luachoncuamay = 0;
                lbldiemnguoichoi.Text = (choinguocchieu("btn3", s) + Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                randommay();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btn4.Text) == 0)
            {
                MessageBox.Show("vui long chon lai");
            }
            else if (Convert.ToInt32(btn4.Text) != 0)
            {
                int s = Convert.ToInt32(btn4.Text);
                btn4.Text = "0";

                luachoncuanguoi = 1;
                luachoncuamay = 0;
                lbldiemnguoichoi.Text = (choinguocchieu("btn4", s) + Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                randommay();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btn5.Text) == 0)
            {
                MessageBox.Show("vui long chon lai");
            }
            else if (Convert.ToInt32(btn5.Text) != 0)
            {
                int s = Convert.ToInt32(btn5.Text);
                btn5.Text = "0";

                luachoncuanguoi = 1;
                luachoncuamay = 0;
                lbldiemnguoichoi.Text = (choinguocchieu("btn5", s) + Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                randommay();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Text = "5"; btn2.Text = "5"; btn3.Text = "5"; btn4.Text = "5";
            btn5.Text = "5"; btn6.Text = "1"; btn7.Text = "5"; btn8.Text = "5";
            btn9.Text = "5"; btn10.Text = "5"; btn11.Text = "5"; btn12.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Text = "0";
            t2.Text = "0";
        }
    }
}
