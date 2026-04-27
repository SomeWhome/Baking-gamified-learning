using UnityEngine;
using UnityEngine.UI;
using Unity.Mathematics;

public class MixerScript : MonoBehaviour
{
    public bool eggs = false;
    public bool flour = false;
    public bool butter = false;
    public bool milk = false;
    private bool baking = false;
    public bool sugar = false;
    public float timer = 15f;
    public bool TimerOver = false;
    public GameObject CakeMix;
    public GameObject Mixer;
    private Vector2 CakeMixSpawnPosition;
    public Text Timer;
    private float TimeLeft;

    private void Update()
    {
        if (timer >= 0)
        {
            if (baking == true)
            {
                timer -= Time.deltaTime;
                TimeLeft = (float)math.round(timer);
                Timer.text = "Oven Finished:" + TimeLeft.ToString();
            }
        }
        if (timer <= 0)
        {
            TimerOver = true;
            BakedGoods();
        }
    }

    public void CheckIngreidents()
    {
        if (eggs == true && flour == true && butter == true && milk == true && sugar == true)
        {
            Mix();

        }
    }



    private void Mix()
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
        Mixer = gameObject;
        CakeMixSpawnPosition = gameObject.transform.position;

        float x = CakeMixSpawnPosition.x;
        float y = CakeMixSpawnPosition.y;
        CakeMixSpawnPosition.y += 1f;
        Instantiate(CakeMix, CakeMixSpawnPosition, gameObject.transform.rotation);
        baking = false;
        timer = 15f;
    }
}
