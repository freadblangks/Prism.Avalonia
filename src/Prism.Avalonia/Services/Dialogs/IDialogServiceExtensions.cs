﻿using System;
using Avalonia.Controls;

namespace Prism.Services.Dialogs
{
    /// <summary>
    /// Extensions for the IDialogService
    /// </summary>
    public static class IDialogServiceExtensions
    {
        /// <summary>
        /// Shows a non-modal dialog.
        /// </summary>
        /// <param name="dialogService">The DialogService</param>
        /// <param name="name">The name of the dialog to show.</param>
        public static void Show(this IDialogService dialogService, string name)
        {
            dialogService.Show(name, new DialogParameters(), null);
        }

        /// <summary>
        /// Shows a non-modal dialog.
        /// </summary>
        /// <param name="dialogService">The DialogService</param>
        /// <param name="name">The name of the dialog to show.</param>
        /// <param name="callback">The action to perform when the dialog is closed.</param>
        public static void Show(this IDialogService dialogService, string name, Action<IDialogResult> callback)
        {
            dialogService.Show(name, new DialogParameters(), callback);
        }
        /// <summary>
        /// Shows a modal dialog.
        /// </summary>
        /// <param name="dialogService">The DialogService</param>
        /// <param name="owner">The parent window of the dialog.</param>
        /// <param name="name">The name of the dialog to show.</param>
        public static void ShowDialog(this IDialogService dialogService, Window owner, string name)
        {
            dialogService.ShowDialog(owner, name, new DialogParameters(), null);
        }

        /// <summary>
        /// Shows a modal dialog.
        /// </summary>
        /// <param name="dialogService">The DialogService</param>
        /// <param name="owner">The parent window of the dialog.</param>
        /// <param name="name">The name of the dialog to show.</param>
        /// <param name="callback">The action to perform when the dialog is closed.</param>
        public static void ShowDialog(this IDialogService dialogService, Window owner, string name, Action<IDialogResult> callback)
        {
            dialogService.ShowDialog(owner, name, new DialogParameters(), callback);
        }
    }
}
