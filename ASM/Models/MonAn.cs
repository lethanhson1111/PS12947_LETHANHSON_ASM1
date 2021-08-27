using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Models
{
    public enum PhanLoai
    {
        [Display(Name = "Món")]
        Monan = 1,
        [Display(Name = "Combo")]
        Combo = 2,
        [Display(Name = "Nước")]
        Nuoc = 3,
    }
    public class MonAn
    {
        [Key]
        public int MonAnID { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Bạn Cần Nhập Tên.")]
        [Display(Name = "Tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Giá."), Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá.")]
        [Display(Name = "Giá")]
        public double Gia { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Phân Loại."), Range(1, double.MaxValue, ErrorMessage = "Bạn cần chọn phân loại.")]
        [Display(Name = "Phân Loại")]
        public PhanLoai Phanloai { get; set; }

        [StringLength(100)]
        [Display(Name = "Hình")]
        public string Hinh { get; set; }

        [NotMapped]
        [Display(Name = "Chọn hình")]
        public IFormFile ImageFile { get; set; }

        [StringLength(250)]
        [Display(Name = "Mô tả")]
        public string Mota { get; set; }

        public bool Trangthai { get; set; }
    }
}
