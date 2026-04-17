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
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            PlayerHolder.setGrabbed();
        }
    }
}

