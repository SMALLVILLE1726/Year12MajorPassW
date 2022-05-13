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
        print(PasswordText);
        print(SymbolsToggle);
        print(LettersToggle);
        print(SpacesToggle); 

        int rnd = Random.Range(65, 91);
        PW += (char)rnd;

         rnd = Random.Range(33, 126);
        PW += (char)rnd;

         rnd = Random.Range(48, 57);
        PW += (char)rnd;


        print(PW);



    }

    // Update is called once per frame
    void GetRandomBit()
    {
        
    }
}
