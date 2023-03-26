using Zenject;

namespace ZPRoot.Tasks._1
{
    public class SampleInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputtable>().To<InputFromKeyboard>().AsSingle();
        }
    }
}