using System;
using System.IO.Compression;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using ZipArchive zipArchive = ZipFile.Open(@"../../../copyMe.zip", ZipArchiveMode.Create);
        zipArchive.CreateEntryFromFile("copyMe.png", "copyMe.png");
    }
}
 