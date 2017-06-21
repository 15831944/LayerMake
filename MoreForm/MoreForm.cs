using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreForm
{
    public partial class MoreForm : Form
    {
        /// <summary>
        /// A listBox that will be passed in from LayerMakeForm
        /// </summary>
        private ListBox lmListBox;

        /// <summary>
        /// Initializes a new instance of the MoreForm class. Auto generated constructor for MoreForm
        /// </summary>
        public MoreForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the MoreForm class, then sets lmListBox to be able to change the passed in listBox on the original form,
        /// and copy the contents of the listBox to the one on this form.
        /// </summary>
        /// /// <param name="lBox">A listBox from the form that calls this one.</param>
        public MoreForm(ListBox lBox)
        {
            InitializeComponent();
            this.lmListBox = lBox;
            listBox1.Items.AddRange(lBox.Items);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0) // if something is selected
                lmListBox.SelectedItem = listBox1.SelectedItem;
            this.Close();
        } 
    }
}
