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
        private void button_sobel_Click(object sender, EventArgs e)
        {
            Mat img_input_ch1 = new Mat(img_original.Size, DepthType.Cv8U,1);
            CvInvoke.CvtColor(img_original, img_input_ch1, ColorConversion.Bgr2Gray);
            CvInvoke.Sobel(img_input_ch1, img_processed, DepthType.Cv8U,1,1,3);
        }
    }
}