using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnionArch.Core.Interfaces;

namespace OnionArch.Core.Service
{
    public static class ServiceLocator
    {
        public static IServiceLocator Current { get; private set; }

        public static void SetServiceLocator(Func<IServiceLocator> create)
        {
            if (create == null) throw new ArgumentNullException("create");
            Current = create();
        }
    }
}
