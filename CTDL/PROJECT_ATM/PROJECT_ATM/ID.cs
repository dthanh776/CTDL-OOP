using System;

    internal class ID
    {
    //fields
    private string idUser;
    private string tenUser;
    private double soDuUser;
    private string loaiTienTe;
    //constructor
    public ID(string idUser, string tenUser, string soDuUser, string loaiTienTe)
    {
        this.IdUser = idUser;
        this.TenUser = tenUser;
        double.TryParse(soDuUser, out this.soDuUser);
        this.LoaiTienTe = loaiTienTe;
    }
    //properties
    public string IdUser
    {
        get
        {
            return idUser;
        }

        set
        {
            idUser = value;
        }
    }

    public string TenUser
    {
        get
        {
            return tenUser;
        }

        set
        {
            tenUser = value;
        }
    }

    public double SoDuUser
    {
        get
        {
            return soDuUser;
        }

        set
        {
            soDuUser = value;
        }
    }

    public string LoaiTienTe
    {
        get
        {
            return loaiTienTe;
        }

        set
        {
            loaiTienTe = value;
        }
    }

    //method
    public  string toString()
    {
        return $"{IdUser}#{TenUser}#{SoDuUser}#{LoaiTienTe}";
    }
  
}

