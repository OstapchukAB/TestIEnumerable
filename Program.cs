int? a=null;
var s = new int?[] { 2 ,3 ,5,a ,7 ,11 ,13 ,17 ,19 ,23 ,29 ,31 ,37 ,41 ,43 };
//var s = new int[] { 1};
//var e = s.AsEnumerable();
//string s = null;
Display(s);

static void Display<T>(System.Collections.Generic.IEnumerable<T> values)
{
    if (values == null)
        return;
    int i = 0;
    var enumerator = values.GetEnumerator();
    while (i < 10 && enumerator.MoveNext())
    {
        System.Console.WriteLine($"{i} {enumerator.Current}");
        i++;
    }
    if (enumerator is System.IDisposable)
        enumerator.Dispose();
}


