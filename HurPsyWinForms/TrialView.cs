using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HurPsyLib;

namespace HurPsyWinForms
{
    public partial class TrialView : UserControl
    {
        private int stimulusCount = 0;
        private List<StimulusView> stimulusViews;

        public TrialView()
        {
            InitializeComponent();
            stimulusViews = new List<StimulusView>();
        }

        public int StimulusCount
        {
            get { return stimulusCount; }
            set
            {
                if (value < 0)
                { HurPsyException.Throw("Error_InvalidIndex"); }

                stimulusCount = value;
                while (stimulusViews.Count < stimulusCount)
                {
                    StimulusView stimView = new StimulusView();
                    stimView.Visible = false;
                    this.Controls.Add(stimView);
                }
            }
        }

        public StimulusView GetStimulusView(int index)
        {
            if (index < 0 || index >= stimulusCount)
            { HurPsyException.Throw("Error_InvalidIndex"); }
            return stimulusViews[index];
        }

        public void StartTrial(double msPeriod)
        {
            TrialTimer.Interval = (int)Math.Round(msPeriod, 0);
            ShowStimulusViews();
            TrialTimer.Start();
        }

        private void ShowStimulusViews()
        {
            for(int i=0; i < StimulusCount; i++)
            { stimulusViews[i].Show(); }
        }

        private void HideStimulusViews()
        { foreach (StimulusView stimView in stimulusViews) { stimView.Hide(); } }

        private void TrialTimer_Tick(object sender, EventArgs e)
        {
            TrialTimer.Stop();
            HideStimulusViews();
        }

        public event EventHandler? TrialEnded;

        private void OnTrialEnded(EventArgs e)
        {
            TrialEnded?.Invoke(this, e);
        }       
    }
}
