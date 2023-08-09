using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEvolutionSamplesVer._11
{
    public class Program
    {
                                                                  /***************************
                                                                  ******                ******
                                                                  ******    C# 11.0     ******
                                                                  ******                ******
                                                                  ***************************/
        static void Main(string[] args)
        {

            #region  Raw String Literals (Ham Dize Harf Dizileri)

            /*
             dize harf dizileri için yeni bir format sunar. 
            Bu format, dize içerisinde kaçış dizilerine gerek kalmadan 
            özel karakterleri içerebilmenizi sağlar. 
            Özellikle, uzun ve karmaşık dize ifadeleri oluştururken 
            daha temiz ve okunabilir kod yazmanıza yardımcı olur.
             * """ olara kullanılır .*/
             
            string longMessage = @"""
            This is a long message.
            It has several lines.
            Some are indented
             more than others.
            Some should start at the first column.
            Some have ""quoted text"" in them.
            """;

            #region Ne İşe Yarar
            /*
             
            Genel nitelikler,
            bir sınıfı veya bir yöntemi niteliklerle özelleştirmek istediğinizde 
            kullanılır. Özel nitelikler oluşturmak yerine, 
            tür parametrelerini kullanarak genel bir nitelik tanımlayabilirsiniz.

            Artıları:
            Genel nitelikler, daha esnek ve yeniden kullanılabilir nitelikler 
            oluşturmanızı sağlar. Özellikle tür parametrelerini kullanarak 
            geniş bir nitelik yelpazesi oluşturabilirsiniz.*/

            #endregion


            #endregion


            #region Numeric IntPtr and UIntPtr (Sayısal IntPtr ve UIntPtr)
            /*
             Bu, özellikle bellek adreslemesi veya işaretçi işlemleri gibi
            durumlarda daha tutarlı ve okunabilir kod yazmanızı sağlar.
             */


            //nint number = 42;
            // nuint unsignedNumber = 123;

            #region Ne İşe Yarar
            /*Bu özellik, nint ve nuint türlerini 
             * System.IntPtr ve System.UIntPtr türleriyle özdeşleştirerek 
             * sayısal işlemleri daha tutarlı bir şekilde yapmanıza olanak tanır.*/
            #endregion


            #endregion


            #region Newlines in String Interpolations (Dize İnterpolasyonlarında Yeni Satırlar)
          
            /*
             Dize interpolasyonları içindeki { ve } karakterleri arasındaki
            metin artık çoklu satırları kapsayabilir. 
            Bu özellik, daha uzun C# ifadelerini içeren dize interpolasyonlarını 
            daha okunabilir hale getirir.
             */


            string message = $"This is a long message.{Environment.NewLine}" +
                 $"It spans multiple lines.";


            #region Ne İşe Yarar

            /*
            Daha uzun ve karmaşık ifadeleri daha düzenli bir şekilde yazmanızı 
            sağlar, böylece kodunuz daha anlaşılır ve bakımı daha kolay hale gelir.
            */

            #endregion

            #endregion


            #region  List Patterns (Liste Desenleri)

            /*
             Liste desenleri, bir liste veya dizi içindeki elemanların dizilişini 
            eşleme imkanı sağlar. Bu özellikle, bir dizi veya liste içinde belirli 
            bir sıralamayı aramak veya öğeleri belirli özelliklere göre 
            eşleştirmek istediğinizde kullanışlıdır.
             */

            //bool IsOneTwoThree(List<int> list) => list is { 1, 2, 3 };


            #region Ne İşe Yarar
            /*
             zellikle koleksiyonlar üzerinde desen eşleme yapmanın daha 
            basit ve doğrudan bir yolunu sunar, böylece karmaşık koşulları 
            daha sade ve anlaşılır bir şekilde ifade edebilirsiniz.
             */
            #endregion


            #endregion

        }
    }
}
