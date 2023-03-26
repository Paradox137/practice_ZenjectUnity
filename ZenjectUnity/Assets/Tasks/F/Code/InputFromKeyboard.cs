using UnityEngine;

namespace ZPRoot.Tasks.F.Code
{
	public class InputFromKeyboard : IInputtable
	{
		public Vector3 InputForMove ()
		{
			return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		}
	}
}
