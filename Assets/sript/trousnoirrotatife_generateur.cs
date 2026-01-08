using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class trousnoirrotatife_generateur : MonoBehaviour
{
    public stat stat;
    public ground_manageur ground_Manageur;
    public RectTransform bare;
    public float maxusine;
    public float maxGTNR;
    public float usine;
    public float builde;
    public float GTNR;
    public TextMeshProUGUI usinetexte;
    public TextMeshProUGUI powertexte;
    public TextMeshProUGUI buildetexte;
    public TextMeshProUGUI GTNRtexte;
    public TextMeshProUGUI spacetraveltext;
    public TextMeshProUGUI solaresistemtext;
    public Dysonsphere_generateur dysonsphere;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bare.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (builde + (100 * GTNR) < 100 * (maxGTNR))
        {
            builde += Time.deltaTime * usine * 0.01f;
            buildetexte.text = $"{builde}%";
            bare.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
        }
        stat.power += Time.deltaTime * GTNR * 100000000000000000;
    }
    public void addusine()
    {
        if (stat.ground >= 1000)
        {
            stat.ground -= 1000;
            maxusine += 1;
            usinetexte.text = $"{usine}/{(maxusine)}";
        }
    }
    public void lessusine()
    {
        if (maxusine > 0 & (stat.money >= 100000000000000000000f || maxusine != usine))
        {
            stat.ground += 1000;
            if (usine == (maxusine))
            {
                stat.money -= 100000000000000000000f;
                usine = (maxusine - 1);
            }
            maxusine -= 1;
            usinetexte.text = $"{usine}/{(maxusine)}";
        }
    }
    public void buyusine()
    {
        if (stat.money >= 10000000000000000000f & (maxusine) > usine)
        {
            stat.money -= 10000000000000000000f;
            usine += 1;
            usinetexte.text = $"{usine}/{(maxusine)}";

        }
    }
    public void sellusine()
    {
        if (usine > 0 & stat.money >= 100000000000000000000f)
        {
            usine -= 1;
            stat.money -= 100000000000000000000f;
            usinetexte.text = $"{usine}/{(maxusine)}";

        }
    }
    public void createDysonsphere()
    {
        if (stat.money >= 100000000000000000000f & builde >= 100 & (maxGTNR) > GTNR)
        {
            GTNR += 1;
            builde -= 100;
            stat.money -= 100000000000000000000f;
            powertexte.text = $"{GTNR * 100}pw/h/s";
            GTNRtexte.text = $"{GTNR}/{maxGTNR}";
            buildetexte.text = $"{builde}%";
            bare.localScale = new Vector3(1 + (builde * 0.418f), 1, 1);
        }
    }
    public void spacetravel()
    {
        if (stat.money >= 10000000000000000000 * Mathf.Pow((maxGTNR+1), 2f))
        {
            stat.money -= 10000000000000000000 * Mathf.Pow((maxGTNR+1), 2f);
            maxGTNR += 1;
            GTNRtexte.text = $"{GTNR}/{maxGTNR}";
            ground_Manageur.grounb.text = $"buy ground\n{10000 * (Mathf.Pow(5, (ground_Manageur.groundachat / (ground_Manageur.groundextantion * (maxGTNR + dysonsphere.maxDysonsphere + 1)))))} = 1km²";
            spacetraveltext.text = $"mony({10000000000000000000 * Mathf.Pow((maxGTNR+1 ), 2f)}) = solare system";

        }
    }
}