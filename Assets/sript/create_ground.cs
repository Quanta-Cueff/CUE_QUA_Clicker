using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class create_ground : MonoBehaviour
{
    public ground_manageur ground_Manageur;
    public stat stat;
    public Image Image;
    public trousnoirrotatife_generateur trousnoirrotatife_Generateur;
    public Dysonsphere_generateur dysonsphere_Generateur;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ground_Manageur.groundextantion >= 100)
        {
            if (Image.fillAmount >= 1)
            {
                Image.fillAmount -= 1;
                stat.ground += (dysonsphere_Generateur.maxDysonsphere + trousnoirrotatife_Generateur.maxGTNR) + 1f;
            }
            Image.fillAmount += 0.1f * Time.deltaTime;
        }
    }
}
