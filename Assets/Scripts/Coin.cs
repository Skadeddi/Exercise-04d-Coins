using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            Player.coins++;
            Debug.Log(Player.coins);
            GameObject.Find("CoinSoundHandler").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }
}
