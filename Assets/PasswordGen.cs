using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordGen : MonoBehaviour
{

    public Text PasswordText;
    public Slider LengthSlider;
    public Toggle LettersToggle;
    public Toggle SymbolsToggle;
    public Toggle SpacesToggle;
    public string PW;

    // Start is called before the first frame update
    void Start()
    {

        print(LengthSlider.value);
        print(SymbolsToggle.isOn);
        print(LettersToggle.isOn);
        print(SpacesToggle.isOn); 

        //Characters
        int rnd = Random.Range(65, 90);
        PW += (char)rnd;

        //Symbols 
         rnd = Random.Range(33, 47);
        PW += (char)rnd;

        //Numbers
         rnd = Random.Range(48, 57);
        PW += (char)rnd;


        print(PW);



    }

    // Update is called once per frame
    void GetRandomBit()
    {
        
    }
}
