﻿using Avalonia.Media;

namespace Neumorphism.Avalonia.Styles.Themes.Base
{
    public class NeumorphismLightTheme : IBaseTheme
    {
        public Color ValidationErrorColor { get; } = Color.Parse("#F44336");
        public Color MaterialDesignBackground { get; } = Color.Parse("#FFFFFFFF");
        public Color MaterialDesignForeground { get; } = Color.Parse("#FF000000");
        public Color MaterialDesignPaper { get; } = Color.Parse("#FFE0E5EC");
        public Color MaterialDesignCardBackground { get; } = Color.Parse("#FFFFFFFF");
        public Color MaterialDesignToolBarBackground { get; } = Color.Parse("#FFF5F5F5");
        public Color MaterialDesignBody { get; } = Color.Parse("#DD000000");
        public Color MaterialDesignBodyLight { get; } = Color.Parse("#89000000");
        public Color MaterialDesignColumnHeader { get; } = Color.Parse("#BC000000");
        public Color MaterialDesignCheckBoxOff { get; } = Color.Parse("#89000000");
        public Color MaterialDesignCheckBoxDisabled { get; } = Color.Parse("#FFBDBDBD");
        public Color MaterialDesignTextBoxBorder { get; } = Color.Parse("#89000000");
        public Color MaterialDesignDivider { get; } = Color.Parse("#1F000000");
        public Color MaterialDesignSelection { get; } = Color.Parse("#44888b8f");
        public Color MaterialDesignToolForeground { get; } = Color.Parse("#FF616161");
        public Color MaterialDesignToolBackground { get; } = Color.Parse("#FFE0E0E0");
        public Color MaterialDesignFlatButtonClick { get; } = Color.Parse("#FFDEDEDE");
        public Color MaterialDesignFlatButtonRipple { get; } = Color.Parse("#FFB6B6B6");
        public Color MaterialDesignToolTipBackground { get; } = Color.Parse("#757575");
        public Color MaterialDesignChipBackground { get; } = Color.Parse("#12000000");
        public Color MaterialDesignSnackbarBackground { get; } = Color.Parse("#FF323232");
        public Color MaterialDesignSnackbarMouseOver { get; } = Color.Parse("#FF464642");
        public Color MaterialDesignSnackbarRipple { get; } = Color.Parse("#FFB6B6B6");
        public Color MaterialDesignTextFieldBoxBackground { get; } = Color.Parse("#0F000000");
        public Color MaterialDesignTextFieldBoxHoverBackground { get; } = Color.Parse("#14000000");
        public Color MaterialDesignTextFieldBoxDisabledBackground { get; } = Color.Parse("#08000000");
        public Color MaterialDesignTextAreaBorder { get; } = Color.Parse("#BC000000");
        public Color MaterialDesignTextAreaInactiveBorder { get; } = Color.Parse("#0F000000");
        public Color MaterialDesignDataGridRowHoverBackground { get; } = Color.Parse("#0A000000");

        public Color MaterialDesignShadowLightColor { get; } = Color.Parse("#CCFFFFFF");
        public Color MaterialDesignShadowDarkColor { get; } = Color.Parse("#33000000");

        public Color MaterialDesignBorderShadowColor { get; } = Color.Parse("#FFC4C7CB");

        public Color MaterialDesignDisabledNoTransparencyColor { get; } = Color.Parse("#FFD3D8DE");


        public Color MaterialDesignTransparentColor { get; } = Color.Parse("#00FFFFFF");
        public Color MaterialDesignSilverGrayColor { get; } = Color.Parse("#CCCCCCCC");
    }
}