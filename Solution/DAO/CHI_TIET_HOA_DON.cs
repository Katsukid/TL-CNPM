
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DAO
{

using System;
    using System.Collections.Generic;
    
public partial class CHI_TIET_HOA_DON
{

    public int MaChiTietHD { get; set; }

    public int MaHoaDon { get; set; }

    public int SoNgayThue { get; set; }

    public Nullable<decimal> DonGia { get; set; }

    public Nullable<decimal> ThanhTien { get; set; }

    public Nullable<System.DateTime> NgayThanhToan { get; set; }

    public int MaPhong { get; set; }



    public virtual HOA_DON HOA_DON { get; set; }

    public virtual PHONG PHONG { get; set; }

}

}
