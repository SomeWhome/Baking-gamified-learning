using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class WindowServing : MonoBehaviour
{
    public GameObject Score;
    public GameObject Order;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true && collision.gameObject.GetComponent<ItemDropOFF>().CAKE == true)
        {
            //score updated
            Score.GetComponent<ScoreUpdater>().ScoreUpdate();
            //Gets Cake as Game Object
            //cake consummed
            Destroy(GameObject.Find("Cake(Clone)"));
            //order deleted
            Order.GetComponent<OrderManager>().CompleteOrder();
        }
    }
}
