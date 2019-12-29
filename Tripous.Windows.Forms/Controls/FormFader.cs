/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tripous.Windows.Forms
{

    /// <summary>
    /// Cycles the Opacity of a form. 
    /// <para>Starts from 0.0, which is a completely transparent form, 
    /// then it goes to 1.0, waits for a while, 
    /// and then down to 0.0 agaain.</para>
    /// </summary>
    [System.ComponentModel.ToolboxItem(false)]
    public class FormFader : Component
    {
        private enum Phase
        {
            Ascending,
            Showing,
            Descending,
        }

        private Form form;
        private Timer timer = new Timer();
        private double step = 0.013;
        private Phase phase;
        private double showingValue;
        private bool restoreShowing;

        /// <summary>
        /// Disposes the timer.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                timer.Dispose();

            base.Dispose(disposing);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (form != null)
            {
                double Value;

                switch (phase)
                {
                    case Phase.Ascending:
                        Value = form.Opacity + Step;
                        if (Value >= 1)
                        {
                            phase = Phase.Showing;
                            showingValue = 0;
                        }
                        else
                        {
                            form.Opacity = Value;
                        }
                        break;

                    case Phase.Showing:
                        showingValue = showingValue + Step;
                        if (showingValue >= 1)
                        {
                            phase = Phase.Descending;
                        }
                        break;

                    case Phase.Descending:
                        Value = form.Opacity - Step;
                        if (Value <= 0)
                        {
                            timer.Enabled = false;
                            if (RestoreShowing)
                                form.Opacity = 1.0;

                            if (CycleCompleted != null)
                                CycleCompleted(this, EventArgs.Empty);
                        }
                        else
                        {
                            form.Opacity = Value;
                        }
                        break;
                }
            }
        }

        /* constructor */
        /// <summary>
        /// Constructor.
        /// </summary>
        public FormFader()
        {
            timer.Enabled = false;
            timer.Interval = 50;
            timer.Tick += new EventHandler(Timer_Tick);
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        public FormFader(IContainer container)
            : this()
        {
            container.Add(this);
        }

        /// <summary>
        /// Starts a fading operation.
        /// </summary>
        public void Start()
        {
            if ((form != null) && (!timer.Enabled))
            {
                phase = Phase.Ascending;
                form.Opacity = 0.0;
                timer.Enabled = true;
            }
        }
        /// <summary>
        /// Stops a fading operation
        /// </summary>
        public void Stop()
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
                form.Opacity = 1.0;
            }
        }



        /// <summary>
        /// The form to fade.
        /// </summary>
        [DefaultValue((Form)null)]
        public Form Form
        {
            get { return form; }
            set { form = value; }
        }
        /// <summary>
        /// True when fading
        /// </summary>
        [ReadOnly(true)]
        [Browsable(false)]
        public bool Fading { get { return timer.Enabled; } }
        /// <summary>
        /// Gets or sets the amount of the opacity each step increases or decreases.
        /// </summary>
        [DefaultValue(0.013)]
        public double Step
        {
            get { return step < 0.005 ? 0.005 : step; }
            set { step = value; }
        }
        /// <summary>
        /// When true the Form.Opacity is restored back to 1.0 after a complete cycle.
        /// </summary>
        [DefaultValue(false)]
        public bool RestoreShowing
        {
            get { return restoreShowing; }
            set { restoreShowing = value; }
        }


        /// <summary>
        /// Occurs when a cycle completes.
        /// </summary>
        public event EventHandler CycleCompleted;

    }
}
