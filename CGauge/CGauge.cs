using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGauge
{
    public partial class CGauge: UserControl
    {
        // Private Properties
        private Bitmap __Image;

        private Color __Base;
        private Color __Fill;
        private Color __Normal;
        private Color __Warning;
        private Color __Alarm;

        private float __Width;
        private float __Height;
        private float __StrokeWeight;
        private float __InnerStrokeWeight;

        private float __Value;
        private float __ValueMin;
        private float __ValueMax;
        private string __Unit;
        private float __ThresholdWarning;
        private float __ThresholdAlarm;
        private float __ThresholdWarningPercent;
        private float __ThresholdAlarmPercent;

        private float __StartAngle;
        private float __SweepAngle;
        private float __PositionX;
        private float __PositionY;

        private Font __Font_Value;
        private Font __Font_Unit;

        // Public Properties
        [Category("Threshold Settings"), Description("Alarm threshold value in percent (%).")]
        public float ThresholdAlarm
        {
            get { return __ThresholdAlarmPercent; }
            set { __ThresholdAlarmPercent = value; this.Invalidate(); }
        }

        [Category("Threshold Settings"), Description("Warning threshold value in percent (%).")]
        public float ThresholdWarning
        {
            get { return __ThresholdWarningPercent; }
            set { __ThresholdWarningPercent = value; this.Invalidate(); }
        }

        [Category("Value Settings"), Description("Value.")]
        public float Value
        {
            get { return __Value; }
            set { __Value = value; this.Invalidate(); }
        }

        [Category("Value Settings"), Description("Value minimum limit.")]
        public float ValueMin
        {
            get { return __ValueMin; }
            set { __ValueMin = value; this.Invalidate(); }
        }

        [Category("Value Settings"), Description("Value maximum limit.")]
        public float ValueMax
        {
            get { return __ValueMax; }
            set { __ValueMax = value; this.Invalidate(); }
        }

        [Category("Value Settings"), Description("Value font.")]
        public Font ValueFont
        {
            get { return __Font_Value; }
            set { __Font_Value = value; this.Invalidate(); }
        }

        [Category("Value Settings"), Description("Value unit.")]
        public string ValueUnit
        {
            get { return __Unit; }
            set { __Unit = value; this.Invalidate(); }
        }

        [Category("Value Settings"), Description("Value unit font.")]
        public Font ValueUnitFont
        {
            get { return __Font_Unit; }
            set { __Font_Unit = value; this.Invalidate(); }
        }

        [Category("Gauge Settings"), Description("Gauge width in pixel.")]
        public float GaugeWidth
        {
            get { return __Width; }
            set { __Width = value; this.Invalidate(); }
        }

        [Category("Gauge Settings"), Description("Gauge height in pixel.")]
        public float GaugeHeight
        {
            get { return __Height; }
            set { __Height = value; this.Invalidate(); }
        }

        [Category("Gauge Settings"), Description("Gauge stroke weight in pixel.")]
        public float StrokeWeight
        {
            get { return __StrokeWeight; }
            set { __StrokeWeight = value; this.Invalidate(); }
        }

        [Category("Gauge Settings"), Description("Gauge inner stroke weight in pixel.")]
        public float InnerStrokeWeight
        {
            get { return __InnerStrokeWeight; }
            set { __InnerStrokeWeight = value; this.Invalidate(); }
        }

        [Category("Gauge Settings"), Description("Gauge start angle (0..360°)")]
        public float StartAngle
        {
            get { return __StartAngle; }
            set { __StartAngle = value; this.Invalidate(); }
        }

        [Category("Gauge Settings"), Description("Gauge sweep angle (0..360°)")]
        public float SweepAngle
        {
            get { return __SweepAngle; }
            set { __SweepAngle = value; this.Invalidate(); }
        }

        [Category("Color Settings"), Description("Gauge base color.")]
        public Color BaseColor
        {
            get { return __Base; }
            set { __Base = value; this.Invalidate(); }
        }
        [Category("Color Settings"), Description("Gauge base color.")]
        public Color FillColor
        {
            get { return __Fill; }
            set { __Fill = value; this.Invalidate(); }
        }
        [Category("Color Settings"), Description("Gauge base color.")]
        public Color NormalColor
        {
            get { return __Normal; }
            set { __Normal = value; this.Invalidate(); }
        }
        [Category("Color Settings"), Description("Gauge base color.")]
        public Color WarningColor
        {
            get { return __Warning; }
            set { __Warning = value; this.Invalidate(); }
        }
        [Category("Color Settings"), Description("Gauge base color.")]
        public Color AlarmColor
        {
            get { return __Alarm; }
            set { __Alarm = value; this.Invalidate(); }
        }

        public int GetWidth()
        { return base.Width; }

        public void SetWidth(int value)
        { base.Width = value; this.Invalidate(); }
        public int GetHeight()
        { return base.Height; }
        public void SetHeight(int value)
        { base.Height = value; this.Invalidate(); }

        public CGauge()
        {
            InitializeComponent();

            __StartAngle = 150.0F;
            __SweepAngle = 240.0F;

            __Base = Color.FromArgb(211, 211, 211);
            __Fill = Color.FromArgb(126, 223, 180);
            __Normal = Color.FromArgb(126, 223, 180);
            __Warning = Color.FromArgb(247, 156, 71);
            __Alarm = Color.FromArgb(246, 94, 46);
            __Width = 150.0F;
            __Height = 150.0F;
            __StrokeWeight = 20.0F;
            __InnerStrokeWeight = 4.0F;
            __ValueMin = 0.0F;
            __ValueMax = 100.0F;
            __Unit = "°C";

            __Image = new Bitmap(this.Size.Width, this.Size.Height);
            __PositionX = this.Size.Width / 2 - __Width / 2;
            __PositionY = this.Size.Height / 2 - __Height / 2;

            __ThresholdWarningPercent = 70.0F;
            __ThresholdAlarmPercent = 90.0F;

            __Font_Value = new Font("Calibri", 22);
            __Font_Unit = new Font("Calibri", 14, FontStyle.Bold);

            this.DoubleBuffered = true;
        }

        public class PaintEventArgs : EventArgs
        {
            public System.Drawing.Rectangle ClipRectangle { get; }
            public System.Drawing.Graphics Graphics { get; }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            
            if((__Image.Size.Width != this.Size.Width) || (__Image.Size.Height != this.Size.Height))
            {
                __Image = new Bitmap(this.Size.Width, this.Size.Height);
            }

            __PositionX = (this.Size.Width / 2) - (__Width / 2);
            __PositionY = (this.Size.Height / 2) - (__Height / 2);

            __ThresholdAlarm = __ThresholdAlarmPercent * __SweepAngle / 100.0F;
            __ThresholdWarning = __ThresholdWarningPercent * __SweepAngle / 100.0F;

            if (__Value < this.__ValueMin) __Value = this.__ValueMin;
            if (__Value > this.__ValueMax) __Value = this.__ValueMax;

            // Decisions for fill color with thresholds
            Color tFill = this.__Fill;
            if (Map(__Value, this.__ValueMin, this.__ValueMax, 0, __SweepAngle) > (__ThresholdAlarm)) tFill = this.__Alarm;
            else if (Map(__Value, this.__ValueMin, this.__ValueMax, 0, __SweepAngle) > (__ThresholdWarning)) tFill = this.__Warning;

            // some settings about bitmap
            e.Graphics.Clear(this.BackColor);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // Draw Arc operations
            Pen penArcBase = new Pen(this.__Base, this.__StrokeWeight);
            e.Graphics.DrawArc(penArcBase, this.__PositionX, this.__PositionY, this.__Width, this.__Height, __StartAngle, __SweepAngle);
            Pen penArcFill = new Pen(tFill, this.__StrokeWeight);
            e.Graphics.DrawArc(penArcFill, this.__PositionX, this.__PositionY, this.__Width, this.__Height, __StartAngle, Map(__Value, this.__ValueMin, this.__ValueMax, 0, __SweepAngle));
            Pen penArcUpperLimit = new Pen(this.__Alarm, this.__InnerStrokeWeight);
            e.Graphics.DrawArc(penArcUpperLimit, this.__PositionX + __StrokeWeight / 2 + __InnerStrokeWeight, this.__PositionY + __StrokeWeight / 2 + __InnerStrokeWeight, this.__Width - __StrokeWeight - __InnerStrokeWeight * 2, this.__Height - __StrokeWeight - __InnerStrokeWeight * 2, __StartAngle + __ThresholdAlarm, __SweepAngle - __ThresholdAlarm);
            Pen penArcMidLimit = new Pen(this.__Warning, this.__InnerStrokeWeight);
            e.Graphics.DrawArc(penArcMidLimit, this.__PositionX + __StrokeWeight / 2 + __InnerStrokeWeight, this.__PositionY + __StrokeWeight / 2 + __InnerStrokeWeight, this.__Width - __StrokeWeight - __InnerStrokeWeight * 2, this.__Height - __StrokeWeight - __InnerStrokeWeight * 2, __StartAngle + __ThresholdWarning, __ThresholdAlarm - __ThresholdWarning);
            Pen penArcLowLimit = new Pen(this.__Normal, this.__InnerStrokeWeight);
            e.Graphics.DrawArc(penArcLowLimit, this.__PositionX + __StrokeWeight / 2 + __InnerStrokeWeight, this.__PositionY + __StrokeWeight / 2 + __InnerStrokeWeight, this.__Width - __StrokeWeight - __InnerStrokeWeight * 2, this.__Height - __StrokeWeight - __InnerStrokeWeight * 2, __StartAngle, __ThresholdWarning);

            // Draw String operations
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(__Value.ToString(), __Font_Value, Brushes.Black, this.__PositionX + this.__Width / 2, this.__PositionY + this.__Height / 2, sf);
            e.Graphics.DrawString(__Unit, __Font_Unit, Brushes.Gray, this.__PositionX + this.__Width / 2, this.__PositionY + this.__Height / 2 + this.__Height / 5, sf);
        }

        private float Map(float Val, float inMin, float inMax, float outMin, float outMax)
        {
            float tResult;

            tResult = (Val - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;

            return tResult;
        }
    }
}
