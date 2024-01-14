using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProiectFloreaLicenta
{
    public class Instructiune
    {
        public String tipInstructine { get; set; }
        public int pcCurent { get; set; }   
        public int target { get; set; }   

        public Instructiune(string tipInstructiune, int pcCurent, int target)
        {
            this.tipInstructine = tipInstructiune;
            this.pcCurent = pcCurent;
            this.target = target;
        }
    }
}
