// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.Write("masukkan nama anda: ");
string namaMH = Console.ReadLine();

bool cek = namaMH == "Rizky Kusuma Nugraha";

if (cek)
{
    Console.WriteLine("Anjay mabar " + namaMH);
} else
{
    Console.WriteLine("Lu bukan mahasiswa bjir");
}
