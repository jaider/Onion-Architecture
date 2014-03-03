using System;
using StructureMap;
using OnionArch.Core.Interfaces;

namespace OnionArch.DependencyResolution
{
    internal class StructureMapServiceLocator : IServiceLocator
    {
        #region Private Fields

        private readonly IContainer _container;

        #endregion Private Fields

        #region Constructors/Destructors

        public StructureMapServiceLocator(IContainer container)
        {
            _container = container;
        }

        #endregion Constructors/Destructors

        #region Public Methods

        public T GetInstance<T>() where T : class
        {
            return _container.GetInstance<T>();
        }

        public object GetInstance(Type type)
        {
            return _container.GetInstance(type);
        }

        #endregion Public Methods
    }
}