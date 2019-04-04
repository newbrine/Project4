using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToDeck : MonoBehaviour
{

    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject card6;
    System.Random rand = new System.Random();

    private List<string> Cards = new List<string>(); 
    public List<string> usedCards;

    void Start()
    {
        Cards.Add("card1");
        Cards.Add("card2");
        Cards.Add("card3");
        Cards.Add("card4");
        Cards.Add("card5");
        Cards.Add("card6");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            for (int i = 0; i < 3; i++)
            {
                if(usedCards[i] != null)
                {
                    Cards.Add(usedCards[i]);
                }
            }
            usedCards.Clear();

            card1.gameObject.SetActive(true);
            card2.gameObject.SetActive(true);
            card3.gameObject.SetActive(true);
            card4.gameObject.SetActive(true);
            card5.gameObject.SetActive(true);
            card6.gameObject.SetActive(true);

            int counter = 1;
            for(int i = 5; i >= 3; i++)
            {
                int temp = rand.Next(0, i);
                usedCards.Add(Cards[temp]);

                if (Cards[temp] == "card1")
                {
                    card1.transform.position = new Vector2(-30 - (5 * i), 4);
                }
                if (Cards[temp] == "card2")
                {
                    card2.transform.position = new Vector2(-30 - (5 * i), 4);
                }
                if (Cards[temp] == "card3")
                {
                    card3.transform.position = new Vector2(-30 - (5 * i), 4);
                }
                if (Cards[temp] == "card4")
                {
                    card4.transform.position = new Vector2(-30 - (5 * i), 4);
                }
                if (Cards[temp] == "card5")
                {
                    card5.transform.position = new Vector2(-30 - (5 * i), 4);
                }
                if (Cards[temp] == "card6")
                {
                    card6.transform.position = new Vector2(-30 - (5 * i), 4);
                }

                Cards.Remove(Cards[temp]);
                counter = counter + 1;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "baseAttack")
        {
            card1 = collision.gameObject;
        }
        if (collision.gameObject.name == "baseAttack2")
        {
            card2 = collision.gameObject;
        }
        if (collision.gameObject.name == "baseDefense")
        {
            card3 = collision.gameObject;
        }
        if (collision.gameObject.name == "baseHealth")
        {
            card4 = collision.gameObject;
        }
        if (collision.gameObject.name == "baseHealth2")
        {
            card5 = collision.gameObject;
        }
        if (collision.gameObject.name == "baseSpeed")
        {
            card6 = collision.gameObject;
        }
    }
}
