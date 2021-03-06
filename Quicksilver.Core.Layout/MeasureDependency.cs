﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2011. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 17/267 Nepean Hwy, 
//  Seaford, Vic 3198, Australia and are supplied subject to licence terms.
// 
//  Version 1.0.8.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.Generic;
using System.Diagnostics;

namespace ComponentFactory.Quicksilver.Layout
{
    /// <summary>
    /// Dependency object that fires an event whenever a measure is required.
    /// </summary>
    public class MeasureDependency : DependencyObject
    {
        #region Events
        /// <summary>
        /// Occurs when the element requires a measure.
        /// </summary>
        public event EventHandler NeedMeasure;
        #endregion

        #region Protected
        /// <summary>
        /// Raises the NeedMeasure event.
        /// </summary>
        /// <param name="sender">Source instance.</param>
        /// <param name="e">An EventArgs containing the event data.</param>
        protected virtual void OnNeedMeasure(object sender, EventArgs e)
        {
            EventHandler handler = NeedMeasure;
            if (handler != null)
                handler(this, e);
        }

        /// <summary>
        /// Invoked when a property change requires a measure to occur.
        /// </summary>
        /// <param name="d">Owning object.</param>
        /// <param name="e">Details of property that has changed.</param>
        protected static void OnNeedMeasureOnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MeasureDependency sender = (MeasureDependency)d;
            sender.OnNeedMeasure(sender, EventArgs.Empty);
        }
        #endregion
    }
}
