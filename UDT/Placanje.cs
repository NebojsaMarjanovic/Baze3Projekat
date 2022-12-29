using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedType(Format.Native)]
public struct Placanje : INullable
{

    public Placanje(double iznos, int brRata)
    {
        this.iznos = iznos;
        this.brojRata = brRata;
        _null = false;
    }

    public bool IsNull
    {
        get
        {
            // Put your code here
            return _null;
        }
    }


    public static Placanje Null
    {
        get
        {
            Placanje h = new Placanje();
            h._null = true;
            return h;
        }
    }


    private double iznos;
    private int brojRata;

    public override string ToString()
    {
        if (this.IsNull)
            return "0";
        else
        {
            string delim = new string((new char[] { ';' }));
            return (this.iznos + delim + this.brojRata);
        }
    }

    public static Placanje Parse(SqlString s)
    {
        if (s.IsNull)
            return Null;
        else
        {
            Placanje p = new Placanje();
            string str = Convert.ToString(s);
            string[] a = null;
            a = str.Split(new char[] { ';' });
            double iznos = Convert.ToDouble(a[0]);
            ValidateBroj((int)iznos);
            p.iznos = iznos;
            int brojRata = Convert.ToInt32(a[1]);
            ValidateBroj(brojRata);
            p.brojRata = brojRata;
            return p;
        }
    }

    private static void ValidateBroj(int broj)
    {
        if (broj < 0)
        {
            throw new ArgumentOutOfRangeException("Broj ne može biti manji od 0");
        }
    }


    public double Iznos
    {
        get
        {
            return this.iznos;
        }
        set
        {
            this.iznos = value;
            this._null = false;
        }
    }

    public int BrojRata
    {
        get
        {
            return this.brojRata;
        }
        set
        {
            this.brojRata = value;
            this._null = false;
        }
    }

    public double IzracunajRatu()
    {
        if (this.brojRata == 0)
        {
            return 0;
        }
        return this.Iznos / this.BrojRata;
    }

    public override int GetHashCode()
    {
        if (this.IsNull)
            return 0;
        return this.ToString().GetHashCode();
    }

    public int CompareTo(object other)
    {
        if (other == null)
            return 1;   //by definition

        Placanje p = (Placanje)other;
        if (p.Equals(null))
            throw new ArgumentException("the arugment to compare is not a Placanje");
        if (this.IsNull)
        {
            if (p.IsNull)
                return 0;
            return -1;
        }
        if (p.IsNull)
            return 1;
        return this.ToString().CompareTo(p.ToString());
    }

    public void Write(System.IO.BinaryWriter w)
    {
        byte header = (byte)(this.IsNull ? 1 : 0);
        w.Write(header);
        if (header == 1)
        {
            return;
        }
        ValidateBroj((int)this.Iznos);
        w.Write(this.Iznos);
        ValidateBroj(this.brojRata);
        w.Write(this.brojRata);
    }

    public void Read(System.IO.BinaryReader r)
    {
        byte header = r.ReadByte();
        if (header == 1)
        {
            this._null = true;
            return;
        }
        this._null = false;
        double iznos = r.ReadDouble();
        ValidateBroj((int)iznos);
        this.iznos = iznos;
        int brojRata = r.ReadInt32();
        ValidateBroj(brojRata);
        this.brojRata = brojRata;
    }

    //  Private member
    private bool _null;
}
