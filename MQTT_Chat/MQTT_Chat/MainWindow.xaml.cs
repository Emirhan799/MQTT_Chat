using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Formatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MQTTnet.Extensions.ManagedClient;

namespace MQTT_Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        private IMqttClient mqttClient;

        public MainWindow()
        {
            InitializeComponent();
            InitializeMqttClient();
        }

        public async void InitializeMqttClient()
        {
            var factory = new MqttFactory();
            mqttClient = factory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                .WithClientId("Client1")
                .WithProtocolVersion(MqttProtocolVersion.V500)
                .WithTcpServer("b9781cbd845e40cfb0d35a1195f914f9.s2.eu.hivemq.cloud", 8883)
                .WithCredentials("username", "password")
                .WithCleanSession()
                .WithTls()
                .Build();


            /*mqttClient.UseConnectedHandler(async e =>
            {
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show("Bağlandı");
                });

                await mqttClient.SubscribeAsync("konu1"); // İstenilen konuyu abone olabilirsiniz
            });

            mqttClient.UseDisconnectedHandler(async e =>
            {
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show("Bağlantı Kesildi");
                });
                await Task.Delay(TimeSpan.FromSeconds(5));
                await mqttClient.ConnectAsync(options);
            });

            mqttClient.UseApplicationMessageReceivedHandler(e =>
            {
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show($"Gelen mesaj: {e.ApplicationMessage.Payload}");
                });
            });

            await mqttClient.ConnectAsync(options);
        }*/

        
        }
        private void Gonder_Button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sadece MQTT Broker'a Bağlantıyı Yapabildim \n" +
                "Bunun İçin De Broker Adresini Düzenlemeniz Gerekmekte \n" +
                "Diğer İşlemleri Yaptıramadım Çünkü Video Kayıtları Yoktu \n" +
                "Anca Bu Kadar Geldi Elimden, Teşekkürler.");
        }
    }
}
