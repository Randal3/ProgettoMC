using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    [SerializeField] private GameObject Inventory;
    [SerializeField] private bool activate = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            activate = !activate;
        }
        if (activate)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }
    void ActivateMenu()
    {
        Inventory.SetActive(true);
    }
    void DeactivateMenu()
    {
        Inventory.SetActive(false);
    }
}
