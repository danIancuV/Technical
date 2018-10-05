using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Collections;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //var db = new filedbEntities();

            //IEnumerable<SerializedFile> enumfiles = db.SerializedFiles;
            //IEnumerable<SerializedFile> fileList = enumfiles.Where(x => x.Id > 2);

            //foreach (var item in fileList)
            //{
            //    Console.WriteLine(item.FileContent);
            //}

            //IQueryable<SerializedFile> queryfiles = db.SerializedFiles;
            //IEnumerable<SerializedFile> fileList1 = queryfiles.Where(x => x.Id > 2).OrderBy(x => x.Id).Skip(1).Take(1).ToList();

            //bool isInDb = queryfiles.Where(x => x.Id > 2).Any(x => x.FileContent.Contains("wirtek1"));

            //IEnumerable<bool> fileList3 = queryfiles.Where(x => x.Id > 2).Select(x => x.FileContent.Contains("wirtek1")).ToList();

            //IEnumerable<bool> fileList4 = queryfiles.Where(x => x.Id > 2).Select(x => x.FileContent.Contains("wirtek1")).ToList();

            //SerializedFile first = queryfiles.First(x => x.Id > 2);

            //SerializedFile single = queryfiles.Single(x => x.Id > 2 && x.FileContent.Contains("wirtek1"));


            //foreach (var item in fileList1)
            //{
            //    Console.WriteLine(item.FileContent);
            //}

            //Console.WriteLine(isInDb);

            //Console.WriteLine(first.Name);

            //Console.WriteLine(single.Name);          
    
            using (var db = new filedbEntities())
            {
                IEnumerable<string> myParamEnumerable = db.SerializedFiles.Select(serializedFile => serializedFile.FileContent);

                MyEnumerable<string> myEnumerable = new MyEnumerable<string>(myParamEnumerable);
                
                Console.WriteLine(myEnumerable);

                IEnumerable<int> myNbParamEnumerable = db.SerializedFiles.Select(serializedFile => serializedFile.Id);               

                MyEnumerable<int> myNbEnumerable = new MyEnumerable<int>(myNbParamEnumerable);                

                Console.WriteLine(myNbEnumerable);
            }
        }
    }
}

public class MyEnumerable<T> : IEnumerable<T>
{
    private readonly IEnumerable<T> _myEnumerable;

    public MyEnumerable(IEnumerable<T> myEnumerable)
    {
        _myEnumerable = myEnumerable;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _myEnumerable.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public override string ToString()
    {
        string myString = "";
        foreach (var item in _myEnumerable)
        {
           myString += String.Concat(" ", item);          
        }
        return myString;
    }
}



