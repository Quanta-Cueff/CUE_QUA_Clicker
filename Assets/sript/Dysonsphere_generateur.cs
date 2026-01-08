using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JetBrains.Annotations;


public class Dysonsphere_generateur : MonoBehaviour
{
    public stat stat;
    public ground_manageur ground_Manageur;
    public RectTransform bare;
    public Toggle auto;
    public float maxusine;
    public float maxDysonsphere;
    public float usine;
    public float builde;
    public float Dysonsphere;
    public TextMeshProUGUI usinetexte;
    public TextMeshProUGUI powertexte;
    public TextMeshProUGUI buildetexte;
    public TextMeshProUGUI Dysonspheretexte;
    public TextMeshProUGUI spacetraveltext;
    public TextMeshProUGUI solaresistemtext;
    public trousnoirrotatife_generateur GTNR;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (builde + (100 * Dysonsphere) < 100*(maxDysonsphere+1))
        { 
            builde += Time.deltaTime * usine * 0.01f;
            buildetexte.text = $"{builde}%";
            bare.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
        }
        stat.power += Time.deltaTime * Dysonsphere * 1000000000000000;
    }
    public void addusine()
    {
        if (stat.ground >= 100)
        {
            stat.ground -= 100;
            maxusine += 1;
            usinetexte.text = $"{usine}/{(maxusine)}";
        }
    }
    public void lessusine()
    {
        if (maxusine > 0 & (stat.money >= 100000000000 || maxusine != usine))
        {
            stat.ground += 100;
            if (usine == maxusine)
            {
                stat.money -= 100000000000;
                usine = (maxusine - 1);
            }
            maxusine -= 1;
            usinetexte.text = $"{usine}/{(maxusine)}";
        }
    }
    public void buyusine()
    {
        if (stat.money >= 100000000000 & (maxusine) > usine)
        {
            stat.money -= 100000000000;
            usine += 1;
            usinetexte.text = $"{usine}/{(maxusine)}";
            
        }
    }
    public void sellusine()
    {
        if (usine > 0 & stat.money >= 100000000000)
        {
            usine -= 1;
            stat.money -= 100000000000;
            usinetexte.text = $"{usine}/{(maxusine)}";
            
        }
    }
    public void createDysonsphere()
    {
        if (stat.money >= 10000000000000 & builde >= 100 & (maxDysonsphere+1) > Dysonsphere)
        {
            Dysonsphere += 1;
            builde -= 100;
            stat.money -= 10000000000000;
            powertexte.text = $"{Dysonsphere * 1}pw/h/s";
            Dysonspheretexte.text = $"{Dysonsphere}/{maxDysonsphere+1}";
            buildetexte.text = $"{builde}%";
            bare.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
            auto.interactable = true;
        }
    }
    public void spacetravel()
    {
        if (stat.money >= 1000000000000000000 * Mathf.Pow((maxDysonsphere+1), 1.5f))
        {
            stat.money -= 1000000000000000000 * Mathf.Pow((maxDysonsphere+1), 1.5f);
            maxDysonsphere += 1;
            Dysonspheretexte.text = $"{Dysonsphere}/{maxDysonsphere + 1}";
            ground_Manageur.grounb.text = $"buy ground\n{10000 * (Mathf.Pow(5, (ground_Manageur.groundachat / (ground_Manageur.groundextantion * (maxDysonsphere + 1 + GTNR.maxGTNR)))))} = 1km²";
            spacetraveltext.text = $"mony({1000000000000000000 * Mathf.Pow((maxDysonsphere+1), 1.5f)}) = solare system";
            
        }
    }
}