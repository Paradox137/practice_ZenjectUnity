using UniRx;

namespace ZPRoot.Tasks.S.Code
{
	public class TestPresenter
	{
		public TestPresenter (TestHPView testHPView, TestHPModel testHPModel)
		{
			testHPModel.HP.Subscribe(testHPView.DisplayHP);
			
			testHPView.OnDamage.Subscribe(_ => testHPModel.Damage(20));
		}
	}
}
