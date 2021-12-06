using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_MA_Converter
{
    class Forms
    {
        public static Home home = new Home()
        {
            TopLevel = false,
            TopMost = true,
            Dock = System.Windows.Forms.DockStyle.Fill
        };

        
        public static Add add = new Add()
        {
            TopLevel = false,
            TopMost = true,
            Dock = System.Windows.Forms.DockStyle.Fill
        };

        public static Show show = new Show()
        {
            TopLevel = false,
            TopMost = true,
            Dock = System.Windows.Forms.DockStyle.Fill
        };
    }
}
