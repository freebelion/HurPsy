using HurPsyLib;

namespace HurPsyExp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deney tanımını oluştur
            Experiment exp = new Experiment();

            // Görsel uyarıcı nesneleri tanımla ve deney tanımına ekle                    
            for (int i = 1; i <= 6; i++)
            {
                ImageStimulus imgstim = new ImageStimulus();
                imgstim.ImageSize = new HurPsySize(10, 10);
                imgstim.Id = "daire" + i.ToString();
                imgstim.FileName = "daire" + i.ToString() + ".png";
                exp.AddStimulus(imgstim);
            }

            // Konumlandırıcı nesneleri tanımla ve deney tanımına ekle
            RectangleLocator ceyrek1 = new RectangleLocator();
            ceyrek1.Id = "ceyrek1";
            ceyrek1.RectangleLocation.OriginChoice = HurPsyOrigin.TopLeft;
            ceyrek1.RectangleLocation.LengthUnit = HurPsyUnit.Fraction;
            ceyrek1.RectangleLocation.X = 0;
            ceyrek1.RectangleLocation.Y = 0;
            ceyrek1.RectangleSize.SizeUnit = HurPsyUnit.Fraction;
            ceyrek1.RectangleSize.Width = 0.5;
            ceyrek1.RectangleSize.Height = 0.5;
            exp.AddLocator(ceyrek1);

            RectangleLocator ceyrek2 = new RectangleLocator();
            ceyrek2.Id = "ceyrek2";
            ceyrek2.RectangleLocation.OriginChoice = HurPsyOrigin.TopLeft;
            ceyrek2.RectangleLocation.LengthUnit = HurPsyUnit.Fraction;
            ceyrek2.RectangleLocation.X = 0.5;
            ceyrek2.RectangleLocation.Y = 0;
            ceyrek2.RectangleSize.SizeUnit = HurPsyUnit.Fraction;
            ceyrek2.RectangleSize.Width = 0.5;
            ceyrek2.RectangleSize.Height = 0.5;
            exp.AddLocator(ceyrek2);

            RectangleLocator ceyrek3 = new RectangleLocator();
            ceyrek3.Id = "ceyrek3";
            ceyrek3.RectangleLocation.OriginChoice = HurPsyOrigin.TopLeft;
            ceyrek3.RectangleLocation.LengthUnit = HurPsyUnit.Fraction;
            ceyrek3.RectangleLocation.X = 0;
            ceyrek3.RectangleLocation.Y = 0.5;
            ceyrek3.RectangleSize.SizeUnit = HurPsyUnit.Fraction;
            ceyrek3.RectangleSize.Width = 0.5;
            ceyrek3.RectangleSize.Height = 0.5;
            exp.AddLocator(ceyrek3);

            RectangleLocator ceyrek4 = new RectangleLocator();
            ceyrek4.Id = "ceyrek4";
            ceyrek4.RectangleLocation.OriginChoice = HurPsyOrigin.TopLeft;
            ceyrek4.RectangleLocation.LengthUnit = HurPsyUnit.Fraction;
            ceyrek4.RectangleLocation.X = 0.5;
            ceyrek4.RectangleLocation.Y = 0.5;
            ceyrek4.RectangleSize.SizeUnit = HurPsyUnit.Fraction;
            ceyrek4.RectangleSize.Width = 0.5;
            ceyrek4.RectangleSize.Height = 0.5;
            exp.AddLocator(ceyrek4);

            Experiment.Block blck = exp.CreateNewBlock();

            for (int i = 1; i <= 6; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    Experiment.Trial tri = blck.CreateNewTrial();
                    Experiment.TrialStep stp = tri.CreateNewStep();
                    stp.StepTime = new HurPsyTimePeriod();
                    stp.StepTime.Seconds = 1.0;
                    stp.AddStimulusLocatorPair("daire" + i.ToString(), "ceyrek" + j.ToString());
                }               
            }

            exp.SaveToXml("deney2.xml");
        }
    }
}
