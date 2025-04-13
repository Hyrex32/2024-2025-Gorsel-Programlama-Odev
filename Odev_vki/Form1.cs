using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Odev_vki
{
    public partial class Form1 : Form
    {
        string dbConnectionString = "Data Source=data.db;Version=3;"; //Veritabanı oluşumu
        public Form1()
        {
            InitializeComponent();
            VeriTabaniOlustur();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 60; //Resimlerin sığması için
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void VeriTabaniOlustur()
        {
            if (!File.Exists("data.db"))
            {
                SQLiteConnection.CreateFile("data.db");
            }

            using (SQLiteConnection con = new SQLiteConnection(dbConnectionString))
            {
                con.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Users (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Ad TEXT,
                                Soyad TEXT,
                                Gun INTEGER,
                                Ay INTEGER,
                                Yil INTEGER,
                                VKI REAL,
                                VKIYorum TEXT,
                                Burc TEXT,
                                BurcYorum TEXT,
                                BurcResmi TEXT
                            )";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //VKI (Vücut Kitle Endeksi) hesaplama metodu
        private double VKI_Hesapla(double kilo, double boy)
        {
            double boyMetre = boy / 100.0;
            double vki = kilo / (boyMetre * boyMetre);
            return Math.Round(vki, 2);
        }

        //VKI'ye göre yorum üretme metodu
        private string VKI_Yorum(double vki)
        {
            if (vki < 18.5)
                return "Zayıf";
            else if (vki < 25)
                return "Normal";
            else if (vki < 30)
                return "Fazla Kilolu";
            else
                return "Obez";
        }

        //Doğum tarihine göre burç hesaplama metodu
        private string BurcAdi(int gun, int ay)
        {
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 19))
                return "Koç";
            else if ((ay == 4 && gun >= 20) || (ay == 5 && gun <= 20))
                return "Boğa";
            else if ((ay == 5 && gun >= 21) || (ay == 6 && gun <= 20))
                return "İkizler";
            else if ((ay == 6 && gun >= 21) || (ay == 7 && gun <= 22))
                return "Yengeç";
            else if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
                return "Aslan";
            else if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22))
                return "Başak";
            else if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22))
                return "Terazi";
            else if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 21))
                return "Akrep";
            else if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21))
                return "Yay";
            else if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 19))
                return "Oğlak";
            else if ((ay == 1 && gun >= 20) || (ay == 2 && gun <= 18))
                return "Kova";
            else if ((ay == 2 && gun >= 19) || (ay == 3 && gun <= 20))
                return "Balık";
            return "";
        }
        private string BurcYorumu(string burc)
        {
            switch (burc)
            {
                case "Koç":
                    return "Sevgili Koç, bugün gündeminde aşk olacak! Heyecan verici ve sıcak yakınlaşmalarla güzel duygulara kapılabilirsin. Bu Pazar günü, kalbinin ritminin değiştiğini hissedebilirsin. Ancak dikkatli ol bu durum mevcut ilişkinde sadakatini de sınayabilir!";
                case "Boğa":
                    return "Sevgili Boğa, bugün huzura ihtiyaç duyacaksın. Terazi burcunda Dolunayın enerjisiyle sevdiklerini bir araya getirmek ve aile bağlarını güçlendirmek isteyebilirsin.";
                case "İkizler":
                    return "Sevgili İkizler, bugün dengeyi bulacaksın! Üstelik hem duygusal konularda hem de profesyonel hayatında aklın ve mantığının aynı düzlemde buluştuğunu keşfedeceksin. Kalbinden geçenin doğru olduğunu fark ettiğinde ise her zamanki belirsizlik ve kararsızlıklardan kurtulup peşi sıra kararlar verebileceksin.";
                case "Yengeç":
                    return "Sevgili Yengeç, bugün hayattan ne istediğini her zamankinden çok daha iyi bileceksin. Terazi burcunda meydana gelen Dolunaydan güç alarak duygularını netleştirecek ve gerçekten ne hissettiğini fark edeceksin.";
                case "Aslan":
                    return "Sevgili Aslan, bugün sevgiden güç alabilirsin. Zira, Terazi burcunda meydana gelen Dolunay adeta aşka odaklanıp duygularına kapılmanı sağlayabilir. Çoğunlukla ben merkezci bir şekilde hareket etsen de bugün yegane önceliğin o olabilir!";
                case "Başak":
                    return "Sevgili Başak, bugün aklın ve kalbin arasındaki denge kazanmanı sağlayabilir. Özellikle finansal konularda atacağın her adımda güçlenebilirsin. Maddi anlamda bolca kazanç elde edeceğin anlaşmalar imzalayabilir, projelere imza atabilir ya da ihalelere girebilirsin.";
                case "Terazi":
                    return "Sevgili Terazi, bugün aklın ve zarafetinle göz kamaştıracaksın. Burcunda meydana gelen Dolunaydan güç ve ilham alacak, ışığınla dikkatleri üzerine çekeceksin. Bilmeni isteriz, göz kamaştırıyorsun...";
                case "Akrep":
                    return "Sevgili Akrep, bugün geçmişi ardında bırakabildin mi? Her zaman canlı, enerjik ve gizemli olsan da içinde bitmeyen savaşlar olabilir. Kimseye göstermesen de içindeki fırtınaları artık ruhun dinginlik arıyor da olabilir... Huzura ihtiyacın olduğunu sen de biliyorsun!";
                case "Yay":
                    return "Sevgili Yay, bugün aradığın macerayı bulacaksın. Ancak sandığın gibi özgürlükte değil, bağlılıkta... Terazi burcunda meydana gelen Dolunayın enerjisiyle aşkı bulmak, hatta sırılsıklam aşık olmak üzeresin.";
                case "Oğlak":
                    return "Sevgili Oğlak, bugün finansal konularda aniden karar vermemelisin. Analitik veriler, rasyonel analizler ve güçlü bir matematiğe dayandırmalısın atacağın adımları. Bu sayede başarıya ulaşabileceğini bilmeli, doğru kişilerle doğru işi yaptığından ise emin olmalısın.";
                case "Kova":
                    return "Sevgili Kova, bugün toparlayan ve bir araya getiren bir güce sahip olabilirsin. Tüm sevdiklerini bir araya getirebilir, küsleri barıştıran ve iyiliği saçan bir duruş sergileyebilirsin. Hayatındaki hemen herkese güzel enerjiler, güçlü bir motivasyon ve mutluluk katabilirsin.";
                case "Balık":
                    return "Sevgili Balık, bugün hayatın merkezinde sen olacaksın adeta! Hayatını güzelleştirmek, yaralarını sarmak ve mutlu olmak için harekete geçeceksin. Hayatında olumsuz giden ne varsa ardında bırakacak, hafifleyeceksin.";
                default:
                    return "";
            }
        }

        //Burca karşılık gelen resim dosyasının adını döndüren metot
        private string BurcResmi(string burc)
        {
            switch (burc)
            {
                case "Koç": return "koc.png";
                case "Boğa": return "boga.png";
                case "İkizler": return "ikizler.png";
                case "Yengeç": return "yengec.png";
                case "Aslan": return "aslan.png";
                case "Başak": return "basak.png";
                case "Terazi": return "terazi.png";
                case "Akrep": return "akrep.png";
                case "Yay": return "yay.png";
                case "Oğlak": return "oglak.png";
                case "Kova": return "kova.png";
                case "Balık": return "balik.png";
                default: return "";
            }
        }

        private void ekle_button_Click(object sender, EventArgs e)
        {
            string ad = ad_textbox.Text;
            string soyad = soyad_textbox.Text;
            DateTime dogumTarihi = dateTimePicker1.Value;
            double kilo = double.Parse(kilo_textbox.Text);
            double boy = double.Parse(boy_textbox.Text);

            int gun = dogumTarihi.Day;
            int ay = dogumTarihi.Month;
            int yil = dogumTarihi.Year;

            double vki = VKI_Hesapla(kilo, boy);
            string vkiYorum = VKI_Yorum(vki);

            string burc = BurcAdi(gun, ay);
            string burcYorum = BurcYorumu(burc);
            string burcResmi = BurcResmi(burc);

            using (SQLiteConnection con = new SQLiteConnection(dbConnectionString))
            {
                con.Open();
                string sql = "INSERT INTO Users (Ad, Soyad, Gun, Ay, Yil, VKI, VKIYorum, Burc, BurcYorum, BurcResmi) " +
                             "VALUES (@Ad, @Soyad, @Gun, @Ay, @Yil, @VKI, @VKIYorum, @Burc, @BurcYorum, @BurcResmi)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@Gun", gun);
                    cmd.Parameters.AddWithValue("@Ay", ay);
                    cmd.Parameters.AddWithValue("@Yil", yil);
                    cmd.Parameters.AddWithValue("@VKI", vki);
                    cmd.Parameters.AddWithValue("@VKIYorum", vkiYorum);
                    cmd.Parameters.AddWithValue("@Burc", burc);
                    cmd.Parameters.AddWithValue("@BurcYorum", burcYorum);
                    cmd.Parameters.AddWithValue("@BurcResmi", burcResmi);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Kayıt Eklendi!");
            goster_button.PerformClick();//DataGridView'in yenilenmesi için
        }

        private void goster_button_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(dbConnectionString))
            {
                con.Open();
                string sql = "SELECT * FROM Users";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //Image tipinde yeni sütun ekleme
                    dt.Columns.Add("BurcResmiGorsel", typeof(Image));

                    //Her kayıt için, "BurcResmi" sütununda tutulan dosya adı kullanılarak resmi yükleme
                    foreach (DataRow row in dt.Rows)
                    {
                        string dosyaAdi = row["BurcResmi"].ToString();
                        //Resimlerin bulunduğu dizin.
                        string resimYolu = Path.Combine(Application.StartupPath, "Resimler", dosyaAdi);
                        if (File.Exists(resimYolu))
                        {
                            try
                            {
                                row["BurcResmiGorsel"] = Image.FromFile(resimYolu);
                            }
                            catch
                            {
                                row["BurcResmiGorsel"] = null;
                            }
                        }
                        else
                        {
                            row["BurcResmiGorsel"] = null;
                        }
                    }

                    //SQLite içerisinde string olarak tutulan burcresmi kısmının kaldırılması
                    dt.Columns.Remove("BurcResmi");

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["BurcResmiGorsel"].HeaderText = "Burç Resmi";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            int silinen = 0;
            string adsil = adsil_textbox.Text;
            string soyadsil = soyadsil_textbox.Text;
            DateTime tarihsil = dateTimePicker2.Value;
            int? gunsil = null;
            int? aysil = null;
            int? yilsil = null;

            if (tarihsil.Date != DateTime.Now.Date)
            {
                gunsil = tarihsil.Day;
                aysil = tarihsil.Month;
                yilsil = tarihsil.Year;
            }
            
            double? vkisil = null;
            String vkiyorumsil = vkiyorumsil_textbox.Text;
            if (!string.IsNullOrEmpty(vkisil_textbox.Text))
            {
                vkisil = double.Parse(vkisil_textbox.Text);
            }
            List<Veri> list = new List<Veri>();
            list.Add(new Veri(adsil, "Ad"));
            list.Add(new Veri(soyadsil, "Soyad"));
            list.Add(new Veri(gunsil, "Gun"));
            list.Add(new Veri(aysil, "Ay"));
            list.Add(new Veri(yilsil, "Yil"));
            list.Add(new Veri(vkisil, "VKI"));
            list.Add(new Veri(vkiyorumsil, "VKIYorum"));

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].veri is String)
                {
                    if(list[i].veri == "")
                    {
                        list.RemoveAt(i);//Null veya "" olanları listeden kaldırma
                        i = -1;
                    }
                }
                else
                {
                    if (list[i].veri == null)
                    {
                        list.RemoveAt(i);//Null veya "" olanları listeden kaldırma
                        i = -1;
                    }
                }
                
            }


            using (SQLiteConnection con = new SQLiteConnection(dbConnectionString))
            {
                con.Open();
                string sqlkomut = "DELETE FROM Users";
                string ek = " WHERE ";
                if (list.Count > 0)
                {
                    if(list.Count == 1)
                    {
                        ek += list[0].ad + "=" + $"'{list[0].veri}'";//Tek elemanlı durum
                    }
                    else
                    {
                        for (int k = 0; k < list.Count - 1; k++)
                        {
                            ek += list[k].ad + "=" + $"'{list[k].veri}' and ";//Çok elemanlı durum
                        }
                        ek += list[list.Count - 1].ad + "=" + $"'{list[list.Count - 1].veri}'";// son eleman yazılmadığı için
                    }
                    
                    sqlkomut += ek;//SQL komutunun tamamlanması
                }               
                using (SQLiteCommand cmd = new SQLiteCommand(sqlkomut, con))
                {
                    silinen = cmd.ExecuteNonQuery();
                }
            }
            String messageboxtext = $"{silinen} Kayıt Silindi";//Toplam kaç kayıtın silindiği
            MessageBox.Show(messageboxtext);
            goster_button.PerformClick();//DataGridView'in yenilenmesi için

        }
    }

    class Veri
    {
        public dynamic veri;
        public string ad;
        public Veri(dynamic veri, string ad) 
        {
            this.veri = veri;
            this.ad = ad;
        }
    }
}
