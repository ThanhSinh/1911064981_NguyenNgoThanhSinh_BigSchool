using _1911064981_NguyenNgoThanhSinh_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace _1911064981_NguyenNgoThanhSinh_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

        public IEnumerable<Attendance> IsFollowCourses { get; set; }
        public IEnumerable<Following> IsFollowLecturers { get; set; }
    }
}