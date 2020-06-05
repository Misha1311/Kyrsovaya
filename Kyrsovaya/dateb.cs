using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Newtonsoft.Json;

namespace Kyrsovaya
{
    [Serializable]
    static class dateb
    {
        public static List<data> newData = new List<data>();

        public static void AddDate(data AddDate)
        {
            newData.Add(AddDate);
        }
    }
}
