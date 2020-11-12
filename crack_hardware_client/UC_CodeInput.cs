using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public partial class UC_CodeInput : UserControl
{
    public UC_CodeInput()
    {
        InitializeComponent();
    }

    private void tbx_Key_Enter(object sender, EventArgs e)
    {
        TextBox textBox = sender as TextBox;
        textBox.SelectAll();

    }

    private void tbx_Key_MouseUp(object sender, MouseEventArgs e)
    {
        TextBox textBox = sender as TextBox;
        textBox.SelectAll();
    }

    internal void SetFocus()
    {
        tbx_Key1.Focus();
    }

    internal void Clear()
    {
        for (int n = 1; n <= 18; n++) {
            Control[] tbx_Key_List = this.Controls.Find("tbx_Key" + n, false);
            if (tbx_Key_List.Length > 0) {
                TextBox textBox = tbx_Key_List[0] as TextBox;
                textBox.Clear();
            }
        }
    }

    private void tbx_Key_KeyUp(object sender, KeyEventArgs e)
    {
        TextBox textBox = sender as TextBox;

    }

    private void tbx_Key_KeyDown(object sender, KeyEventArgs e)
    {

    }

    private void tbx_Key_KeyPress(object sender, KeyPressEventArgs e)
    {
        TextBox textBox = sender as TextBox;
        if (e.KeyChar == (char)Keys.Back)
        {
            this.SelectNextControl(this.ActiveControl, false, true, false, true);
        }
        else
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            this.SelectNextControl(this.ActiveControl, true, true, false, true);
        }
    }
}