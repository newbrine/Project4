using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCard : MonoBehaviour
{

    public BlobController hero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "baseAttack")
        {
            hero.buffAttack(1);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "baseAttack2")
        {
            hero.buffAttack(1);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "baseHealth")
        {
            hero.buffHealth(1);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "baseHealth2")
        {
            hero.buffHealth(1);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "baseSpeed")
        {
            hero.buffSpeed(1);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "baseDefense")
        {
            hero.buffDefense(1);
            collision.gameObject.SetActive(false);
        }
    }
}
