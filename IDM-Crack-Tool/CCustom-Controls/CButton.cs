using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDM_Crack_Tool.Custom_Controls.State;

namespace IDM_Crack_Tool.Custom_Controls
{
    public class CButton : Control
    {
        public CButton()
        {
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);

        }

        public ActionMouseState State= ActionMouseState.None;

        protected override void OnMouseEnter(EventArgs e)
        {
            State = ActionMouseState.Hovered;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            State = ActionMouseState.None;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            State = ActionMouseState.Pressed;
            Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            State = ActionMouseState.Released;
            Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            switch (State)
            {
                case ActionMouseState.None:
                    e.Graphics.FillRectangle(new SolidBrush(ButtonNormalColor1), ClientRectangle);
                    e.Graphics.FillRectangle(new SolidBrush(ButtonNormalColor2), ClientRectangle);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(TextNormalColor), ClientRectangle, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center, Trimming= st });
                    break;
                case ActionMouseState.Hovered:
                    e.Graphics.FillRectangle(new SolidBrush(ButtonHoveredColor1), ClientRectangle);
                    e.Graphics.FillRectangle(new SolidBrush(ButtonHoveredColor2), ClientRectangle);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(TextHoveredColor), ClientRectangle, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center, Trimming = st });
                    break;
                case ActionMouseState.Pressed:
                    e.Graphics.FillRectangle(new SolidBrush(ButtonPressedColor1), ClientRectangle);
                    e.Graphics.FillRectangle(new SolidBrush(ButtonPressedColor2), ClientRectangle);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(TextPressedColor), ClientRectangle, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center, Trimming = st });
                    break;
                case ActionMouseState.Released:
                    e.Graphics.FillRectangle(new SolidBrush(ButtonHoveredColor1), ClientRectangle);
                    e.Graphics.FillRectangle(new SolidBrush(ButtonHoveredColor2), ClientRectangle);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(TextHoveredColor), ClientRectangle, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center, Trimming=st });
                    break;

            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            Invalidate();
            base.OnTextChanged(e);
        }

        StringTrimming st = StringTrimming.EllipsisCharacter;
        public StringTrimming StringTrimming
        {
            get { return st; }
            set { st = value; Invalidate(); }
        }

        Color color1 = Color.FromArgb(0, 168, 148);
        Color color2 = Color.FromArgb(0, 168, 148);

        public Color ButtonNormalColor1
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }

        public Color ButtonNormalColor2
        {
            get { return color2; }
            set { color2 = value; Invalidate(); }
        }

        public Color ButtonHoveredColor1 { get; set; } = Color.FromArgb(20, 188, 168);
        public Color ButtonHoveredColor2 { get; set; } = Color.FromArgb(20, 188, 168);

        public Color ButtonPressedColor1 { get; set; } = Color.FromArgb(0, 148, 128);
        public Color ButtonPressedColor2 { get; set; } = Color.FromArgb(0, 148, 128);

        Color text1 = Color.White;
        public Color TextNormalColor
        {
            get { return text1; }
            set { text1 = value; Invalidate(); }
        }

        Color text2 = Color.White;
        public Color TextHoveredColor
        {
            get { return text2; }
            set { text2 = value; Invalidate(); }
        }

        Color text3 = Color.White;

        public Color TextPressedColor
        {
            get { return text3; }
            set { text3 = value; Invalidate(); }
        }
    }
}
