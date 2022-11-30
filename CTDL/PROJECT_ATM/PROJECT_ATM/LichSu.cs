using System;

    internal class LichSu
    {
    private string iDGiaoDich;
    private string loaiGiaoDich;
    private double soTienGiaoDich;
    private DateTime thoiGianGiaoDich;
   
    public string IDGiaoDich
    {
        get
        {
            return iDGiaoDich;
        }

        set
        {
            iDGiaoDich = value;
        }
    }

    public string LoaiGiaoDich
    {
        get
        {
            return loaiGiaoDich;
        }

        set
        {
            loaiGiaoDich = value;
        }
    }

    public double SoTienGiaoDich
    {
        get
        {
            return soTienGiaoDich;
        }

        set
        {
            soTienGiaoDich = value;
        }
    }

    public DateTime ThoiGianGiaoDich
    {
        get
        {
            return thoiGianGiaoDich;
        }

        set
        {
            thoiGianGiaoDich = value;
        }
    }

    public string toString()
    {
        return $"{IDGiaoDich,-15}{LoaiGiaoDich,-15}{SoTienGiaoDich,-15}{ThoiGianGiaoDich,-15}";
    }
    public LichSu(string iDGiaoDich, string loaiGiaoDich, double soTienGiaoDich, DateTime thoiGianGiaoDich)
    {
        this.IDGiaoDich = iDGiaoDich;
        this.LoaiGiaoDich = loaiGiaoDich;
        this.SoTienGiaoDich = soTienGiaoDich;
        this.ThoiGianGiaoDich = thoiGianGiaoDich;
    }


}

