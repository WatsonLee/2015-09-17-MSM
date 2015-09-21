﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSPP.Models
{
    public class FinanceKind
    {
        public int Id { get; set; }

        /// <summary>
        /// 出账种类
        /// </summary>
        [Required]
        public string Content { get; set; }

        public ICollection<FinanceModels> Finances { get; set; }
    }
}
