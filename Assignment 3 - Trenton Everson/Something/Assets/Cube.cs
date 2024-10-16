using System.Collections;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public IEnumerator RotateForSeconds(float duration)
    {
        var end = Time.time + duration;
        while (Time.time < end)
        {
            transform.Translate(0, Time.deltaTime, 0, Space.World);
            
            yield return null;
        }
        print("Coroutine has finished :)");
        

    }
}
