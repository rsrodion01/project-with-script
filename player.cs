using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip damageSound;
    public string sceneName;
    public int coins = 0;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int HP = 10;
    public int maxHP = 10;
    public void TakeDamage(int damage)
    {
        HP -= damage;
        print("Player HP:" + HP);
        audioSource.PlayOneShot(damageSound);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        }
        if (HP <= 0)
        {
            int SceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(SceneIndex);
        }
    }
    
    public void CollectCoins()
    {
        coins++;
        print("Collected coins:" + coins);
    }
}
