using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class stat : MonoBehaviour
{
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI monayText;
    public TextMeshProUGUI groundText;
    public float power;
    public float money;
    public float ground;
    private float exposant;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monayText.text = $"money: {Mathf.Floor(money * 100f) / 100f}$";
        powerText.text = $"power: {Mathf.Floor(power* 100f) / 100f}w/h";
        groundText.text = $"ground: {Mathf.Floor(ground * 100f ) / 100f}km²";
    }
    public void expodantel(string exit,string textA,float valu, string textB)
    {
        exposant = 0;
        while(valu >= 1000)
        {
            valu = valu / 1000;
            exposant += 3;
        }
        if( valu >= 100 )
        {
            exit = $"{textA}{Mathf.Floor(valu)}e{exposant}{textB}";
        }else if( valu >= 10){
            exit = $"{textA}{Mathf.Floor(valu*10)/10}e{exposant}{textB}";
        }
        else{
            exit = $"{textA}{Mathf.Floor(valu * 100) / 100}e{exposant}{textB}";
        }
    }
}
