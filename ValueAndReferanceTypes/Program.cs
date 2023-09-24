using System;

namespace ValAndRef
{

    class Program
    {
        public static void Main(string[] args)
        {
            //STACK
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            Console.WriteLine(number1); // 30

            //HEAP
            int[] numbers1 = {10, 20, 30};
            int[] numbers2 = {100,200, 300};
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]); // 999 

            /*
             *int, double vb. değişkenler birer value iken 
             *array, class, interface birer referanca'tır. 
             *
             *bellekte stack ve heap şeklinde iki alan var,
             *value stack'te tanımlanır.
             *referance ise heap'te tanımlanır.
             *
             *number1 ve number2'yi tanımladığında stackte tanımlanırlar ve
             *number1 a number2 value'yu eşitlersen değeri stack'te kopyalar (atar)
             *
             *ama number1 ve number2 arraylerini tanımladığında stackte oluşurlar ve 
             *heap'te değerlerinin bulunduğu alana referans ederler (pointer gibi)
             *eski point edilen yer ise dotnet'in garbage collector isimli çöp toplayıcısı
             *tarafından bellekten atılır.
             *
             *
             *bu nedenle number1 = number2 eşitlemesi yaptığımızda 
             * değişen şey bulundurdukları değerler değil referans ettikleri 
             * heap bölgesidir. bu eşitleme ile numbers1 ve numbers2 aynı yere referans eder 
             * ve bu referens bölgeesindeki değerlre değiştiğinde numbers1 sorgulamada bu değişen
             * güncel değerleri gösterir. 
             */

        }
    }
}

