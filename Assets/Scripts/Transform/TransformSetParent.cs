using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TransformSetParent : MonoBehaviour
{
    [SerializeField] private GameObject child;
    [SerializeField] private UnityEngine.Transform parent;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            child.transform.SetParent(parent);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            child.transform.SetParent(null);  
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            child.transform.SetParent(parent,false);
            print($"transform.position {child.transform.position}");
            print($"transform.rotation {child.transform.rotation}");
            /*при присваивании родителя, суммирует его координаты и поворот со своими*/
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            child.transform.SetParent(parent,true);  
            print($"transform.position {child.transform.position}");
            print($"transform.rotation {child.transform.rotation}");
            /*при присваивании родителя остовляет свои координаты относительно мира*/
        }
    }
}
