using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionPanel : MonoBehaviour
{    
    public void DisableThisGameObject()
    {
        this.gameObject.SetActive(false);
    }
}
