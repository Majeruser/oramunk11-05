using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
   public interface IDownloadable
    {
        int GetSize();
        string GetDescription();
    }
}
