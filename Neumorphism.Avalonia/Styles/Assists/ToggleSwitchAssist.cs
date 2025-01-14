﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace Neumorphism.Avalonia.Styles.Assists
{
    public static class ToggleSwitchAssist
    {
        /// <summary>
        /// Background on
        /// </summary>
        public static AvaloniaProperty<IBrush> SwitchTrackOnBackgroundProperty = AvaloniaProperty.RegisterAttached<ToggleSwitch, IBrush>(
            "SwitchTrackOnBackground", typeof(ToggleSwitchAssist));

        public static void SetSwitchTrackOnBackground(AvaloniaObject element, IBrush value) {
            element.SetValue(SwitchTrackOnBackgroundProperty, value);
        }

        public static IBrush GetSwitchTrackOnBackground(AvaloniaObject element) {
            return (IBrush) element.GetValue(SwitchTrackOnBackgroundProperty);
        }


        /// <summary>
        /// Background off
        /// </summary>
        public static AvaloniaProperty<IBrush> SwitchTrackOffBackgroundProperty = AvaloniaProperty.RegisterAttached<ToggleSwitch, IBrush>(
            "SwitchTrackOffBackground", typeof(ToggleSwitchAssist));

        public static void SetSwitchTrackOffBackground(AvaloniaObject element, IBrush value) {
            element.SetValue(SwitchTrackOffBackgroundProperty, value);
        }

        public static IBrush GetSwitchTrackOffBackground(AvaloniaObject element) {
            return (IBrush) element.GetValue(SwitchTrackOffBackgroundProperty);
        }


        /// <summary>
        /// Button on
        /// </summary>
        public static AvaloniaProperty<IBrush> SwitchTrackOnForegroundProperty = AvaloniaProperty.RegisterAttached<ToggleSwitch, IBrush>(
            "SwitchTrackOnForeground", typeof(ToggleSwitchAssist));

        public static void SetSwitchTrackOnForeground(AvaloniaObject element, IBrush value)
        {
            element.SetValue(SwitchTrackOnForegroundProperty, value);
        }

        public static IBrush GetSwitchTrackOnForeground(AvaloniaObject element)
        {
            return (IBrush)element.GetValue(SwitchTrackOnForegroundProperty);
        }


        /// <summary>
        /// Button off
        /// </summary>
        public static AvaloniaProperty<IBrush> SwitchTrackOffForegroundProperty = AvaloniaProperty.RegisterAttached<ToggleSwitch, IBrush>(
            "SwitchTrackOffForeground", typeof(ToggleSwitchAssist));

        public static void SetSwitchTrackOffForeground(AvaloniaObject element, IBrush value)
        {
            element.SetValue(SwitchTrackOffForegroundProperty, value);
        }

        public static IBrush GetSwitchTrackOffForeground(AvaloniaObject element)
        {
            return (IBrush)element.GetValue(SwitchTrackOffForegroundProperty);
        }

        /// <summary>
        /// Button over
        /// </summary>
        public static AvaloniaProperty<IBrush> SwitchTrackOverForegroundProperty = AvaloniaProperty.RegisterAttached<ToggleSwitch, IBrush>(
            "SwitchTrackOverForeground", typeof(ToggleSwitchAssist));

        public static void SetSwitchTrackOverForeground(AvaloniaObject element, IBrush value)
        {
            element.SetValue(SwitchTrackOverForegroundProperty, value);
        }

        public static IBrush GetSwitchTrackOverForeground(AvaloniaObject element)
        {
            return (IBrush)element.GetValue(SwitchTrackOverForegroundProperty);
        }
    }
}