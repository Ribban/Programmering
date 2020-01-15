using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Name
{
    public class DataSample<T>
    {
        private T theData;
        public DataSample(T theData)
        {
            this.theData = theData;
        }
        public T GetData()
        {
            return theData;
        }
        public String MyToString()
        {
            return theData.ToString();
        }
        public static T getMiddleElement(T[] arr)
        {
            T element = arr[arr.Length / 2];
            return element;
        }
        static void Main(string[] args)
        {
            String[] words = { "C++", "MacOS", "C#", "Android", "Python" };
            String middle = DataSample<string>.getMiddleElement(words);
        }
    }
}
