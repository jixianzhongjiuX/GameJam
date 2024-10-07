/*
 * ���о���Ĺ�����������ʵ��
 */

//����������Ч
using System.Collections.Generic;
using System.Numerics;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
/// <summary>
/// //////////////////////////////////////////////////////
/// �����Ǿ�����Ч�ĵ���function
/// //////////////////////////////////////////////////////
/// </summary>
using EffectItemFunction = ItemFunction;

public class ChangeHP: EffectItemFunction
{
    //��Ѫ
    public override void Do_function(Item item)
    {
        
    }
}

public class ChangeSpeed: EffectItemFunction
{
    //������
    public override void Do_function(Item item)
    {
        
    }
}

public class ChangeJumpHight : EffectItemFunction
{
    //��Ծ�߶�
    public override void Do_function(Item item)
    {
        
    }
}

public class SingleDirectionMove : EffectItemFunction
{
    public override void Do_function(Item item)
    {
        item.gameObject.transform.Translate(new UnityEngine.Vector3(0.5f, 0, 0));
    }
}

public class ChaseMouseMove : EffectItemFunction
{
    public override void Do_function(Item item)
    {
        if(isFirst)
        {
            direction= Input.mousePosition- item.transform.position;
            direction=direction.normalized;
            isFirst =false;
        }
        item.transform.Translate(direction*ChangeSpeed*Time.deltaTime);
    }
    public float ChangeSpeed=1;
    UnityEngine.Vector3 direction;
    bool isFirst=true;
}

public class ChasePlayer : EffectItemFunction
{
    public float ChangeSpeed = 1;
    public override void Do_function(Item item)
    {
        UnityEngine.Vector3 direction=(Player.GetInstance.transform.position-item.transform.position).normalized;
        item.transform.Translate(direction * ChangeSpeed * Time.deltaTime);
    }
}








