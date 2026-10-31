using System.Collections.Generic;
using System.Windows.Forms;
using ClassManager.Models;

namespace ClassManager.Views
{
    public interface ILopView
    {
        string MaLop { get; set; }
        string TenLop { get; set; }
        string SearchKeyword { get; set; }

        void DisplayLopList(List<Lop> list);
        void ShowMessage(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
        bool ConfirmAction(string message, string caption);
        void ClearInput();
        void SetMaLopEnabled(bool enabled);
        void FocusMaLop();
        void FocusTenLop();
    }
}