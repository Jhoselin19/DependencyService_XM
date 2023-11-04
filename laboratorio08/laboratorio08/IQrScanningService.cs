using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio08
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
