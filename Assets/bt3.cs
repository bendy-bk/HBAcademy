using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bt3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 2, 6, 9, 1, 1, 9, 6, 1, 9 };

        Dictionary<int, int> result = CountElements(array);

        foreach (var pair in result)
        {
            Debug.Log($"dic[{pair.Key}] = {pair.Value}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Dictionary<int, int> CountElements(int[] array)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        foreach (int num in array)
        {
            if (dic.ContainsKey(num))
                dic[num]++;
            else
                dic[num] = 1;
        }

        return dic;
    }
}
