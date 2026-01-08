using UnityEngine;
using TMPro;

public class extantion : MonoBehaviour
{
    public stat stat;
    public Dysonsphere_generateur dysonsphere_Generateur;
    public ground_manageur ground_manageur;
    public TextMeshProUGUI extantiontext;
    public trousnoirrotatife_generateur GTNR;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void extantione()
    {
        if (stat.money >= (float)(1.00e7 * Mathf.Pow((100f / (101f - ground_manageur.groundextantion)), 10f)))
        {
            stat.money -= (float)(1.00e7 * Mathf.Pow((100f / (101f - ground_manageur.groundextantion)), 10f));
            ground_manageur.groundextantion += 1;
            ground_manageur.grondprix = 10000 * (Mathf.Pow(5, (ground_manageur.groundachat / (ground_manageur.groundextantion * (dysonsphere_Generateur.maxDysonsphere + 1 + GTNR.maxGTNR)))));
            ground_manageur.grounb.text = $"buy ground\n{10000 * (Mathf.Pow(5, (ground_manageur.groundachat / (ground_manageur.groundextantion * (dysonsphere_Generateur.maxDysonsphere + 1 + GTNR.maxGTNR))))) } = 1km²";
            extantiontext.text = $"extantion {ground_manageur.groundextantion-1}/99\r\n{(float)(1.00e7 * Mathf.Pow((100f / (101f - ground_manageur.groundextantion)), 10f))}$";
        }
    }
}
