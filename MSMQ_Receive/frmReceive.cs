using Bussiness_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMQ_Receive
{
    public partial class frmReceive : Form
    {
        MessageQueue queue = null;

        public frmReceive()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            string path = @".\private$\phongkehoach";
            queue = new MessageQueue(path);
            queue.BeginReceive();
            queue.ReceiveCompleted += Queue_ReceiveCompleted;
        }

        private void Queue_ReceiveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            var msg = e.Message;
            int type = msg.BodyType;
            XmlMessageFormatter fmt = new XmlMessageFormatter(
            new System.Type[] { typeof(string), typeof(Student) }
            );
            msg.Formatter = fmt;
            var result = msg.Body;
            var t = result.GetType();
            Console.WriteLine(t);

            if (t.Equals(typeof(Student)))
            {
                SetText(t + ":" + result);
            }
            else
                SetText("" + result);
            queue.BeginReceive();//loop back
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.rtbMessage.InvokeRequired)
            {
                SetTextCallback callback = new SetTextCallback(SetText);
                this.Invoke(callback, new object[] { text });
            }
            else
            {
                this.rtbMessage.AppendText(text + "\n");
            }
        }


    }
}
