using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice : MonoBehaviour
{
    private int Gatcha;
    [SerializeField]private string GatchaResult;
    [SerializeField]private int PickUp;

    void Start()
    {
        Gatcha = Random.Range(0, 101);
        if (PickUp == 8)
        {
            Debug.Log("픽업이 8개가 되었습니다. 획득 및 픽업이 초기화 됩니다.");
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
