using UnityEngine;
using UnityEngine.U2D;

public class ColorChangeCoroutine : MonoBehaviour
{
    [SerializeField] private Cube[] _shapes;

    public void BeginTest() {
        for (var i = 0; i < _shapes.Length; i++)
        {
            StartCoroutine(_shapes[i].RotateForSeconds(1 + 1 * i));
            
        }
        //print("Coroutine has finished :)");
    }
}
