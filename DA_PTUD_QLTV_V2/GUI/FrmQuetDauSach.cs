using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using DTO;
using BLL;

namespace GUI
{
    public partial class FrmQuetDauSach : Form
    {
        FilterInfoCollection filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        VideoCaptureDevice video;

        public FrmQuetDauSach()
        {
            InitializeComponent();
        }

        private void FrmQuetDauSach_Load(object sender, EventArgs e)
        {
            video = new VideoCaptureDevice(filter[0].MonikerString);
            video.NewFrame += video_NewFrame;
            video.Start();
        }

        private void video_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var rs = reader.Decode(bitmap);

            if (rs != null)
            {
                cmbDauSach.Invoke(new MethodInvoker(delegate()
                {
                    cmbDauSach.Items.Add(rs.ToString());
                    cmbDauSach.SelectedIndex = 0;
                }));
            }

            picDisplay.Image = bitmap;
        }

        private void FrmQuetDauSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (video != null)
                if (video.IsRunning)
                    video.Stop();
        }
    }
}
