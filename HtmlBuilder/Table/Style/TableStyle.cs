using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder.Style
{
    public class TableStyle
    {
        private bool _isWidthSet;

        private string _width;
        public string Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _isWidthSet = true;
            }
        }

        private bool _isBackgroundColorSet;

        private string _backgroundColor;
        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                _isBackgroundColorSet = true;
            }
        }

        private bool _isBorderSet;

        private string _border;
        public string Border
        {
            get { return _border; }
            set
            {
                _border = value;
                _isBorderSet = true;
            }
        }

        public TableStyle()
        {
        }

        public string SerializeToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("style='");

            if (_isWidthSet)
            {
                stringBuilder.Append($"width:{Width};");
            }
            if (_isBorderSet)
            {
                stringBuilder.Append($"border:{Border};");
            }
            if (_isBackgroundColorSet)
            {
                stringBuilder.Append($"background-color:{BackgroundColor};");
            }

            stringBuilder.Append("'");

            return stringBuilder.ToString();
        }
    }
}
