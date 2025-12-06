using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAccountingSalesOE
{
    public static class LocalizationHelper
    {
        public static void ApplyLocalization(Form form, CultureInfo culture)
        {
            var resources = new ComponentResourceManager(form.GetType());

            Size currentSize = form.Size;

            ApplyResources(form, resources, culture);

            resources.ApplyResources(form, "$this", culture);

            form.Size = currentSize;

            form.Refresh();
        }

        private static void ApplyResources(Control rootControl, ComponentResourceManager resources, CultureInfo culture)
        {
            Stack<Control> stack = new Stack<Control>();
            stack.Push(rootControl);

            while (stack.Count > 0)
            {
                Control current = stack.Pop();
                resources.ApplyResources(current, current.Name, culture);

                if (current is DataGridView dgv)
                {
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        if (!string.IsNullOrEmpty(col.Name)) resources.ApplyResources(col, col.Name, culture);
                    }
                }

                if (current is MenuStrip ms) ApplyResourcesToMenuItems(ms.Items, resources, culture);

                for (int i = current.Controls.Count - 1; i >= 0; i--) stack.Push(current.Controls[i]);
            }
        }

        private static void ApplyResourcesToMenuItems(ToolStripItemCollection items, ComponentResourceManager resources, CultureInfo culture)
        {
            Stack<ToolStripItem> stack = new Stack<ToolStripItem>();

            for (int i = items.Count - 1; i >= 0; i--) stack.Push(items[i]);

            while (stack.Count > 0)
            {
                ToolStripItem item = stack.Pop();
                if (!string.IsNullOrEmpty(item.Name)) resources.ApplyResources(item, item.Name, culture);

                if (item is ToolStripMenuItem menuItem && menuItem.HasDropDownItems)
                {
                    for (int i = menuItem.DropDownItems.Count - 1; i >= 0; i--) stack.Push(menuItem.DropDownItems[i]);
                }
            }
        }
    }
}
