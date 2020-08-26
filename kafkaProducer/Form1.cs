using KafkaNet;
using KafkaNet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_Interview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void kafkanetSend_click(object sender, EventArgs e)
        {
            //kafka-net library is used in this approach
            string payload = $"Welcome to Kafka {i++}";
            string topic = "test-topic";
            KafkaNet.Protocol.Message msg = new KafkaNet.Protocol.Message(payload);
            Uri uri = new Uri("http://localhost:9092");
            var options = new KafkaOptions(uri);
            var router = new BrokerRouter(options);
            KafkaNet.Producer client = new KafkaNet.Producer(router);

            client.SendMessageAsync(topic, new List<KafkaNet.Protocol.Message> { msg });
            Console.WriteLine("sent");
        }

        private async void confluentSend_click(object sender, EventArgs e)
        {
            ConfluentProducer producer = new ConfluentProducer();
            await producer.PublishAsync("test-topic", $"Welcome to Kafka {i++}");
        }
    }
}
