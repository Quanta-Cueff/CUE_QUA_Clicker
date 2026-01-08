using UnityEngine;
using TMPro;

public class fussion_generateur : MonoBehaviour
{
    public stat stat;
    public float maxnucleaire;
    public float nucleaire;
    public TextMeshProUGUI nucleairetexte;
    public TextMeshProUGUI powertexte;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        stat.power += Time.deltaTime * 1000000000 * nucleaire;
    }
    public void addbarage()
    {
        if (stat.ground >= 100)
        {
            stat.ground -= 100;
            maxnucleaire += 1;
            nucleairetexte.text = $"{nucleaire}/{(maxnucleaire)}";
        }
    }
    public void lessbarage()
    {
        if (maxnucleaire > 0 & stat.money >= (((maxnucleaire - 1) - nucleaire) * 1000000000))
        {
            stat.ground += 100;
            if (nucleaire >= (maxnucleaire - 1))
            {
                stat.money -= ((maxnucleaire - 1) - nucleaire) * -1000000000;
                nucleaire = (maxnucleaire - 1);
            }
            maxnucleaire -= 1;
            nucleairetexte.text = $"{nucleaire}/{(maxnucleaire)}";
        }
    }
    public void buybarage()
    {
        if (stat.money >= 10000000000 & (maxnucleaire) > nucleaire)
        {
            stat.money -= 10000000000;
            nucleaire += 1;
            nucleairetexte.text = $"{nucleaire}/{(maxnucleaire)}";
            powertexte.text = $"{nucleaire * 1}gw/h/s";
        }
    }
    public void sellbarage()
    {
        if (nucleaire > 0 & stat.money >= 1000000000)
        {
            nucleaire -= 1;
            stat.money -= 1000000000;
            nucleairetexte.text = $"{nucleaire}/{(maxnucleaire)}";
            powertexte.text = $"{nucleaire * 1}gw/h/s";
        }
    }
}