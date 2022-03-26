using System;

namespace Rot
{     
                                            //This program was coded by Özhan Yıldırım. 
                                            //Heimdallrson 
    class Program
    {
        static double mysqrt(double number)  //mysqrt isimli bir metod oluşturup number parametresini veriyorum

        {
          
            double root = 1;    //root değişkenine 1 değerini veriyorum 
            int i = 0;         //i değişkenine 1 değerini veriyorum


            //babil metodu adı verilen yol ile girilen sayının karekökünü hesaplama işlemi 


                
            
            /* kısaca babillilerin kullandığı iteratif bir karekök hesaplama yöntemi.
              örneğin, karekök(11)'i bulmak istiyoruz:
             karekök(9)=3 ve karekök(16)=4 olduğuna göre bu ikisi arasında bir şey olmalı. önce bir tahmin yapmak gerek. 
                     tahminimiz 3,5 olsun.
                     adım-1: (3,5 + 11/3,5)/2=3,321
                     adım-2: (3,321 + 11/3,321)/2=3,316
                     adım-3: (3,317 + 11/3,317)/2=3,316
                     adım-2 ve adım-3 aynı sonucu verdi. demek ki karekök(11)=3,316'dir. */
            while (true)
            {
                i = i + 1;
                root = (number / root + root) / 2;            //yukarıda anlattığım işlemler yapılıyor                                                 
                if (i == number + 1) { break; }                    
            }

            return root;  //karekök sonucunu geri döndürüyorum

        }
        static void Main(string[] args)
        {
            Console.Write("enter a number and watch the magic:");  //kullanıcıdan sayı girişi alıyorum
            int number = Convert.ToInt32(Console.ReadLine()); //kullanıcının girdiği sayıyı number değişkenine atıyorum 

            double rots;     //rots isimli içi boş bir değişken oluşturuyprum
            rots = mysqrt(number);  //rot değişkeninin içini mysqrt metodundan gelen değerle dolduruyorum
            Console.WriteLine(rots);  //rots değişkeninin değerini ekrana yazdırıyorum 

        }


    }
}
