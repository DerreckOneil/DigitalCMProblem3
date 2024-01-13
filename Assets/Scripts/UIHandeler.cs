using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHandeler : MonoBehaviour
{
    public static int number;

    [SerializeField] private TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        number = PlayerPrefs.GetInt("SavedNumber", 0);
        UpdateNumberText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateNumberText() {
        text.text = "Number: " + number;
    }
    public void AddOne() {
        number++;
        UpdateNumberText();
        SaveNumber();
    }
    public void SubtractOne() {
        number--;
        UpdateNumberText();
        SaveNumber();
    }
    void SaveNumber() {
        PlayerPrefs.SetInt("SavedNumber", number);
        PlayerPrefs.Save();
    }
}
