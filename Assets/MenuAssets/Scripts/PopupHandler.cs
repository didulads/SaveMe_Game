using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PopupHandler : MonoBehaviour {

	public void ReturnToMain(){
		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1;
	}

	public void RestartLevel(){
		int lev = PlayerPrefs.GetInt ("level");
		if (lev <= 30)
		{
			SceneManager.LoadScene("LevelScene1");
		}else if (lev <= 50)
		{
			SceneManager.LoadScene("LevelScene2");
		}
		Time.timeScale = 1;
	}

	public void LoadNextLevel(){
		PlayerPrefs.SetInt ("level",PlayerPrefs.GetInt("level")+1);
		int lev = PlayerPrefs.GetInt ("level");
		if (lev <= 30)
		{
			SceneManager.LoadScene("LevelScene1");
		}else if (lev <= 50)
		{
			SceneManager.LoadScene("LevelScene2");
		}
		Time.timeScale = 1;
	}
}
