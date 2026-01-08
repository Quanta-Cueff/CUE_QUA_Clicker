using TMPro;
using UnityEngine;

public class barge_generateur : MonoBehaviour
{
    public stat stat;
    public float maxbarage;
    public float barage;
    public TextMeshProUGUI baragetexte;
    public TextMeshProUGUI powertexte;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        stat.power += Time.deltaTime * 100000 * barage;
    }
    public void addbarage()
    {
        if (stat.ground >= 4)
        {
            stat.ground -= 4;
            maxbarage += 1;
            baragetexte.text = $"{barage}/{(maxbarage)}";
        }
    }
    public void lessbarage()
    {
        if (maxbarage > 0)
        {
            stat.ground += 4;
            if (barage >= (maxbarage - 1))
            {
                stat.money -= ((maxbarage - 1) - barage) * 100000;
                barage = (maxbarage - 1);
            }
            maxbarage -= 1;
            baragetexte.text = $"{barage}/{(maxbarage)}";
        }
    }
    public void buybarage()
    {
        if (stat.money >= 1000000 & (maxbarage)  > barage)
        {
            stat.money -= 1000000;
            barage += 1;
            baragetexte.text = $"{barage}/{(maxbarage)}";
            powertexte.text = $"{barage * 100}kw/h/s";
            powertexte.text = $"{barage * 100}kw/h/s";
        }
    }
    public void sellbarage()
    {
        if (barage > 0)
        {
            barage -= 1;
            stat.money += 100000;
            baragetexte.text = $"{barage}/{(maxbarage) }";
            powertexte.text = $"{barage * 100}kw/h/s";
        }
    }
}