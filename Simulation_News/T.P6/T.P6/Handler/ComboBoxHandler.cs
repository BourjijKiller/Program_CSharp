﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T.P6.Args;

namespace T.P6
{
    class ComboBoxHandler : ComboBox
    {
        public ComboBoxHandler() : base()
        {

        }
        
        public void ajouterData(Object sender, ArgsCBB e)
        {
            this.Items.Add(e.getObj);
            if (this.Items.Count == 1)
                this.SelectedItem = e.getObj;
        }

        public void supprimerData(Object sender, ArgsCBB e)
        {
            this.Items.Remove(e.getObj);
        }
    }
}
