Random r = new Random();
char[] a = new char[10];
for(int i = 0; i < a.Length; i ++)
{
    a[i] = (char)r.Next(0x0410, 0x44F);
    if (a[i] == '0' || a[i] == '1' || a[i] == '2' || a[i] == '3' || a[i] == '4' || a[i] == '5' || a[i] == '6' || a[i] == '7' || a[i] == '8' || a[i] == '9') a[i] = '*';
    Console.Write(a[i]);
}