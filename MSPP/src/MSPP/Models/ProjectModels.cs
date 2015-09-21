using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSPP.Models
{
    public class ProjectModels
    {
        public int Id { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [Required]
        [Display(Name = "项目名称")]
        public string Name { get; set; }

        /// <summary>
        /// 项目简介
        /// </summary>
        [Display(Name = "项目简介")]
        public string Content { get; set; }

        /// <summary>
        /// 项目创建日期
        /// </summary>
        public DateTime Date { get; set; }

        public ICollection<TaskModels> Tasks { get; set; }

        public ICollection<FinanceModels> Finances { get; set; }

        /// <summary>
        /// 表示这个项目的总收支状况
        /// Decimal
        /// </summary>
        [Display(Name = "项目收益")]
        public decimal Account { get; set; }
    }
}
