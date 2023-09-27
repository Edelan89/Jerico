using UnityEngine;
using System;

public class TreeManager : MonoBehaviour
{
    public static TreeManager instance;

    public int branchQuantity;
    private int branchesCutted;
    private void Awake()
    {
        instance = this;
    }

    public void CutBranch(bool isCritical)
    {
        if (isCritical)
        {
            Lose(); 
            return;
        }
        branchesCutted++;
        if(branchesCutted == branchQuantity)
        {
            Win();
        }
    }

    private void Win()
    {
        throw new NotImplementedException();
    }

    private void Lose()
    {
        throw new NotImplementedException();
    }
}
