using UnityEngine;

public class ItemGrabber : MonoBehaviour
{
    public GameObject SpawnedItem;
    public GameObject Player;
    private Vector2 SpawnPosition;
 

    private void Start()
    {
        Player = GameObject.Find("Player");
        if (Player == null)
        {
            {
                Debug.LogWarning("Player Not assigned");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ItemDropOFF PlayerHolder = collision.gameObject.GetComponent<ItemDropOFF>();
        if (collision.gameObject.CompareTag("Player") && (PlayerHolder.grabbedItem == false))
        {

            SpawnPosition.y = 1f;
            SpawnPosition.x = 0f;
            SpawnedItem.transform.position = SpawnPosition;
            SpawnedItem.transform.SetParent(Player.transform, false);
            if (gameObject.GetComponent<BoxCollider2D>() != null)
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                //PlayerHolder.grabbedItem = true;
            }
            else if (gameObject.GetComponent<CircleCollider2D>() != null)
            {
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
                //PlayerHolder.grabbedItem = true;
            }
            else
            {
                Debug.LogWarning("Collider is not found");
            }
        }
    }
}

