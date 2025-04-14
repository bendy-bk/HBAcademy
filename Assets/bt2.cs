using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class bt2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> input = new List<int> { 1, 2, 4, 1, 9, 1, 6, 1, 5, 6, 8, 7 };
        int target = 1;
        Debug.Log("Input: { " + string.Join(", ", input) + " }");

        List<int> output = RemoveElements(input, target);

        Debug.Log("Output: { " + string.Join(", ", output) + " }");

    }

    static List<int> RemoveElements(List<int> inputList, int valueToRemove)
    {
        return inputList.Where(x => x != valueToRemove).ToList();
    }


}
