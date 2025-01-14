﻿using System;
using AvaloniaMedia=Avalonia.Media;

namespace Neumorphism.Avalonia.Styles.Colors.ColorManipulation
{
    public static class ColorHelper
    {
        public static AvaloniaMedia.Color ContrastingForegroundColor(this AvaloniaMedia.Color color) {
            double RgbSrgb(double d) {
                d = d / 255.0;
                return d > 0.03928
                    ? d = Math.Pow((d + 0.055) / 1.055, 2.4)
                    : d = d / 12.92;
            }

            var r = RgbSrgb(color.R);
            var g = RgbSrgb(color.G);
            var b = RgbSrgb(color.B);

            var luminance = 0.2126 * r + 0.7152 * g + 0.0722 * b;
            return luminance > 0.179 ? AvaloniaMedia.Colors.Black : AvaloniaMedia.Colors.White;
        }

        public static AvaloniaMedia.Color ShiftLightness(this AvaloniaMedia.Color color, int amount = 1) {
            var lab = color.ToLab();
            var shifted = new Lab(lab.L - LabConstants.Kn * amount, lab.A, lab.B);
            return shifted.ToColor();
        }

        public static AvaloniaMedia.Color Darken(this AvaloniaMedia.Color color, int amount = 1) {
            return color.ShiftLightness(amount);
        }

        public static AvaloniaMedia.Color Lighten(this AvaloniaMedia.Color color, int amount = 1) {
            return color.ShiftLightness(-amount);
        }

        /// <summary>
        ///     Calculates the CIE76 distance between two colors.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static double Difference(this AvaloniaMedia.Color color, AvaloniaMedia.Color other) {
            var lab1 = color.ToLab();
            var lab2 = color.ToLab();

            return Math.Sqrt(Math.Pow(lab2.L - lab1.L, 2) +
                             Math.Pow(lab2.A - lab1.A, 2) +
                             Math.Pow(lab2.B - lab1.B, 2));
        }
    }
}