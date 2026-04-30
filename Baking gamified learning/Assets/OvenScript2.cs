using UnityEngine;
using UnityEngine.UI;
using Unity.Mathematics;
public class OvenScript2 : MonoBehaviour
{
    public float timer = 15f;
    public bool TimerOver = false;
    public GameObject Cake;
    public GameObject oven;
    private Vector2 CakeSpawnPosition;
    public Text Timer;
    private float TimeLeft;
    private bool baking = false;
    public bool CakeBatter = false;

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            if (baking == true)
            {
                timer -= Time.deltaTime;
                TimeLeft = (float)math.round(timer);
                Timer.text = "Timer till Cake baked:" + TimeLeft.ToString();
            }
            if (timer <= 0)
            {
                TimerOver = true;
                BakedGoods();
            }
        }
    }

    public void cook()
    {
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
