using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RnMUI_LoadScene : MonoBehaviour {

	public string sceneName;
	public bool ignoreFirst = true;

	public void LoadScene()
	{
        //Application.LoadLevel(sceneName);
        SceneManager.LoadScene(sceneName);
	}

	public void OnProgress()
	{
		if (this.ignoreFirst)
		{
			this.ignoreFirst = false;
			return;
		}
		LoadScene();
	}
}
