using LayeryDemo.BusinessServices;
using LayeryDemo.DataModel;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeryDemo.IoCContainer
{
    public static class IoCMappingContainer
    {
        private static IUnityContainer _Instance = new UnityContainer();

        static IoCMappingContainer()
        {
        }

        public static IUnityContainer GetInstance()
        {
            // Mapper Config


            // Register types            
            _Instance.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());


            _Instance.RegisterType<IStandardService, StandardService>(new HierarchicalLifetimeManager());
            _Instance.RegisterType<ITeacherService, TeacherService>(new HierarchicalLifetimeManager());
            return _Instance;
        }
    }
}
