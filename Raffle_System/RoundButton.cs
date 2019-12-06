using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class RoundButton : Button
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private Pen _pen = null;
        SolidBrush _brushText = null, _brushInside = null;
        private Point _textStartPoint = new Point(0, 0);
        private bool _bDrawOutline = false;
        private Pen _dashedPen = null;
        private Pen _blackPen = null;

        // These are for drawing when you hover over the button
        private Color _hoverColor = Color.FromKnownColor(KnownColor.ControlDark);
        private Pen _hoverPen = null;
        private SolidBrush _hoverBrushInside = null;

        [
        Category("Button step-in color"),
        Description("This color will show up when you hover over the button")
        ]
        public Color HoverColor
        {
            get
            {
                return _hoverColor;
            }
            set
            {
                _hoverColor = value;
                _hoverPen.Color = value;
                _hoverBrushInside.Color = value;
            }
        }

        [
        Category("Text start point"),
        Description("Point where your text would start getting drawn")
        ]
        public Point TextStartPoint
        {
            get
            {
                return _textStartPoint;
            }
            set
            {
                _textStartPoint = value;
            }
        }

        public RoundButton()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitComponent call
            _pen = new Pen(BackColor);
            _brushInside = new SolidBrush(BackColor);
            _brushText = new SolidBrush(ForeColor);

            _hoverPen = new Pen(_hoverColor);
            _hoverBrushInside = new SolidBrush(_hoverColor);

            _blackPen = new Pen(Color.FromKnownColor(KnownColor.Black), 2);
            _dashedPen = new Pen(Color.FromKnownColor(KnownColor.Black), 1);
            _dashedPen.DashStyle = DashStyle.Dot;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // RoundButton
            // 
            this.ForeColorChanged += new System.EventHandler(this.RoundButton_ForeColorChanged);
            this.Enter += new System.EventHandler(this.RoundButton_Enter);
            this.MouseEnter += new System.EventHandler(this.RoundButton_MouseEnter);
            this.BackColorChanged += new System.EventHandler(this.RoundButton_BackColorChanged);
            this.Leave += new System.EventHandler(this.RoundButton_Leave);
            this.MouseLeave += new System.EventHandler(this.RoundButton_MouseLeave);

        }
        #endregion

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            ColorButton1(g);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(path);
        }

        // Fills color. No color gradient.
        void ColorButton1(Graphics g)
        {
            g.DrawEllipse(_pen, 0, 0, ClientSize.Width, ClientSize.Height);
            g.FillEllipse(_brushInside, 0, 0, ClientSize.Width, ClientSize.Height);
        DrawText(g);
        }

        private void DrawText(Graphics g)
        {
            g.DrawString(this.Text, this.Font, _brushText, new PointF(_textStartPoint.X, _textStartPoint.Y));
        }

        private void RoundButton_MouseEnter(object sender, System.EventArgs e)
        {
            _pen.Color = _hoverColor;
            _brushInside.Color = _hoverColor;
            this.Invalidate();
        }

        private void RoundButton_MouseLeave(object sender, System.EventArgs e)
        {
            _pen.Color = BackColor;
            _brushInside.Color = BackColor;
            this.Invalidate();
        }

        private void RoundButton_Enter(object sender, System.EventArgs e)
        {
            _bDrawOutline = true;
        }

        private void RoundButton_Leave(object sender, System.EventArgs e)
        {
            _bDrawOutline = false;
        }

        private void RoundButton_BackColorChanged(object sender, System.EventArgs e)
        {
            _pen.Color = BackColor;
            _brushInside.Color = BackColor;
        }

        private void RoundButton_ForeColorChanged(object sender, System.EventArgs e)
        {
            _brushText.Color = ForeColor;
        }
    }