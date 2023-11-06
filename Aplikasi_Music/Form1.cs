namespace Aplikasi_Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Memeriksa apakah pilihan dalam comboBox2 adalah makanan yang di pilih.
            if (comboBox2.Text != "Lobster Asam Pedas")
            {

            }
            // Jika ya, mengatur nilai teks dalam textBox1 menjadi harga.
            else if (comboBox2.Text == "Lobster Asam Pedas")
            {
                textBox1.Text = "300000";
            }

            if (comboBox2.Text != "Kepiting Asam Manis")
            {

            }
            else if (comboBox2.Text == "Kepiting Asam Manis")
            {
                textBox1.Text = "250000";
            }

            if (comboBox2.Text != "Baby Crab")
            {

            }
            else if (comboBox2.Text == "Baby Crab")
            {
                textBox1.Text = "50000";
            }
            if (comboBox2.Text != "Cumi asap")
            {

            }
            else if (comboBox2.Text == "Cumi asap")
            {
                textBox1.Text = "70000";
            }
            if (comboBox2.Text != "Udang Goreng")
            {

            }
            else if (comboBox2.Text == "Udang Goreng")
            {
                textBox1.Text = "120000";
            }
            if (comboBox2.Text != "Cumi Bakar")
            {

            }
            else if (comboBox2.Text == "Cumi Bakar")
            {
                textBox1.Text = "100000";
            }
            if (comboBox2.Text != "Sushi Me")
            {

            }
            else if (comboBox2.Text == "Sushi Me")
            {
                textBox1.Text = "150000";
            }
            if (comboBox2.Text != "Kepiting Bakar")
            {

            }
            else if (comboBox2.Text == "Kepiting Bakar")
            {
                textBox1.Text = "350000";
            }
            if (comboBox2.Text != "Lobster Bakar")
            {

            }
            else if (comboBox2.Text == "Lobster Bakar")
            {
                textBox1.Text = "400000";
            }
            if (comboBox2.Text != "Ikan Bakar")
            {

            }
            else if (comboBox2.Text == "Ikan Bakar")
            {
                textBox1.Text = "80000";
            }
            if (comboBox2.Text != "Steak Wagyu A5")
            {

            }
            else if (comboBox2.Text == "Steak Wagyu A5")
            {
                textBox1.Text = "800000";
            }
            if (comboBox2.Text != "Chicken Steak")
            {

            }
            else if (comboBox2.Text == "Chicken Steak")
            {
                textBox1.Text = "80000";
            }
            if (comboBox2.Text != "Steak Sirloin")
            {

            }
            else if (comboBox2.Text == "Steak Sirloin")
            {
                textBox1.Text = "200000";
            }
            if (comboBox2.Text != "Chicken Wings")
            {

            }
            else if (comboBox2.Text == "Chicken Wings")
            {
                textBox1.Text = "50000";
            }
            if (comboBox2.Text != "Fried Chicken")
            {

            }
            else if (comboBox2.Text == "Fried Chicken")
            {
                textBox1.Text = "75000";
            }
            if (comboBox2.Text != "Ayam Bakar")
            {

            }
            else if (comboBox2.Text == "Ayam Bakar")
            {
                textBox1.Text = "70000";
            }

        }



       

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menghapus semua item yang ada dalam comboBox2.
            comboBox2.Items.Clear();

            // Memeriksa apakah kategori yang dipilih dalam comboBox1 adalah "SeaFood".
            if (comboBox1.SelectedItem.ToString() == "SeaFood")
            {
                // Jika "SeaFood" dipilih, tambahkan item makanan laut ke dalam comboBox2.
                comboBox2.Items.Add("Ikan Bakar");
                comboBox2.Items.Add("Kepiting Asam Manis");
                comboBox2.Items.Add("Lobster Asam Pedas");
                comboBox2.Items.Add("Baby Crab");
                comboBox2.Items.Add("Cumi asap");
                comboBox2.Items.Add("Udang Goreng");
                comboBox2.Items.Add("Cumi Bakar");
                comboBox2.Items.Add("Sushi Me");
                comboBox2.Items.Add("Kepiting Bakar");
                comboBox2.Items.Add("Lobster Bakar");
            }
            else if (comboBox1.SelectedItem.ToString() == "Daging")
            {
                // Jika "Daging" dipilih, tambahkan item makanan daging ke dalam comboBox2.
                comboBox2.Items.Add("Ayam Bakar");
                comboBox2.Items.Add("Chicken Steak ");
                comboBox2.Items.Add("Chicken Wings");
                comboBox2.Items.Add("Steak Wagyu A5");
                comboBox2.Items.Add("Steak Sirloin");
                comboBox2.Items.Add("Fried Chicken");
            }

            // Jika ada item dalam comboBox2, pilih item pertama (indeks 0).
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //di sini 
        private void button1_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah nilai yang dimasukkan di textBox1 dan textBox2 menjadi tipe data yang sesuai.
            if (decimal.TryParse(textBox1.Text, out decimal harga) && int.TryParse(textBox2.Text, out int jumlah))
            {
                // Menghitung total harga dengan mengalikan harga per makanan dengan jumlah makanan.
                decimal totalHarga = harga * jumlah;

                // Menampilkan total harga di textBox3.
                textBox3.Text = totalHarga.ToString();

                // Menginisialisasi variabel diskon dengan nilai awal 0.
                decimal diskon = 0;

                // Jika total harga mencapai atau melebihi 400000, maka berikan diskon sebesar 10%.
                if (totalHarga >= 400000)
                {
                    diskon = totalHarga * 0.10m; ;
                }

                // Menghitung total bayar setelah diberikan diskon.
                decimal totalBayar = totalHarga - diskon;

                // Menampilkan nilai diskon di textBox4.
                textBox4.Text = diskon.ToString("N0") + " ";

                // Menampilkan total bayar setelah diskon di textBox5.
                textBox5.Text =totalBayar.ToString("N0");
            }
        }


        //ketika berhasil membeli akan muncul pesan berhasil membeli dan akan menghapus ketika brhasil di beli
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            MessageBox.Show("Berhasil Membeli!");
        }


        //ketika batal membeli maka akan menghapus semua isi dalam textBox dan comboBox
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

