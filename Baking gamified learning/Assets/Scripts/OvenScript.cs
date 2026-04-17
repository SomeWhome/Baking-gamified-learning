using Unity.VisualScripting;
using UnityEngine;

public class OvenScript : MonoBehaviour
{
    public bool eggs = false;
    public bool flour = false;
    public bool butter = false;
    public bool milk = false;
    public bool sugar = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (eggs == true && flour == true && butter == true && milk == true && sugar == true)
        {
            cook();

        }
    }


    private void cook()
    {
        Debug.Log("oven runs");
    }
}
