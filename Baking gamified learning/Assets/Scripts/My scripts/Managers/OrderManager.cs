using Mono.Cecil.Cil;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    //Vairables
    private int OrderCap;
    private int OrderAmmount;
    private string ItemToBake;
    private void Start()
    {
        Order();
    }

    public void Order()
    {
        if (OrderCap != OrderAmmount)
        {
            if (ItemToBake == "Cake")
            {
                OrderAmmount = +1;
               
            }
        }
    }
}
