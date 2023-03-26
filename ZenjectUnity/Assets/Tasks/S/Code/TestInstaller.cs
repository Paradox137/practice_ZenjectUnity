using Zenject;

namespace ZPRoot.Tasks.S.Code
{
	public class TestInstaller : MonoInstaller
	{
		public override void InstallBindings ()
		{
			Container.Bind<TestHPModel>().AsCached().IfNotBound();
			Container.Bind<TestPresenter>().AsCached().NonLazy();
		}
	}
}
