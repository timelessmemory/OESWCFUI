using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OesUI.Custom
{
    [ToolboxBitmap(typeof(MyOpaqueLayer))]
    public class MyOpaqueLayer : System.Windows.Forms.Control
    {
        private bool transparentBG = true;
        private int alpha = 125;
        private Container components = new Container();

        public MyOpaqueLayer() : this(125, true)
        {
        }

        public MyOpaqueLayer(int Alpha, bool showLoadingImage)
        {
            SetStyle(System.Windows.Forms.ControlStyles.Opaque, true);
            base.CreateControl();
            this.alpha = Alpha;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!((components == null)))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// draw window
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            float vlblControlWidth;
            float vlblControlHeight;

            Pen labelBorderPen;
            SolidBrush labelBackColorBrush;

            if (transparentBG)
            {
                Color drawColor = Color.FromArgb(this.alpha, this.BackColor);
                labelBorderPen = new Pen(drawColor, 0);
                labelBackColorBrush = new SolidBrush(drawColor);
            }
            else
            {
                labelBorderPen = new Pen(this.BackColor, 0);
                labelBackColorBrush = new SolidBrush(this.BackColor);
            }

            base.OnPaint(e);
            vlblControlWidth = this.Size.Width;
            vlblControlHeight = this.Size.Height;
            e.Graphics.DrawRectangle(labelBorderPen, 0, 0, vlblControlWidth, vlblControlHeight);
            e.Graphics.FillRectangle(labelBackColorBrush, 0, 0, vlblControlWidth, vlblControlHeight);
        }
       
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        [Category("myOpaqueLayer"), Description("isOpen alpha, default is True")]
        public bool TransparentBG
        {
            get { return transparentBG; }
            set
            {
                transparentBG = value;
                this.Invalidate();
            }
        }

        [Category("myOpaqueLayer"), Description("set alpha")]
        public int Alpha
        {
            get { return alpha; }
            set
            {
                alpha = value;
                this.Invalidate();
            }
        }
    }
}
