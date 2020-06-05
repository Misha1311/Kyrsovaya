using System.Collections.Generic;

namespace Kyrsovaya
{
    static class dateb
    {
        public static List<data> newData = new List<data>();

        public static void AddDate(data AddDate)
        {
            newData.Add(AddDate);
        }
    }
}
