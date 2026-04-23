using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class OvenScript : MonoBehaviour
{
    public bool eggs = false;
    public bool flour = false;
    public bool butter = false;
    public bool milk = false;
    private bool baking = false;
    public bool sugar = false;
    public float timer = 15f;
    public bool TimerOver = false;
    public GameObject Cake;
    public GameObject oven;
    private Vector2 CakeSpawnPosition;

    private void Update()
    {
        if (timer >= 0)
        {
            if (baking == true)
            {
                timer -= Time.deltaTime;
            }
        }
        if (timer <= 0 )
        {
            TimerOver = true;
            BakedGoods();
        }
    }

    public void CheckIngreidents()
    {
        if (eggs == true && flour == true && butter == true && milk == true && sugar == true)
        {
            cook();

        }
    }



    private void cook()
    {
        eggs = false;
        flour = false;
        butter = false;
        milk = false;
        sugar = false;
        baking = true;
    }
    private void BakedGoods()
    {
        oven = gameObject;
        CakeSpawnPosition = gameObject.transform.position;

        float x = CakeSpawnPosition.x;
        float y = CakeSpawnPosition.y;
        CakeSpawnPosition.y += 1f;
        Instantiate(Cake, CakeSpawnPosition, gameObject.transform.rotation);
        baking = false;
        timer = 15f;
    }
}
