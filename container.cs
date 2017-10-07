using System;
using System.Collections.Generic;
using System.Text;

namespace kontener
{
    public static class ServiceLocator
    {
        readonly static Dictionary<Type, Type>
        services = new Dictionary<Type, Type>();

        public static void Register<TRegister ,TImplement >()
        {
            services.Add(typeof(TRegister), typeof(TImplement));
        }

        public static T Resolve<T>()
        {
            Type type = services[typeof(T)];

            return (T)Activator.CreateInstance(type);
        }
    }
}
