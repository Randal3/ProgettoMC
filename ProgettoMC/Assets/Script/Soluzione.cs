using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soluzione : MonoBehaviour
{
    public static bool youWin;
    public Transform[] pictures;
    public GameObject player;
    public GameObject game;
    public GameObject retun;
   // public GameObject but;
    public GameObject joystick;
    public bool open;
    public GameObject libro1;
    private bool cont;
    public GameObject enemy;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        youWin = false;
        cont = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((pictures[0].rotation.eulerAngles.z == 180 || pictures[0].rotation.eulerAngles.z <= 10) &&
             pictures[1].rotation.eulerAngles.z == 0 &&
             pictures[2].rotation.eulerAngles.z == 180 && 
            (pictures[3].rotation.eulerAngles.z <= 10 || pictures[3].rotation.eulerAngles.z == 180 ) &&
             pictures[4].rotation.eulerAngles.z == 180 &&
             pictures[5].rotation.eulerAngles.z == 270)
        {
            youWin = true;
            game.SetActive(false);
            player.SetActive(true);
            //camera.enabled = true;
           // but.SetActive(true);
            joystick.SetActive(true);
            retun.SetActive(false);
            if (cont == false)
            {
                enemy.transform.position = spawn.transform.position;
                enemy.SetActive(true);
                libro1.SetActive(true);
                cont= true;
                Luci.luci = true;
            }

        }
    }
}
