using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace MySQLFun.Models
{
    public interface ITeamRepository
    {
        IQueryable<Team> Teams { get; }
    }
}
