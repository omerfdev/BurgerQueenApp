﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerQueenApp
{
    public class FormClear
    {
        public static void Clear(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is ComboBox) { ((ComboBox)item).SelectedIndex = -1; }
                else if (item is GroupBox)
                {
                    GroupBox g = (GroupBox)item;
                    foreach (RadioButton cntrl in g.Controls)
                    {
                        if (cntrl is RadioButton) { cntrl.Checked = false; }

                    }

                }

            }

        }


    }
}
