using System.Net.Sockets;
using System.Text;
using UnityEngine;

namespace UserDatagramProtocol
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int port = 66666;
        [SerializeField] private int targetPort = 55555;

        private string _previousPos = null;
        private string _previousRot = null;
        private UdpClient _udpClient = null;

        private void Start()
        {
            _udpClient = new UdpClient(port);
        }

        private void Update()
        {
            var position = transform.position;
            var rotation = transform.rotation;
            var posMessage = $"Position:x={position.x}, y={position.y}, z={position.z}";
            var rotMessage = $"Rotation:x={rotation.x}, y={rotation.y}, z={rotation.z}";
            if (_previousPos != posMessage)
            {
                var posArray = Encoding.ASCII.GetBytes(posMessage);
                _udpClient.Send(posArray, posArray.Length, "localhost", targetPort);
                _previousPos = posMessage;
            }
            if (_previousRot != rotMessage)
            {
                var rotArray = Encoding.ASCII.GetBytes(rotMessage);
                _udpClient.Send(rotArray, rotArray.Length, "localhost", targetPort);
                _previousRot = rotMessage;
            }
        }
    }
}