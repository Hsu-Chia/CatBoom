using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    public GameObject projectile;
    public GameObject Spawnposition;
    // Start is called before the first frame update
    void Start()
    {

        // 生成物件並設置其位置
    }

    // Update is called once per frame
    void Update()
    {
        Mouseleftclick();
    }

    void Mouseleftclick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Vector2 v2 = Input.mousePosition;
            //Debug.Log(Input.mousePosition);
            Instantiate(projectile,Spawnposition.transform.position, Quaternion.identity);
            Debug.Log("yes");
        }
    }
}
