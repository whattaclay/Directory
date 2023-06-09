using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTranslate : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private Vector3 vector;
    void Update()
    {
        //transform.Translate(vector); //величина вектора по оси задает скорость в том направлении
                                    //отрицательный вектор задает направление в противооположную сторону
        //transform.Translate(vector, Space.World);//относительно мировых координат
        transform.Translate(vector, target.transform);//отситывает направление векторов относительно заданного объекта
        
    }
}
