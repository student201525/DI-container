using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


// ДЗ
using Ninject;
using Ninject.Modules;
using IocExample.Classes;
using IocExampleNewCLass;

namespace IocExample
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var logger = new ConsoleLogger();
        //    var sqlConnectionFactory = new SqlConnectionFactory("SQL Connection", logger);
        //    //var createUserHandler = new CreateUserHandler(new UserService(new QueryExecutor(sqlConnectionFactory), new CommandExecutor(sqlConnectionFactory), new CacheService(logger, new RestClient("API KEY"))), logger);

        //    //createUserHandler.Handle();
        //}


        ////////////  1 способ   ////////////////////////
        //static void Main(string[] args)
        //{
        //    IKernel container = new StandardKernel();
        //    container.Bind<ILogger>().To<ConsoleLogger>();
        //    container.Bind<IConnectionFactory>().ToConstructor<SqlConnectionFactory> (msg => new SqlConnectionFactory("SQL Connection", msg.Inject<ILogger>())).InSingletonScope();
        //    container.Bind<RestClient>().ToConstructor<RestClient> (msg => new RestClient("API KEY"));
        //    container.Bind<CacheService>().To<CacheService>();
        //    container.Bind<CommandExecutor>().To<CommandExecutor>();
        //    container.Bind<QueryExecutor>().To<QueryExecutor>();
        //    container.Bind<UserService>().To<UserService>();
        //    container.Bind<CreateUserHandler>().To<CreateUserHandler>();

        //    var logger = container.Get<CreateUserHandler>();
        //    logger.Handle();

        //    Console.Read();
        //}
        ////////////  1 способ   ////////////////////////



        ////////////  2 способ   ////////////////////////
        static void Main(string[] args)
        {
            var container = new StandardKernel();
            container.Load(Assembly.GetExecutingAssembly());

            var logger = container.Get<CreateUserHandler>();
            logger.Handle();

            Console.Read();

             
        }
        ////////////  2 способ   ////////////////////////
    }




    //}
}
