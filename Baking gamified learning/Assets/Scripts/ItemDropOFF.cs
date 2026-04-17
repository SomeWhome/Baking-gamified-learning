using UnityEngine;

public class ItemDropOFF : MonoBehaviour
{
    public bool eggs = false;
    public bool flour = false;
    public bool butter = false;
    public bool milk = false;
    public bool sugar = false;
    public bool grabbedItem = false;
    float timer = 0.5f;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (grabbedItem == false)
        {
            Debug.Log("grabbed da item");
            if (collision.gameObject.CompareTag("Flour"))
            {
                Debug.Log("grabbedItem da flour");
                flour = true;

                
            }
            else if (collision.gameObject.CompareTag("eggs"))
            {
                eggs = true;


            }
            else if (collision.gameObject.CompareTag("butter"))
            {
                butter = true;


            }
            else if (collision.gameObject.CompareTag("milk"))
            {

                milk = true;


            }
            else if (collision.gameObject.CompareTag("sugar"))
            {
                sugar = true;


            }
        }
    }

    public void setGrabbed()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            grabbedItem = true;
        }
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check if its an oven
        if (collision.gameObject.CompareTag("Oven"))
        {
            if (eggs == true)
            {
                collision.gameObject.GetComponent<OvenScript>().eggs = true;
                grabbedItem = false;
                Destroy(gameObject);
            }
            else if (flour == true)
            {
                collision.gameObject.GetComponent<OvenScript>().flour = true;
                grabbedItem = false;
                Destroy(gameObject);
            }
            else if (butter == true)
            {
                collision.gameObject.GetComponent<OvenScript>().butter = true;
                grabbedItem = false;
            }
            else if (milk == true)
            {
                collision.gameObject.GetComponent<OvenScript>().milk = true;
                grabbedItem = false;
            }
            else if (sugar == true)
            {
                collision.gameObject.GetComponent<OvenScript>().sugar = true;
                grabbedItem = false;
            }
        }       

    }
}
