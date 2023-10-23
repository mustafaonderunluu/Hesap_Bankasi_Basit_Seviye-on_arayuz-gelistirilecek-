// See https://aka.ms/new-console-template for more information

class HesapBankasi
{
    static double bakiye = 0;


    static void Main()
    {
        Console.WriteLine("Hesap Bankasına Hoşgeldiniz ");
        while (true)
        {
            Console.WriteLine("\n Lütfen yapmak istediğiniz işlemi seçin : ");
            Console.WriteLine("1. Para yatırma");
            Console.WriteLine("2. Para Çekme");
            Console.WriteLine("3. Bakiye Sorgulama");
            Console.WriteLine("4. Çıkış");

            string kullaniciGirdisi = Console.ReadLine();

            try
            {
                int secim = Convert.ToInt32(kullaniciGirdisi);

                switch (secim)
                {
                    case 1:
                        // 1. seçeneğe göre yapılacak işlem
                        Console.WriteLine("Para yatırma işlemi seçildi.");
                        // Burada para yatırma işlemi kodunu ekleyebilirsiniz.
                        break;

                    case 2:
                        // 2. seçeneğe göre yapılacak işlem
                        Console.WriteLine("Para çekme işlemi seçildi.");
                        // Burada para çekme işlemi kodunu ekleyebilirsiniz.
                        break;

                    case 3:
                        // 3. seçeneğe göre yapılacak işlem
                        Console.WriteLine("Bakiye sorgulama işlemi seçildi.");
                        // Burada bakiye sorgulama kodunu ekleyebilirsiniz.
                        break;

                    case 4:
                        Console.WriteLine("Çıkış yapılıyor...");
                        return; // Programı sonlandırır.

                    default:
                        Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçerli bir sayı girmelisiniz.");
            }

        }
        static void parayatirma()
        {
            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz :");
            double yatırılanmiktar = Convert.ToDouble(Console.ReadLine());
            if (yatırılanmiktar > 0)
            {
                bakiye += yatırılanmiktar;
                Console.WriteLine("Para yatırma işlemi başarılı. Yeni Bakiye :" + bakiye);
            }
            else
            {
                Console.WriteLine("Geçersiz miktar. Lütfen tekrar deneyiniz..");
            }
        }
        static void paraçekme()
        {
            Console.WriteLine("Çekmek istediğiniz tutarı giriniz : ");
            double çekilenmiktar = Convert.ToDouble(Console.ReadLine());
            if (çekilenmiktar > 0 && çekilenmiktar <= bakiye)
            {
                bakiye -= çekilenmiktar;
                Console.WriteLine("Para Çekme işlemi başarılı. Yeni Bakiye :" + bakiye);


            }
            else if (çekilenmiktar <= 0)
            {
                Console.WriteLine("Geçersiz miktar. Lütfen tekrar deneyiniz..");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");

            }
        }
        static void bakiyesorgulama()
        {
            Console.WriteLine("Mevcut bakiye " + bakiye);
        }
    }
}