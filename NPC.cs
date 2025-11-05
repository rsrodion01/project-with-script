using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int level = 1;
    public string name;
    public float speed = 1.2f;
    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        //Здесь мы увеличиваем здоровье игрока на его уровень
        health += level;
    }

    // Update is called once per frame
    void Update()
    {
        print(level + " " + name);
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
