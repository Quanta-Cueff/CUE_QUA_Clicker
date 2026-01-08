using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class solar_generateur : MonoBehaviour
{
    public stat stat;
    public float maxsolare;
    public float solar;
    public TextMeshProUGUI solartexte;
    public TextMeshProUGUI powertexte;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stat.power += Time.deltaTime * 10 * solar;
    }
    public void addsolar()
    {
        if (stat.ground > 0)
        {
            stat.ground -= 1;
            maxsolare += 1;
            solartexte.text = $"{solar}/{(maxsolare + 1) * 20}";
        }
    }
    public void lesssolar()
    {
        if ( maxsolare > 0)
        {
            stat.ground += 1;
            if (solar >= maxsolare*20)
            {
                stat.money -= (maxsolare*20 - solar) * 80;
                solar = maxsolare*20;
            }
            maxsolare -= 1;
            solartexte.text = $"{solar}/{(maxsolare + 1) * 20}";
        }
    }
    public void buysolar()
    {
        if (stat.money >= 100 & (maxsolare+1)*20 > solar)
        {
            stat.money -= 100;
            solar += 1;
            solartexte.text = $"{solar}/{(maxsolare+1)*20}";
            powertexte.text = $"{solar * 10}w/h/s";
        }
    }
    public void sellsolar()
    {
        if (solar > 0)
        {
            solar -= 1;
            stat.money += 80;
            solartexte.text = $"{solar}/{(maxsolare + 1) * 20}";
            powertexte.text = $"{solar * 10}w/h/s";
        }
    }
}
