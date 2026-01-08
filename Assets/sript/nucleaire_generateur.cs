using TMPro;
using UnityEngine;

public class nucleaire_generateur : MonoBehaviour
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
        stat.power += Time.deltaTime * 10000000 * nucleaire;
    }
    public void addbarage()
    {
        if (stat.ground >= 10)
        {
            stat.ground -= 10;
            maxnucleaire += 1;
            nucleairetexte.text = $"{nucleaire}/{(maxnucleaire)}";
        }
    }
    public void lessbarage()
    {
        if (maxnucleaire > 0 & stat.money >=(((maxnucleaire - 1) - nucleaire) * 10000000))
        {
            stat.ground += 10;
            if (nucleaire >= (maxnucleaire - 1))
            {
                stat.money -= ((maxnucleaire - 1) - nucleaire) * -10000000;
                nucleaire = (maxnucleaire - 1);
            }
            maxnucleaire -= 1;
            nucleairetexte.text = $"{nucleaire}/{(maxnucleaire)}";
        }
    }
    public void buybarage()
    {
        if (stat.money >= 800000000 & (maxnucleaire) > nucleaire)
        {
            stat.money -= 800000000;
            nucleaire += 1;
            nucleairetexte.text = $"{nucleaire}/{(maxnucleaire)}";
            powertexte.text = $"{nucleaire * 0.01}gw/h/s";
        }
    }
    public void sellbarage()
    {
        if (nucleaire > 0 & stat.money >= 10000000)
        {
            nucleaire -= 1;
            stat.money -= 10000000;
            nucleairetexte.text = $"{nucleaire}/{(maxnucleaire)}";
            powertexte.text = $"{nucleaire * 0.01}gw/h/s";
        }
    }
}