using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FineGioco : MonoBehaviour
{
    public Gestore_Indovinelli gestoreIndovinelli;
    public GameObject fuga;
    public GameObject haiFinito;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    public void FinisciGioco()
    {
        bool isFinito = gestoreIndovinelli.GetComponent<Gestore_Indovinelli>().isFinito();
        if (isFinito)
        {
            this.fuga.SetActive(true);
            this.haiFinito.SetActive(true);
        }
        else
            Debug.Log("non hai ancora finito");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("FineGioco");
        }
    }
}
