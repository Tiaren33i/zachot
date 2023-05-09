using System;
using System.Collections;
using System.Collections.Generic;




namespace WinFormsApp2
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        public List<string> list = new List<string>();

        public List<string> list1 = new List<string>();
        public List<string> list2 = new List<string>();
        public List<string> list3 = new List<string>();


        public List<string> list5 = new List<string>();
        public List<string> list6 = new List<string>();
        public List<string> list7 = new List<string>();

        int Рандонмый_вопросИНДЕКС1;
        int Рандонмый_вопросИНДЕКС2;
        int Рандонмый_вопросИНДЕКС3;

        string q1;
        string q2;
        string q3;

        bool konesh = false;
        bool gg = true;

        int cht = 0;
        int hd = 0;

        Random ranf = new Random();

        public string Вопросы = @"C:\Users\miron\OneDrive\Рабочий стол\zachot-main\WinFormsApp2\вопросы.txt";
        public string Ответы = @"C:\Users\miron\OneDrive\Рабочий стол\zachot-main\WinFormsApp2\ответ.txt";

        public void Form3_Load(object sender, EventArgs e)
        {

            comboBox1.Hide();
            comboBox2.Hide();
            comboBox3.Hide();
            using (StreamReader sr = new StreamReader(File.Open(Вопросы, FileMode.Open)))
            {
                string s = sr.ReadLine();
                list.Add(s);

                while (s != null)
                {

                    s = sr.ReadLine();
                    if (s != null)
                    {
                        list.Add(s);
                    }


                }

                sr.Close();
            }

            using (StreamReader sr = new StreamReader(File.Open(Ответы, FileMode.Open)))
            {


                string s = sr.ReadLine();
                list1.Add(s);

                while (s != null)
                {

                    s = sr.ReadLine();
                    if (s != null)
                    {
                        list1.Add(s);
                    }

                }

                sr.Close();
            }
            using (StreamReader sr = new StreamReader(File.Open(@"C:\Users\miron\OneDrive\Рабочий стол\zachot-main\WinFormsApp2\respond1.txt", FileMode.Open)))
            {


                string s = sr.ReadLine();
                list2.Add(s);

                while (s != null)
                {

                    s = sr.ReadLine();
                    if (s != null)
                    {
                        list2.Add(s);
                    }

                }

                sr.Close();
            }

            using (StreamReader sr = new StreamReader(File.Open(@"C:\Users\miron\OneDrive\Рабочий стол\zachot-main\WinFormsApp2\respond2.txt", FileMode.Open)))
            {


                string s = sr.ReadLine();
                list3.Add(s);

                while (s != null)
                {

                    s = sr.ReadLine();
                    if (s != null)
                    {
                        list3.Add(s);
                    }

                }

                sr.Close();
            }
            label2.Text = cht.ToString();


        }


        void gh()
        {


            label2.Text = cht.ToString();
            while (true)
            {
                if (gg == true)
                {
                    Рандонмый_вопросИНДЕКС1 = ranf.Next(list.Count);
                    q1 = list1[Рандонмый_вопросИНДЕКС1];
                    list5.Add(list1[Рандонмый_вопросИНДЕКС1]);
                    list5.Add(list2[Рандонмый_вопросИНДЕКС1]);
                    list5.Add(list3[Рандонмый_вопросИНДЕКС1]);

                    label7.Text = list[Рандонмый_вопросИНДЕКС1].ToString();
                    list.RemoveAt(Рандонмый_вопросИНДЕКС1);
                    list1.RemoveAt(Рандонмый_вопросИНДЕКС1);
                    list2.RemoveAt(Рандонмый_вопросИНДЕКС1);
                    list3.RemoveAt(Рандонмый_вопросИНДЕКС1);



                    while (list5.Count > 0)
                    {

                        if (list5.Count > 0)
                        {
                            int gfd = ranf.Next(list5.Count);
                            comboBox1.Items.Add(list5[gfd]);
                            list5.RemoveAt(gfd);
                        }
                        else
                        {
                            break;
                        }
                    }
                    gg = false;
                    break;
                }
                else
                {
                    comboBox1.Items.Clear();
                    gg = true;
                }

            }

        }
        void gh1()
        {


            label2.Text = cht.ToString();
            while (true)
            {
                if (gg == true)
                {

                    Рандонмый_вопросИНДЕКС2 = ranf.Next(list.Count);
                    q2 = list1[Рандонмый_вопросИНДЕКС2];
                    label8.Text = list[Рандонмый_вопросИНДЕКС2].ToString();
                    list7.Add(list1[Рандонмый_вопросИНДЕКС2]);
                    list7.Add(list2[Рандонмый_вопросИНДЕКС2]);
                    list7.Add(list3[Рандонмый_вопросИНДЕКС2]);


                    list.RemoveAt(Рандонмый_вопросИНДЕКС2);
                    list1.RemoveAt(Рандонмый_вопросИНДЕКС2);
                    list2.RemoveAt(Рандонмый_вопросИНДЕКС2);
                    list3.RemoveAt(Рандонмый_вопросИНДЕКС2);


                    while (list7.Count > 0)
                    {

                        if (list7.Count > 0)
                        {
                            int gfd = ranf.Next(list7.Count);
                            comboBox2.Items.Add(list7[gfd]);
                            list7.RemoveAt(gfd);
                        }
                        else
                        {
                            break;
                        }
                    }
                    gg = false;
                    break;
                }
                else
                {
                    comboBox2.Items.Clear();
                    gg = true;
                }

            }
        }
        void gh2()
        {


            label2.Text = cht.ToString();
            while (true)
            {

                if (gg == true)
                {
                    Рандонмый_вопросИНДЕКС3 = ranf.Next(list.Count);
                    q3 = list1[Рандонмый_вопросИНДЕКС3];
                    list6.Add(list1[Рандонмый_вопросИНДЕКС3]);
                    list6.Add(list2[Рандонмый_вопросИНДЕКС3]);
                    list6.Add(list3[Рандонмый_вопросИНДЕКС3]);

                    label9.Text = list[Рандонмый_вопросИНДЕКС3].ToString();
                    list.RemoveAt(Рандонмый_вопросИНДЕКС3);
                    list1.RemoveAt(Рандонмый_вопросИНДЕКС3);
                    list2.RemoveAt(Рандонмый_вопросИНДЕКС3);
                    list3.RemoveAt(Рандонмый_вопросИНДЕКС3);



                    while (list6.Count > 0)
                    {

                        if (list6.Count > 0)
                        {
                            int gfd = ranf.Next(list6.Count);
                            comboBox3.Items.Add(list6[gfd]);
                            list6.RemoveAt(gfd);
                        }
                        else
                        {
                            break;
                        }
                    }
                    gg = false;
                    break;
                }
                else
                {

                    comboBox3.Items.Clear();
                    gg = true;
                }
            }


        }

        void проверка()
        {
            bool h = label1.Text == label4.Text;
            bool h1 = label4.Text == label5.Text;
            bool h2 = label1.Text == label5.Text;
            while (true)
            {
                if (h1 == true && h2 == true && h == true)
                {

                    if (list.Count >= 3)
                    {
                        cht = cht + 3;
                        gh();
                        gh1();
                        gh2();

                        comboBox1.Show();
                        comboBox2.Show();
                        comboBox3.Show();
                        break;
                    }
                    else
                    {
                        h1 = false;

                    }

                }
                else if (h1 == false && h2 == false && h == true)
                {

                    if (list.Count >= 2)
                    {
                        cht = cht + 2;
                        gh();
                        gh1();

                        comboBox1.Show();
                        comboBox2.Show();
                        break;
                    }
                    else
                    {
                        h = false;
                    }
                }
                else if (h1 == false && h2 == true && h == false)
                {
                    if (list.Count >= 2)
                    {
                        cht = +2;

                        gh();
                        gh1();

                        comboBox2.Show();
                        comboBox1.Show();
                        break;
                    }
                    else
                    {
                        h2 = false;
                    }
                }
                else if (h1 == true && h2 == false && h == false)
                {
                    if (list.Count >= 2)
                    {
                        cht = cht + 2;

                        gh();
                        gh1();

                        comboBox1.Show();
                        comboBox2.Show();
                        break;
                    }
                    else
                    {
                        h1 = false;
                    }
                }
                else
                {
                    if (list.Count >= 1)
                    {
                        cht = cht + 1;



                        gh();
                        comboBox1.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("все");
                        konesh = true;
                        break;
                    }
                }

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (konesh == true)
            {
                MessageBox.Show("все");
            }
            else
            {
                if (cht == 0)
                {
                    label1.Text = ranf.Next(1, 3).ToString();
                    label4.Text = ranf.Next(1, 3).ToString();
                    label5.Text = ranf.Next(1, 3).ToString();
                    проверка();
                    comboBox1.Text = " ".ToString();
                    comboBox2.Text = " ".ToString();
                    comboBox3.Text = " ".ToString();




                }
                else
                {

                    MessageBox.Show("ответе на вопросы");
                }
            }




        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 nach = new Form1();
            Hide();
            nach.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox1.Items[0].ToString() == q1)
                {
                    ++hd;
                    --cht;
                    comboBox1.Hide();

                    label7.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();




                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox1.Hide();
                    label7.Text = "";
                    label6.Text = hd.ToString();
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox1.Items[1].ToString() == q1)
                {
                    ++hd;
                    --cht;
                    comboBox1.Hide();
                    label7.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();






                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox1.Hide();
                    label7.Text = "";
                    label6.Text = hd.ToString();
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox1.Items[2].ToString() == q1)
                {
                    ++hd;
                    --cht;
                    comboBox1.Hide();
                    label7.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();




                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox1.Hide();
                    label7.Text = "";
                    label6.Text = hd.ToString();
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                if (comboBox1.Items[3].ToString() == q1)
                {
                    ++hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox1.Hide();
                    label7.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();




                }
                else
                {
                    --cht;
                    --hd;
                    label2.Text = cht.ToString();
                    comboBox1.Hide();
                    label7.Text = "";
                    label6.Text = hd.ToString();
                }
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex == 0)
            {
                if (comboBox2.Items[0].ToString() == q2)
                {
                    ++hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox2.Hide();
                    label8.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();





                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox2.Hide();
                    label8.Text = "";
                    label6.Text = hd.ToString();
                }
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                if (comboBox2.Items[1].ToString() == q2)
                {
                    ++hd;
                    --cht;

                    comboBox2.Hide();
                    label8.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();




                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox2.Hide();
                    label8.Text = "";
                    label6.Text = hd.ToString();
                }
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                if (comboBox2.Items[2].ToString() == q2)
                {
                    ++hd;
                    --cht;
                    comboBox2.Hide();
                    label8.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();


                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox2.Hide();
                    label8.Text = "";
                    label6.Text = hd.ToString();
                }
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                if (comboBox2.Items[3].ToString() == q2)
                {
                    ++hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox2.Hide();
                    label8.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();



                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox2.Hide();
                    label8.Text = "";
                    label6.Text = hd.ToString();
                }
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.SelectedIndex == 0)
            {
                if (comboBox3.Items[0].ToString() == q3)
                {
                    ++hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox3.Hide();
                    label9.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();





                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox3.Hide();
                    label9.Text = "";
                    label6.Text = hd.ToString();
                }
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                if (comboBox3.Items[1].ToString() == q3)
                {
                    ++hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox3.Hide();
                    label9.Text = "";
                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();




                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox3.Hide();
                    label9.Text = "";
                    label6.Text = hd.ToString();
                }
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                if (comboBox3.Items[2].ToString() == q3)
                {
                    ++hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox3.Hide();
                    label9.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();



                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox3.Hide();
                    label9.Text = "";
                    label6.Text = hd.ToString();
                }
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                if (comboBox3.Items[3].ToString() == q3)
                {
                    ++hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox3.Hide();
                    label9.Text = "";

                    label6.Text = hd.ToString();
                    label2.Text = cht.ToString();


                }
                else
                {
                    --hd;
                    --cht;
                    label2.Text = cht.ToString();
                    comboBox3.Hide();
                    label9.Text = "";
                    label6.Text = hd.ToString();
                }
            }


        }

    }
}

