﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanlaptop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.BINHLUAN = new HashSet<BINHLUAN>();
            this.HOADON = new HashSet<HOADON>();
        }
    
        public int MAKH { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TENKH { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        public string DIACHI { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        public string USERNAME { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        public string PASSWORD { get; set; }

        [Required(ErrorMessage ="Không được để trống")]
        [StringLength(10)]
        public string SDT {get; set;}

        [Required(ErrorMessage = "Không được bỏ trống")]
        [StringLength(12, MinimumLength =9, ErrorMessage ="CCCD phải là 9 hoặc 12")]
        public string CCCD { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail không đúng kiểu mời nhập lại")]
        public string EMAIL { get; set; }

        public Nullable<System.DateTime> NGAYSINH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHLUAN> BINHLUAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }
    }
}