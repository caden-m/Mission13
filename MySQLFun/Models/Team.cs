using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MySQLFun.Models
{
    public class Team
    {
        [Key]
        [Required]
        public int TeamID { get; set; }
        public string TeamName { get; set; }

        // Foreign Table
        public int CaptainID { get; set; }
        [ForeignKey("CaptainID")]
        public Bowler Bowler { get; set; }
    }
}
