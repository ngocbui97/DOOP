using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.Common
{
    public interface Where<T> where T : new()
    {
        Having<T> Where(string condition);
        Having<T> AllRow();
    }

    public interface GroupBy<T> where T : new()
    {
        RunQuery<T> GroupBy(string columnNames);
    }

    public interface Having<T> where T : new()
    {
        GroupBy<T> Having(string condition);
        List<T> Run();
    }
}
