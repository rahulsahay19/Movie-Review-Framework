using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Movie_Review_Framework.Infrastructure;
using StructureMap;
using StructureMap.Graph;

namespace Movie_Review_Framework
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //This will serve as single request for each web request
        //which means it won't create multiple instances 
        //this will take care currenntly executing web request
        public IContainer Container
        {
            get
            {
                return (IContainer) HttpContext.Current.Items["_Container"];
            }
            set
            {
                HttpContext.Current.Items["_Container"] = value;
            }
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Setting the dependency resolver to structure map
            DependencyResolver.SetResolver(
                new StructureMapDependencyResolver(()=>Container??ObjectFactory.Container));

            //Now configure object factory
            ObjectFactory.Configure(cfg => cfg.Scan(scan =>
            {
                //This means IAnyType maps to AnyType
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            }));
        }

        public void Application_BeginRequest()
        {
            Container = ObjectFactory.Container.GetNestedContainer();
        }

        //At the end of each request dispose the container.
        public void Application_EndRequest()
        {
            Container.Dispose();
            Container = null;
        }
    }
}
