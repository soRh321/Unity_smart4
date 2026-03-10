using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class practice : MonoBehaviour
{
    [SerializeField] private int P_Gold = 200;
    [SerializeField] private int P_rPotion;
    [SerializeField] private int P_yPotion;
    [SerializeField] private int P_bPotion;
    private int Gatcha;
    [SerializeField]private int PickUp;
    [SerializeField]int[] intArray = new int[3];
    [SerializeField] List<int> intList = new();

    void Start()
    {
        intArray[0] = 1;
        intArray[1] = 2;
        intArray[2] = 3;

        for(int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i]);
        }
        //리스트
        intList.Add(0);
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        for(int i = 0; i< intList.Count; i++)
        {
                       Debug.Log(intList[i]);
        }
        for (int i = 0; i < 10; i++)
        {
            GatchaFun();
        }

        //string wish = "노란포션";
        //switch (wish)
        //{
        //    case "빨간포션":
        //        P_Gold -= 200;
        //        P_rPotion++;
        //        break;
        //    case "노란포션":
        //        P_Gold -= 100;
        //        P_yPotion++;
        //        break;
        //    case "파란포션":
        //        P_Gold -= 50;
        //        P_bPotion++;
        //        break;
        //    default:
        //        break;
        //}
        //Debug.Log($"골드 : {P_Gold}, R : {P_rPotion}, Y : {P_yPotion}, B : {P_bPotion} ");
        //GatchaFun();
    }
    void GatchaFun()
    {
        Gatcha = Random.Range(0, 101);
        if (PickUp == 80)
        {
            Debug.Log($"{Gatcha}픽업s등급이 나왔습니다.");
            Debug.Log("획득 및 픽업이 초기화 됩니다.");
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
                        Debug.Log($"{Gatcha}s등급이 나왔습니다.");
                        PickUp++;
                    }
                    else
                    {
                        Debug.Log($"{Gatcha}픽업s등급이 나왔습니다.");
                        PickUp = 0;
                    }
                }
            }
            else if (Gatcha > 80)
            {
                Debug.Log($"{Gatcha}a등급이 나왔습니다.");
                PickUp++;
            }
            else if (Gatcha > 50)
            {
                Debug.Log($"{Gatcha}b등급이 나왔습니다.");
                PickUp++;
            }

            else
            {
                Debug.Log($"{Gatcha}c등급이 나왔습니다.");
                PickUp++;
            }
        }
    }
    void Switch_Gatcha()
    {
        int S_Gatcha = Random.Range(0, 101);

        switch (S_Gatcha)
        {
            case > 95:
                Debug.Log("s등급이 나왔습니다.");
                break;
            case > 80:
                Debug.Log("a등급이 나왔습니다.");
                break;
            case > 50:
                Debug.Log("b등급이 나왔습니다.");
                break;
            default:
                Debug.Log("c~등급이 나왔습니다.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
