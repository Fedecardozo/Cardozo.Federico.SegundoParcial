using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISql
    {

        public bool Update_Sql();

        public bool Insert_Sql();

        public bool Delete_Sql();

    }
}
