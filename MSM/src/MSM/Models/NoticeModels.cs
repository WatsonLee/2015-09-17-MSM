using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSM.Models
{
    public class NoticeModels
    {
        public int Id { get; set; }

        /// <summary>
        /// 公告内容
        /// </summary>
        [Display(Name = "规则内容")]
        public string Content { get; set; }

        /// <summary>
        /// 公告附件路径
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 公告提交时间
        /// </summary>
        public DateTime SubmitTime { get; set; }

        /// <summary>
        /// 公告发布时间
        /// </summary>
        [Display(Name = "公告发布时间")]
        public DateTime PublishTime { get; set; }

        /// <summary>
        /// 公告添加人
        /// </summary>
        public int Publisher { get; set; }

        public UserModels User { get; set; }
    }
}
