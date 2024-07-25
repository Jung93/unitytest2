using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Vector3[] pointList;
    public int[] jellyGoldList;
    public int[] jellyJelatineList;
    public Sprite[] jellySpriteList;
    public string[] jellyNameList;
    public int[] numGoldList;
    public int[] clickGoldList;


    public RuntimeAnimatorController[] controller;


    public void ChangeAc(Animator anim, int level) {
    
        anim.runtimeAnimatorController = controller[level - 1];

    }

}
