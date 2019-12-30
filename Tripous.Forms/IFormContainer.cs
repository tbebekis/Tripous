using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripous.Forms
{


    /// <summary>
    /// Represents an object that can act as a parent of a nested form
    /// </summary>
    public interface IFormContainer
    {
        /// <summary>
        /// True if container contains the specifield child form.
        /// </summary>
        bool Contains(IChildForm Child);
        /// <summary>
        /// Gets called by a <see cref="IChildForm"/> in order to add the child to the internal child list.
        /// </summary>
        object Add(IChildForm Child);
        /// <summary>
        /// Gets called by a <see cref="IChildForm"/> in order to remove the child from the internal child list.
        /// </summary>
        void Remove(IChildForm Child);
        /// <summary>
        /// Gets notified (called) by a <see cref="IChildForm"/> when its caption changes.
        /// </summary>
        void TitleChanged(IChildForm Child);
        /// <summary>
        /// Activates (brings to front) the specified child
        /// </summary>
        void ActivateChild(IChildForm Child);
        /// <summary>
        /// Returns an array of child forms
        /// </summary>
        IChildForm[] GetChildren();
        /// <summary>
        /// True if all child forms can be closed
        /// </summary>
        bool CanCloseChildren(CloseReason CloseReason);
        /// <summary>
        /// Closes child forms. Returns true if all child forms are closed.
        /// </summary>
        bool CloseChildren();



        /* properties */
        /// <summary>
        /// Gets the active form in the container
        /// </summary>
        Form ActiveNestedForm { get; }
        /// <summary>
        /// The number of child forms
        /// </summary>
        int ChildCount { get; }
    }
}
