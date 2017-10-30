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
        private void button_gray_Click(object sender, EventArgs e)
        {
            CvInvoke.CvtColor(img_original, img_processed, ColorConversion.Bgr2Gray);
            imageBox2.Image = img_processed;
        }
    }
}