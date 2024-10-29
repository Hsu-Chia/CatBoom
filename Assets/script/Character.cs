using UnityEngine;

public class Character
{
    int position = 100;
    int mp =100;
    public void Move(int distance)
    {
        position+=distance;
        Debug.Log("角色行走了=" + distance);
    }
    public void Attack()
    {
        mp-=10;
        Debug.Log("角色發動攻擊 消耗10mp");
    }
    public void DisplayStatus()
    {
        Debug.Log("角色現在位置"+position+"剩餘的Mp為"+mp);
    }


}
