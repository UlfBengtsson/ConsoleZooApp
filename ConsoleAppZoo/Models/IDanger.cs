using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    public interface IDanger
    {
        //           type, level
        Dictionary<string, int> DangerTypes();
    }
}
