using Mono.Cecil.Cil;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OrderManager : MonoBehaviour
{
    //Vairables
    private int OrderCap = 5;
    private int OrderAmmount = 0;
    private string ItemToBake;
    private List<string> ItemList;
    public List<Text> UIList;
    private float timer = 20f;
    private float timeleft;
    public Text OrderTimer;
    public Text FlourTick;
    public Text ButterTick;
    public Text EggTick;
    public Text MilkTick;
    public Text SugarTick;
    private void Start()
    {
        ItemToBake = "Cake";
        Order();

    }
    private void Update()
    {


        if (timer >= 0)
        {
            if (OrderCap <= 5)
            {
                timer -= Time.deltaTime;
                timeleft = timer;
                timeleft = (float)math.round(timeleft);
                OrderTimer.text = "Time till order:" + timeleft.ToString();
            }
        }
        else
        {
            timer = 20f;
            Order();
        }
    }
    public void Order()
    {
        if (OrderCap != OrderAmmount)
        {
            if (ItemToBake == "Cake")
            {
                OrderAmmount +=1;
                ItemList.Add("Cake");
                for (int i = 0; i < ItemList.Count; i++)
                {
                    UIList[i].text = ItemList[i].ToString();
                }
            }
        }
    }

    public bool CompleteOrder()
    {
        for (int i = 0; i < OrderCap; i++)
        {
            Debug.Log(ItemList[i]);
            if (ItemList[i] == "Cake")
            {
                ItemList.RemoveAt(i);
                return true;
            }
        }
        return true;
    }

    
}
