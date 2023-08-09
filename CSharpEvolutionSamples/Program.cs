using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEvolutionSamples
{
                               

    public class Program
    {
        #region Record Structs


        /*          Grafiksel bir uygulamada, 
        her bir şeklin koordinatlarını ve boyutunu saklamak için 
        bu yapıları kullanabilirsiniz
        */

        public record struct Point(int X, int Y);


        Point p1 = new Point(5, 10);
        Point p2 = new Point(8, 12);


        #region Ne işe yarar
        /*
         * C# 10 ile birlikte gelen "Record Structs",
         * performans gereksinimleri olan senaryolarda kullanılmak üzere 
         * tasarlanmıştır. Bu yapılar, genellikle sadece veri taşımak için 
         * kullanılır ve daha hızlı ve düşük bellek tüketimi sunar. 
         * Klasik referans tipi sınıflarına kıyasla daha hızlıdır çünkü 
         * yapılar yığın bellekte depolanırken sınıflar heap bellekte depolanır.
         */
        #endregion


        #endregion

        static void Main(string[] args)
        {
                                                                  /***************************
                                                                  ******                ******
                                                                  ******    C# 10.0     ******
                                                                  ******                ******
                                                                  ***************************/


            #region Improvements of Structure Types

            /*
             Bir dikdörtgenin genişliğini ve yüksekliğini belirten bir yapı
            tanımlayarak, farklı dikdörtgenler oluşturabilirsiniz
             */


            Rectangle rect = new Rectangle();
            Rectangle resizedRect = rect with { Width = 10, Height = 20 };


            #region Ne İşe Yarar

            /*
             Yapı tiplerindeki geliştirmeler, 
            yapılara yeni yetenekler ekler ve daha esnek hale getirir.
            Örneğin, instance parametresiz kurucu tanımlayarak 
            bir yapının varsayılan değerlerini ayarlayabilir ve 
            with ifadesini kullanarak mevcut bir yapının
            bir kopyasını alıp belirli alanları değiştirebilirsiniz.
             */


            #endregion

            #endregion


            #region Interpolated String Handlers

            /*
            Bir rapor oluştururken, 
            tablo sütunlarının hizalanması için 
            özelleştirilmiş metin formatlamaları yapabilirsiniz.

            Kullanıcıya özel mesajlar oluştururken, 
            metin içeriğini belirli bir genişlikte hizalayabilirsiniz.
            */



            // Örnek 2: İnterpolasyon handler ile özel formatlama
            string message = "Hello";
            string formattedMessage = new StringFormatter().Format(message);



            #region Ne işe Yarar
            /*
             İnterpolasyon handler'ları, 
            özel bir formatlama veya dönüşüm yapmadan önce 
            metin içeriğini düzenlemek için kullanılır. 
            Bu, metin formatlamayı daha esnek hale 
            getirir ve özelleştirilmiş çıktılar oluşturmanıza yardımcı olur.
             */
            #endregion

            #endregion


            #region Global Using Directives
            /*
             Büyük projelerde, 
            birden çok sınıfın aynı isim alanında yer aldığı durumlar olabilir. 
            Dosya kapsamlı isim alanı bildirimi, bu durumları daha iyi yönetmenizi sağlar.

            Farklı isim alanlarında bulunan aynı isimdeki sınıfları 
            ayırt etmek ve isim çakışmalarını önlemek için 
            dosya kapsamlı isim alanı kullanabilirsiniz.
            */



            // namespace GlobalUsingExample
            StringBuilder sb = new();
            Console.WriteLine("global using directives kullanıyorum.Yeniliklere açık olmak çok güzel");

            /*
            Dosya kapsamlı isim alanı bildirimi,
            bir dosyanın içeriğini belirli bir isim alanı içine yerleştirerek 
            dosya yönetimini ve isim alanlarını daha düzenli hale getirir.
            */

            #region Ne İşe Yarar




            #endregion


            #endregion


            #region Extended Property Patterns
            /*
            Bir uygulamada kullanıcıların yaşlarına göre 
            farklı işlemler yapmanız gerektiğinde, 
            özellik desenlerini kullanarak yaşa göre gruplamalar 
            yapabilirsiniz.
             */



            object person = new Person { Name = "Alice", Age = 30 };
            if (person is Person { Age: >= 18 } adult)
            {
                Console.WriteLine($"{adult.Name} is an adult.");
            }


            #region Ne İşe Yarar

            /*
             Genişletilmiş özellik desenleri,
            nesnelerin özelliklerini daha esnek ve anlamlı şekillerde 
            kontrol etmenizi sağlar. 
            Bu, özelliklerin belirli koşullara uyan nesneleri 
            bulma ve işleme yeteneğini artırır.
             */


            #endregion

            #endregion


            #region Lambda Expression Improvements

            /*
             Özellikle eski veya kullanımdan kaldırılmış 
            olan kod bloklarını 
            belirtmek için öznitelikleri kullanarak 
            lambda ifadelerini işaretleyebilirsiniz.
             */


            // Örnek 1: Lambda ifadesinin tipini belirtme
            Func<int, int> square = (int x) => x * x;

            // Örnek 2: Lambda ifadesine öznitelik ekleme
            Func<int, int> addOne = [Obsolete] (int x) => x + 1;

            #region Ne İşe Yarar

            /* İfadenin tipini belirtme ve öznitelik ekleme gibi özellikler
             * ekleyerek daha okunabilir ve bakımı daha kolay lambda 
             * ifadeleri oluşturmanıza yardımcı olur.*/

            #endregion



            #endregion


            #region Record Types Can Seal ToString()

            /*Bir kayıt türünde yer alan ToString() yöntemini mühürleyerek,
             * alt sınıfların bu yöntemi değiştirerek veya geçersiz kılarak
             * otomatik ToString() davranışını önleyebilirsiniz.*/



            // kullanımını Person class üzerinde gösterildi.


            #region Ne İşe Yarar
            /*Mühürlü ToString() yöntemi, 
             * kayıt türlerinin miras alındığı alt sınıflar için otomatik ToString() 
             * yöntemini önler. 
             * Bu, türetilmiş kayıt türlerinin ToString() yöntemini ana kayıt 
             * türünden devralmasını sağlar.*/

            #endregion


            #endregion


            #region Assignment and Declaration in Same Deconstruction

            /*
             İki değişkenin değerini değiştirmek için geçici bir değişken 
            kullanmak yerine, deconstruction ifadesini kullanarak
            doğrudan değişkenlerin değerlerini değiştirebilirsiniz.

             */

            //Değişkenleri değiştirme ve atama yapma
            int x = 10, y = 20;
            (x, y) = (y, x);


            int x1, y1;
            (x1, y1) = (30, 40);


            #region Ne İşe Yarar
            /*Aynı değişkenlerin hem tanımlandığı hem de atama yapıldığı 
                 * bir deconstruction ifadesi, 
                 * değişkenleri daha anlamlı ve kısa bir şekilde 
                 * değiştirmenizi veya atamanızı sağlar.*/
            #endregion



            #endregion


            #region Allow AsyncMethodBuilder Attribute on Methods

            /*
             Özel bir AsyncMethodBuilder türü oluşturarak,
            asenkron işlemleri daha iyi kontrol etmek ve özelleştirmek için
            AsyncMethodBuilder özniteliğini kullanabilirsiniz.
             */


            #region Ne İşe Yarar
            /*
             Bu özellik, bir metodu belirli bir AsyncMethodBuilder türü ile
            işaretlemek ve özelleştirmek için kullanılır. 
            Bu, metodu özelleştirilmiş bir şekilde 
            işaretlemek ve senkronizasyon veya performans iyileştirmeleri 
            yapmak için kullanılır.
             */

            #endregion

            #endregion


            #region Enhanced #line Pragma

            /*
             Özel bir metin tabanlı dil veya DSL için kodu daha anlamlı
            bir şekilde vurgulamak için yeni #line pragma 
            formatını kullanabilirsiniz
             */


            //#line 42 "myFile.txt"

            #region Ne İşe Yarar
            /*
             Bu özellik, özellikle DSL (Domain-Specific Language) 
            veya özel metin tabanlı dillerde kodun kaynak kodunun 
            daha doğru ve anlamlı bir şekilde vurgulanmasını sağlar.
            Debugging deneyimini geliştirebilir.
             */
            #endregion


            #endregion


        }
    }
}
