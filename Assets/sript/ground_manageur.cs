using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ground_manageur : MonoBehaviour
{
    public stat stat;
    public Dysonsphere_generateur dysonsphere_Generateur;
    public float grondprix;
    public Toggle auto;
    public TextMeshProUGUI grounb;
    public float groundextantion;
    public float groundachat;
    public trousnoirrotatife_generateur GTNR;
    private float tamporisgrounde;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (auto.isOn == true)
        {
            tamporisgrounde = stat.ground;
            buyground();
            while(tamporisgrounde != stat.ground)
            {
                tamporisgrounde = stat.ground;
                buyground();
            }
        }
    }
    public void buyground()
    {
        if (stat.money >= grondprix)
        {
            stat.money -= grondprix;
            grondprix = 10000 * (Mathf.Pow(5, (float)(groundachat / (groundextantion*(dysonsphere_Generateur.maxDysonsphere + 1 + GTNR.maxGTNR))))); 
            groundachat += 1;
            stat.ground += 1;
            grounb.text = $"buy ground\n{grondprix} = 1km²";
        }
    }
}
