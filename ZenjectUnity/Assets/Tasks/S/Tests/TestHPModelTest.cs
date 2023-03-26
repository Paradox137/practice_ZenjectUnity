using NUnit.Framework;
using ZPRoot.Tasks.S.Code;

namespace Tasks.S.Tests
{
	public class TestHPModelTest
	{
		[Test] public void InitialValueOfHPIs100 ()
		{
			var hpModel = new TestHPModel();
			Assert.That(hpModel.HP.Value, Is.EqualTo(100));
		}

		[Test] public void HPDecreasesWhenTakingDamage ()
		{
			var hpModel = new TestHPModel();
			Assert.That(hpModel.HP.Value, Is.EqualTo(100));
			hpModel.Damage(30);
			Assert.That(hpModel.HP.Value, Is.EqualTo(70));
		}

		[Test] public void HPDoesNotChangeAt0Damage ()
		{
			var hpModel = new TestHPModel();
			Assert.That(hpModel.HP.Value, Is.EqualTo(100));
			hpModel.Damage(0);
			Assert.That(hpModel.HP.Value, Is.EqualTo(100));
		}

		[Test] public void IfReceiveDamageMoreThanHPHPWillBe0 ()
		{
			var hpModel = new TestHPModel();
			Assert.That(hpModel.HP.Value, Is.EqualTo(100));
			hpModel.Damage(120);
			Assert.That(hpModel.HP.Value, Is.EqualTo(0));
		}

		[Test] public void NegativeDamageDoesntChangeHP ()
		{
			var hpModel = new TestHPModel();
			Assert.That(hpModel.HP.Value, Is.EqualTo(100));
			hpModel.Damage(-50);
			Assert.That(hpModel.HP.Value, Is.EqualTo(100));
		}
	}
}
