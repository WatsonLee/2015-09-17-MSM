using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSPP.Models
{
    public class UserModels
    {
        public int Id { get; set; }

        [Display(Name = "用户名")]
        public string Name { get; set; }

        [Display(Name = "邮箱")]
        public string Email { get; set; }


        [Display(Name = "联系电话")]
        public string Phone { get; set; }

        /// <summary>
        /// 毕业院校
        /// NVARCHAR 20
        /// </summary>
        [Display(Name = "毕业院校")]
        public string University { get; set; }

        /// <summary>
        /// 所学专业
        /// NVARCHAR 20
        /// </summary>
        [Display(Name = "所学专业")]
        public string Major { get; set; }

        /// <summary>
        /// 毕业年份
        /// </summary>
        [Display(Name = "毕业年份")]
        public DateTime GraduateTime { get; set; }

        /// <summary>
        /// 学历
        /// NVARCHAR 20
        /// </summary>
        [Display(Name = "学历")]
        public string Education { get; set; }

        /// <summary>
        /// 入职时间/加入时间,相当于注册的时间
        /// </summary>
        public DateTime JoinTime { get; set; }

        /// <summary>
        /// 此人的工作状态
        /// 0.离职    1.在职
        /// </summary>
        [Display(Name = "工作状态")]
        public int State { get; set; }

        /// <summary>
        /// 籍贯
        /// NVARCHAR 20
        /// </summary>
        [Display(Name = "籍贯")]
        public string Native { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [Display(Name = "生日")]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 婚姻状况
        /// 0.未婚    1.已婚
        /// </summary>
        [Display(Name = "婚姻")]
        public int Marry { get; set; }

        /// <summary>
        /// 用户的自我简介
        /// NVARCHAR 100
        /// </summary>
        [Display(Name = "自我简介")]
        public string Description { get; set; }

        /// <summary>
        /// 记录该用户参与的任务
        /// 外键，记录该用户参与的任务
        /// </summary>
        public ICollection<TaskAndUser> TaskAndUsers { get; set; }

        /// <summary>
        /// 记录用户审核的项目
        /// </summary>
        public ICollection<TaskModels> TaskManager { get; set; }

        /// <summary>
        /// 记录用户创建的项目
        /// </summary>
        public ICollection<TaskModels> TaskCreator { get; set; }

        /// <summary>
        /// 记录用户操作账目记录
        /// </summary>
        public ICollection<FinanceModels> FinanceOpt { get; set; }

        /// <summary>
        /// 记录用户支付的记录，即会计支付记录
        /// </summary>
        public ICollection<FinanceModels> FinancePay { get; set; }

        /// <summary>
        /// 用户上传规则记录
        /// </summary>
        public ICollection<RuleModels> RulePub { get; set; }

        /// <summary>
        /// 用户上传公告记录
        /// </summary>
        public ICollection<NoticeModels> NoticePub { get; set; }

        /// <summary>
        /// 用户上传文件记录
        /// </summary>
        public ICollection<ShareModels> SharePub { get; set; }
    }
}
