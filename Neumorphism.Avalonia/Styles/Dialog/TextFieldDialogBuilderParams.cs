﻿using Neumorphism.Avalonia.Styles.Dialog.Bases;

namespace Neumorphism.Avalonia.Styles.Dialog
{
    public class TextFieldDialogBuilderParams : TwoFeedbackDialogBuilderParamsBase
    {
        /// <summary>
        /// Build text fields stack.
        /// </summary>
        public TextFieldBuilderParams[] TextFields = TextFieldBuilderParams.OneRegularTextField;
        //public DialogResult NegativeResult = new DialogResult(DialogHelper.DIALOG_RESULT_CANCEL);
    }
}
