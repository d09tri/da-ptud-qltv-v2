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
        FilterInfoCollection filter;
        VideoCaptureDevice video;
        DauSachBLL dsBLL = new DauSachBLL();
        static List<int> lstMaBanIn = new List<int>();

        public FrmQuetDauSach()
        {
            InitializeComponent();
        }

        private void FrmQuetDauSach_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            video = new VideoCaptureDevice(filter[0].MonikerString);
            video.NewFrame += video_NewFrame;
            video.Start();
        }

        private void video_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null)
            {
                cmbDauSach.Invoke(new MethodInvoker(delegate()
                {
                    int maBanIn = int.Parse(result.ToString());
                    if (lstMaBanIn.Contains(maBanIn))
                        maBanIn = 0;
                    else
                    {
                        lstMaBanIn.Add(maBanIn);
                        DauSach ds = dsBLL.GetDauSachTheoMaBanIn(maBanIn);
                        if (ds != null)
                        {
                            cmbDauSach.Items.Add(string.Format("{0} - {1}", ds.TenSach, maBanIn));
                            cmbDauSach.SelectedIndex = lstMaBanIn.Count - 1;
                        }
                        else
                        {
                            lstMaBanIn.Remove(maBanIn);
                        }
                    }
                }));
            }

            picDisplay.Image = bitmap;
        }

        private void FrmQuetDauSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            video.Stop();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            FrmChucNangMuonSach.GanDuLieuDSMaBanIn(lstMaBanIn);
            this.Close();
        }
    }
}
