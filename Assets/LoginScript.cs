using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{

    public InputField username;
    public InputField password;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString ("GameID","GAME_0004");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseModal(){
        gameObject.SetActive(false);
    }

    public void LogIn(){
        StartCoroutine(GetRequest("http://savemeapp.000webhostapp.com/Transactions/player_login.php?playerid="+username.text+"&password="+password.text));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                if(webRequest.downloadHandler.text == "404"){
                    Debug.Log("User Not Found");
                } else if(webRequest.downloadHandler.text == "2"){
                    Debug.Log("Error Occured");
                } else {
                    string[] comps = (webRequest.downloadHandler.text).Split('|');
                    PlayerPrefs.SetString ("Coins",comps[0]);
                    PlayerPrefs.SetString ("Name",comps[1]);
                    PlayerPrefs.SetString ("Gamer",comps[2]);
                    CloseModal();
                }
            }
        }
    }
}

[System.Serializable]
public class Player
{

    public string coinBalance;
    public string username;
    public string PlayerID;
}
