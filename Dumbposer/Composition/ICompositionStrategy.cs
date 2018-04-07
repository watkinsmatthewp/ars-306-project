using Dumbposer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dumbposer.Composition
{
    public interface ICompositionStrategy<T>
    {
        Melody Compose(T input);
    }
}
