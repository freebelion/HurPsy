using HurPsyLib;
using System.Linq.Expressions;

namespace HurPsyExp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deney tanımını oluştur
            Experiment exp = new Experiment();

            // Görsel uyarıcı nesneleri tanımla ve deney tanımına ekle                    
            for(int i=1; i<=6; i++)
            {
                ImageStimulus imgstim = new ImageStimulus();
                imgstim.ImageSize = new HurPsySize(10, 10);
                imgstim.Id = "img" + i.ToString();
                imgstim.FileName = "img" + i.ToString() + ".png";
                exp.AddStimulus(imgstim);
            }

            // Konumlandırıcı nesneleri tanımla ve deney tanımına ekle
            PointLocator merkez = new PointLocator(0,0);
            merkez.Id = "merkez";
            exp.AddLocator(merkez);

            Experiment.Block blck = exp.CreateNewBlock();

            for (int i = 1; i <= 6; i++)
            {
                Experiment.Trial tri = blck.CreateNewTrial();
                Experiment.TrialStep stp = tri.CreateNewStep();
                stp.StepTime = new HurPsyTimePeriod();
                stp.StepTime.Milliseconds = 500;
                stp.AddStimulusLocatorPair("img" + i.ToString(), "merkez");
            }

            exp.SaveToXml("deney.xml");

            Experiment? exp2 = Experiment.LoadFromXml("deney.xml");
        }
    }
}
