using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Forms.Interfaces {
    public interface IInfoDialog {
        string Title { get; set; }
        string Information { get; set; }
        void ShowDialog();
        void Show();
    }
}
