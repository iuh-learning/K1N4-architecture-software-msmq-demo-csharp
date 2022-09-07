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

namespace MSMQ_Sender
{
    public partial class frmSender : Form
    {
        MessageQueue queue = null;

        private void init()
        {
            String path = @".\private$\phongkehoach";
            if (MessageQueue.Exists(path))
            {
                queue = new MessageQueue(path, QueueAccessMode.Send);
            }
            else
            {
                queue = MessageQueue.Create(path, true);
            }
            queue.Label = "queue cho phong ke hoach";
        }

        public frmSender()
        {
            InitializeComponent();
            init();
        }

        private void btnSendText_Click(object sender, EventArgs e)
        {
            String message = txtSender.Text;
            MessageQueueTransaction transaction = new MessageQueueTransaction();
            transaction.Begin();
            queue.Send(message, transaction);
            transaction.Commit();
            txtSender.Text = "";
        }

        private void btnSendObject_Click(object sender, EventArgs e)
        {
            Student st = new Student(1001L, "Nguyễn văn Tèo", new DateTime(1999, 10, 15));
            MessageQueueTransaction transaction = new MessageQueueTransaction();
            transaction.Begin();
            queue.Send(st, transaction);
            transaction.Commit();
        }
    }
}
