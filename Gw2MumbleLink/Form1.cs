using MumbleLink_CSharp;
using MumbleLink_CSharp_GW2;
using System;
using System.Windows.Forms;

namespace Gw2MumbleLink {
    public partial class Form1 : Form {

        bool mUpdate = true;

        GW2Link link;

        public Form1 () {
            InitializeComponent();
            link = new GW2Link();
        }

        private void Form1_Load (object sender, EventArgs e) {
            //worker.DoWork += DoBackgroundWork;
            //worker.RunWorkerAsync();

            var timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(MyTimer_Tick);
            timer.Start();
        }

        private void MyTimer_Tick (object sender, EventArgs e) {
            if (!mUpdate)
                return;

            MumbleLinkedMemory data = link.Read();//We got the default MumbleLink Struct, useful for position/rotation
            GW2Context context = link.GetContext();//We're extracting the Context field from the default MumbleLink Struct for easy usage (contains : MapId, MapType, ShardId, Instance and Build)

            string str = data.ToString() + "\n" + context.ToString();

            var identity = link.GetIdentity();

            if (identity != null)
                str += "\n" + identity.ToString();

            txtInfo.Text = str.Replace("\n", "\r\n");
        }

        private void checkBox1_CheckedChanged (object sender, EventArgs e) {
            mUpdate = checkUpdate.Checked;
        }

        private void checkAlwaysOnTop_CheckedChanged (object sender, EventArgs e) {
            TopMost = checkAlwaysOnTop.Checked;
        }
        
        private void Form1_FormClosed (object sender, FormClosedEventArgs e) {
            link.Dispose();
        }

    }
}
