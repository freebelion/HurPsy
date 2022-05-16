using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class will act as the base class for all model classes
    /// representing different types of experimental responses.
    /// However, it can have its own istances for null responses,
    /// which only require waiting for the period specified as the responseTime.
    /// </summary>
    internal class ResponseModel
    {
        // Response time (in milliseconds)
        private double responseTime;
        // The boolean flag indicating whether
        // or not the response is correct.
        private bool correctResponse;

        /// <summary>
        /// The accessor property for the flag
        /// indicating (in)correct response.
        /// </summary>
        public bool Correct
        {
            get { return correctResponse; }
            set { correctResponse = value; }
        }

        /// <summary>
        /// The acessor property for the response time
        /// (in millseconds)
        /// </summary>
        public double Time
        {
            get { return responseTime; }
            set { responseTime = value; }
        }

        /// <summary>
        /// The function which can be overridden by the derived classes
        /// to determine whether or not a given response is correct.
        /// </summary>
        /// <returns>true</returns>
        public virtual bool IsCorrect(ResponseModel comparedResponse) { return true; }
    }
}
