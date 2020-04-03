using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noise_Alert
{
    public partial class Form1 : Form
    {
        int count = 0;
        private DialogResult result;

        public Form1()
        {
            InitializeComponent();
            MMDeviceEnumerator deviceEnumerator = new MMDeviceEnumerator();
            var devicesActive = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            selectDevice.Items.AddRange(devicesActive.ToArray());
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(selectDevice.SelectedItem != null)
            {

                var device = (MMDevice)selectDevice.SelectedItem;
                int soundLevel = (int)(device.AudioMeterInformation.MasterPeakValue * 100);
                audioLevel.Value = (int)(soundLevel);
                audioLevelText.Text = ((int)soundLevel).ToString();
                showMesageBox(soundLevel);

            }


        }

        private void showMesageBox(int soundLevel)
        {
            if (alertDetection(soundLevel) == true)
            {
                count++;
                if (count == 1)
                {
                    result = MessageBox.Show("Sound exceeded recommended hearing limits", "Too loud", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                }

            }
            if (result == DialogResult.OK)
            {
                count = 0;
                result = DialogResult.Yes;
            };
        }

        private bool alertDetection(int soundLevel)
        {
          
            if (soundLevel > 65) return true;
            return false;
            
        }
    }
}
