using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();
        Singa singa =   new Singa("Singa",20,4);
        Gajah gajah =   new Gajah("Gajah", 50, 4);
        Ular ular   =   new Ular("Ular", 2, 1);
        Buaya buaya =   new Buaya("Buaya", 5, 3);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.TampilkanHewan();

        Console.WriteLine("\nMemanggil method Suara() untuk beberapa hewan berbeda : ");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        Console.WriteLine("\n========Method Khusus=========");
        singa.Mengaum();
        ular.Merayap();
    }
}

class Hewan
{
    public string nama;
    public int umur;

    public Hewan (string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }
    public virtual string  Suara()
    {
        return ("Hewan ini bersuara");
    }
    public virtual string Infohewan()
    {
        return ($"Nama : {nama}\nUmur : {umur} tahun");
    }
}


class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string nama,int umur,int JumlahKaki) : base(nama,umur)
    {
        this.JumlahKaki = JumlahKaki;
    }

    public override string Infohewan()
    {
        return base.Infohewan()+($"\nJumlah kaki : {JumlahKaki}");
    }
}



class Reptil : Hewan
{
    public int panjangTubuh;

    public Reptil(string nama, int umur, int panjangTubuh) : base(nama, umur)
    {
        this.panjangTubuh = panjangTubuh;
    }

    public override string Infohewan()
    {
        return base.Infohewan() + ($"\nPanjang Tubuh : {panjangTubuh} Meter");
    }
}



class Singa : Mamalia
{
    public Singa(string nama, int umur, int JumlahKaki) : base(nama, umur, JumlahKaki)
    {

    }

    public override string Suara()
    {
        return ("Singa Sedang Bersuara");
    }

    public void Mengaum()
    {
        Console.WriteLine("Singa Sedang Mengaum");
    }

}



class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int JumlahKaki) : base(nama, umur, JumlahKaki)
    {

    }

    public override string Suara()
    {
        return ("Gajah Sedang Bersuara");
    }
}



class Ular : Reptil
{
    public Ular(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }
    public void Merayap()
    {
        Console.WriteLine("Ular Sedang Merayap");
    }
    public override string Suara()
    {
        return ("Ular Sedang Bersuara");
    }
}



class Buaya : Reptil
{
    public Buaya(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }
    public override string Suara()
    {
        return ("Buaya Sedang Bersuara");
    }
}


class KebunBinatang
{
    private List<Hewan> DaftarHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        DaftarHewan.Add(hewan);
        Console.WriteLine($"{hewan.nama} berhasil ditambahkan ke kebun binatang.");
    }

    public void TampilkanHewan()
    {
        Console.WriteLine("\nDaftar hewan di kebun binatang:");
        foreach (var hewan in DaftarHewan)
        {
            Console.WriteLine($"\n{hewan.Infohewan()}");
           
        }
    }
}