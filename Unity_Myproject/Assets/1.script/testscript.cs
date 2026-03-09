using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class testscript : MonoBehaviour
{
    public int publicInt;
    private int privateInt;

    public TextMeshProUGUI Txt_Text;
    public string NextText;

    public void OnClickButton()
    {
        Txt_Text.text = NextText;
    }
}
