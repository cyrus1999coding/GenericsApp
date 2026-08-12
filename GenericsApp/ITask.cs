using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal interface ITask<TResult>
    {
        TResult Perform();
    }
}
