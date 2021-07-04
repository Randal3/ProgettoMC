using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using System;


public class PlayFabManager : MonoBehaviour
{
    public GameObject nameWindow;
    public GameObject leaderboardWindow;

    public GameObject nameError;
    public InputField nameInput;

    public GameObject rowPrefab;
    public Transform rowsParent;

    public GameObject bottoneAggiornaClassifica;
    public GameObject bottoneChiudiClassifica;
    public GameObject bottoneHome;
    public GameObject bottoneShare;


    private void Start()
    {
        Login();
    }

    public void Login()
    {
#if UNITY_ANDROID
        var request = new LoginWithAndroidDeviceIDRequest
        {
            AndroidDeviceId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };
        PlayFabClientAPI.LoginWithAndroidDeviceID(request, OnSuccess, OnError);
#endif
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
                    StatisticName = "LowestTime", Value = time*(-1)
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

        Debug.Log(FineGioco.tempoFinale);
        int finalScore = this.stringToInt(FineGioco.tempoFinale);

        this.SendLeaderboard(finalScore);

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
            int risultato = item.StatValue;
            int ricalcolato = risultato * (-1);
            GameObject newGo = Instantiate(rowPrefab, rowsParent);
            Text[] texts = newGo.GetComponentsInChildren<Text>();
            texts[0].text = (item.Position + 1).ToString();
            texts[1].text = item.DisplayName;
            texts[2].text = this.intToTime(ricalcolato.ToString());

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
        string result = "00:00";
        char[] resultAsChars = result.ToCharArray();
        int chars = score.Length;
        int j = 0;
        int i;
        if (chars < 2)
            i = 5 - chars;
        else
            i = 4 - chars;
        while(i<5)
        {

            if (i == 2)
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

    int stringToInt(string tempo)
    {
        string t_score = tempo;
        string score = t_score.Replace(":", string.Empty);

        int result = 0;
        int moltiplicatore = 1;
        int indice = score.Length-1;
        while(indice >= 0)
        {
            if (score[indice] == '0')
                result += 0 * moltiplicatore;
            else if (score[indice] == '1')
                result += 1 * moltiplicatore;
            else if (score[indice] == '2')
                result += 2 * moltiplicatore;
            else if (score[indice] == '3')
                result += 3 * moltiplicatore;
            else if (score[indice] == '4')
                result += 4 * moltiplicatore;
            else if (score[indice] == '5')
                result += 5 * moltiplicatore;
            else if (score[indice] == '6')
                result += 6 * moltiplicatore;
            else if (score[indice] == '7')
                result += 7 * moltiplicatore;
            else if (score[indice] == '8')
                result += 8 * moltiplicatore;
            else if (score[indice] == '9')
                result += 9 * moltiplicatore;
            indice--;
            moltiplicatore *= 10;
        }
        return result;
    }
}
