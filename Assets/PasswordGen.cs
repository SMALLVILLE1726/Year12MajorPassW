using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordGen : MonoBehaviour
{
    int rnd = 0; 
    public Text PasswordText;
    public Slider LengthSlider;
    public Toggle LettersToggle;
    public Toggle SymbolsToggle;
    public Toggle SpacesToggle;
    public string PW;

    // Start is called before the first frame update
    public void gen()
    {
        PW = "";
        // Added a "for" Statement to loop the program
        for (int i = 0; i < LengthSlider.value; i++)
        {
            //Added "if" statements to only activate certain variables when turned on.

            //Characters
            if (LettersToggle.isOn)
            {
                rnd = Random.Range(65, 90);
                PW += (char)rnd;
            }

            //Symbols 
            if (SymbolsToggle.isOn)
            {
                rnd = Random.Range(33, 47);
                PW += (char)rnd;
            }

            //Numbers
            if (SpacesToggle.isOn)
            {
                rnd = Random.Range(48, 57);
                PW += (char)rnd;
            }
        }

        PasswordText.text = PW;

    }

    // Update is called once per frame
    void GetRandomBit()
    {
        
    }
}
