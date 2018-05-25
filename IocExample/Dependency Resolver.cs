using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


// ДЗ
using Ninject;
using Ninject.Modules;
using IocExample;
using IocExample.Classes;

namespace IocExampleNewCLass
{
    ////////////  2 способ   ////////////////////////
    public class Dependency_Resolver : NinjectModule
    {

        Dictionary<Type, object> objects = new Dictionary<Type, object>();

        public void AddObject(Type t, object o)
        {
            objects.Add(t,o);
        }


        public override void Load()
        {
            
            Bind<ILogger>().To<ConsoleLogger>();
            Bind<IConnectionFactory>().ToConstructor<SqlConnectionFactory>
                (msg => new SqlConnectionFactory("SQL Connection", msg.Inject<ILogger>())).InSingletonScope();
            Bind<RestClient>().ToConstructor<RestClient>
                (msg => new RestClient("API KEY"));
            Bind<CacheService>().To<CacheService>();
            Bind<CommandExecutor>().To<CommandExecutor>();
            Bind<QueryExecutor>().To<QueryExecutor>();
            Bind<UserService>().To<UserService>();
            Bind<CreateUserHandler>().To<CreateUserHandler>();

        }
    }
    ////////////  2 способ   ////////////////////////
}
