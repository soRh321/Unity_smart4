using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gatcha : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] TextMeshProUGUI txt;
    [SerializeField] Button btn_Gatcha;
    
    [SerializeField] private int PickUp;
    [SerializeField] private string[] S;
    [SerializeField] private string[] A;
    [SerializeField] private string[] B;
    [SerializeField] private string[] C;
    private void Awake()
    {
        btn_Gatcha.onClick.AddListener(OnClickGatchaBtn);
    }
    private void OnClickGatchaBtn()
    {
        txt.text = "[10연차]\n";
        for (int i = 0; i < 10; i++)
        {
            GatchaFun();
        }
    }
    void GatchaFun()
    {
        //Debug.Log(input.text);
        int Gatcha;
        Gatcha = Random.Range(0, 101);

        if (PickUp == 80)
        {
            txt.text += "픽업s등급이 나왔습니다.(획득 및 픽업이 초기화)\n";
            
            PickUp = 0;
        }
        else
        {
            if (Gatcha > 95)
            {

                int C_Pickup = Random.Range(0, 2);
                {
                    if (C_Pickup == 0)
                    {
                        int index = Random.Range(0, S.Length);
                        txt.text += $"{S[index]}s등급이 나왔습니다.\n";
                        PickUp++;
                    }
                    else
                    {
                        int index = Random.Range(0, S.Length);
                        txt.text += $"{S[index]}s등급(픽업)이 나왔습니다.\n";
                        PickUp = 0;
                    }
                }
            }
            else if (Gatcha > 80)
            {
                int index = Random.Range(0, A.Length);
                txt.text += $"{A[index]}a등급이 나왔습니다.\n";
                PickUp++;
            }
            else if (Gatcha > 50)
            {
                int index = Random.Range(0, B.Length);
                txt.text += $"{B[index]}b등급이 나왔습니다.\n";
                PickUp++;
            }

            else
            {
                int index = Random.Range(0, C.Length);
                txt.text += $"{C[index]}c등급이 나왔습니다.\n";
                PickUp++;
            }
        }
    }
    // Start is called before the first frame update
}
