using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EzDrink
{
    public class DataGridViewDisableButtonCell : DataGridViewButtonCell
    {
        private bool _enabledValue;
        public bool Enabled
        {
            get
            {
                return _enabledValue;
            }
            set
            {
                _enabledValue = value;
            }
        }

        // Override the Clone method so that the Enabled property is copied.
        public override object Clone()
        {
            DataGridViewDisableButtonCell cell =
                (DataGridViewDisableButtonCell)base.Clone();
            cell.Enabled = Enabled;
            return cell;
        }

        // By default, enable the button cell.
        public DataGridViewDisableButtonCell()
        {
            _enabledValue = true;
        }

        //override button appearance
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, 
            int rowIndex, DataGridViewElementStates elementState, object value, 
            object formattedValue, string errorText, DataGridViewCellStyle cellStyle, 
            DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            if (!_enabledValue)
            {
                if ((paintParts & DataGridViewPaintParts.Background) == DataGridViewPaintParts.Background)
                    DrawCellBackground(ref graphics, cellStyle.BackColor, cellBounds);
                if ((paintParts & DataGridViewPaintParts.Border) == DataGridViewPaintParts.Border)
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
                Rectangle buttonArea = cellBounds;
                SetButtonArea(ref buttonArea, ref advancedBorderStyle);
                ButtonRenderer.DrawButton(graphics, buttonArea, PushButtonState.Disabled);
                if (FormattedValue is String)
                    TextRenderer.DrawText(graphics, (string)FormattedValue, DataGridView.Font, buttonArea, SystemColors.GrayText);
            }
            else
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
        }

        //set button area
        private void SetButtonArea(ref Rectangle buttonArea, ref DataGridViewAdvancedBorderStyle advancedBorderStyle)
        {
            Rectangle buttonAdjustment = BorderWidths(advancedBorderStyle);
            buttonArea.X += buttonAdjustment.X;
            buttonArea.Y += buttonAdjustment.Y;
            buttonArea.Height -= buttonAdjustment.Height;
            buttonArea.Width -= buttonAdjustment.Width;
        }

        //draw cell background
        private void DrawCellBackground(ref Graphics graphics, Color backColor, Rectangle cellBounds)
        {
            SolidBrush cellBackground = new SolidBrush(backColor);
            graphics.FillRectangle(cellBackground, cellBounds);
            cellBackground.Dispose();
        }
    }
}
