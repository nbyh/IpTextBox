using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpTextBox
{
    [ToolboxBitmap(typeof(TextBox))]
    public partial class IpAddressTextBox : UserControl
    {
        public IpAddressTextBox()
        {
            InitializeComponent();
        }

        /** Sets and Gets the tooltiptext on toolTip1 */
        /// <summary>
        /// Gets or sets the tool tip text.
        /// </summary>
        /// <value>
        /// The tool tip text.
        /// </value>
        public string ToolTipText
        {
            get
            { return this.toolTip1.GetToolTip(Box1); }
            set
            {
                this.toolTip1.SetToolTip(Box1, value);
                this.toolTip1.SetToolTip(Box2, value);
                this.toolTip1.SetToolTip(Box3, value);
                this.toolTip1.SetToolTip(Box4, value);
                this.toolTip1.SetToolTip(label1, value);
                this.toolTip1.SetToolTip(label2, value);
                this.toolTip1.SetToolTip(label3, value);
            }
        }

        /** Set or Get the string that represents the value in the box */
        /// <summary>
        /// </summary>
        /// <returns>与该控件关联的文本。</returns>
        public override string Text
        {
            get
            {
                return Box1.Text + "." + Box2.Text + "." + Box3.Text + "." + Box4.Text;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string[] pieces = value.Split(".".ToCharArray(), 4);
                    Box1.Text = pieces[0];
                    Box2.Text = pieces[1];
                    Box3.Text = pieces[2];
                    Box4.Text = pieces[3];
                }
                else
                {
                    Box1.Text = "";
                    Box2.Text = "";
                    Box3.Text = "";
                    Box4.Text = "";
                }
            }
        }

        /// <summary>
        /// Determines whether this instance is valid.
        /// </summary>
        /// <returns>
        ///   <see langword="true" /> if this instance is valid; otherwise, <see langword="false" />.
        /// </returns>
        public bool IsValid()
        {
            try
            {
                int checkval = int.Parse(Box1.Text);
                if (checkval < 0 || checkval > 255)
                    return false;
                checkval = int.Parse(Box2.Text);
                if (checkval < 0 || checkval > 255)
                    return false;
                checkval = int.Parse(Box3.Text);
                if (checkval < 0 || checkval > 255)
                    return false;
                checkval = int.Parse(Box4.Text);
                return checkval >= 0 && checkval <= 255;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified in string is valid.
        /// </summary>
        /// <param name="inString">The in string.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>
        ///   <see langword="true" /> if the specified in string is valid; otherwise, <see langword="false" />.
        /// </returns>
        ///if not hide_events
        ///Checks that a string passed in resolves to an integer value between 0 and 255
        ///param inString The string passed in for testing
        ///return True if the string is between 0 and 255 inclusively, false otherwise
        ///endif
        private bool IsValid(string inString, int x, int y)
        {
            try
            {
                int theValue = int.Parse(inString);
                if (theValue >= x && theValue <= y) return true;
                MessageBox.Show("输入值必须介于 0 与" + y + "之间", "超出可输入范围");
                return false;
            }
            catch
            {
                return false;
            }
        }

        /// \ifnot hide_events
        /// Performs KeyPress analysis and handling to ensure a valid ip octet is
        /// being entered in Box1.
        /// \endif
        private void Box1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Only Accept a '.', a numeral, or backspace
            if (e.KeyChar.ToString() == "." || Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                //If the key pressed is a '.'
                if (e.KeyChar.ToString() == ".")
                {
                    //If the Text is a valid ip octet move to the next box
                    if (Box1.Text != "" && Box1.Text.Length != Box1.SelectionLength)
                    {
                        if (IsValid(Box1.Text, 0, 255))
                            Box2.Focus();
                        else
                            Box1.SelectAll();
                    }
                    e.Handled = true;
                }

                //If we are not overwriting the whole text
                else if (Box1.SelectionLength != Box1.Text.Length)
                {
                    //Check that the new Text value will be a valid
                    // ip octet then move on to next box
                    if (Box1.Text.Length == 2)
                    {
                        if (e.KeyChar == 8)
                            Box1.Text.Remove(Box1.Text.Length - 1, 1);
                        else if (!IsValid(Box1.Text + e.KeyChar.ToString(), 0, 255))
                        {
                            Box1.SelectAll();
                            e.Handled = true;
                        }
                        else
                        {
                            Box2.Focus();
                        }
                    }
                }
            }
            //Do nothing if the keypress is not numeral, backspace, or '.'
            else
                e.Handled = true;
        }

        /// \ifnot hide_events
        /// Performs KeyPress analysis and handling to ensure a valid ip octet is
        /// being entered in Box2.
        /// \endif
        private void Box2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Similar to Box1_KeyPress but in special case for backspace moves cursor
            //to the previouse box (Box1)
            if (e.KeyChar.ToString() == "." || Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (e.KeyChar.ToString() == ".")
                {
                    if (Box2.Text != "" && Box2.Text.Length != Box2.SelectionLength)
                    {
                        if (IsValid(Box2.Text, 0, 255))
                            Box3.Focus();
                        else
                            Box2.SelectAll();
                    }
                    e.Handled = true;
                }
                else if (Box2.SelectionLength != Box2.Text.Length)
                {
                    if (Box2.Text.Length == 2)
                    {
                        if (e.KeyChar == 8)
                        {
                            Box2.Text.Remove(Box2.Text.Length - 1, 1);
                        }
                        else if (!IsValid(Box2.Text + e.KeyChar.ToString(), 0, 255))
                        {
                            Box2.SelectAll();
                            e.Handled = true;
                        }
                        else
                        {
                            Box3.Focus();
                        }
                    }
                }
                else if (Box2.Text.Length == 0 && e.KeyChar == 8)
                {
                    Box1.Focus();
                    Box1.SelectionStart = Box1.Text.Length;
                }
            }
            else
                e.Handled = true;

        }

        /// \ifnot hide_events
        /// Performs KeyPress analysis and handling to ensure a valid ip octet is
        /// being entered in Box3.
        /// \endif
        private void Box3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Identical to Box2_KeyPress except that previous box is Box2 and
            //next box is Box3
            if (e.KeyChar.ToString() == "." || Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (e.KeyChar.ToString() == ".")
                {
                    if (Box3.Text != "" && Box3.SelectionLength != Box3.Text.Length)
                    {
                        if (IsValid(Box3.Text, 0, 255))
                            Box4.Focus();
                        else
                            Box3.SelectAll();
                    }
                    e.Handled = true;
                }
                else if (Box3.SelectionLength != Box3.Text.Length)
                {
                    if (Box3.Text.Length == 2)
                    {
                        if (e.KeyChar == 8)
                        {
                            Box3.Text.Remove(Box3.Text.Length - 1, 1);
                        }
                        else if (!IsValid(Box3.Text + e.KeyChar.ToString(), 0, 255))
                        {
                            Box3.SelectAll();
                            e.Handled = true;
                        }
                        else
                        {
                            Box4.Focus();
                        }
                    }
                }
                else if (Box3.Text.Length == 0 && e.KeyChar == 8)
                {
                    Box2.Focus();
                    Box2.SelectionStart = Box2.Text.Length;
                }
            }
            else
                e.Handled = true;
        }

        /// \ifnot hide_events
        /// Performs KeyPress analysis and handling to ensure a valid ip octet is
        /// being entered in Box4.
        /// \endif
        private void Box4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Similar to Box3 but ignores the '.' character and does not advance
            //to the next box.  Also Box3 is previous box for backspace case.
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (Box4.SelectionLength != Box4.Text.Length)
                {
                    if (Box4.Text.Length == 2)
                    {
                        if (e.KeyChar == 8)
                        {
                            Box4.Text.Remove(Box4.Text.Length - 1, 1);
                        }
                        else if (!IsValid(Box4.Text + e.KeyChar.ToString(), 0, 255))
                        {
                            Box4.SelectAll();
                            e.Handled = true;
                        }
                    }
                }
                else if (Box4.Text.Length == 0 && e.KeyChar == 8)
                {
                    Box3.Focus();
                    Box3.SelectionStart = Box3.Text.Length;
                }
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the Enter event of the Box control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// \ifnot hide_events
        /// Performs KeyPress analysis and handling to ensure a valid ip octet is
        /// being entered in Box4.
        /// \endif
        /// \ifnot hide_events
        /// Selects All text in a box for overwriting upon entering the box
        /// \endif
        private void Box_Enter(object sender, System.EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
        }

        /// <summary>
        /// Handles the EnabledChanged event of the label control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// \ifnot hide_events
        /// Ensures a consistent "grayed out" look when the control is disabled
        /// \endif
        private void label_EnabledChanged(object sender, System.EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Enabled)
                lbl.BackColor = SystemColors.Window;
            else
                lbl.BackColor = SystemColors.Control;
        }

        /// <summary>
        /// Handles the EnabledChanged event of the panel1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// \ifnot hide_events
        /// Ensures a consistent "grayed out" look when the control is disabled
        /// \endif
        private void panel1_EnabledChanged(object sender, System.EventArgs e)
        {
            Panel pan = (Panel)sender;
            if (pan.Enabled)
                pan.BackColor = SystemColors.Window;
            else
                pan.BackColor = SystemColors.Control;
        }
    }
}
