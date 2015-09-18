using System;
using System.ComponentModel.DataAnnotations;

namespace MSM.Models
{
    public class FinanceModels
    {
        public int Id { get; set; }

        /// <summary>
        /// 标明是进账还是出账
        /// 0.出账    1.进账
        /// </summary>
        [Required]
        [Display(Name ="进账/出账")]
        public int Direction { get; set; }

        /// <summary>
        /// 记录金额
        /// </summary>
        [Required]
        [Display(Name ="金额")]
        public decimal Value { get; set; }

        /// <summary>
        /// 表明增加该条记录的日期
        /// </summary>
        public DateTime OperateDate { get; set; }

        /// <summary>
        /// 若为出账，则该字段表示支付状态
        /// 0.审核未通过    1.审核通过待支付    2.已支付
        /// </summary>
        [Display(Name = "支付状态")]
        public int State { get; set; }

        /// <summary>
        /// 若为学生申请的出账，则该字段表示申请日期
        /// </summary>
        [Display(Name = "申请日期")]
        public DateTime ApplyDate { get; set; }

        /// <summary>
        /// 标明收款方
        /// NVARCHAR
        /// </summary>
        [Required]
        [Display(Name = "收款人")]
        public string Receiver { get; set; }

        /// <summary>
        /// 标明该账目记录属于哪个项目
        /// </summary>
        [Required]
        [Display(Name = "所属项目")]
        public int ProjectId { get; set; }

        public ProjectModels Project { get; set; }

        /// <summary>
        /// 标明增加该条记录的人员
        /// </summary>
        [Required]
        [Display(Name = "操作人")]
        public int Operator { get; set; }

        public UserModels UserOpt { get; set; }

        /// <summary>
        /// 若为出账，则记录支付人员ID
        /// </summary>
        [Display(Name = "支付人")]
        public int Payer { get; set; }

        public UserModels UserPay { get; set; }
    }
}
