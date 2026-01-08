using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class muscular_power : MonoBehaviour

{
    public stat stat;
    private float strangr;
    public float prix;
    public TextMeshProUGUI strage;
    public TextMeshProUGUI musculatione;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        strangr = 1;
    }

    public void musculare_power()
    {
        stat.power += strangr;
        
    }

    public void musculation()
    {
        if (stat.money >= prix)
        {
            stat.money -= prix;
            strangr += 0.1f;
            prix = prix * 1.2f;
            musculatione.text = $"mony({Mathf.Floor(prix*100f)/100f}) = strange(0.1)";
            strage.text = $"strege({Mathf.Floor(strangr * 100f) / 100}f)-- > power({Mathf.Floor(strangr * 100f) / 100f})";
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
