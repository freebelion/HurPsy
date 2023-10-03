using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HurPsyWinForms
{
    public partial class StimulusView : UserControl
    {private Random rnd = new Random((int) DateTime.Now.Ticks);
        public StimulusView()
        {
            InitializeComponent();          
        }

        public void SetLocation(TrialView trview, HurPsyPoint exploc)
        {
            Point pf = new Point();
            switch (exploc.LengthUnit)
            {
                case HurPsyUnit.MM:
                    pf.X = (int)((exploc.X * trview.DeviceDpi) / 25.4);
                    pf.Y = (int)((exploc.Y * trview.DeviceDpi) / 25.4);
                    break;
                case HurPsyUnit.Fraction:
                    pf.X = (int)(exploc.X * trview.ClientRectangle.Width);
                    pf.Y = (int)(exploc.Y * trview.ClientRectangle.Height);
                    break;
            }

            switch (exploc.OriginChoice)
            {
                case HurPsyOrigin.TopLeft:
                    // No change needed for the default origin choice of Windows
                    break;
                case HurPsyOrigin.MiddleCenter:
                    pf.Offset(
                        (trview.ClientRectangle.Width - this.ClientRectangle.Width) / 2,
                        (trview.ClientRectangle.Height - this.ClientRectangle.Height) / 2);
                    break;
            }

            this.Location = pf;
        }

        public void SetSize(TrialView trview, HurPsySize expsz)
        {
            Size sz = new Size();
            switch (expsz.SizeUnit)
            {
                case HurPsyUnit.MM:
                    sz.Width = (int)((expsz.Width * trview.DeviceDpi) / 25.4);
                    sz.Height = (int)((expsz.Height * trview.DeviceDpi) / 25.4);
                    break;
                case HurPsyUnit.Fraction:
                    sz.Width = (int)(expsz.Width * trview.ClientRectangle.Width);
                    sz.Height = (int)(expsz.Height * trview.ClientRectangle.Height);
                    break;
            }
            this.Size = sz;
        }

        public void SetImage(string imageFileName)
        {
            this.BackgroundImage = Image.FromFile(imageFileName);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
