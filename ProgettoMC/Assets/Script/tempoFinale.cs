using UnityEngine;
using UnityEngine.UI;

public class tempoFinale : MonoBehaviour
{
    public PlayFabManager pf;
    public Text text;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        pf = pf.GetComponent<PlayFabManager>();
        string tempo = FineGioco.tempoFinale;
        text.text = tempo;

        string t_score = tempo;
        string t_score1 = t_score.Replace(":", string.Empty);
        string t_score2 = t_score1.Replace(",", string.Empty);
        this.score = System.Convert.ToInt32(t_score2);
        pf.Login();

    }

    public int getScore()
    {
        return this.score;
    }
}
