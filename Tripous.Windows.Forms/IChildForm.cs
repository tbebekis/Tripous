using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripous.Windows.Forms
{
    /// <summary>
    /// Represents a form that can be a nested form
    /// </summary>
    public interface IChildForm
    {
        /// <summary>
        /// Gets the nested form container that contains this form instance or null
        /// </summary>
        IFormContainer FormContainer { get; }
        /// <summary>
        /// Gets the title of the form
        /// </summary>
        string Title { get; }
        /// <summary>
        /// Updates the user interface, title, enable-disable buttons etc.
        /// </summary>
        void UpdateUi();
        /// <summary>
        /// Returns true if the form can close.
        /// </summary>
        bool CanClose(CloseReason CloseReason);
        /// <summary>
        /// Closes the form
        /// </summary>
        void Close();
        /// <summary>
        /// Called just before this child form is deactivated by the container
        /// </summary>
        void Deactivating();
        /// <summary>
        /// Called just after this child form is activated by the container
        /// </summary>
        void RestoreScrollPosition();
        /// <summary>
        /// Instructs this form to set focus either to itself or to any of its controls
        /// </summary>
        void ActivateFocus();


    }
}
