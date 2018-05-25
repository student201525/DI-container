using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using IocExample.Classes; //эксперимент ДЗ
using IocExampleNewCLass;

namespace IocExample
{
    public class Util
    {
        public static object CreateInstance(Type implementationType, List<object> parameters)
        {
            return Activator.CreateInstance(implementationType, parameters.ToArray());
        }

        public static object CreateInstance(Type implementationType)
        {
            return Activator.CreateInstance(implementationType);
        }

        public static ConstructorInfo GetSingleConstructor(Type implementationType)
        {
            return implementationType.GetConstructors().SingleOrDefault();
        }



        //<!--for static void MainTEST(string[] args)

        //private readonly IHello cust;

        //public Utils(IHello custIOC)
        //{
        //    cust = custIOC;
        //}

        //public void getCustHello()
        //{
        //    cust.GetMeet();
        //}

        //for static void MainTEST(string[] args)-->
    }
}