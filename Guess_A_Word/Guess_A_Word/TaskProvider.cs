using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guess_A_Word
{
    public interface TaskProvider
    {
        Task Get();
    }
}
