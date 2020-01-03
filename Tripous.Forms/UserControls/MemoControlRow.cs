﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripous.Forms
{

    /// <summary>
    /// Multiline textbox <see cref="ControlRow"/>
    /// </summary>
    public partial class MemoControlRow : ControlRow
    {
        /// <summary>
        /// Returns the value of the <see cref="Value"/> property
        /// </summary>
        protected override object GetValue()
        {
            return edtText.Text;
        }
        /// <summary>
        /// Sets the value of the <see cref="Value"/> property
        /// </summary>
        protected override void SetValue(object V)
        {
            edtText.Text = Sys.IsNull(V) ? null : V.ToString();
        }

        /// <summary>
        /// The name of the property to bind to
        /// </summary>
        protected override string BindPropertyName { get { return "Text"; } }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public MemoControlRow()
        {
            InitializeComponent();

            this.Control = edtText;
        }
    }
}