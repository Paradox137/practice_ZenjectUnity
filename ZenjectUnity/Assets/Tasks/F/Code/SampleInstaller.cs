using Zenject;

namespace ZPRoot.Tasks.F.Code
{
    public class SampleInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputtable>().To<InputFromKeyboard>().AsSingle();
        }
    }
}