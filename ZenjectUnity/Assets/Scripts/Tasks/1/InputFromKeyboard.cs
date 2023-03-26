using UnityEngine;

namespace ZPRoot.Tasks._1
{
	public class InputFromKeyboard : IInputtable
	{
		public Vector3 InputForMove ()
		{
			return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		}
	}
}
