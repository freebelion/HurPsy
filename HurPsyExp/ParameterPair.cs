using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HurPsyExp
{
    /// <summary>
    /// This class will help pass a pair of objects as a CommandParameter.
    /// The objects will be bound to properties of some controls in templates of AddPairPopup and AddTrialPopup
    /// </summary>
    public class ParameterPair : DependencyObject
    {
        /// <summary>
        /// First bindable object
        /// </summary>
        public static readonly DependencyProperty Object1Property =
            DependencyProperty.Register("Object1", typeof(object), typeof(ParameterPair));
        /// <summary>
        /// Second bindable object
        /// </summary>
        public static readonly DependencyProperty Object2Property =
            DependencyProperty.Register("Object2", typeof(object), typeof(ParameterPair));
        
        /// <summary>
        /// The actual Object1 property for this instance
        /// </summary>
        public object Object1
        {
            get => GetValue(Object1Property);
            set => SetValue(Object1Property, value);
        }

        /// <summary>
        /// The actual Object2 property for this instance
        /// </summary>
        public object Object2
        {
            get => GetValue(Object2Property);
            set => SetValue(Object2Property, value);
        }
    }
}
