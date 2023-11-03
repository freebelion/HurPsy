﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    [DataContract]
    public class RectangleLocator : Locator
    {
        [DataMember]
        public HurPsyPoint RectangleLocation { get; set; }
        [DataMember]
        public HurPsySize RectangleSize { get; set; }

        public RectangleLocator()
        {
            RectangleLocation = new HurPsyPoint();
            RectangleSize = new HurPsySize();
        }

        public override HurPsyPoint GetLocation(Stimulus? stim = null)
        {
            double width = RectangleSize.Width;
            double height = RectangleSize.Height;
            double topleftx = RectangleLocation.X;
            double toplefty = RectangleLocation.Y;
            HurPsySize stimSize = new HurPsySize();

            if (stim != null)
            {
                if (stim is ImageStimulus)
                {
                    ImageStimulus imgstim = (ImageStimulus)stim;
                    stimSize = imgstim.ImageSize;
                }
            }

            switch (RectangleSize.SizeUnit)
            {
                case HurPsyUnit.MM:
                    if(stimSize.SizeUnit == HurPsyUnit.Fraction)
                    { }
                    break;
                case HurPsyUnit.Fraction:
                    
                    break;
            }

            switch (RectangleLocation.OriginChoice)
            {
                case HurPsyOrigin.TopLeft:
                    width -= stimSize.Width;
                    height -= stimSize.Height;
                    break;
                case HurPsyOrigin.MiddleCenter:
                    topleftx -= RectangleSize.Width / 2;
                    toplefty -= RectangleSize.Height / 2;
                    break;
            }

            double x = topleftx + width * HurPsyCommon.Rnd.NextDouble();
            double y = toplefty + height * HurPsyCommon.Rnd.NextDouble();

            HurPsyPoint loc = new HurPsyPoint(x, y);
            loc.OriginChoice = RectangleLocation.OriginChoice;
            loc.LengthUnit = RectangleSize.SizeUnit;
            return loc;
        }
    }
}
