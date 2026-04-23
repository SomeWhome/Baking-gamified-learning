using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class WindowServing : MonoBehaviour
{
    public int score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered");
        if (collision.CompareTag("Player") == true)
        {
            Debug.Log("Running");
            //score updated
            score = +100;
            //Gets Cake as Game Object
            //cake consummed
            Destroy(GameObject.Find("Cake(Clone)"));
        }
    }
}
