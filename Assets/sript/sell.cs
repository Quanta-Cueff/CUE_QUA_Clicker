using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sell : MonoBehaviour
{
    public stat stat;
    public float valeur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sell_power()
    {
        stat.money = stat.money+stat.power*valeur;
        stat.power = 0;
        
        

    }
}
