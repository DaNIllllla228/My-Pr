using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Здоровье NPC
        int health = 5;

        //уровень NPC
        int level = 1;

        //скорость NPC
        int speed = 1.2f;

        health = health + level;
            print(5+health)
    }

    // Update is called once per frame
    void Update()
    {
       
    

    }
}
