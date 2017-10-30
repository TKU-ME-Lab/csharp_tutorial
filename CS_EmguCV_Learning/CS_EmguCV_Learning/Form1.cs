using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace CS_EmguCV_Learning
{
    public partial class Form1 : Form
    {
        Mat img_original = new Mat();
        Mat img_processed = new Mat();

        
        public Form1()
        {
            InitializeComponent();
            //imageBox 設定
            imageBox1.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox2.SizeMode = PictureBoxSizeMode.Zoom;

            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            imageBox2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
        }

        private void button_capture_Click(object sender, EventArgs e)
        {
            ICapture webCam = null;
            webCam = new VideoCapture(0);
            img_original = webCam.QueryFrame();
            //show the image
            imageBox1.Image = img_original;
        }

    }
}
