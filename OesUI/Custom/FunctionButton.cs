using System.Drawing;
using System.Windows.Forms;

namespace OesUI.Custom
{
    class FunctionButton : Control
    {
        public Font TextFont { get; set; }
        public Color DefaultFontColor { get; set; }
        public Color SelectedFontColor { get; set; }
        public Image DefaultImage { get; set; }
        public Image SelectedImage { get; set; }
        private Color currentColor;
        private Image currentImage;
        private bool isSelected;

        public bool IsSelected 
        {
            get 
            {
                return isSelected;
            }
            set 
            {
                isSelected = value;

                if (isSelected)
                {
                    currentColor = SelectedFontColor;
                    currentImage = SelectedImage;
                }
                else
                {
                    currentImage = DefaultImage;
                    currentColor = DefaultFontColor;
                }
            } 
        }

        public FunctionButton()
        {
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.UpdateStyles();
            base.CreateControl();

            this.Width = 150;
            this.Height = 50;
            this.currentImage = new Bitmap(24, 24);
            this.currentColor = Color.Blue;
            this.TextFont = new Font("Microsoft Yahei", 15);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;
                return cp;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!this.IsSelected)
            {
                IsSelected = true;
                this.Invalidate();

                foreach (Control item in this.Parent.Controls)
                {
                    if (item is FunctionButton && item != this)
                    {
                        if ((item as FunctionButton).IsSelected)
                        {
                            (item as FunctionButton).IsSelected = false;
                            item.Invalidate();
                        }
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(currentImage, new Point(15, 13));
            e.Graphics.DrawString(this.Text, this.TextFont, new SolidBrush(currentColor), new Point(45, 18));
        }
    }
}
