using Mono.Cecil.Cil;
using System.Collections.Generic;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    //Vairables
    private int OrderCap = 5;
    private int OrderAmmount = 0;
    private string ItemToBake;
    private List<string> ItemList;
    private float timer = 20f;
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
            }
        }
    }
    public void Order()
    {
        if (OrderCap != OrderAmmount)
        { 
            if (ItemToBake == "Cake")
            {
                OrderAmmount = +1;
                ItemList = new List<string> { "Cake" };
                Debug.Log(ItemList);

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
