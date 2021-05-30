using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;

public class PlayFabManager : MonoBehaviour
{
    public GameObject nameWindow;
    public GameObject leaderboardWindow;

    public GameObject nameError;
    public InputField nameInput;

    public GameObject rowPrefab;
    public Transform rowsParent;

    public tempoFinale tf;

    public GameObject bottoneAggiornaClassifica;
    public GameObject bottoneChiudiClassifica;
    public GameObject bottoneHome;
    public GameObject bottoneShare;


    public void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = "Tutorial",
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
    }

    void OnSuccess(LoginResult result)
    {
        Debug.Log("Successo login");
        string name = null;
        if (result.InfoResultPayload.PlayerProfile != null)
            name = result.InfoResultPayload.PlayerProfile.DisplayName;

        if (name == null)
        {
            nameWindow.SetActive(true);
            bottoneHome.SetActive(false);
            bottoneShare.SetActive(false);
        }
    }

    void OnError(PlayFabError error)
    {
        Debug.Log("Errore");
        Debug.Log(error.GenerateErrorReport());
    }

    public void SendLeaderboard(int time)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName = "LowestTime", Value = time
                }
         }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    }

    void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("Successo classifica");
    }

    public void GetLeaderboard()
    {
        this.bottoneHome.SetActive(false);
        this.bottoneShare.SetActive(false);
        this.tf = tf.GetComponent<tempoFinale>();
        this.SendLeaderboard(tf.getScore());

        var request = new GetLeaderboardRequest
        {
            StatisticName = "LowestTime",
            StartPosition = 0,
            MaxResultsCount = 10
        };
        this.bottoneAggiornaClassifica.SetActive(true);
        this.bottoneChiudiClassifica.SetActive(true);
        PlayFabClientAPI.GetLeaderboard(request, OnLeaderboardGet, OnError);
    }

    void OnLeaderboardGet(GetLeaderboardResult result)
    {
        leaderboardWindow.SetActive(true);
        foreach (Transform item in rowsParent)
        {
            Destroy(item.gameObject);
        }
        
        foreach (var item in result.Leaderboard)
        {
            GameObject newGo = Instantiate(rowPrefab, rowsParent);
            Text[] texts = newGo.GetComponentsInChildren<Text>();
            texts[0].text = (item.Position + 1).ToString();
            texts[1].text = item.DisplayName;
            texts[2].text = this.intToTime(item.StatValue.ToString());

            Debug.Log(item.Position + " " +item.DisplayName + " " + item.StatValue);
        }

    }


    public void SubmitNameButton()
    {
        var request = new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = nameInput.text,
        };
        PlayFabClientAPI.UpdateUserTitleDisplayName(request, OnDisplayNameUpdate, OnError);
    }

    void OnDisplayNameUpdate(UpdateUserTitleDisplayNameResult result)
    {
        Debug.Log("Updated display name");
        this.nameWindow.SetActive(false);
        this.bottoneHome.SetActive(true);
        this.bottoneShare.SetActive(true);
    }

    string intToTime(string score)
    {
        string result = "00:00,00";
        char[] resultAsChars = result.ToCharArray();
        int chars = score.Length;
        int j = 0;
        int i = 7 - chars;
        while(i<8)
        {
            if (i == 2 || i == 5)
                i++;
            
            resultAsChars[i] = score[j];
            
            j++;
            i++;
        }
        return new string(resultAsChars);
    }

    public void chiudiClassifica()
    {
        this.leaderboardWindow.SetActive(false);
        this.bottoneChiudiClassifica.SetActive(false);
        this.bottoneAggiornaClassifica.SetActive(false);
        this.bottoneHome.SetActive(true);
        this.bottoneShare.SetActive(true);
    }
}
