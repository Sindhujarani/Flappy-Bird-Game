using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public PipeMoveScript myParent;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            other.gameObject.GetComponent<Bullet>().DestroyMe();
            myParent.SetUpPipes(false);
        }
    }
}
