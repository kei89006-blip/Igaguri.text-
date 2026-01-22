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
            igaguri.GetComponent<IgaguriController>().Shoot(
                new Vector3(0,200,2000));
        }
    }
}
