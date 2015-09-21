using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSPP.Models
{
    public class RuleModels
    {
        public int Id { get; set; }

        /// <summary>
        /// 规则内容
        /// </summary>
        [Required]
        [Display(Name = "规则内容")]
        public string Content { get; set; }

        /// <summary>
        /// 规则附件路径
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 规则添加时间
        /// </summary>
        public DateTime SubmitTime { get; set; }

        /// <summary>
        /// 规则上传人
        /// </summary>
        public int Publisher { get; set; }

        public UserModels User { get; set; }
    }
}
