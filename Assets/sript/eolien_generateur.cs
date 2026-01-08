using UnityEngine;
using TMPro;
using System.Drawing;

public class eolien_generateur : MonoBehaviour
{
    public stat stat;
    public float maxeolien;
    public float eolien;
    public TextMeshProUGUI eolientexte;
    public TextMeshProUGUI powertexte;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        stat.power += Time.deltaTime * 1000 * eolien;
    }
    public void addeolien()
    {
        if (stat.ground > 0)
        {
            stat.ground -= 1;
            maxeolien += 1;
            eolientexte.text = $"{eolien}/{(maxeolien) * 5}";
        }
    }
    public void lesseolien()
    {
        if (maxeolien > 0)
        {
            stat.ground += 1;
            if (eolien >= (maxeolien-1) * 5)
            {
                stat.money -= ((maxeolien-1)*5 - eolien) * 60000;
                eolien = (maxeolien-1) * 5;
            }
            maxeolien -= 1;
            eolientexte.text = $"{eolien}/{(maxeolien) * 5}";
        }
    }
    public void buyeolien()
    {
        if (stat.money >= 100000 & (maxeolien ) * 5 > eolien)
        {
            stat.money -= 100000;
            eolien += 1;
            eolientexte.text = $"{eolien}/{(maxeolien) * 5}";
            powertexte.text = $"{eolien * 1}kw/h/s";
        }
    }
    public void selleolien()
    {
        if (eolien > 0)
        {
            eolien -= 1;
            stat.money += 60000;
            eolientexte.text = $"{eolien}/{(maxeolien) * 5}";
            powertexte.text = $"{eolien * 1}kw/h/s";
        }
    }
}