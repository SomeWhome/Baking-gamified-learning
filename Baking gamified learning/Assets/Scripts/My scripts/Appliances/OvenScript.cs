using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;
using Unity.Mathematics;

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
    public Text Timer;
    private float TimeLeft;
    public Text FlourTick;
    public Text ButterTick;
    public Text EggTick;
    public Text MilkTick;
    public Text SugarTick;

    private void Update()
    {
        if (timer >= 0)
        {
            if (baking == true)
            {
                timer -= Time.deltaTime;
                TimeLeft = (float)math.round(timer);
                Timer.text = "Timer till Cake baked:" + TimeLeft.ToString();
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
        EggTick.gameObject.SetActive(false);
        flour = false;
        FlourTick.gameObject.SetActive(false);
        butter = false;
        ButterTick.gameObject.SetActive(false);
        milk = false;
        MilkTick.gameObject.SetActive(false);
        sugar = false;
        SugarTick.gameObject.SetActive(false);
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
