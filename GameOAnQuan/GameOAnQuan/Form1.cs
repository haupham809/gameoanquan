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

        public static int conchucuamay1 = 0; public static int conchucuanguoi1 = 0;
        private void reset()
        {
            btn1.BackColor = Color.Aqua;
            btn2.BackColor = Color.Aqua;
            btn3.BackColor = Color.Aqua;
            btn4.BackColor = Color.Aqua;
            btn5.BackColor = Color.Aqua;
            btn6.BackColor = Color.Fuchsia;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
            btn10.BackColor = Color.White;
            btn11.BackColor = Color.White;
            btn12.BackColor = Color.Lime;
        }
        private bool kiemtra()
        {
            if (Convert.ToInt32(btn1.Text) == 0 && Convert.ToInt32(btn2.Text) == 0 && Convert.ToInt32(btn3.Text) == 0
                && Convert.ToInt32(btn4.Text) == 0 && Convert.ToInt32(btn5.Text) == 0 && Convert.ToInt32(btn7.Text) == 0 && Convert.ToInt32(btn8.Text) == 0 && Convert.ToInt32(btn9.Text) == 0
                && Convert.ToInt32(btn10.Text) == 0 && Convert.ToInt32(btn11.Text) == 0) return true;
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
                if (Convert.ToInt32(btn1.Text) == 0 && Convert.ToInt32(btn2.Text) == 0 && Convert.ToInt32(btn3.Text) == 0
                && Convert.ToInt32(btn4.Text) == 0 && Convert.ToInt32(btn5.Text) == 0 && Convert.ToInt32(btn7.Text) == 0 && Convert.ToInt32(btn8.Text) == 0 && Convert.ToInt32(btn9.Text) == 0
                && Convert.ToInt32(btn10.Text) == 0 && Convert.ToInt32(btn11.Text) == 0)
                    return 0;
                    MessageBox.Show("Người\n"+" so luong "+soluongsoi);
                
            }
            else if (luachoncuamay == 1)
            {
                if (Convert.ToInt32(btn1.Text) == 0 && Convert.ToInt32(btn2.Text) == 0 && Convert.ToInt32(btn3.Text) == 0
               && Convert.ToInt32(btn4.Text) == 0 && Convert.ToInt32(btn5.Text) == 0 && Convert.ToInt32(btn7.Text) == 0 && Convert.ToInt32(btn8.Text) == 0 && Convert.ToInt32(btn9.Text) == 0
               && Convert.ToInt32(btn10.Text) == 0 && Convert.ToInt32(btn11.Text) == 0)
                    return 0;
                MessageBox.Show("máy\n" + " so luong " + soluongsoi);
            }


            int x = 0;
            
           if (soluongsoi > 0) {
                    reset();
                    int vitrichon = Convert.ToInt32(btn.Replace("btn", ""));


                    if (vitrichon == 1)
                    {
                        btn2.BackColor = Color.Red;
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
                        btn3.BackColor = Color.Red;
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
                        btn4.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn4.Text = (Convert.ToInt32(btn4.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn5.Text) == 0)
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
                        btn5.BackColor = Color.Red;
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
                        btn6.BackColor = Color.Red;
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
                        btn7.BackColor = Color.Red;
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
                        btn8.BackColor = Color.Red;
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
                        btn9.BackColor = Color.Red;
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
                        btn10.BackColor = Color.Red;
                        soluongsoi = soluongsoi - 1;
                        btn10.Text = (Convert.ToInt32(btn10.Text) + 1).ToString();
                        if (soluongsoi == 0)
                        {
                            if (Convert.ToInt32(btn11.Text) == 0)
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
                        btn11.BackColor = Color.Red;
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
                        btn12.BackColor = Color.Red;
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
                        btn1.BackColor = Color.Red;
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

           
          
            return x;

            }
       
        private void btn1_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                string text = "";
                lbldiemmay.Text = (conchucuamay + Convert.ToInt32(lbldiemmay.Text) + Convert.ToInt32(btn7.Text) + Convert.ToInt32(btn8.Text)
                    + Convert.ToInt32(btn9.Text) + Convert.ToInt32(btn10.Text) + Convert.ToInt32(btn11.Text) + Convert.ToInt32(btn12.Text)).ToString();
                lbldiemnguoichoi.Text = (conchucuanguoi + Convert.ToInt32(lbldiemnguoichoi.Text) + Convert.ToInt32(btn1.Text) + Convert.ToInt32(btn2.Text)
                    + Convert.ToInt32(btn3.Text) + Convert.ToInt32(btn4.Text) + Convert.ToInt32(btn5.Text) + Convert.ToInt32(btn6.Text)).ToString();
                if (Convert.ToInt32(lbldiemmay.Text) > Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    text = " Bạn đã thua /n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) < Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã thắng \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) == Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã hòa \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbldiemmay.Text = "0";
                    lbldiemnguoichoi.Text = "0";
                    btn1.Text = "5"; btn2.Text = "5"; btn3.Text = "5"; btn4.Text = "5";
                    btn5.Text = "5"; btn6.Text = "1"; btn7.Text = "5"; btn8.Text = "5";
                    btn9.Text = "5"; btn10.Text = "5"; btn11.Text = "5"; btn12.Text = "1";
                }
                else if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    btn1.Text = "0"; btn2.Text = "0"; btn3.Text = "0"; btn4.Text = "0";
                    btn5.Text = "0"; btn6.Text = "0"; btn7.Text = "0"; btn8.Text = "0";
                    btn9.Text = "0"; btn10.Text = "0"; btn11.Text = "0"; btn12.Text = "0";

                }

            }

            else
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
                    lbldiemnguoichoi.Text = (choinguocchieu("btn1", s) + Convert.ToInt32(lbldiemnguoichoi.Text)).ToString();
                    randommay();
                }
            }

        }
        private void randommay()
        {
            if (kiemtra())
            {
                string text = "";
                lbldiemmay.Text = (conchucuamay + Convert.ToInt32(lbldiemmay.Text) + Convert.ToInt32(btn7.Text) + Convert.ToInt32(btn8.Text)
                    + Convert.ToInt32(btn9.Text) + Convert.ToInt32(btn10.Text) + Convert.ToInt32(btn11.Text) + Convert.ToInt32(btn12.Text)).ToString();
                lbldiemnguoichoi.Text = (conchucuanguoi + Convert.ToInt32(lbldiemnguoichoi.Text) + Convert.ToInt32(btn1.Text) + Convert.ToInt32(btn2.Text)
                    + Convert.ToInt32(btn3.Text) + Convert.ToInt32(btn4.Text) + Convert.ToInt32(btn5.Text) + Convert.ToInt32(btn6.Text)).ToString();
                if (Convert.ToInt32(lbldiemmay.Text) > Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    text = " Bạn đã thua /n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) < Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã thắng \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) == Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã hòa \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbldiemmay.Text = "0";
                    lbldiemnguoichoi.Text = "0";
                    btn1.Text = "5"; btn2.Text = "5"; btn3.Text = "5"; btn4.Text = "5";
                    btn5.Text = "5"; btn6.Text = "1"; btn7.Text = "5"; btn8.Text = "5";
                    btn9.Text = "5"; btn10.Text = "5"; btn11.Text = "5"; btn12.Text = "1";
                }
                else if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    btn1.Text = "0"; btn2.Text = "0"; btn3.Text = "0"; btn4.Text = "0";
                    btn5.Text = "0"; btn6.Text = "0"; btn7.Text = "0"; btn8.Text = "0";
                    btn9.Text = "0"; btn10.Text = "0"; btn11.Text = "0"; btn12.Text = "0";

                }

            }
            else
            {

           
            luachoncuanguoi = 0;
            luachoncuamay = 1;
            Random r = new Random();
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            if (Convert.ToInt32(btn7.Text) > 0) {
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
            int i = r.Next(0, a.Count-1);
           
            if (b[i] == "btn7")
            {
                int s = Convert.ToInt32(btn7.Text);
                btn7.Text = "0";
                lbldiemmay.Text = (choinguocchieu("btn7", s) + Convert.ToInt32(lbldiemmay.Text)).ToString();
            }
            else if (b[i] == "btn8")
            {
                int s = Convert.ToInt32(btn8.Text);
                btn8.Text = "0";
                lbldiemmay.Text = (choinguocchieu("btn8", s) + Convert.ToInt32(lbldiemmay.Text)).ToString();
            }
            else if (b[i] == "btn9")
            {
                int s = Convert.ToInt32(btn9.Text);
                btn9.Text = "0";
                lbldiemmay.Text = (choinguocchieu("btn9", s) + Convert.ToInt32(lbldiemmay.Text)).ToString();
            }
            else if (b[i] == "btn10")
            {
                int s = Convert.ToInt32(btn10.Text);
                btn10.Text = "0";
                lbldiemmay.Text = (choinguocchieu("btn10", s) + Convert.ToInt32(lbldiemmay.Text)).ToString();
            }
            else if (b[i] == "btn11")
            {
                int s = Convert.ToInt32(btn11.Text);
                btn11.Text = "0";
                lbldiemmay.Text = (choinguocchieu("btn11", s) + Convert.ToInt32(lbldiemmay.Text)).ToString();
            }
            }

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                string text = "";
                lbldiemmay.Text = (conchucuamay + Convert.ToInt32(lbldiemmay.Text) + Convert.ToInt32(btn7.Text) + Convert.ToInt32(btn8.Text)
                    + Convert.ToInt32(btn9.Text) + Convert.ToInt32(btn10.Text) + Convert.ToInt32(btn11.Text) + Convert.ToInt32(btn12.Text)).ToString();
                lbldiemnguoichoi.Text = (conchucuanguoi + Convert.ToInt32(lbldiemnguoichoi.Text) + Convert.ToInt32(btn1.Text) + Convert.ToInt32(btn2.Text)
                    + Convert.ToInt32(btn3.Text) + Convert.ToInt32(btn4.Text) + Convert.ToInt32(btn5.Text) + Convert.ToInt32(btn6.Text)).ToString();
                if (Convert.ToInt32(lbldiemmay.Text) > Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    text = " Bạn đã thua /n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) < Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã thắng \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) == Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã hòa \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbldiemmay.Text = "0";
                    lbldiemnguoichoi.Text = "0";
                    btn1.Text = "5"; btn2.Text = "5"; btn3.Text = "5"; btn4.Text = "5";
                    btn5.Text = "5"; btn6.Text = "1"; btn7.Text = "5"; btn8.Text = "5";
                    btn9.Text = "5"; btn10.Text = "5"; btn11.Text = "5"; btn12.Text = "1";
                }
                else if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    btn1.Text = "0"; btn2.Text = "0"; btn3.Text = "0"; btn4.Text = "0";
                    btn5.Text = "0"; btn6.Text = "0"; btn7.Text = "0"; btn8.Text = "0";
                    btn9.Text = "0"; btn10.Text = "0"; btn11.Text = "0"; btn12.Text = "0";

                }

            }
            else
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
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                string text = "";
                lbldiemmay.Text = (conchucuamay + Convert.ToInt32(lbldiemmay.Text) + Convert.ToInt32(btn7.Text) + Convert.ToInt32(btn8.Text)
                    + Convert.ToInt32(btn9.Text) + Convert.ToInt32(btn10.Text) + Convert.ToInt32(btn11.Text) + Convert.ToInt32(btn12.Text)).ToString();
                lbldiemnguoichoi.Text = (conchucuanguoi + Convert.ToInt32(lbldiemnguoichoi.Text) + Convert.ToInt32(btn1.Text) + Convert.ToInt32(btn2.Text)
                    + Convert.ToInt32(btn3.Text) + Convert.ToInt32(btn4.Text) + Convert.ToInt32(btn5.Text) + Convert.ToInt32(btn6.Text)).ToString();
                if (Convert.ToInt32(lbldiemmay.Text) > Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    text = " Bạn đã thua /n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) < Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã thắng \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) == Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã hòa \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbldiemmay.Text = "0";
                    lbldiemnguoichoi.Text = "0";
                    btn1.Text = "5"; btn2.Text = "5"; btn3.Text = "5"; btn4.Text = "5";
                    btn5.Text = "5"; btn6.Text = "1"; btn7.Text = "5"; btn8.Text = "5";
                    btn9.Text = "5"; btn10.Text = "5"; btn11.Text = "5"; btn12.Text = "1";
                }
                else if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    btn1.Text = "0"; btn2.Text = "0"; btn3.Text = "0"; btn4.Text = "0";
                    btn5.Text = "0"; btn6.Text = "0"; btn7.Text = "0"; btn8.Text = "0";
                    btn9.Text = "0"; btn10.Text = "0"; btn11.Text = "0"; btn12.Text = "0";

                }

            }
            else
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
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                string text = "";
                lbldiemmay.Text = (conchucuamay + Convert.ToInt32(lbldiemmay.Text) + Convert.ToInt32(btn7.Text) + Convert.ToInt32(btn8.Text)
                    + Convert.ToInt32(btn9.Text) + Convert.ToInt32(btn10.Text) + Convert.ToInt32(btn11.Text) + Convert.ToInt32(btn12.Text)).ToString();
                lbldiemnguoichoi.Text = (conchucuanguoi + Convert.ToInt32(lbldiemnguoichoi.Text) + Convert.ToInt32(btn1.Text) + Convert.ToInt32(btn2.Text)
                    + Convert.ToInt32(btn3.Text) + Convert.ToInt32(btn4.Text) + Convert.ToInt32(btn5.Text) + Convert.ToInt32(btn6.Text)).ToString();
                if (Convert.ToInt32(lbldiemmay.Text) > Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    text = " Bạn đã thua /n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) < Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã thắng \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) == Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã hòa \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbldiemmay.Text = "0";
                    lbldiemnguoichoi.Text = "0";
                    btn1.Text = "5"; btn2.Text = "5"; btn3.Text = "5"; btn4.Text = "5";
                    btn5.Text = "5"; btn6.Text = "1"; btn7.Text = "5"; btn8.Text = "5";
                    btn9.Text = "5"; btn10.Text = "5"; btn11.Text = "5"; btn12.Text = "1";
                }
                else if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    btn1.Text = "0"; btn2.Text = "0"; btn3.Text = "0"; btn4.Text = "0";
                    btn5.Text = "0"; btn6.Text = "0"; btn7.Text = "0"; btn8.Text = "0";
                    btn9.Text = "0"; btn10.Text = "0"; btn11.Text = "0"; btn12.Text = "0";

                }

            }
            else
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
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                string text = "";
                lbldiemmay.Text = (conchucuamay + Convert.ToInt32(lbldiemmay.Text) + Convert.ToInt32(btn7.Text) + Convert.ToInt32(btn8.Text)
                    + Convert.ToInt32(btn9.Text) + Convert.ToInt32(btn10.Text) + Convert.ToInt32(btn11.Text) + Convert.ToInt32(btn12.Text)).ToString();
                lbldiemnguoichoi.Text = (conchucuanguoi + Convert.ToInt32(lbldiemnguoichoi.Text) + Convert.ToInt32(btn1.Text) + Convert.ToInt32(btn2.Text)
                    + Convert.ToInt32(btn3.Text) + Convert.ToInt32(btn4.Text) + Convert.ToInt32(btn5.Text) + Convert.ToInt32(btn6.Text)).ToString();
                if (Convert.ToInt32(lbldiemmay.Text) > Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    text = " Bạn đã thua /n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) < Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã thắng \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                else if (Convert.ToInt32(lbldiemmay.Text) == Convert.ToInt32(lbldiemnguoichoi.Text))
                {
                    t2.Text = (Convert.ToInt32(t2.Text) + 1).ToString();
                    t1.Text = (Convert.ToInt32(t1.Text) + 1).ToString();
                    text = " Ban đã hòa \n" + "máy:" + lbldiemmay.Text + " điểm" + "\n người chơi:" + lbldiemnguoichoi.Text + " điểm";
                }
                if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbldiemmay.Text = "0";
                    lbldiemnguoichoi.Text = "0";
                    btn1.Text = "5"; btn2.Text = "5"; btn3.Text = "5"; btn4.Text = "5";
                    btn5.Text = "5"; btn6.Text = "1"; btn7.Text = "5"; btn8.Text = "5";
                    btn9.Text = "5"; btn10.Text = "5"; btn11.Text = "5"; btn12.Text = "1";
                }
                else if (MessageBox.Show(text + "\n Bạn có muốn chơi lại không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    btn1.Text = "0"; btn2.Text = "0"; btn3.Text = "0"; btn4.Text = "0";
                    btn5.Text = "0"; btn6.Text = "0"; btn7.Text = "0"; btn8.Text = "0";
                    btn9.Text = "0"; btn10.Text = "0"; btn11.Text = "0"; btn12.Text = "0";

                }

            }
            else
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbldiemmay.Text = "0";
            lbldiemnguoichoi.Text = "0";
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
