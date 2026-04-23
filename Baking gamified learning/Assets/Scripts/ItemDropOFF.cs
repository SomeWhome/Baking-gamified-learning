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
    private GameObject item;
    public GameObject Flower_crate;
    public GameObject Sugar_crate;
    public GameObject Butter_crate;
    public GameObject Milk_crate;
    public GameObject Eggs_crate;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (grabbedItem == false)
        {
            if (collision.gameObject.CompareTag("Flour"))
            {
                flour = true;
                item = collision.gameObject;
                grabbedItem = true;
            }
            else if (collision.gameObject.CompareTag("eggs"))
            {
                eggs = true;
                item = collision.gameObject;
                grabbedItem = true;
            }
            else if (collision.gameObject.CompareTag("butter"))
            {
                butter = true;
                item = collision.gameObject;
                grabbedItem = true;
            }
            else if (collision.gameObject.CompareTag("milk"))
            {

                milk = true;
                item = collision.gameObject;
                grabbedItem = true;
            }
            else if (collision.gameObject.CompareTag("sugar"))
            {
                sugar = true;
                item = collision.gameObject;
                grabbedItem = true;
            }

            
        }
    }

    //public void setGrabbed()
    //{
    //    timer -= Time.deltaTime;
    //    if (timer < 0)
    //    {
    //        grabbedItem = true;
    //    }
    //}
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger enter");
        //check if its an oven
        if (collision.gameObject.CompareTag("Oven"))
        {
            Debug.Log("oven enter");
            if (eggs == true)
            {
                collision.gameObject.GetComponent<OvenScript>().eggs = true;
                collision.gameObject.GetComponent<OvenScript>().CheckIngreidents();
                grabbedItem = false;
                Destroy(item);
                eggs = false;
                Eggs_crate.GetComponent<Crates>().spawneditem = false;
            }
            else if (flour == true)
            {
                collision.gameObject.GetComponent<OvenScript>().flour = true;
                collision.gameObject.GetComponent<OvenScript>().CheckIngreidents();
                grabbedItem = false;
                Destroy(item);
                flour = false;
                Flower_crate.GetComponent<Crates>().spawneditem = false ;
            }
            else if (butter == true)
            {
                collision.gameObject.GetComponent<OvenScript>().butter = true;
                collision.gameObject.GetComponent<OvenScript>().CheckIngreidents();
                grabbedItem = false;
                Destroy(item);
                butter = false;
                Butter_crate.GetComponent<Crates>().spawneditem = false;
            }
            else if (milk == true)
            {
                collision.gameObject.GetComponent<OvenScript>().milk = true;
                collision.gameObject.GetComponent<OvenScript>().CheckIngreidents();
                grabbedItem = false;
                Destroy(item);
                milk = false;
                Milk_crate.GetComponent<Crates>().spawneditem = false;
            }
            else if (sugar == true)
            {
                collision.gameObject.GetComponent<OvenScript>().sugar = true;
                collision.gameObject.GetComponent<OvenScript>().CheckIngreidents();
                grabbedItem = false;
                Destroy(item);
                sugar = false;
                Sugar_crate.GetComponent<Crates>().spawneditem = false;
            }
        }

        //if (grabbedItem == false)
        //{
        //    gameObject.GetComponent<Crates>().spawneditem = false;
        //}
    }
}
