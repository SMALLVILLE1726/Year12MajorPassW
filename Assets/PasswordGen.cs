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

            //Added "rnd2" to randomise the order of the symbols,numbers and letters. 

            int rnd2 = Random.Range(0, 3);
           
            //Added "bool" and "added" to aelect the symbols, numbers and letters seperately.

            bool added = false;

            //Characters
            if (LettersToggle.isOn && rnd2 == 0)
            {
                rnd = Random.Range(65, 90);
                PW += (char)rnd;
                added = true;
            }

            //Symbols 
            if (SymbolsToggle.isOn && rnd2 == 1)
            {
                rnd = Random.Range(33, 47);
                PW += (char)rnd;
                added = true;
            }

            //Numbers
            if (SpacesToggle.isOn && rnd2 == 2)
            {
                rnd = Random.Range(48, 57);
                PW += (char)rnd;
                added = true;
            }

            if (added == false)
            {
                i--;
                //Added a "i--;" to loop the program again in case of the variables isn't selected. 
            }
        }

        PasswordText.text = PW;

    }

    // Update is called once per frame
    void GetRandomBit()
    {
        
    }
}
