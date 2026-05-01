
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
    private string[] BakingList;
    public List<Text> UIList;
    private float timer = 20f;
    private float timeleft;
    public Text OrderTimer;



    private void Start()
    {
        ItemToBake = "Cake";
        Order();
        BakingList[0] = "food";

        Debug.Log("food");
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
                earliestInList(ItemToBake);
                for (int i = 0; i < BakingList.Length; i++)
                {
                    UIList[i].text = BakingList[i].ToString();
                }
            }
        }
    }

    private bool earliestInList(string addition)
    {
        for (int i = 0; i < OrderCap; i++)
        {
            Debug.Log(BakingList[i]);
            if (BakingList[i] == null || BakingList[i] == "null")
            {
                BakingList[i] = addition;
                return true;
            }
        }

        return false;
    }

    public bool CompleteOrder()
    {
        for (int i = 0; i < OrderCap; i++)
        {
            if (BakingList[i] == "Cake")
            {
                BakingList[i] = "null";
                return true;
            }
        }
        return true;
    }

    
}
