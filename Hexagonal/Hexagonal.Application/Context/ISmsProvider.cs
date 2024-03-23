using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagonal.Application.Context;
public interface ISmsProvider
{
    void Send(string message);
}
