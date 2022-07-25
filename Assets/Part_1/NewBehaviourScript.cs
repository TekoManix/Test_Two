using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int x;

    // Start is called before the first frame update
    void Start()
    {
        int[] a = new int[3] { 1, 3, 5 };
        for (int i = 0; i < 10; i++)
        {
            a[i] = i;
            print(a[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
