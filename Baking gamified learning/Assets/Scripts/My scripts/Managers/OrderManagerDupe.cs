using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OrderManagerDupe : MonoBehaviour
{
    //Vairables
    private int OrderCap = 5;
    private int OrderAmmount = 0;
    private string ItemToBake;
    private List<string> ItemList;
    private string[] BakingList = {null, null, null, null, null };
    public List<Text> UIList;
    private float timer = 40f;
    private float timeleft;
    public Text OrderTimer;
    public static int OrderCount;




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
            timer = 40f;
            Order();
        }
    }
    public void Order()
    {
        if (OrderCap != OrderAmmount)
        {
            if (ItemToBake == "Cake")
            {
                OrderCount += 1;
                OrderAmmount += 1;
                earliestInList(ItemToBake);
                for (int i = 0; i < BakingList.Length; i++)
                {
                    if(BakingList[i] != null && BakingList[i] != "null")
                        UIList[i].text = BakingList[i].ToString();
                }
            }
        }
    }

    private bool earliestInList(string addition)
    {
        for (int i = 0; i < OrderCap; i++)
        {

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
            if (BakingList[4-i] == "Cake")
            {
                OrderCount --;
                OrderAmmount--;
                BakingList[4-i] = "null";
                UIList[4-i].text = "";
                  
                return true;
            }
        }
        return true;
    }
}
