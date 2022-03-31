using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace MySQLFun.Models
{
    public class EFTeamRepository : ITeamRepository
    {
        private BowlingLeagueDbContext _context { get; set; }
        public EFTeamRepository(BowlingLeagueDbContext temp)
        {
            _context = temp;
        }
        public IQueryable<Team> Teams => _context.Teams;


    }
}
