using UniRx;
using UnityEngine;

namespace ZPRoot.Tasks.S.Code
{
	public class TestHPModel
	{
		IntReactiveProperty hp = new IntReactiveProperty(100);

		public IReadOnlyReactiveProperty<int> HP
		{
			get
			{
				return hp;
			}
		}

		public void Damage (int __damage)
		{
			if(__damage < 0)
				return;

			int tmp = hp.Value - __damage;
			
			if (tmp < 0)
				hp.Value = 0;
			else
			{
				hp.Value = tmp;
				Debug.Log(tmp);
			}
		}
	}
}
