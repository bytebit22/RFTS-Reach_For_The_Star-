using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFTS_Reach_For_The_Star_
{
    public partial class Form1 : Form
    {
        public 
            
            Form1()
        {
            InitializeComponent();
            axKHOpenAPI1.CommConnect();
        }
    }
}