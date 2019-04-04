using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobController : MonoBehaviour
{
    private float speed = 7;
    private Rigidbody2D rb2D;
    private Vector2 velocity;
    public int health = 1;
    public int attack = 1;
    public int defense = 1;
    public int attackSpeed = 1;
    private bool roundOver = false;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + velocity * Time.deltaTime);
    }

    void Update()
    {
        float inp = Input.GetAxis("Horizontal");
        velocity = new Vector2(inp * speed, rb2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector3(-55, -4);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(-26, -3);
            roundOver = false;
        }
    }

    public int getAttack()
    {
        return this.attack;
    }

    public int getHealth()
    {
        return this.health;
    }

    public int getSpeed()
    {
        return this.attackSpeed;
    }

    public int getDefense()
    {
        return this.defense;
    }

    public void buffAttack(int value)
    {
        this.attack = this.attack + value;
    }

    public void buffHealth(int value)
    {
        this.health = this.health + value;
    }

    public void buffSpeed(int value)
    {
        this.attackSpeed = this.attackSpeed + value;
    }

    public void buffDefense(int value)
    {
        this.defense = this.defense + value;
    }
}
