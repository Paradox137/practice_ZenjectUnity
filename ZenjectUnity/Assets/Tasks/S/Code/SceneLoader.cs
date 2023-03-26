using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;
using ZPRoot.Tasks.S.Code;

public class SceneLoader : MonoBehaviour
{
	[Inject] ZenjectSceneLoader _sceneLoader;

	[Inject] TestHPModel _hpModel;

	public Button button;
	public string sceneName;

	void BindTestHPModel (DiContainer container)
	{
		container.Bind<TestHPModel>().FromInstance(_hpModel);
	}
	void Start ()
	{
		button.onClick
			.AsObservable()
			.Subscribe(_ =>
			{
				_sceneLoader.LoadScene(
					sceneName,
					LoadSceneMode.Single,
					BindTestHPModel
				);
			});
	}
}
