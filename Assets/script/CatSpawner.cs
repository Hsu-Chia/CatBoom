using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using System.Collections;

public class CatSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] catPrefabs; // 各等級的貓 Prefab（0=Level1, 1=Level2, ..., 9=Level10）
    [SerializeField]
    private GameObject Spawnposition;

    private GameObject currentCat; // 用來儲存當前生成的貓物件
    private bool isDragging = false; // 控制是否正在拖曳中
    private bool isSpawning = false; // 控制是否正在生成新貓
    private float initialYPosition; // 儲存 CatSpawner 的初始 Y 軸位置

    void Start()
    {
        initialYPosition = transform.position.y; // 記錄初始的 Y 軸位置
        RebornCat(); 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isSpawning)
        {
            isDragging = true;
        }

        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, initialYPosition, 0);

            if (currentCat != null)
            {
                currentCat.transform.position = new Vector3(mousePosition.x, currentCat.transform.position.y, 0);
            }
        }

        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;
            DropCat();
            StartCoroutine(SpawnCatWithDelay());
        }
    }

    void RebornCat()
    {
        if (catPrefabs.Length == 0)
        {
            Debug.LogWarning("貓的 Prefab 陣列是空的！");
            return;
        }

        int randomIndex = Random.Range(0, catPrefabs.Length);
        GameObject selectedPrefab = catPrefabs[randomIndex];

        currentCat = Instantiate(selectedPrefab, Spawnposition.transform.position, Quaternion.identity);

        Rigidbody2D newCatRb = currentCat.GetComponent<Rigidbody2D>();
        
        if (newCatRb != null)
        {
            newCatRb.gravityScale = 0;
        }

        Debug.Log("生成成功");
    }

    void DropCat()
    {
        if (currentCat != null)
        {
            Rigidbody2D catRb = currentCat.GetComponent<Rigidbody2D>();
            if (catRb != null)
            {
                catRb.gravityScale = 1;
                Debug.Log("貓下落了");
            }
        }
    }

    public GameObject GetCatPrefab(int level)
    {
        if (level > 0 && level <= catPrefabs.Length)
        {
            return catPrefabs[level - 1];
        }
        else
        {
            Debug.LogWarning($"無法找到 Level {level} 的貓，請確認 catPrefabs 設置正確");
            return null;
        }
    }

    IEnumerator SpawnCatWithDelay()
    {
        isSpawning = true;
        yield return new WaitForSeconds(2);
        RebornCat();
        isSpawning = false;
    }
}