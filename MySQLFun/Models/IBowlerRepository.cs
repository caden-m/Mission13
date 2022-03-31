using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MySQLFun.Models
{
    public interface IBowlerRepository
    {
        IQueryable<Bowler> Bowlers { get; }
        public void CreateBowler(Bowler b);
        public void SaveBowler(Bowler b);
        public void DeleteBowler(Bowler b);
    }
}
