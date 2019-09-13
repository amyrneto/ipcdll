using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ipcdll;

namespace InterProcessComm
{
    public partial class formIPC : Form
    {
        ClassIPC ipc = new ClassIPC();
        public formIPC()
        {
            InitializeComponent();
        }

        private void btnCreateSharedMemory_Click(object sender, EventArgs e)
        {
            long size = long.Parse(textBoxMemSizeAttribute.Text);
            lblSharedMemoryLabel.Text = textBoxMemName.Text;
            lblStatus.Text = "Active";
            ipc.AccessMemoryMap(textBoxMemName.Text, size);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            long size = long.Parse(textBoxMemSizeDataBuffer.Text);
            long offset = long.Parse(textBoxOffset.Text.ToString());
            int data = int.Parse(textBoxData.Text);

            ipc.WriteMemoryMap(lblSharedMemoryLabel.Text, data, offset, size);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            long size = long.Parse(textBoxMemSizeDataBuffer.Text);
            long offset = long.Parse(textBoxOffset.Text.ToString());

            int data;
            ipc.ReadMemoryMap(lblSharedMemoryLabel.Text, out data, offset, size);
            textBoxData.Text = data.ToString();
            Update();
        }
    }
}
