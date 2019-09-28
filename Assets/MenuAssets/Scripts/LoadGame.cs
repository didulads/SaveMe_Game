using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadGame : MonoBehaviour {
	  
	public void LoadLevel(int lev){
		PlayerPrefs.SetInt ("level", lev);
        if (lev <= 30)
        {
            SceneManager.LoadScene("LevelScene1");
        }else if (lev <= 50)
        {
            SceneManager.LoadScene("LevelScene2");
        }
    }

}
