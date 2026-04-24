using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class WindowServing : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered");
        if (collision.CompareTag("Player") == true)
        {
            Debug.Log("Running");
            //score updated
            collision.gameObject.GetComponent<ScoreUpdater>().ScoreUpdate();
            //Gets Cake as Game Object
            //cake consummed
            Destroy(GameObject.Find("Cake(Clone)"));
        }
    }
}
