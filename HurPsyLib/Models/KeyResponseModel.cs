using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    internal class KeyResponseModel : ResponseModel
    {
        // The member variable to store the code for the key response
        private int responseKey;

        /// <summary>
        /// The accessor property for the key response
        /// </summary>
        public int Key
        {
            get { return responseKey; }
            set { responseKey = value; }
        }

        public override bool IsCorrect(ResponseModel comparedResponse)
        {
            KeyResponseModel keyresp =  (KeyResponseModel)comparedResponse;
            // If this response object is flagged as correct,
            // any other response with the same key code is also correct.
            return (this.Correct && (this.Key == keyresp.Key));
        }
    }
}
