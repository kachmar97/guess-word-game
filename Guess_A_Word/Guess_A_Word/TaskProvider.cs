using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guess_A_Word
{
    interface TaskProvider
    {
        Task Get();
    }
}
