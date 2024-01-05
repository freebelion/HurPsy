using CommunityToolkit.Mvvm.ComponentModel;
using HurPsyExp.ExpDesign;
using HurPsyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyExp.ExpRun
{
    public partial class RunViewModel : ObservableObject
    {
        private Experiment _experiment;

        public RunViewModel()
        {
            _experiment = new Experiment();
        }

        public void LoadExperiment()
        {
            Experiment? exp = UtilityClass.LoadExperiment();

            if (exp != null)
            {// If an experiment definition was successfully loaded,
                _experiment = exp;
            }
        }
    }
}
