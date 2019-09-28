using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SteeringChanger : MonoBehaviour
{
    public Sprite[] images;
    public float[] amounts;
    public string[] gameids;
    public Button[] buttons;
    public GameObject loginPanel;
    public GameObject purchasePanel;
    public Sprite steer;

    private Text coinText;
    private Text responseText;

    private string objId;
    private int posSel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void equipItem(int pos)
    {
        if(!PlayerPrefs.HasKey("GameID"))
            PlayerPrefs.SetString ("GameID","GAME_0004");
        if(PlayerPrefs.HasKey("Gamer"))
        {
            GetComponent<Image>().sprite = images[pos];
            if(PlayerPrefs.HasKey(gameids[pos]) || pos == 0)
            {
                ColorBlock colors_ = buttons[pos].colors;

                for(int i = 0; i < 5; i++){
                    buttons[i].colors = colors_;
                    buttons[i].interactable = true;
                }

                colors_.normalColor = Color.red;
                buttons[pos].colors = colors_;
                buttons[pos].interactable = false;
            }
            else
            {
                var children = purchasePanel.GetComponentsInChildren<Transform>();
                foreach (var child in children){
                    Debug.Log(child.name);
                    switch (child.name){
                        case "strImg":
                            child.GetComponent<Image>().sprite = images[pos];
                            break;
                        case "Dollars":
                            child.GetComponent<Text>().text = "$"+amounts[pos];
                            break;
                        case "SavemeCoin":
                            child.GetComponent<Text>().text = "S"+amounts[pos];
                            break;
                        case "name":
                            child.GetComponent<Text>().text = PlayerPrefs.GetString("Name");
                            break;
                        case "coins":
                            coinText = child.GetComponent<Text>();
                            StartCoroutine(GetRequest("http://savemeapp.000webhostapp.com/Transactions/get_current_coins.php?playerid="+PlayerPrefs.GetString("Gamer")));
                            child.GetComponent<Text>().text = PlayerPrefs.GetString("Coins")+" Coins";
                            break;
                        case "meta":
                            child.GetComponent<Text>().text = gameids[pos];
                            responseText = child.GetComponent<Text>();
                            objId = gameids[pos];
                            posSel = pos;
                            Debug.Log("metaFound : "+objId);
                            break;
                        default:
                            break;
                    }
                }

                purchasePanel.SetActive(true);
            }
        } 
        else 
        {
            loginPanel.SetActive(true);
        }
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
                coinText.text = webRequest.downloadHandler.text + " Coins";
                PlayerPrefs.SetString("Coins",webRequest.downloadHandler.text);
            }
        }
    }

    public void PurchaseItem(){
        StartCoroutine(PurchaseHandler("http://savemeapp.000webhostapp.com/Transactions/spendcoins.php?obj="+ objId +"&gameId="+PlayerPrefs.GetString("GameID")+"&playerid="+PlayerPrefs.GetString("Gamer")));
        Debug.Log("http://savemeapp.000webhostapp.com/Transactions/spendcoins.php?obj="+ objId +"&gameId="+PlayerPrefs.GetString("GameID")+"&playerid="+PlayerPrefs.GetString("Gamer"));
    }

    IEnumerator PurchaseHandler(string uri)
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
                Debug.Log(webRequest.downloadHandler.text);
                responseText.text = webRequest.downloadHandler.text;
                if(webRequest.downloadHandler.text == "You Purchased the item successfully"){
                    PlayerPrefs.SetInt(objId,1);
                    ColorBlock colors_ = buttons[posSel].colors;

                    for(int i = 0; i < 5; i++){
                        buttons[i].colors = colors_;
                        buttons[i].interactable = true;
                    }

                    colors_.normalColor = Color.red;
                    buttons[posSel].colors = colors_;
                    buttons[posSel].interactable = false;
                }
            }
        }
    }
}
