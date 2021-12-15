using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PleasantRustle
{
    public partial class ListItem : UserControl
    {   
        public ListItem()
        {
            InitializeComponent();
        }
        #region Properties
        private string _type;
        private string _nameAgent;
        private string _counSail;
        private string _nomberPhone;
        private string _priority;
        private Image _icon;
        [Category("Costom")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; 
            }
        }
        [Category("Costom")]
        public  string Priority
        {
            get { return _priority; }
            set { _priority = value; Priority1.Text = value; }
        }
        [Category("Costom")]
        public string Type
        {
            get { return _type; }
            set {  _type = value; Type1.Text = value; }
        }
        [Category("Costom")]
        public string NameAgent
        {
            get { return _nameAgent; }
            set { _nameAgent = value; NameAgent1.Text = value; }
        }
        [Category("Costom")]
        public string CountSail
        {
            get { return _counSail; }
            set { _counSail = value; CountSail1.Text = value; }
        }
        [Category("Costom")]
        public string NomebrPhone
        {
            get { return _nomberPhone; }
            set { _nomberPhone = value; NomebrPhone1.Text = value; }
        }
        #endregion
    }
}
