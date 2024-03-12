using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    public int count=0;

    
    public TMP_Text TheText;
    

    void Update()
    {
        TheText.text = count.ToString();
    }
    public void Add1()
    {
        count++;
    }
    public void Add2()
    {
        count += 2;
    }
    public void Add3()
    {
        count += 3;
    }
    public void Add4()
    {
        count += 4;
    }
    public void Add5()
    {
        count += 5;

    }
    public void Add6()
    {
        count += 6;
    }
    public void Add7()
    {
        count += 7;
    }
    public void Add8()
    {
        count += 8;
    }
}
