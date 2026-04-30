using UnityEngine;
using UnityEngine.UI;

public class ItemDropOFF : MonoBehaviour
{
    public bool eggs = false;
    public bool flour = false;
    public bool butter = false;
    public bool milk = false;
    public bool sugar = false;
    public bool grabbedItem = false;
    public bool CAKE = false;
    public bool Cakebatter = false;
    //float timer = 0.5f;
    private GameObject item;
    public GameObject Flower_crate;
    public GameObject Sugar_crate;
    public GameObject Butter_crate;
    public GameObject Milk_crate;
    public GameObject Eggs_crate;
    public GameObject mixer;
    public Text FlourTick;
    public Text ButterTick;
    public Text EggTick;
    public Text MilkTick;
    public Text SugarTick;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (grabbedItem == false)
        {
            if (collision.gameObject.CompareTag("Flour"))
            {
                flour = true;
                item = collision.gameObject;
                grabbedItem = true;
                FlourTick.gameObject.SetActive(true);
            }
            else if (collision.gameObject.CompareTag("eggs"))
            {
                eggs = true;
                item = collision.gameObject;
                grabbedItem = true;
                EggTick.gameObject.SetActive(true);
            }
            else if (collision.gameObject.CompareTag("butter"))
            {
                butter = true;
                item = collision.gameObject;
                grabbedItem = true;
                ButterTick.gameObject.SetActive(true);
            }
            else if (collision.gameObject.CompareTag("milk"))
            {

                milk = true;
                item = collision.gameObject;
                grabbedItem = true;
                MilkTick.gameObject.SetActive(true);
            }
            else if (collision.gameObject.CompareTag("sugar"))
            {
                sugar = true;
                item = collision.gameObject;
                grabbedItem = true;
                SugarTick.gameObject.SetActive(true);
            }
            else if(collision.gameObject.CompareTag("Cake"))
            {
               CAKE = true;
                item = collision.gameObject;
                grabbedItem= true;
            }
            else if(collision.gameObject.CompareTag("CakeBatter"))
            {
                Cakebatter = true;
                item = collision.gameObject;
                grabbedItem= true;
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
        //check if its an oven
        if (collision.gameObject.CompareTag("Mixer"))
        {
            if (eggs == true)
            {
                collision.gameObject.GetComponent<MixerScript>().eggs = true;
                collision.gameObject.GetComponent<MixerScript>().CheckIngreidents();
                grabbedItem = false;
                Destroy(item);
                eggs = false;
                Eggs_crate.GetComponent<Crates>().spawneditem = false;
            }
            else if (flour == true)
            {
                collision.gameObject.GetComponent<MixerScript>().flour = true;
                collision.gameObject.GetComponent<MixerScript>().CheckIngreidents();
                grabbedItem = false;
                Destroy(item);
                flour = false;
                Flower_crate.GetComponent<Crates>().spawneditem = false ;
            }
            else if (butter == true)
            {
                collision.gameObject.GetComponent<MixerScript>().butter = true;
                collision.gameObject.GetComponent<MixerScript>().CheckIngreidents();
                grabbedItem = false;
                Destroy(item);
                butter = false;
                Butter_crate.GetComponent<Crates>().spawneditem = false;
            }
            else if (milk == true)
            {
                collision.gameObject.GetComponent<MixerScript>().milk = true;
                collision.gameObject.GetComponent<MixerScript>().CheckIngreidents();
                grabbedItem = false;
                Destroy(item);
                milk = false;
                Milk_crate.GetComponent<Crates>().spawneditem = false;
            }
            else if (sugar == true)
            {
                collision.gameObject.GetComponent<MixerScript>().sugar = true;
                collision.gameObject.GetComponent<MixerScript>().CheckIngreidents();
                grabbedItem = false;
                Destroy(item);
                sugar = false;
                Sugar_crate.GetComponent<Crates>().spawneditem = false;
            }
            else if (Cakebatter ==  true)
            {

            }
        }
        if (collision.gameObject.CompareTag("Oven") && Cakebatter == true)
        {
            collision.gameObject.GetComponent<OvenScript2>().cook();
            grabbedItem = false;
            Destroy(item);
            Cakebatter = false;
        }

        //if (grabbedItem == false)
        //{
        //    gameObject.GetComponent<Crates>().spawneditem = false;
        //}
    }
}
