using System.Net.Sockets;
using System.Text;
using UnityEngine;
using Application = UnityEngine.Device.Application;

namespace UserDatagramProtocol
{
    public class ReceiverPositionAndRotation : MonoBehaviour
    {
        [SerializeField]
        private int port = 55555;
        private UdpClient _udpClient;

        private void Start()
        {
            _udpClient = new UdpClient(port);
            UpdatePositionAsync();
        }
        private async void UpdatePositionAsync()
        {
            /*_udpClient ??= new UdpClient(port);*/
            while (Application.isPlaying)
            {
                var data = await _udpClient.ReceiveAsync();
                var message = Encoding.ASCII.GetString(data.Buffer);
                print(message);
            }
        }
    }
}