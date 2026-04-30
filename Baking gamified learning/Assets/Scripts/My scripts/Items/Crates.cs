using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class Crates : MonoBehaviour
{
    public GameObject spawnedObject;
    private Vector2 SpawnPosition;
    public Quaternion spawnedRotation = Quaternion.identity;
    public KeyCode activationKey = KeyCode.E;
    private bool entered =  false;
    public bool spawneditem = false;
    private GameObject crate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject != null)
        {
            crate = gameObject;
            SpawnPosition = gameObject.transform.position;

            float x = SpawnPosition.x;
            float y = SpawnPosition.y;
            SpawnPosition.y += 0.5f;
          
        }
        else
        {
            Debug.LogWarning("Target object is not assigned");
        }

        if (entered && Input.GetKeyDown(activationKey))
        {
            if (spawneditem == false)
            {
                GameObject itemSpawned = Instantiate(spawnedObject, SpawnPosition, gameObject.transform.rotation);
                spawneditem = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        entered = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        entered = false;
    }

}


