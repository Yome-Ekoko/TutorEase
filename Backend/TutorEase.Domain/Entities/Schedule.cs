using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorEase.Domain.Enum;
using TutorEase.Domain.Entities.Base;
using TutorEase.Domain.Common;

namespace TutorEase.Domain.Entities
{
    public class Schedule : EntityBase<string>
    {
        public Schedule()
        {
            SetNewId();
        }
        [Required]
        [StringLength(256)]
        public string TutorId { get; set; }

        [Required]
        [StringLength(256)]
        public string StudentId { get; set; }

        [Required]
        public string Day { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public string Time1 { get; set; }

        public BookingStatus Status { get; set; }

        [ForeignKey("TutorId")]
        public virtual T_User Tutor { get; set; }

        [ForeignKey("StudentId")]
        public virtual T_User Student { get; set; }

        public override void SetNewId()
        {
            Id = $"TUT_{CoreHelpers.CreateUlid(DateTimeOffset.Now)}";
        }
    }
}

