using UnityEngine;
using Zenject;

namespace ZPRoot.Tasks.F.Code
{
	public class PlayerInput : MonoBehaviour
	{
		[Inject]
		private IInputtable inputObject;

		private void Move (Vector3 __inputPos)
		{
			var position = transform.localPosition;

			transform.localPosition = position + __inputPos;
		}

		private void Update ()
		{
			if (inputObject != null)
			{
				Move(inputObject.InputForMove());
			}
		}
	}
}
