using UnityEngine;

namespace Transform
{
    public class TransformRotate : MonoBehaviour
    {
        private GameObject _cube1, _cube2 , _cube3;
        private Vector3 _axis = new Vector3(0, 1, 1);

        private void Awake()
        {
            _cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _cube1.transform.position = new Vector3(1f, 0f, 0f);
            _cube1.transform.Rotate(90f,45f,0f);
            _cube1.GetComponent<Renderer>().material.color = Color.magenta;
            _cube1.name = "Self";
            
            _cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _cube2.transform.position = new Vector3(-1f, 0f, 0f);
            _cube2.transform.Rotate(-90f,45f,0f);
            _cube2.GetComponent<Renderer>().material.color= Color.blue;
            _cube2.name = "World";
            
            _cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _cube3.transform.position = new Vector3(-3f, 0f, 0f);
            _cube3.transform.Rotate(0f,0f,0f);
            _cube3.GetComponent<Renderer>().material.color= Color.green;
            _cube3.name = "AxisRotate";

        }
        private void Update()
        {
            _cube1.transform.Rotate(0f,0f,0.1f, Space.Self);
            _cube2.transform.Rotate(0f,0f,0.1f, Space.World);
            _cube3.transform.Rotate(_axis, 0.3f);//вокруг какой оси и на сколько будет меняться угол
        }
    }
}