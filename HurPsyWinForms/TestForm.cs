using HurPsyLib;

namespace HurPsyWinForms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.InitialDirectory = Directory.GetCurrentDirectory();
                opf.Filter = "XML Files(*.xml)|*.xml";
                opf.Multiselect = false;
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    Experiment testExperiment = Experiment.LoadFromXml(opf.FileName);
                    ExperimentViewModel expvm = new ExperimentViewModel(testExperiment);
                    this.Controls.Add(expvm.TrialViewControl);
                    expvm.TrialViewControl.Dock = DockStyle.Fill;
                }
            }
        }       
    }
}
