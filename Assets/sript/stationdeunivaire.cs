using TMPro;
using UnityEngine;

public class stationdeunivaire : MonoBehaviour
{
    public stat stat;
    public energiersombre_generateur energiersombre_Generateur;
    public ground_manageur ground_Manageur;
    public RectTransform bare;
    public RectTransform bare2;
    public float maxusine;
    public float maxSLU;
    public float usine;
    public float builde;
    public float builde2;
    public float SLU;
    public TextMeshProUGUI usinetexte;
    public TextMeshProUGUI buildetexte;
    public TextMeshProUGUI buildetexte2;
    public TextMeshProUGUI SLUtexte;
    public TextMeshProUGUI energuesombretexte;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bare.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
        bare2.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (builde + (100 * SLU) < 100 * (maxSLU))
        {
            builde += Time.deltaTime * usine * 0.1f;
            buildetexte.text = $"{builde}%";
            bare.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
        }
        if (builde2 >= 100)
        {
            stat.ground += SLU *100;
            builde2 -= 100;
        }
        
        builde2 += Time.deltaTime * SLU * 1f;
        buildetexte2.text = $"{builde2}%";
        buildetexte.text = $"{builde}%";
        bare2.localScale = new Vector3(1 + (builde2 * 0.418f), 1, 1);
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
            if (usine == (maxusine))
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
    public void createSLU()
    {
        if (stat.money >= 1000000000000000000000f & builde >= 100 & (maxSLU) > SLU)
        {
            SLU += 1;
            builde -= 100;
            stat.money -= 1000000000000000000000f;
            SLUtexte.text = $"{SLU}/{maxSLU}";
            buildetexte.text = $"{builde}%";
            bare.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
        }
    }
    public void LU()
    {
        if (energiersombre_Generateur.energuesombre >= 10)
        {
            energiersombre_Generateur.energuesombre -= 10;
            maxSLU += 1;
            SLUtexte.text = $"{SLU}/{maxSLU}";
            energuesombretexte.text = $"{energiersombre_Generateur.energuesombre * 1}";
        }
    }
}