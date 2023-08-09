using CSharpVersionSamples12.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpVersionSamples12.Classes.Person;

namespace CSharpVersionSamples12
{
    
    public class Program
    {

        static void Main(string[] args)
        {
                                                                  /***************************
                                                                  ******                ******
                                                                  ******    C# 12.0     ******
                                                                  ******                ******
                                                                  ***************************/


            #region Primary Constructors (Ana Yapıcılar)

            /*
            Person Classı oluşturuldu.
            Kodun daha okunabilir olmasını sağlar. 
            Yapıcıları daha az karmaşık hale getirir ve ana yapıcıların 
            kullanımını teşvik eder.
            */


            var person = new Person("John Doe", 30);

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            #region Ne İşe Yarar
            /*
             Sınıf veya yapı tanımlarında ana yapıcılar kullanarak 
            daha temiz ve okunabilir kod oluşturabilirsiniz. 
            Bu özellik, sınıfları ve yapıları daha tutarlı ve basit bir şekilde
            başlatmanızı sağlar.
             */
            #endregion

            #endregion



            #region Default Lambda Parameters (Varsayılan Lambda Parametreleri)

            /*
             Lambda ifadelerini daha kolay ve esnek hale getirir, okunabilirliği artırır.
             */

            Func<int, int, int> add = (x, y) => x + y;

            int result = add(3, 5); // 3 + 5 = 8

            #region Ne İşe Yarar
            /*
             Lambda ifadeleri içindeki parametrelere varsayılan değerler atayarak,
            daha esnek ve okunabilir kod yazabilirsiniz.
             */
            #endregion


            #endregion



            #region Inline Arrays (Satır İçi Diziler)

            /*
             Daha hızlı ve daha verimli kod yazmanızı sağlar, 
            uygulama performansını artırır.
             */
            NumberList numbers;
            numbers.Number1 = 10;
            numbers.Number2 = 20;
            numbers.Number3 = 30;
            numbers.Number4 = 40;
            numbers.Number5 = 50;

            Console.WriteLine($"Numbers: {numbers.Number1}, {numbers.Number2}, {numbers.Number3}, {numbers.Number4}, {numbers.Number5}");

            #region Ne İşe Yarar
            /*
             Yapı içindeki sabit boyutlu dizileri kullanarak, 
            performansı artırabilir ve bellek kullanımını optimize edebilirsiniz.
             */
            #endregion



            #endregion



            #region Interceptors (Arabulucular)

            /*
             
            Kodun mevcut işlevselliğini değiştirmek ve özelleştirmek için
            bir yol sağlar. Ancak dikkatli kullanılmalıdır ve deneysel 
            bir özelliktir.
            */


            Calculator calculator = new Calculator();
            int dataOK = calculator.Add(5, 7);

            Console.WriteLine($"Result: {result}");



            #region Ne İşe Yarar

            /*
            Arabulucular, kodun semantiğini derleyici zamanında değiştirerek 
            mevcut kodu yönlendirmenizi 
            sağlar. Bu özellik, kodunuzu daha esnek hale getirir ve 
            özelleştirmenizi sağlar.
            */

            #endregion


            #endregion
        }
    }
}
