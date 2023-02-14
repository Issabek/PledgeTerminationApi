using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Interfaces.Services
{
    public interface ISignService
    {
        string SignDoc(string docHash);
    }
}
