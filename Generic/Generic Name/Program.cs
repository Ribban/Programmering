using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSample<string> dss = new DataSample<string>("Forty-two");
            DataSample<int> dsi = new DataSample<int>(42);
            String s = dss.GetData();
            int i = dsi.GetData();
            Console.WriteLine(String.Format("s={0}, i={1}", s, i));
            Console.ReadKey();
        }
    }
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
    }
}
