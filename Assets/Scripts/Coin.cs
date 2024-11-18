using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin : MonoBehaviour
{
    public float screentime = 4.0f;
    
    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, screentime);
    }

    // Player picks up the coin
    public void PlayerPickUp(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().EarnScore(1);

            Destroy(gameObject);
        }      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
