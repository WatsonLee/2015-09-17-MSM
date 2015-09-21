using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSPP.Models
{
    public class TaskModels
    {
        public int Id { get; set; }

        /// <summary>
        /// 任务标题
        /// NVARCHAR 100
        /// </summary>
        [Required]
        [Display(Name = "任务标题")]
        public string Title { get; set; }

        /// <summary>
        /// 任务负责人
        /// </summary>
        public ICollection<TaskAndUser> TaskAndUsers { get; set; }

        /// <summary>
        /// 项目的状态，用int表示
        /// 0.申请中   1.审核失败    2.审核通过
        /// 3.空白     4.任务取消    5.任务推迟
        /// 6.延期完成 7.按时完成
        /// 任务默认空白状态
        /// </summary>
        [Display(Name = "任务状态")]
        public int State { get; set; }

        /// <summary>
        /// 项目预算
        /// </summary>
        [Display(Name = "任务预算")]
        public decimal Budget { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime ApplyDate { get; set; }

        /// <summary>
        /// 完成日期
        /// </summary>
        public DateTime FinishDate { get; set; }

        /// <summary>
        /// 标明任务属于哪个项目
        /// </summary>
        [Required]
        [Display(Name = "所属项目")]
        public int ProjectId { get; set; }

        public ProjectModels Project { get; set; }

        /// <summary>
        /// 项目审核人
        /// </summary>
        [Display(Name = "项目审核人")]
        public int Manager { get; set; }

        public UserModels UserManager { get; set; }

        /// <summary>
        /// 项目创建人
        /// </summary>
        [Required]
        [Display(Name = "创建人")]
        public int Creator { get; set; }

        public UserModels UserCreator { get; set; }
    }
}
