using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhamQuocHuy_BE_ValidateObjectRequest.Model
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ họ tên")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giới tính")]
        [EnumDataType(typeof(Gendertype), ErrorMessage = "Vui lòng nhập đúng")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập điểm")]
        [Range(0,10,ErrorMessage = "Điểm chỉ từ 0 đến 10")]
        public decimal Point { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        [EnumDataType(typeof(Province), ErrorMessage = "Tỉnh thành không hợp lệ")]
        public string Province { get; set; }

    }

    public enum Gendertype
    {
        Nam, Nữ, Khác
    }
    public enum Province
    {
        AnGiang,
        BaRiaVungTau,
        BacGiang,
        BacKan,
        BacLieu,
        BacNinh,
        BenTre,
        BinhDinh,
        BinhDuong,
        BinhPhuoc,
        BinhThuan,
        CaMau,
        CanTho
    }

}
