using System.Web.Http.Dependencies;
using Unity;
using Unity.WebApi;

namespace FhirStarter.Unity.Webapi
{
    public class UnityDependencyResolver : UnityDependencyScope, IDependencyResolver
    {
        public UnityDependencyResolver(IUnityContainer container)
            : base(container)
        {
        }
       
        public IDependencyScope BeginScope()
        {
            var childContainer = Container.CreateChildContainer();

            return new UnityDependencyScope(childContainer);
        }
    }    
}