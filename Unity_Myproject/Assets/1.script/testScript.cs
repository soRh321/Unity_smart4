using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    [SerializeField] private int P_Gold = 200;
    //public int GetP_Gold()
    //{
    //    return P_Gold;
    //}
    [SerializeField] private int P_Potion;

    // Start is called before the first frame update
    void Start()
    {

        if (P_Gold >= 200)
        {
            P_Gold -= 200;
            P_Potion++;
        }

        else if (P_Gold >= 100)
        {
            //100원을 소모하고 포션 1개를 증가시킨다.
            P_Gold -= 100;
            P_Potion++;
        }

        else
        {
            Angry();
        }
            Debug.Log($"골드 : {P_Gold}, 포션 : {P_Potion} ");
    }

    void Angry()
    {
        Debug.Log("상점 주인 : 화가난다!!!");
    }
    // Update is called once per frame
    void Update()
    {
    
    }
}
