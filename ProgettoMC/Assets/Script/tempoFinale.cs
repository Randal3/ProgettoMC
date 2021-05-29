using UnityEngine;
using UnityEngine.UI;

public class tempoFinale : MonoBehaviour
{
    public PlayFabManager pf;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        string tempo = FineGioco.tempoFinale;
        text.text = tempo;

        string t_score = tempo;
        string t_score1 = t_score.Replace(":", string.Empty);
        string t_score2 = t_score1.Replace(",", string.Empty);
        int score = System.Convert.ToInt32(t_score2);
        PlayFabManager.SendLeaderboard(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
