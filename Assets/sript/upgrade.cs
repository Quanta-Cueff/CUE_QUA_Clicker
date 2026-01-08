using UnityEngine;
using TMPro;

public class upgrade : MonoBehaviour
{
    public float prix;
    public stat stat;
    public sell sell;
    public TextMeshProUGUI selltext;
    public TextMeshProUGUI upgradetext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void achat()
    {
        if(stat.money >= prix)
        {
            stat.money -= prix;
            prix *= 2;
            sell.valeur += 0.1f;
            selltext.text = $"sell\r\n1w/h={sell.valeur}";
            upgradetext.text = $"nouvaus contras\n{prix}={sell.valeur+0.1f}$/w/h";

        }
    }
}
