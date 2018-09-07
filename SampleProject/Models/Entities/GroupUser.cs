using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleProject.Models.Entities
{
    public class GroupUser
    {
        [Key, Column(Order = 1)]
        public int GroupId { get; set; }

        [Key, Column(Order = 2)]
        public Guid UserId { get; set; }
    }
}