using System;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace ZPRoot.Tasks.S.Code
{
	public class TestHPView : MonoBehaviour
	{
		public TextMeshProUGUI text;
		public Button button;
		
		public IObservable<Unit> OnDamage
		{
			get
			{
				return button.OnClickAsObservable();
			}
		}

		public void DisplayHP (int hp)
		{
			text.text = hp.ToString();
		}
	}
}
