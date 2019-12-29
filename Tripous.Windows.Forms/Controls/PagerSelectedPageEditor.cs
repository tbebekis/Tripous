/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;

namespace Tripous.Windows.Forms
{

    /// <summary>
    /// A UITypeEditor used with the SelectedPage property of the Pager. It displays the list
    /// of the availabe pages which belong to the Pager for the user to choose one.
    /// </summary>
    public class PagerSelectedPageEditor : ObjectSelectorEditor
    {
        /// <summary>
        /// Fills a hierarchical collection of labeled items, with each item represented
        /// by a System.Windows.Forms.TreeNode.
        /// </summary>
        protected override void FillTreeWithData(Selector selector, ITypeDescriptorContext context, IServiceProvider provider)
        {
            base.FillTreeWithData(selector, context, provider);

            Pager Pager = (Pager)context.Instance;
            selector.Clear();
            selector.Nodes.Clear();

            SelectorNode Node;
            foreach (Page Page in Pager.Pages)
            {
                Node = new SelectorNode(Page.Name, Page);

                selector.Nodes.Add(Node);

                if (Page == Pager.SelectedPage)
                    selector.SelectedNode = Node;
            }
        }
    }

}
