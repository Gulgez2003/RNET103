//string metin = "ksjdkj,kshkj   skjs. kjdskjd:ksdh+fgf";


//char[] separators = new char[] { ' ', '.', ':', '+', ',' };
//string[] strings = metin.Split(separators, StringSplitOptions.RemoveEmptyEntries);


//Console.WriteLine(string.Join(" ",strings));

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

//string[] mails = { "gulgaz.mm@gmail.com" };

//foreach (var mail in mails)
//{
//    int firstNamePosition = mail.IndexOf(".");
//    int lastNamePosition = mail.IndexOf("@");
//    int mailPosition
//    if (firstNamePosition < 0)
//        continue;
//    Console.WriteLine("Name: {0}",
//                   mail.Substring(0, firstNamePosition),
//                   mail.Substring(firstNamePosition + 1));
//}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////

//string text = "Console";

//int firsPposition = text.IndexOf('b');
//int lastPosition = text.LastIndexOf('b');
//if (firsPposition < 0 || lastPosition < 0)
//{
//    Console.WriteLine("Yoxdur");
//}
//else if (firsPposition != lastPosition)
//{
//    Console.WriteLine("Tekrarlanir");

//}
//else
//{
//    Console.WriteLine("Tekrarlanmir");

//}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;
using System.Text;

//void TestCase1()
//{
//    Stopwatch sw= Stopwatch.StartNew();
//    sw.Start();
//    sw.Stop();
//    Console.WriteLine("StringTest Time: {0} ms", sw.ElapsedMilliseconds);

//    sw.Restart();
//    sw.Start();
//    StringBuilderTest();
//    sw.Stop();
//    Console.WriteLine("StringTest Time: {0} ms", sw.ElapsedMilliseconds);
//}
//TestCase1();
BenchmarkRunner.Run<StringVsStringBuilder>();
class StringVsStringBuilder
{

    private const int NumberOfIterations = 100000;

    [Benchmark]
    public void StringTest()
    {
        string result = "";
        for (int i = 0; i < NumberOfIterations; i++)
        {
            result += " a";
        }
    }


    [Benchmark]
    public void StringBuilderTest()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < NumberOfIterations; i++)
        {
            sb.Append(" a");
        }
    }

}