using Zenject;

namespace Basic
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<string>().FromInstance("Hello World");
        }
    }
}