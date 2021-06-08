using UnityEngine;
using UnityEngine.UI;

public class tempoFinale : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        string tempo = FineGioco.tempoFinale;
        text.text = tempo;
    }

}
