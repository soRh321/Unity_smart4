using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string name;
    int maxHP;
    int nowHP;

    private void Awake()
    {
        name = "메타몽";
        maxHP = 100;
        Debug.Log("Awake 가장 먼저 1회 호출 입니다.");
    }
    private void OnEnable()
    {
        nowHP = maxHP;
        Debug.Log($"{name}OnEnable : {nowHP}/{maxHP} 오브젝트 활성화 될 때 Awake다음으로 호출됩니다.");

    }
    void Start()
    {
        Debug.Log("Start 1번만 호출됩니다.");
    }

    // Update is called once per frame
    void Update()
    {
        nowHP -= 1;
        Debug.Log($"{name}update : {nowHP}/{maxHP} 매 프레임마다 호출됩니다.");
        if(nowHP < 0)
        {
            this.gameObject.SetActive(false);
        }
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable 활성화에서 비활성화 될 때마다 호출됩니다.");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy 오브젝트 삭제될 때 호출됩니다.");
    }
}
public class Player
{
    private int level;

    public int GetLevel()
    {
        return level;
    }
}

public class Monster
{
    private int level;

    public void SetLevel(int _playerLevel)
    {
        level = _playerLevel;
    }
}
public class Game
{
    Player player;
    Monster monster;

    public void Test()
    {
        monster.SetLevel(player.GetLevel());
    }
}

