using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
internal class Program
{
    static void Main(string[] args)
    {
        string a = "";
        int Main, Admin, User;
        //LinkedList L = new LinkedList();
        LinkedList<Admin> ad = new LinkedList<Admin>();
        LinkedList<User> user = new LinkedList<User>();
        LinkedList<ID> id = new LinkedList<ID>();
        DocFileAdmin(ad, "Admin.txt");
        //XuatFileAdmin(ad);
        DocFileUser(user, "TheTu.txt");
        //XuatFileUser(user);
        //DocFileID(id, "[ID].txt");
        //XuatFileID(id);
        ghiFileID(id);
        do
        {
        first:
            Console.Clear();
            MenuMain();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Vui long chon chuc nang: ");
            Main = int.Parse(Console.ReadLine());
            switch (Main)
            {
                case 1:
                    //Dang nhap
                    Console.Clear();
                    int iDem = 3;
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Clear();
                        if (DangNhapMenuAdmin(ad) == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nDang nhap thanh cong !!!");
                            Thread.Sleep(1000);
                            goto second;
                        }
                        else
                        {
                            iDem--;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\nSai tai khoan hoac mat khau !!! <Ban con {iDem} lan nhap>");
                            //Console.ReadKey();
                            if (iDem == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n--->Ban nhap sai qua 3 lan !!!");
                                Console.WriteLine(" Quay lai man hinh dang nhap");
                                Console.ReadKey();
                                goto first;
                            }
                            Console.ReadKey();

                        }
                    }
                //goto first;
                second:
                    do
                    {

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        MenuAdmin();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Vui long chon chuc nang: ");
                        Admin = int.Parse(Console.ReadLine());
                        switch (Admin)
                        {
                            case 1:
                                Console.Clear();
                                XuatFileUser(user);
                                break;
                            case 2:
                                Console.Clear();
                                themTaiKhoan(user);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Nhan phim bat ki de quay lai !!!");
                                break;
                            case 3:
                                Console.Clear();
                                xoaTaiKhoan(user);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Nhan phim bat ki de quay lai !!!");
                                break;
                            case 4:
                                Console.Clear();
                                moKhoaTaiKhoan(user);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Nhan phim bat ki de quay lai !!!");
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Nguoi dung chon thoat!!!");
                                break;
                        }
                        Console.ReadKey();
                    } while (Admin >= 1 && Admin <= 4);
                    break;
                case 2:
                    Console.Clear();
                    bool check = false;
                    string temp = DangNhapMenuUser(user);
                    for (LinkedListNode<User> p = user.First; p != null; p = p.Next)
                    {
                        if (temp == p.Value.Id)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nDang nhap thanh cong !!!");
                            Thread.Sleep(1000);
                            a = p.Value.Id;
                            check = true;
                            goto third;
                        }


                    }
                    if (check == false)
                    {
                        Console.WriteLine("\n--->Quay lai man hinh dang nhap");
                        Console.ReadKey();
                        goto first;
                    }
                    break;
                third:
                    Console.Clear();
                    do
                    {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        MenuUser();
                        Console.Write("Vui long chon chuc nang: ");
                        User = int.Parse(Console.ReadLine());

                        switch (User)
                        {
                            case 1:

                                xemThongTinUser(user, a);
                                break;
                            case 2:
                            quaylai:
                                int chon;
                                char ktRut;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                MenuRutTien(id);
                                Console.Write("Vui long chon so tien muon rut: ");
                                chon = int.Parse(Console.ReadLine());
                                switch (chon)
                                {
                                    case 1:
                                        rutTienNe(user, id, temp, 50000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto quaylai;
                                        }
                                        break;
                                    case 2:
                                        rutTienNe(user, id, temp, 100000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto quaylai;
                                        }
                                        break;
                                    case 3:
                                        rutTienNe(user, id, temp, 500000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto quaylai;
                                        }
                                        break;
                                    case 4:
                                        rutTienNe(user, id, temp, 1000000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto quaylai;
                                        }
                                        break;
                                    case 5:
                                        rutTienNe(user, id, temp, 3000000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto quaylai;
                                        }
                                        break;
                                    case 6:
                                        rutTienNe(user, id, temp, 10000000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto quaylai;
                                        }
                                        break;
                                    case 7:

                                        double soTienCanRut;
                                    nhaplai:
                                        Console.Write("Nhap so tien can rut: ");
                                        soTienCanRut = double.Parse(Console.ReadLine());
                                        Thread.Sleep(500);
                                        if (soTienCanRut < 50000)
                                        {
                                            Console.WriteLine("Nhap sai!!! So tien can rut phai lon hon 50.000 VND.");
                                            goto nhaplai;
                                        }

                                        if (soTienCanRut % 50000 != 0)
                                        {
                                            Console.WriteLine("Nhap sai!!! So tien can rut phai la boi so cua 50.");
                                            goto nhaplai;

                                        }
                                        else
                                        {
                                            rutTienNe(user, id, temp, soTienCanRut);
                                        }
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto quaylai;
                                        }
                                        break;
                                    default:
                                        Console.Write("Nguoi dung chon thoat!!!");
                                        break;
                                }

                                break;
                            case 3:
                            kttk:
                                string[] tk = null;
                                bool kttk = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Vui long nhap tai khoan can chuyen: ");
                                string tkChuyenTien = Console.ReadLine();
                                for (LinkedListNode<User> p = user.First; p != null; p = p.Next)
                                {
                                    if (p.Value.Id == tkChuyenTien && p.Value.Id != temp)
                                    {
                                        kttk = true;
                                    }
                                }
                                if (kttk == true)
                                {
                                    using (StreamReader sR = new StreamReader(@"D:\[" + tkChuyenTien + "]" + ".txt", true))
                                    {

                                        while (sR.Peek() != -1)
                                        {
                                            tk = sR.ReadLine().Split('#');
                                            ID DocTK = new ID(tk[0], tk[1], tk[2], tk[3]);

                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Tai khoan can chuyen khong ton tai, vui long kiem tra lai !!!");
                                    Console.ReadKey();
                                    Thread.Sleep(1000);
                                    goto kttk;
                                }
                                Console.Write("Tai khoan huong thu: " + tk[0]);
                                Console.WriteLine("\nTen nguoi huong thu: " + tk[1]);
                                MenuChuyenTien(id);
                                Console.Write("Vui long chon so tien muon chuyen: ");
                                chon = int.Parse(Console.ReadLine());
                                switch (chon)
                                {
                                    case 1:
                                        chuyenTienNe(user, id, tkChuyenTien, temp, 50000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto kttk;
                                        }
                                        break;
                                    case 2:
                                        chuyenTienNe(user, id, tkChuyenTien, temp, 100000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto kttk;
                                        }
                                        break;
                                    case 3:
                                        chuyenTienNe(user, id, tkChuyenTien, temp, 500000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto kttk;
                                        }
                                        break;
                                    case 4:
                                        chuyenTienNe(user, id, tkChuyenTien, temp, 1000000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto kttk;
                                        }
                                        break;
                                    case 5:
                                        chuyenTienNe(user, id, tkChuyenTien, temp, 3000000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto kttk;
                                        }
                                        break;
                                    case 6:
                                        chuyenTienNe(user, id, tkChuyenTien, temp, 10000000);
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto kttk;
                                        }
                                        break;
                                    case 7:
                                        double soTienCanChuyen;
                                    nhaplai:
                                        Console.Write("Nhap so tien can chuyen: ");
                                        soTienCanChuyen = double.Parse(Console.ReadLine());
                                        Thread.Sleep(500);
                                        if (soTienCanChuyen < 50000)
                                        {
                                            Console.WriteLine("Nhap sai!!! So tien can rut phai lon hon 50.000 VND.");
                                            goto nhaplai;
                                        }

                                        if (soTienCanChuyen % 50000 != 0)
                                        {
                                            Console.WriteLine("Nhap sai!!! So tien can rut phai la boi so cua 50.");
                                            goto nhaplai;

                                        }
                                        else
                                        {
                                            chuyenTienNe(user, id, tkChuyenTien, temp, soTienCanChuyen);
                                        }
                                        Console.Write("Ban co muon tiep tuc rut tien(Y/N): ");
                                        ktRut = char.Parse(Console.ReadLine());
                                        if (ktRut == 'Y' || ktRut == 'y')
                                        {
                                            goto kttk;
                                        }
                                        break;

                                    default:
                                        Console.Write("Nguoi dung chon thoat!!!");
                                        break;
                                }
                                break;
                            case 4:
                                Console.Clear();
                                lichSuGiaoDich(id, temp);
                                Console.WriteLine("Nhap phim bat ki de quay lai !!!");
                                break;
                            case 5:
                                doiMaPin(user, temp);
                                break;
                            default:
                                Console.Write("Nguoi dung chon thoat!!!");
                                break;
                        }
                        Console.ReadKey();
                    } while (User >= 1 && User <= 5);
                    break;
                default:
                    Console.WriteLine("Ban da thoat chuong trinh!!!");
                    break;
            }
        } while (Main >= 1 && Main <= 2);
        //dung man hinh
        Console.ReadKey();
    }
    static void doiMaPin(LinkedList<User> L,string temp)
    {
        bool check = false;
        Console.WriteLine("*****************DOI MA PIN*****************");
        Console.Write("Nhap ma pin cu: ");
        string pinCu = Console.ReadLine();
        for(LinkedListNode<User>p= L.First;p!=null;p=p.Next)
        {
            if(p.Value.Id==temp)
            {
                if(p.Value.Pin==pinCu)
                {
                    check = true;
                }
            }
        }
        if(check==true)
        {
            nhaplai:
            Console.Write("Nhap ma pin moi: ");
            string maPinMoi = Console.ReadLine();
            Console.Write("Xac nhan ma pin moi: ");
            string xacNhanPinMoi = Console.ReadLine();
            if(maPinMoi!=xacNhanPinMoi)
            {
                Console.WriteLine("Ma pin moi khong trung nhau !!! Vui long nhap lai");
                goto nhaplai;
            }
            else
            {
                Console.WriteLine("Doi ma pin thanh cong");
                for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
                {
                    if (p.Value.Id==temp)
                    {
                        p.Value.Pin = maPinMoi;
                        ghiFileTheTu(L);
                    }
                }
                
            }
        }
        else
        {
            Console.WriteLine("Ma pin khong chinh xac !!!!");
            Console.WriteLine("->>Quay lai man hinh menu !!!");
        }
    }
    static void lichSuGiaoDich(LinkedList<ID>L,string temp)
    {
        using (StreamReader sR = new StreamReader(@"D:\[LichSu" + temp + "]" + ".txt", true))
        {
            Console.WriteLine($"============Lich su giao dich cua tai khoan {temp}============");
            string s = null;
            while ((s=sR.ReadLine())!=null)
            {
                Console.WriteLine(s);
            }
        }
    }
    static void chuyenTienNe(LinkedList<User> L, LinkedList<ID> L1, string tkChuyen, string temp, double d)
    {
        double Max = 0;
        double MaxTK = 0;
        string tam = null;
        string[] t = null;
        string[] taikhoan = null;
        string path = @"D:\[" + temp + "]" + ".txt";
        string tk = @"D:\[" + tkChuyen + "]" + ".txt";
        using (StreamReader sR = new StreamReader(@"D:\[" + temp + "]" + ".txt", true))
        {
            while (sR.Peek() != -1)
            {
                t = sR.ReadLine().Split('#');
                ID ID = new ID(t[0], t[1], t[2], t[3]);
                Max = Convert.ToDouble(t[2]);

            }

        }
        if (Max <= 50000)
        {
            Console.WriteLine("So du khong du de chuyen tien");
        }
        if (Max - d <= 50000)
        {
            Console.WriteLine("So du khong du de thuc hien giao dich");
        }
        else
        {

            for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
            {
                if (p.Value.Id == temp)
                {
                    tam = p.Value.Pin;
                }
            }
            Console.Write("Nhap ma pin xac nhan: ");
            string pin = Console.ReadLine();
            if (tam == pin)
            {
                Max = Max - d;
                Console.WriteLine(" ->Chuyen tien thanh cong<- ");
                Thread.Sleep(500);
                Console.WriteLine(" So du hien tai cua ban la: {0}", Max);
                FileStream fl = new FileStream(path, FileMode.Create, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fl))
                {
                    sw.WriteLine($"{t[0]}#{t[1]}#{Max}#{t[3]}");
                }
                using (StreamReader sR = new StreamReader(@"D:\[" + tkChuyen + "]" + ".txt", true))
                {
                    while (sR.Peek() != -1)
                    {
                        taikhoan = sR.ReadLine().Split('#');
                        ID IDD = new ID(taikhoan[0], taikhoan[1], taikhoan[2], taikhoan[3]);
                        MaxTK = Convert.ToDouble(taikhoan[2]);
                    }
                }
                using (StreamWriter sw = new StreamWriter(@"D:\[LichSu" + temp + "]" + ".txt", true))
                {
                    sw.WriteLine("Loai giao dich: Chuyen tien");
                    sw.WriteLine($"{"ID huong thu",-15}{"Ten huong thu",-15}{"So tien",-15}{"Ngay giao dich",-15}");
                    LichSu newLS = new LichSu(tkChuyen, taikhoan[1], d, DateTime.Now);
                    sw.WriteLine(newLS.toString());
                }

                MaxTK = MaxTK + d;
                FileStream fltk = new FileStream(tk, FileMode.Create, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fltk))
                {
                    sw.WriteLine($"{taikhoan[0]}#{taikhoan[1]}#{MaxTK}#{taikhoan[3]}");
                }
                using (StreamWriter sw = new StreamWriter(@"D:\[LichSu" + tkChuyen + "]" + ".txt", true))
                {
                    sw.WriteLine("Loai giao dich: Nhan tien");
                    sw.WriteLine($"{"ID gui tien",-15}{"Loai giao dich",-15}{"So tien",-15}{"Ngay giao dich",-15}");
                    LichSu newLS = new LichSu(temp, "NHAN TIEN", d, DateTime.Now);
                    sw.WriteLine(newLS.toString());
                }
            }
            else
            {
                Console.WriteLine("Sai ma pin!!! Giao dich bi huy");
            }

        }

    }
    static void rutTienNe(LinkedList<User> L, LinkedList<ID> L1, string temp, double d)
    {
        double Max = 0;
        string[] t = null;
        string tam = null;
        string path = @"D:\[" + temp + "]" + ".txt";
        using (StreamReader sR = new StreamReader(@"D:\[" + temp + "]" + ".txt", true))
        {
            while (sR.Peek() != -1)
            {
                t = sR.ReadLine().Split('#');
                ID ID = new ID(t[0], t[1], t[2], t[3]);
                Max = Convert.ToDouble(t[2]);
                //L1.AddLast(ID);
            }

        }
        if (Max <= 50000)
        {
            Console.WriteLine("So du khong du de rut tien");
        }
        if (Max - d <= 50000)
        {
            Console.WriteLine("So du khong du de thuc hien giao dich");
        }
        else
        {
            for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
            {
                if (p.Value.Id == temp)
                {
                    tam = p.Value.Pin;
                }
            }
            Console.Write("Nhap ma pin xac nhan: ");
            string pin = Console.ReadLine();
            if (pin == tam)
            {
                Max = Max - d;
                Console.WriteLine(" ->Rut tien thanh cong<- ");
                Console.WriteLine("\nVUI LONG KHONG DE QUEN TIEN");
                Thread.Sleep(500);
                Console.WriteLine(" So du hien tai cua ban la: {0}", Max);
                FileStream fl = new FileStream(path, FileMode.Create, FileAccess.Write);
                //t[2] = Convert.ToString(Max);
                using (StreamWriter sw = new StreamWriter(fl))
                {
                    sw.WriteLine($"{t[0]}#{t[1]}#{Max}#{t[3]}");
                }

                using (StreamWriter sw = new StreamWriter(@"D:\[LichSu" + temp + "]" + ".txt", true))
                {
                    sw.WriteLine("Loai giao dich: Rut tien");
                    sw.WriteLine($"{"ID",-15}{"Loai giao dich",-15}{"So tien",-15}{"Ngay giao dich",-15}");
                    LichSu newLS = new LichSu(temp, "RUT TIEN", d, DateTime.Now);
                    sw.WriteLine(newLS.toString());
                }
            }
            else
            {
                Console.WriteLine("Sai ma pin !!! Giao dich bi huy");
            }

        }
    }
    static void MenuRutTien(LinkedList<ID> L)
    {
        Console.WriteLine("*****************RUT TIEN*****************");
        Console.WriteLine("\t Vui long chon so tien ban muon chuyen");
        Console.WriteLine("\t 1. 50.000 VND");
        Console.WriteLine("\t 2. 100.000 VND");
        Console.WriteLine("\t 3. 500.000 VND");
        Console.WriteLine("\t 4. 1.000.000 VND");
        Console.WriteLine("\t 5. 3.000.000 VND");
        Console.WriteLine("\t 6. 10.000.000 VND");
        Console.WriteLine("\t 7. So tien khac");
        Console.WriteLine("\t 8. Thoat");
    }
    static void MenuChuyenTien(LinkedList<ID> L)
    {
        Console.WriteLine("*****************CHUYEN TIEN*****************");
        Console.WriteLine("\t Vui long chon so tien ban muon chuyen");
        Console.WriteLine("\t 1. 50.000 VND");
        Console.WriteLine("\t 2. 100.000 VND");
        Console.WriteLine("\t 3. 500.000 VND");
        Console.WriteLine("\t 4. 1.000.000 VND");
        Console.WriteLine("\t 5. 3.000.000 VND");
        Console.WriteLine("\t 6. 10.000.000 VND");
        Console.WriteLine("\t 7. So tien khac");
        Console.WriteLine("\t 8. Thoat");
    }
    static void xemThongTinUser(LinkedList<User> L, string id)
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n==================Thong tin khach hang==================");
            Console.WriteLine($"{"ID",-15}{"Ten",-15}{"So du",-15}{"Loai tien",-15}");
            for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
            {
                if (id == p.Value.Id)
                {
                    using (StreamReader sR = new StreamReader(@"D:\[" + p.Value.Id + "]" + ".txt", true))
                    {
                        while (sR.Peek() != -1)
                        {
                            string[] t = sR.ReadLine().Split('#');
                            ID ID = new ID(t[0], t[1], t[2], t[3]);
                            Console.WriteLine($"{t[0],-15}{t[1],-15}{t[2],-15}{t[3],-15}");
                        }

                    }

                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Mo file that bai" + ex.Message);
        }
    }
    static void moKhoaTaiKhoan(LinkedList<User> L)
    {
        Console.WriteLine("*****************MO KHOA TAI KHOAN*****************");
        bool check = false;
        Console.Write("Nhap ID can mo khoa: ");
        string id = Console.ReadLine();
        for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
        {
            if (id == p.Value.Id && p.Value.Pin=="7777")
            {
                p.Value.Pin = "1111";
                Console.WriteLine("Mo khoa tai khoan thanh cong(Mat khau mac dinh: 1111)!!!");
                ghiFileTheTu(L);
                check = true;
            }
        }
        if (check == false)
        {
            Console.WriteLine("ID khong ton tai hoac tai khoan khong bi khoa!!!");
        }
    }
    static void xoaTaiKhoan(LinkedList<User> L)
    {
        Console.WriteLine("*****************XOA TAI KHOAN*****************");
        bool check = false;
        Console.Write("Nhap ID can xoa: ");
        string id = Console.ReadLine();
        for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
        {
            if (id == p.Value.Id)
            {
                L.Remove(p);
                Console.WriteLine("Xoa tai khoan thanh cong!!!");
                ghiFileTheTu(L);
                check = true;
            }
        }
        if (check == false)
        {
            Console.WriteLine("ID khong ton tai");
        }
        string fileName = @"D:\[" + id + "]" + ".txt";
        FileInfo filetodelete = new FileInfo(fileName);
        try
        {
            filetodelete.Delete();
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void themTaiKhoan(LinkedList<User> L)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("*****************THEM TAI KHOAN*****************");
        LinkedList<ID> ID = new LinkedList<ID>();
    first:
        bool check = false;
        Console.Write("Nhap ID: ");
        string id = Console.ReadLine();

        for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
        {
            if (id == p.Value.Id)
            {
                Console.WriteLine("ID da ton tai");
                check = true;
                goto first;
            }
        }
        Console.Write("Nhap ten nguoi dung: ");
        string ten = Console.ReadLine();
        Console.Write("Nhap so du nguoi dung: ");
        string soDu = Console.ReadLine();
        Console.Write("Nhap loai tien: ");
        string loaiTien = Console.ReadLine();
        if (check == false)
        {
            User user = new User(id, "12345");
            L.AddLast(user);
            ghiFileTheTu(L);
            Console.WriteLine("Them tai khoan thanh công");
        }

        using (StreamWriter sw = new StreamWriter(@"D:\[" + id + "]" + ".txt", true))
        {
            ID newID = new ID(id, ten, soDu, loaiTien);
            sw.WriteLine(newID.toString());
            ID.AddLast(newID);
        }
        using (StreamWriter sw = new StreamWriter(@"D:\[LichSu" + id + "]" + ".txt", true))
        {
            sw.WriteLine($"{"ID",-15}{"Loai giao dich",-15}{"So tien",-15}{"Ngay giao dich",-15}");
            //LichSu newLS = new LichSu("", "", 0, DateTime.Now);
            //sw.WriteLine(newLS.toString());
        }
    }
    static void MenuMain()
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\t\t{"***"}{"*********************"}");
        Console.WriteLine($"\t\t{"*  "}{"NGAN HANG TMCP DCB  *"}");
        Console.WriteLine($"\t\t{"************************"}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("****************************************************");
        Console.WriteLine($"*\tVui long chon chuc nang dang nhap{"*",11}");
        Console.WriteLine($"*\t 1. Dang nhap Admin{"*",25}");
        Console.WriteLine($"*\t 2. Dang nhap User{"*",26}");
        Console.WriteLine($"*\t 3. Thoat chuong trinh{"*",22}");
        Console.WriteLine("****************************************************");
    }
    static void MenuAdmin()
    {
        Console.WriteLine("*****************MENU ADMIN*****************");
        Console.WriteLine("\t 1. Xem danh sach tai khoan");
        Console.WriteLine("\t 2. Them tai khoan");
        Console.WriteLine("\t 3. Xoa tai khoan");
        Console.WriteLine("\t 4. Mo khoa tai khoan");
        Console.WriteLine("\t 5. Thoat");
    }
    static void MenuUser()
    {
        Console.WriteLine("*****************MENU USER*****************");
        Console.WriteLine("\t 1. Xem thong tin tai khoan");
        Console.WriteLine("\t 2. Rut tien");
        Console.WriteLine("\t 3. Chuyen tien");
        Console.WriteLine("\t 4. Xem noi dung giao dich");
        Console.WriteLine("\t 5. Doi ma pin");
        Console.WriteLine("\t 6. Thoat");
    }
    static bool DangNhapMenuAdmin(LinkedList<Admin> L)
    {
        bool check = false;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\t{"*********************",-30}");
        Console.WriteLine($"\t{"*  DANG NHAP ADMIN  *",-30}");
        Console.WriteLine($"\t{"*********************",-30}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\tID: \t");
        Console.ForegroundColor = ConsoleColor.Gray;
        string id = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\tPin: \t");
        Console.ForegroundColor = ConsoleColor.Gray;
        string pass = "";
        ConsoleKeyInfo key = Console.ReadKey(true);
        while (key.Key != ConsoleKey.Enter)
        {

            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                Console.Write("*");
                pass += key.KeyChar;
            }
            else
            {
                if (pass.Length > 0)
                {
                    pass = pass.Substring(0, pass.Length - 1);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(" ");
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                }
            }
            key = Console.ReadKey(true);
        }
        for (LinkedListNode<Admin> p = L.First; p != null; p = p.Next)
        {
            if (p.Value.User == id && p.Value.Password == pass)
            {
                check = true;
                break;
            }
            else
            {
                check = false;

            }
        }
        return check;
    }

    static string DangNhapMenuUser(LinkedList<User> L)
    {
        int dem = 0;
        string KT = "";
        //bool check = false;
        string pass = "";
        for (int i = 0; i < 3; i++)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t{"*********************",-30}");
            Console.WriteLine($"\t{"*  DANG NHAP USER  *",-30}");
            Console.WriteLine($"\t{"*********************",-30}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\tID: \t");
            Console.ForegroundColor = ConsoleColor.Gray;
            string id = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\tPin: \t");
            Console.ForegroundColor = ConsoleColor.Gray;
            ConsoleKeyInfo key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    Console.Write("*");
                    pass += key.KeyChar;
                }
                else
                {
                    if (pass.Length > 0)
                    {
                        pass = pass.Substring(0, pass.Length - 1);
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    }
                }
                key = Console.ReadKey(true);
            } 
            for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
            {
                if (p.Value.Id == id && p.Value.Pin == "7777")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nTai khoan cua ban da bi khoa !!! Vui long lien he Admin de duoc mo khoa");
                    goto end;
                }
            }
            for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
            {
                if (p.Value.Id == id && p.Value.Pin == pass)
                {
                    //check = true;
                    KT = p.Value.Id;
                    goto end;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\tSai tai khoan hoac mat khau !!!");
            Thread.Sleep(1000);
            string giu = id;
            dem++;
            if (dem == 3)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tai khoan cua ban da bi khoa vui long lien he Admin de duoc mo khoa !!!");

                for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
                {
                    if (p.Value.Id == id)
                    {
                        p.Value.Pin = "7777";
                        ghiFileTheTu(L);
                        goto end;
                    }
                }
            }
        }
    end:
        return KT;
    }
    static void DocFileAdmin(LinkedList<Admin> L, string path)
    {
        try
        {
            using (StreamReader sR = new StreamReader(path))
            {

                while (sR.Peek() != -1)
                {
                    string[] t = sR.ReadLine().Split('#');
                    Admin admin = new Admin(t[0], t[1]);
                    L.AddLast(admin);
                }

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Mo file that bai" + ex.Message);
        }
    }
    static void DocFileUser(LinkedList<User> L, string path)
    {
        try
        {
            using (StreamReader sR = new StreamReader(path))
            {

                while (sR.Peek() != -1)
                {
                    string[] t = sR.ReadLine().Split('#');
                    User user = new User(t[0], t[1]);
                    L.AddLast(user);
                }

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Mo file that bai" + ex.Message);
        }
    }
    static void DocFileID(LinkedList<ID> L, string path)
    {
        try
        {
            using (StreamReader sR = new StreamReader(path))
            {

                while (sR.Peek() != -1)
                {
                    string[] t = sR.ReadLine().Split('#');
                    ID id = new ID(t[0], t[1], t[2], t[3]);
                    L.AddLast(id);
                }

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Mo file that bai" + ex.Message);
        }
    }
    static void XuatFileAdmin(LinkedList<Admin> L)
    {

        Console.WriteLine($"{"User: ",-15}{"Password: ",-15}");
        for (LinkedListNode<Admin> p = L.First; p != null; p = p.Next)
        {

            Console.WriteLine(p.Value.toString() + " ");
        }

    }
    static void XuatFileUser(LinkedList<User> L)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("*****Danh sach tai khoan*****");
        Console.WriteLine($"{"ID: ",-15}{"Pin: ",-15}");
        for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
        {

            Console.WriteLine(p.Value.toString() + " ");
        }
        Console.WriteLine("Nhap phim bat ki de quay lai");
    }
    static void XuatFileID(LinkedList<ID> L)
    {

        Console.WriteLine($"{"ID: ",-15}{"Pin: ",-15}");
        for (LinkedListNode<ID> p = L.First; p != null; p = p.Next)
        {

            Console.WriteLine(p.Value.toString() + " ");
        }

    }
    static void ghiFileID(LinkedList<ID> L)
    {

        for (LinkedListNode<ID> p = L.First; p != null; p = p.Next)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\[" + p.Value.IdUser + "]" + ".txt", true))
                {
                    sw.WriteLine(p.Value.toString());
                }
                Console.WriteLine("Ghi file thanh cong");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ghi file that bai" + ex.Message);

            }
        }
    }
    static void ghiFileIDD(LinkedList<ID> L, string a)
    {

        for (LinkedListNode<ID> p = L.First; p != null; p = p.Next)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\[" + p.Value.IdUser + "]" + ".txt", true))
                {

                    sw.WriteLine($"{p.Value.IdUser}#{p.Value.TenUser}#{p.Value.SoDuUser}#{p.Value.LoaiTienTe}");
                }
                Console.WriteLine("Ghi file thanh cong");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ghi file that bai" + ex.Message);

            }
        }
    }
    static void ghiFileTheTu(LinkedList<User> L)
    {
        using (StreamWriter sw = new StreamWriter("TheTu.txt"))
        {
            for (LinkedListNode<User> p = L.First; p != null; p = p.Next)
            {
                sw.WriteLine($"{p.Value.Id}#{p.Value.Pin}");
            }

        }

    }
}


