using UnityEngine;
using UnityEngine.InputSystem; //入力を検知するために必要‼

public class IgaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject igaguri = 
                Instantiate(igaguriPrefab);
            Ray ray = Camera.main.ScreenPointToRay(
                Mouse.current.position.value);
            igaguri.GetComponent<IgaguriController>().Shoot(
                ray.direction * 2000);
        }
    }
}
