
using System;
using System.Dynamic;

namespace SelectionSort
{
    class Program
    {


        //Mantık şu olabilir. "Dizideki ikinci elemandan başla (1.index), o sayısı solundaki ondan küçük sayının önüne koy"
         public void ComputeSelectionSort(int[] arr)
        {
            int key=0;
            for (int i = 0; i < arr.Length; i++)
            {

               for (int k = i; k>0 ; k--)
               {
                 if(arr[k]<arr[i])
                    {
                        key=arr[k+1];
                    }
               }
                //doğru yeri bulduktan sonra tüm replace edip kalan  elemanları kaydırmak için 
               for (int j = 0; j <i; j++)
               {
                
               }
            }
        }   



    static void Main()
    {
       //dersi 10.Dakikadan 17.dakikaya kadar  izle mantığı iyice anlatılıyor.  
       // sadece tek bir sayının yanlış yerde olduğu durumlarda o(n)dir. Bunu algoritmada kontrol etmeliyim
    }
    }
}