namespace SkillTreeMVC5_Day1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountBook")]
    public partial class AccountBook
    {
        public Guid Id { get; set; }

        public CategoryType Categoryyy { get; set; }

        public int Amounttt { get; set; }

        public DateTime Dateee { get; set; }

        [Required]
        [StringLength(500)]
        public string Remarkkk { get; set; }
    }

    public enum CategoryType
    {
        ��X = 0,
        ���J = 1,
    }
}
