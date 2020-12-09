using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LSRVersionManager
{
    public partial class EnumEditor : CheckedListBoxDisabledItems
    {
        public EnumEditor()
        {
            InitializeComponent();
            ItemCheck += EnumEditor_ItemCheck;
        }

        private object _value;
        public object Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Value");
                if (!value.GetType().IsEnum)
                    throw new ArgumentNullException("Value should be enumerable.");
                if (value.GetType().GetCustomAttributes(typeof(FlagsAttribute), false).Length == 0)
                    throw new ArgumentNullException("Value must be marked with [Flags].");
                _value = value;
                Rebuild();
            }
        }

        public event EventHandler<EnumValueChangeEventArgs> ValueChanged;

        protected virtual void OnValueChanged(object value)
        {
            ValueChanged?.Invoke(this, new EnumValueChangeEventArgs { Value = value });
        }

        private void Rebuild()
        {
            Items.Clear();
            if (_value != null)
            {
                foreach (object value in Enum.GetValues(_value.GetType()))
                {
                    if ((int)value == 0) continue;
                    Items.Add(value, ((int)_value & (int)value) != 0);
                }
            }
        }

        void EnumEditor_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ulong bits = Convert.ToUInt64(_value);
            ulong bit = Convert.ToUInt64(Items[e.Index]);
            if (e.NewValue == CheckState.Checked)
                bits = bits | bit;
            else
                bits = bits & ~bit;
            _value = Enum.ToObject(_value.GetType(), bits);
            OnValueChanged(_value);
        }
    }

    public class EnumValueChangeEventArgs : EventArgs
    {
        public object Value
        {
            get;
            set;
        }
    }

    public class CheckedListBoxDisabledItems : CheckedListBox
    {
        private List<string> _disabledItems = new List<string>();
        private List<int> _disabledIndexes = new List<int>();

        public void Disable(string item)
        {
            _disabledItems.Add(item);
            this.Refresh();
        }

        public void Disable(int index)
        {
            _disabledIndexes.Add(index);
            this.Refresh();
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            string s = Items[e.Index].ToString();

            if (_disabledItems.Contains(s) || _disabledIndexes.Contains(e.Index))
            {
                System.Windows.Forms.VisualStyles.CheckBoxState state = System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedDisabled;
                Size glyphSize = CheckBoxRenderer.GetGlyphSize(e.Graphics, state);
                CheckBoxRenderer.DrawCheckBox(
                    e.Graphics,
                    new Point(e.Bounds.X + 1, e.Bounds.Y + 1), // add one pixel to align the check gliph properly
                    new Rectangle(
                        new Point(e.Bounds.X + glyphSize.Width + 3, e.Bounds.Y), // add three pixels to align text properly
                        new Size(e.Bounds.Width - glyphSize.Width, e.Bounds.Height)
                    ),
                    s,
                    this.Font,
                    TextFormatFlags.Left, // text is centered by default
                    false,
                    state
                );
            }
            else
            {
                base.OnDrawItem(e);
            }
        }

        public void ClearDisabledItems()
        {
            _disabledIndexes.Clear();
            _disabledItems.Clear();
            this.Refresh();
        }
    }
}
