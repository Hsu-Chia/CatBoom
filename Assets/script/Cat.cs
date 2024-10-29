using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    [SerializeField] private int level = 1; // 貓的等級
    [SerializeField] private GameObject mergeEffect; // 合成特效 Prefab

    private CatSpawner catSpawner;

    private void Start()
    {
        catSpawner = FindObjectOfType<CatSpawner>();
    }

    public int Level => level;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Cat otherCat = collision.gameObject.GetComponent<Cat>();

        if (otherCat != null && otherCat.Level == this.level)
        {
            if (this.level == 10)
            {
                Destroy(otherCat.gameObject);
                Destroy(this.gameObject);
                Debug.Log("兩隻 Level 10 的貓碰撞並被移除");
            }
            else
            {
                MergeWith(otherCat);
            }
        }
    }

    private void MergeWith(Cat otherCat)
    {
        this.level += 1;
        Destroy(otherCat.gameObject);
        Debug.Log($"合成成功，生成 Level {this.level} 的貓");

        if (mergeEffect != null)
        {
            Instantiate(mergeEffect, transform.position, Quaternion.identity);
        }

        ReplaceWithNextLevel();
    }

    private void ReplaceWithNextLevel()
    {
        GameObject newCatPrefab = catSpawner.GetCatPrefab(this.level);
        if (newCatPrefab != null)
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            SpriteRenderer newCatSpriteRenderer = newCatPrefab.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null && newCatSpriteRenderer != null)
            {
                spriteRenderer.sprite = newCatSpriteRenderer.sprite;
            }
        }
    }
}