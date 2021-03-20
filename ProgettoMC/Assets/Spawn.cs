using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    float x, y, randx, randy;
    float time = 10;
    Vector2 position;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.B))
            {
                x = player.transform.position.x;
                y = player.transform.position.y;
                randx = Random.Range(x + 5, x + 8);
                randy = Random.Range(y + 5, y + 8);
                position = new Vector2(randx, randy);
                enemy.transform.position = position;
                enemy.SetActive(true);

            }
        }
}
