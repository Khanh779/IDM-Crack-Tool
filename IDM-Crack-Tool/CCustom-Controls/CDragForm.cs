using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDM_Crack_Tool.Custom_Controls
{
    [ToolboxItem(true)]
    public partial class CDragForm : Component
    {

        public CDragForm()
        {
            if(DesignMode|| TargetControl==null|| Form==null)
            {
                return;
            }
        }

        public bool SupportMaximize { get; set; } = false;
        public bool MaximizeFullScreen { get; set; } = false;

        public Form Form { get; set; }
        Point pointOld = new Point();
        bool pressing = false;

        Control targetControl;
        public Control TargetControl
        {
            get { return targetControl; }
            set
            {
                targetControl = value;

                if(DesignMode==false && Form!=null)
                {
                    TargetControl.MouseDoubleClick += (sender, e) =>
                    {
                        if(e.Button== MouseButtons.Left)
                        {
                            if (SupportMaximize)
                            {
                                Form.MaximumSize= MaximizeFullScreen==false? Screen.FromControl(Form).WorkingArea.Size: new Size(0,0);
                                Form.WindowState = Form.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
                            }
                        }    
                    };

                    TargetControl.MouseUp += (sender, e) =>
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            pressing = false;
                        }
                    };

                    TargetControl.MouseDown += (sender, e) =>
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            pointOld = e.Location;
                            pressing = true;
                        }
                    };

                    TargetControl.MouseMove += (sender, e) =>
                    {
                        if (pressing && Form != null)
                        {
                            Point diff = new Point(e.X - pointOld.X, e.Y - pointOld.Y);
                            Form.Location = new Point(Form.Location.X + diff.X, Form.Location.Y + diff.Y);
                        }
                    };
                }    
            }
        }

       
    }
}
