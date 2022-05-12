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

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            int rnd = Random.Range(65, 91);
            print((char)rnd);
        }

        for (int i = 0; i < 15; i++)
        {
            int rnd = Random.Range(33, 126);
            print((char)rnd);
        }

        for (int i = 0; i < 15; i++)
        {
            int rnd = Random.Range(48, 57);
            print((char)rnd);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
