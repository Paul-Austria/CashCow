//@BaseCode

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.DataContext
{
    internal partial class ProjectDbContext : DbContext, Contracts.IContext
    {

    }
}