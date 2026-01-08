using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class energiersombre_generateur : MonoBehaviour
{
    public stat stat;
    public ground_manageur ground_Manageur;
    public RectTransform bare;
    public float maxusine;
    public float usine;
    public float builde;
    public float energuesombre;
    public TextMeshProUGUI usinetexte;
    public TextMeshProUGUI powertexte;
    public TextMeshProUGUI buildetexte;
    public TextMeshProUGUI energuesombretexte;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bare.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (builde  >= 100 )
        {
            energuesombre += 1;
            builde -= 100;
            energuesombretexte.text = $"{energuesombre * 1}";
            powertexte.text = $"{energuesombre * 1}ew/h/s";
        }
        builde += Time.deltaTime * usine * 0.1f;
        buildetexte.text = $"{builde}%";
        bare.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
        stat.power += Time.deltaTime * energuesombre * 1000000000000000000;
    }
    public void addusine()
    {
        if (stat.ground >= 10000)
        {
            stat.ground -= 10000;
            maxusine += 1;
            usinetexte.text = $"{usine}/{(maxusine)}";
        }
    }
    public void lessusine()
    {
        if (maxusine > 0 & (stat.money >= 1000000000000000000000f || maxusine != usine))
        {
            stat.ground += 10000;
            if (usine == maxusine)
            {
                stat.money -= 1000000000000000000000f;
                usine = (maxusine - 1);
            }
            maxusine -= 1;
            usinetexte.text = $"{usine}/{(maxusine)}";
        }
    }
    public void buyusine()
    {
        if (stat.money >= 1000000000000000000000f & (maxusine) > usine)
        {
            stat.money -= 1000000000000000000000f;
            usine += 1;
            usinetexte.text = $"{usine}/{(maxusine)}";

        }
    }
    public void sellusine()
    {
        if (usine > 0 & stat.money >= 1000000000000000000000f)
        {
            usine -= 1;
            stat.money -= 1000000000000000000000f;
            usinetexte.text = $"{usine}/{(maxusine)}";

        }
    }
    
    
}