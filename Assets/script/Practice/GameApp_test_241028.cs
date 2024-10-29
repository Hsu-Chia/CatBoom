using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApp_test_241028 : MonoBehaviour
{
    // Start is called before the first frame update
   Character character1;
   Character character2;
   Character character3;
   Store store;
   DisplayUI displayUI;

    void Start()
    {
        character1 = new Character();
        character2 = new Character();
        character3 = new Character();
        store = new Store();
        displayUI = new DisplayUI();
        character1.Move(10);
        character1.DisplayStatus();
        character1.Attack();
        character2.Move(100);
        store.StoreSell();
        displayUI.TEST_UI();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
