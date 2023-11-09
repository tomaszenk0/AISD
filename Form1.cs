namespace praca_domowa_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //Ta funkcja jest wywo�ywana, gdy u�ytkownik kliknie na przycisk "button6". W zale�no�ci od stanu kontrolki checkBox1, ta funkcja generuje losowe liczby lub przekszta�ca wprowadzony napis na liczby ca�kowite i wy�wietla je na kontrolce label3.
        {
            if (checkBox1.Checked)
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik = Random1(liczbaN);
                label3.Text = "";


            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik = convert(liczbaN);
                label3.Text = "";
            }
        }
        int[] Random1(int n)  //Ta funkcja generuje tablic� tab o d�ugo�ci n i wype�nia j� losowymi liczbami od 1 do 100. Nast�pnie wy�wietla ka�d� wylosowan� liczb� na kontrolce label3 i zwraca t� tablic�.
        {
            int[] tab = new int[n];
            Random random2 = new Random();
            for (int i = 0; i < n; i++)
            {
                tab[i] = random2.Next(1, 101);
                label3.Text = tab[i].ToString();


            }
            return tab;

        }
        int[] convert(string napis) // Ta funkcja przyjmuje napis jako argument, usuwa bia�e znaki, dzieli napis na cz�ci, u�ywaj�c przecinka jako separatora, a nast�pnie przekszta�ca te cz�ci w liczby ca�kowite. Wynikiem jest tablica liczb ca�kowitych.
        {
            var liczbyS = napis.Trim().Split(',');
            var liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i].Trim());

            }
            return liczby;
        }
        int[] Sb(int[] tab1)  //Ta funkcja implementuje algorytm sortowania b�belkowego na tablicy liczb tab1. Sortuje te liczby i zwraca posortowan� tablic�.
        {
            bool cbz;
            int n = tab1.Length;
            do
            {
                cbz = false;
                for (int i = 1; i < n; i++)
                {


                    if (tab1[i] < tab1[i - 1])
                    {
                        int a = tab1[i - 1];
                        tab1[i - 1] = tab1[i];
                        tab1[i] = a;
                        cbz = true;

                    }

                }
                n--;


            }
            while (cbz);
            return tab1;
        }

        int[] SS(int[] tab2)  //Ta funkcja implementuje algorytm sortowania przez wybieranie na tablicy liczb tab2. Sortuje te liczby i zwraca posortowan� tablic�.
        {

            for (int i = 0; i < tab2.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < tab2.Length; j++)
                {
                    if (tab2[min] > tab2[j])
                    {
                        min = j;
                    }
                }

                int temp = tab2[i];
                tab2[i] = tab2[min];
                tab2[min] = temp;
            }
            return tab2;

        }

        int[] Si(int[] tab3) //Ta funkcja implementuje algorytm sortowania przez wstawianie na tablicy liczb tab3. Sortuje te liczby i zwraca posortowan� tablic�.
        {

            for (int i = 1; i < tab3.Length; i++)
            {
                int temp = tab3[i];
                int j = i - 1;

                while (j >= 0 && tab3[j] > temp)
                {
                    tab3[j + 1] = tab3[j];
                    j--;
                }
                tab3[j + 1] = temp;
            }
            return tab3;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) //Ta funkcja jest wywo�ywana, gdy u�ytkownik kliknie na kontrolk� label1.W kodzie zmienia tekst kontrolki label1, wy�wietlaj�c aktualny czas.
        {
            label1.Text = DateTime.Now.ToShortTimeString();
        }
        private void timer1_Tick(object sender, EventArgs e) // Ta funkcja jest wywo�ywana w regularnych odst�pach czasu (zdefiniowanych przez timer1) i aktualizuje tekst kontrolki label1, wy�wietlaj�c aktualny czas.
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e) //Ta funkcja jest wywo�ywana podczas za�adowania formularza i inicjalizuje zegar (timer1) oraz wy�wietla aktualny czas na kontrolce label1.
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e) //button1_Click, button2_Click, button3_Click - Te funkcje s� wywo�ywane, gdy u�ytkownik kliknie odpowiednie przyciski ("button1", "button2", "button3"). W zale�no�ci od stanu kontrolki checkBox1, przekszta�caj� wprowadzone liczby lub generuj� losowe liczby, sortuj� je za pomoc� algorytm�w Sb, SS, lub Si, a nast�pnie wy�wietlaj� posortowane liczby na kontrolce label3.
        {
            if (checkBox1.Checked)    
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik1 = Random1(liczbaN);
                int[] wynik = Sb(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }


            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik1 = convert(liczbaN);
                int[] wynik = Sb(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik1 = Random1(liczbaN);
                int[] wynik = SS(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }


            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik1 = convert(liczbaN);
                int[] wynik = SS(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik1 = Random1(liczbaN);
                int[] wynik = Si(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }


            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik1 = convert(liczbaN);
                int[] wynik = Si(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }
            }
        }
    }
}