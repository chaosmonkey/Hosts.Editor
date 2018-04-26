namespace Hosts.Editor
{
    public interface IDependencyResolver
    {
        T Resolve<T>();
    }
}