namespace Hosts.Editor.Infrastructure
{
    public interface IDependencyResolver
    {
        T Resolve<T>();
    }
}