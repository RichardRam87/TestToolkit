using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class TestScript : MonoBehaviour
{
    [MenuItem("MyMenu/DoIt")]
    static void DoSomething()
    {
        Debug.Log("Do Something");
    }
}
