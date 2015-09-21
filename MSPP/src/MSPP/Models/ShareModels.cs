using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSPP.Models
{
    public class ShareModels
    {
        public int Id { get; set; }

        /// <summary>
        /// 共享文件的描述
        /// </summary>
        [Display(Name = "文件简介")]
        public string Content { get; set; }

        /// <summary>
        /// 共享文件的路径
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 文件上传时间
        /// </summary>
        public DateTime SubmitTime { get; set; }

        /// <summary>
        /// 文件上传人
        /// </summary>
        [Display(Name ="上传者")]
        public int Publisher { get; set; }

        public UserModels User { get; set; }
    }
}
