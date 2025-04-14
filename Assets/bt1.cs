using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bt1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int[] input = { 1, 3, 4, 5, 2, 4, 6, 9 };
        DisplayArray(input);
        BubbleSort(input);
        DisplayArray(input);
    }

    public void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public void DisplayArray(int[] array)
    {
        foreach (var i in array)
        {
            Debug.Log(i + ",");
        }
    }


}