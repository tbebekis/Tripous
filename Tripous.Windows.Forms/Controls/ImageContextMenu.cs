/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

 
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Tripous.Windows.Forms
{
 
    /// <summary>
    /// A <see cref="ContextMenuStrip"/> tailored for the <see cref="PictureBox"/>
    /// </summary>
    [ToolboxBitmap(typeof(ContextMenuStrip))]
    public class ImageContextMenu : ContextMenuStrip
    {
        private ToolStripMenuItem mnuCut;
        private ToolStripMenuItem mnuCopy;
        private ToolStripMenuItem mnuPaste;
        private ToolStripMenuItem mnuClear;
        private ToolStripMenuItem mnuLoad;
        private ToolStripMenuItem mnuSave;

        private bool readOnly;

        /// <summary>
        /// Raises the Opening event
        /// </summary>
        protected override void OnOpening(CancelEventArgs e)
        {
            base.OnOpening(e);

            IDataObject DataObject = Clipboard.GetDataObject();

            mnuCut.Enabled = Image != null;
            mnuCopy.Enabled = Image != null;
            mnuPaste.Enabled = (DataObject != null) && DataObject.GetDataPresent(DataFormats.Bitmap) && (!readOnly);
            mnuClear.Enabled = (Image != null) && (!readOnly);
            mnuSave.Enabled = Image != null;
        }
        private void AnyCommand(object sender, EventArgs e)
        {

            string FileName = "";

            if ((sender == mnuCut) && (Image != null))
            {
                Clipboard.SetDataObject(Image, false);
                mnuClear.PerformClick();
            }
            else if ((sender == mnuCopy) && (Image != null))
            {
                Clipboard.SetDataObject(Image, false);
            }
            else if ((sender == mnuPaste) && (!readOnly))
            {
                IDataObject DataObject = Clipboard.GetDataObject();
                if (DataObject.GetDataPresent(DataFormats.Bitmap))
                {
                    this.Image = DataObject.GetData(DataFormats.Bitmap) as Bitmap;
                }
            }
            else if ((sender == mnuClear) && (!readOnly))
            {
                this.Image = null;
            }
            else if ((sender == mnuLoad) && FileBox.Open(ref FileName, "ALL;BMP;JPG;PNG;TIF;GIF;EMF;WMF;ICO"))
            {
                this.Image = Bitmap.FromFile(FileName);
            }
            else if ((sender == mnuSave) && (Image != null) && FileBox.Save(ref FileName, "BMP;JPG;PNG;TIF;GIF;EMF;WMF;ICO"))
            {
                Image.Save(FileName, FileBox.ExtensionToImageFormat(FileName));
            }
        }

        private Image Image
        {
            get
            {
                PictureBox PictureBox = this.SourceControl as PictureBox;
                if (PictureBox != null)
                    return PictureBox.Image;
                return null;
            }
            set
            {
                PictureBox PictureBox = this.SourceControl as PictureBox;
                if (PictureBox != null)
                    PictureBox.Image = value;
            }
        }


        /// <summary>
        /// Constructor
        /// </summary>
        public ImageContextMenu()
        {
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();

            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuClear,
            this.mnuLoad,
            this.mnuSave});
            this.Size = new System.Drawing.Size(153, 136);

            // 
            // mnuCut
            // 
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Size = new System.Drawing.Size(152, 22);
            this.mnuCut.Text = "Cut";
            this.mnuCut.Click += new EventHandler(AnyCommand);

            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(152, 22);
            this.mnuCopy.Text = "Copy";
            this.mnuCopy.Click += new EventHandler(AnyCommand);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(152, 22);
            this.mnuPaste.Text = "Paste";
            this.mnuPaste.Click += new EventHandler(AnyCommand);
            // 
            // mnuClear
            // 
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.Size = new System.Drawing.Size(152, 22);
            this.mnuClear.Text = "Clear";
            this.mnuClear.Click += new EventHandler(AnyCommand);
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(152, 22);
            this.mnuLoad.Text = "Load";
            this.mnuLoad.Click += new EventHandler(AnyCommand);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new EventHandler(AnyCommand);

            this.ResumeLayout(false);
        }

        /// <summary>
        /// Gets or sets a boolean value indicating whether this instance is read only
        /// </summary>
        public bool ReadOnly
        {
            get { return readOnly; }
            set { readOnly = value; }
        }


    }
 
}

 
