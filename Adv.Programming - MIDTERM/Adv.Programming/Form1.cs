using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARASINAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form ikonunu ayarla
            try
            {
                this.Icon = new Icon("../../Icons/Application.ico");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uygulama ikonu y�klenirken hata olu�tu: " + ex.Message,
                                "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // �li comboBox'�na �ehirleri ekle
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Eski�ehir");
            comboBox1.Items.Add("�stanbul");
            comboBox1.Items.Add("�zmir");

            // comboBox1'in d�zenleme se�ene�i kapal�
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // ListView'�n s�tunlar�n� olu�tur
            listView1.Columns.Clear(); // �nceki s�tunlar� temizle
            listView1.Columns.Add("Ad�", 80);
            listView1.Columns.Add("Soyad�", 80);
            listView1.Columns.Add("�li", 70);
            listView1.Columns.Add("�l�esi", 80);
            listView1.Columns.Add("Cinsiyet", 60);
            listView1.Columns.Add("M�zik", 60);
            listView1.Columns.Add("Kitap", 60);
            listView1.Columns.Add("Sinema", 60);

            // ListView �zellikleri
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.View = View.Details;

            // ListView'in s�tunlar�n�n tamamen g�r�n�r olmas� i�in 
            // yatay kayd�rma �zelli�ini etkinle�tir
            listView1.Scrollable = true;

            // G�r�n�m tipi comboBox'�na g�r�n�m tiplerini ekle
            comboBox2.Items.Clear();
            comboBox2.Items.Add("B�y�k �kon (Large Icon)");
            comboBox2.Items.Add("Detay (Details)");
            comboBox2.Items.Add("D��eme(Tile)");
            comboBox2.Items.Add("K���k �kon (Small Icon)");
            comboBox2.Items.Add("Liste (List)");

            // comboBox2'nin d�zenleme se�ene�i kapal�
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            // Varsay�lan olarak "Detay" g�r�n�m�n� se�
            comboBox2.SelectedIndex = 1; // Detay (Details)

            // Erkek radyo d��mesini varsay�lan olarak se�
            radioButton1.Checked = true;

            // �kon 1 radyo d��mesini varsay�lan olarak se�
            radioButton3.Checked = true;

            // Durum �ubu�una ho�geldin mesaj� ekle
            toolStripStatusLabel1.Text = "Ho�geldiniz!";

            // ImageList'leri ayarla
            imageList1.ImageSize = new Size(20, 20); // K���k ikon boyutu
            imageList1.ColorDepth = ColorDepth.Depth32Bit;

            imageList2.ImageSize = new Size(32, 32); // B�y�k ikon boyutu
            imageList2.ColorDepth = ColorDepth.Depth32Bit;

            try
            {
                // Resimleri ImageList'e ekle
                // Resimleri temizleyelim ve yeniden ekleyelim
                imageList1.Images.Clear();
                imageList2.Images.Clear();

                // K���k ikonlar (Small ImageList)
                imageList1.Images.Add(Image.FromFile("../../Icons/person1-small.jpg"));
                imageList1.Images.Add(Image.FromFile("../../Icons/person2-small.jpg"));
                imageList1.Images.Add(Image.FromFile("../../Icons/person3-small.jpg"));
                imageList1.Images.Add(Image.FromFile("../../Icons/person4-small.png"));

                // B�y�k ikonlar (Large ImageList)
                imageList2.Images.Add(Image.FromFile("../../Icons/person1-large.jpg"));
                imageList2.Images.Add(Image.FromFile("../../Icons/person2-large.jpg"));
                imageList2.Images.Add(Image.FromFile("../../Icons/person3-large.jpg"));
                imageList2.Images.Add(Image.FromFile("../../Icons/person4-large.png"));

                // ToolStrip butonlar�na ikonlar� ata
                toolStripButton1.Image = Image.FromFile("../../Icons/Toolbar-ClearStudentInfo.ico");
                toolStripButton2.Image = Image.FromFile("../../Icons/Toolbar-ClearStudentList.ico");
                toolStripButton3.Image = Image.FromFile("../../Icons/Toolbar-About.ico");

                // PictureBox'lara ikonlar� ata
                pictureBox1.Image = Image.FromFile("../../Icons/person1-small.jpg");
                pictureBox2.Image = Image.FromFile("../../Icons/person2-small.jpg");
                pictureBox3.Image = Image.FromFile("../../Icons/person3-small.jpg");
                pictureBox4.Image = Image.FromFile("../../Icons/person4-small.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("�konlar y�klenirken hata olu�tu: " + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // ImageList'leri ListView'e ata
            listView1.SmallImageList = imageList1;
            listView1.LargeImageList = imageList2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �l�e listBox'�n� temizle
            listBox1.Items.Clear();

            // comboBox1'de se�ili bir ��e yoksa metottan ��k
            if (comboBox1.SelectedItem == null)
                return;

            // Se�ilen �ehre g�re il�eleri ekle
            string selectedCity = comboBox1.SelectedItem.ToString();

            if (selectedCity == "Ankara")
            {
                listBox1.Items.Add("�ankaya");
                listBox1.Items.Add("Beypazar�");
                listBox1.Items.Add("Polatl�");
                listBox1.Items.Add("G�lba��");
                listBox1.Items.Add("Sincan");
                listBox1.Items.Add("Mamak");
            }
            else if (selectedCity == "Eski�ehir")
            {
                listBox1.Items.Add("Alpu");
                listBox1.Items.Add("�ifteler");
                listBox1.Items.Add("Merkez");
                listBox1.Items.Add("Odunpazar�");
                listBox1.Items.Add("Sancakaya");
                listBox1.Items.Add("Seyitgazi");
                listBox1.Items.Add("Sivrihisar");
            }
            else if (selectedCity == "�stanbul")
            {
                listBox1.Items.Add("Be�ikta�");
                listBox1.Items.Add("Bak�rk�y");
                listBox1.Items.Add("Beyo�lu");
                listBox1.Items.Add("Beylikd�z�");
                listBox1.Items.Add("Ey�p");
                listBox1.Items.Add("Kad�k�y");
                listBox1.Items.Add("�i�li");
                listBox1.Items.Add("�sk�dar");
                listBox1.Items.Add("Zeytinburnu");
            }
            else if (selectedCity == "�zmir")
            {
                listBox1.Items.Add("Bornova");
                listBox1.Items.Add("�e�me");
                listBox1.Items.Add("Dikili");
                listBox1.Items.Add("Fo�a");
                listBox1.Items.Add("Kar��yaka");
                listBox1.Items.Add("Konak");
                listBox1.Items.Add("Torbal�");
                listBox1.Items.Add("Urla");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox2'de se�ili bir ��e yoksa metottan ��k
            if (comboBox2.SelectedIndex == -1)
                return;

            // G�r�n�m t�r�n� se�ilen de�ere g�re de�i�tir
            switch (comboBox2.SelectedIndex)
            {
                case 0: // B�y�k �kon (Large Icon)
                    listView1.View = View.LargeIcon;
                    break;
                case 1: // Detay (Details)
                    listView1.View = View.Details;
                    break;
                case 2: // D��eme (Tile)
                    listView1.View = View.Tile;
                    break;
                case 3: // K���k �kon (Small Icon)
                    listView1.View = View.SmallIcon;
                    break;
                case 4: // Liste (List)
                    listView1.View = View.List;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Listeye Ekle butonuna bas�ld���nda
            try
            {
                // Gerekli kontrolleri yap
                if (string.IsNullOrEmpty(textBox1.Text) ||
                    string.IsNullOrEmpty(textBox2.Text) ||
                    comboBox1.SelectedItem == null ||
                    listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Bilgilerde eksiklik bulunmaktad�r!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ��renci bilgilerini al
                string ad = textBox1.Text;
                string soyad = textBox2.Text;
                string il = comboBox1.SelectedItem.ToString();
                string ilce = listBox1.SelectedItem.ToString();

                // Cinsiyet bilgisini al
                string cinsiyet = radioButton1.Checked ? "Erkek" : "Kad�n";

                // Hobi bilgilerini al
                string muzik = checkBox1.Checked ? "Evet" : "Hay�r";
                string kitap = checkBox2.Checked ? "Evet" : "Hay�r";
                string sinema = checkBox3.Checked ? "Evet" : "Hay�r";

                // Se�ilen ikonu belirle
                int ikonIndex = 0;
                if (radioButton3.Checked) ikonIndex = 0;
                else if (radioButton4.Checked) ikonIndex = 1;
                else if (radioButton5.Checked) ikonIndex = 2;
                else if (radioButton6.Checked) ikonIndex = 3;

                // Listeye yeni ��e ekle
                ListViewItem item = new ListViewItem(ad);
                item.ImageIndex = ikonIndex; // �kon indeksi
                item.SubItems.Add(soyad);
                item.SubItems.Add(il);
                item.SubItems.Add(ilce);
                item.SubItems.Add(cinsiyet);
                item.SubItems.Add(muzik);
                item.SubItems.Add(kitap);
                item.SubItems.Add(sinema);

                listView1.Items.Add(item);

                // Formu temizle
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgilerde eksiklik bulunmaktad�r! Hata: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ��renci bilgilerini temizleme metodu
        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
            radioButton1.Checked = true; // Erkek se�ili
            radioButton3.Checked = true; // �kon 1 se�ili
            checkBox1.Checked = false;   // M�zik se�ili de�il
            checkBox2.Checked = false;   // Kitap se�ili de�il
            checkBox3.Checked = false;   // Sinema se�ili de�il
        }

        // ��renci listesini temizleme metodu
        private void ClearList()
        {
            listView1.Items.Clear();
        }

        // Men� - Bilgileri Temizle
        private void bilgileriTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Men� - Listeyi Temizle
        private void listeyiTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        // Men� - ��k��
        private void ��k��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Men� - Hakk�nda
        private void hakk�ndaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        // ToolStrip butonlar�
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ClearForm(); // Bilgileri temizle
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClearList(); // Listeyi temizle
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog(); // Hakk�nda formunu g�ster
        }

        // ToolStrip ItemClicked olay�n� i�le
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Bu metot toolStrip'teki herhangi bir ��eye t�kland���nda �al���r
            // �u anda �zel bir i�lem yapmas�na gerek yok
        }

        // MenuStrip ItemClicked olay�n� i�le
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Bu metot menuStrip'teki herhangi bir ��eye t�kland���nda �al���r
            // �u anda �zel bir i�lem yapmas�na gerek yok
        }
    }
}