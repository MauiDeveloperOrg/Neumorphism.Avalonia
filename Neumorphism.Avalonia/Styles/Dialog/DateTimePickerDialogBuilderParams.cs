﻿using Avalonia.Layout;
using Neumorphism.Avalonia.Styles.Dialog.Bases;
using System;

namespace Neumorphism.Avalonia.Styles.Dialog
{
    public class DatePickerDialogBuilderParams : TwoFeedbackDialogBuilderParamsBase
    {
        /// <summary>
        /// Define implicit date.
        /// </summary>
        public DateTime ImplicitValue = DateTime.Now;
    }
    
    public class TimePickerDialogBuilderParams : TwoFeedbackDialogBuilderParamsBase
    {
        /// <summary>
        /// Define implicit time.
        /// </summary>
        public TimeSpan ImplicitValue = TimeSpan.Zero;
    }
}
