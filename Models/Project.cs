﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CsScore.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Group OwnerGroup { get; set; }

        public ICollection<Score> ScoreRecords { get; set; }

        [Required]
        public int GroupId { get; set; }

        public DateTimeOffset SubmitDate { get; set; }

        public DateTimeOffset UpdatedDate { get; set; }
    }
}
