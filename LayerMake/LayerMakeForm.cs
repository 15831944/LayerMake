//-----------------------------------------------------------------------
// <copyright file="LayerMakeForm.cs" company="Goldsmith Engineering">
//     Copyright (c) Goldsmith Engineering. All rights reserved.
// </copyright>
// <author>Winston Goldsmith</author>
//-----------------------------------------------------------------------

namespace LayerMake
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml;
    using Autodesk.AutoCAD.ApplicationServices;
    using Autodesk.AutoCAD.DatabaseServices;
    using Autodesk.AutoCAD.EditorInput;
    using Autodesk.AutoCAD.Windows;
    using More;

    /// <summary>
    /// Initializes form that allows the user to create new layers in AutoCAD
    /// </summary>
    public partial class LayerMakeForm : Form
    {
        /// <summary>
        /// The path to the location of the xml file with the segments of layer names
        /// </summary>
        private string path = @"c:\users\wgoldsmith\documents\visual studio 2015\projects\layermake\layermake\layermake.xml";
// take out path if call is changed to take the path as an argument

        /// <summary>
        /// A child form that is used to show ListBoxes in a larger window
        /// </summary>
        private MoreForm textForm;

        /// <summary>
        /// 2 character segment to be put in the Data State spot in the layer text box
        /// </summary>
        private string dataStateSeg;

        /// <summary>
        /// 3 character segment to be put in the Category spot in the layer text box
        /// </summary>
        private string categorySeg;

        /// <summary>
        /// 3 character segment to be put in the Entity Type spot in the layer text box
        /// </summary>
        private string entityTypeSeg;

        /// <summary>
        /// 3 character segment to be put as the beginning of the Entity Description spot in the layer text box
        /// </summary>
        private string entityDescSeg1;

        /// <summary>
        /// 3 character segment to be put as the middle of the Entity Description spot in the layer text box
        /// </summary>
        private string entityDescSeg2;

        /// <summary>
        /// 4 character segment to be put as the end of the Entity Description spot in the layer text box
        /// </summary>
        private string entityDescSeg3;

        /// <summary>
        /// List of Layer objects that have all the information for the AutoCAD layers to be created.
        /// the key is a string that will be the layer name
        /// </summary>
        private Dictionary<string, Layer> layerList = new Dictionary<string, Layer>();

        /// <summary>
        /// Initializes a new instance of the LayerMakeForm class. Auto generated constructor for LayerMakeForm
        /// </summary>
        public LayerMakeForm()
        {
            this.InitializeComponent();
        }

        ////        public LayerMakeForm(string p)
        ////        {
        ////            this.path = @p; // @ makes the string literal so that slashes in path will not be escaped
        ////            this.InitializeComponent();
        ////        }

        /// <summary>
        /// Reads layermake.xml and adds all the seg elements into the 4 list boxes
        /// </summary>
        private void ReadXML()
        {
            using (XmlReader reader = XmlReader.Create(this.path))
            {
                while (reader.Read())
                {
                    // if Node Type is...
                    switch (reader.NodeType)
                    {
                        // ...equal to type Element
                        case XmlNodeType.Element:

                            if (reader.Name.Equals("dsseg"))
                            {
                                this.dataStateListBox.Items.Add(reader.ReadElementContentAsString());
                            }
                            else if (reader.Name.Equals("cseg"))
                            {
                                this.categoryListBox.Items.Add(reader.ReadElementContentAsString());
                            }
                            else if (reader.Name.Equals("etseg"))
                            {
                                this.entityTypeListBox.Items.Add(reader.ReadElementContentAsString());
                            }
                            else if (reader.Name.Equals("edseg"))
                            {
                                this.entityDescListBox.Items.Add(reader.ReadElementContentAsString());
                            }

                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Calls all segment update methods
        /// </summary>
        private void updateAllSegs()
        {
            this.updateDataSeg();
            this.updateCatSeg();
            this.updateEntTypeSeg();
            this.updateEntDescSeg();
        }

        /// <summary>
        /// Fills out the layer text box with all the individual segments
        /// </summary>
        private void updateTextBox()
        {
            this.layerTextBox.Text = this.dataStateSeg + this.categorySeg + this.entityTypeSeg + this.entityDescSeg1 + this.entityDescSeg2 + this.entityDescSeg3;
        }

        /// <summary>
        /// Sets dataStateSeg to be the first 2 characters in the layer text box
        /// </summary>
        private void updateDataSeg()
        {
            this.dataStateSeg = this.layerTextBox.Text.Substring(0, 2);
        }

        /// <summary>
        /// Sets categorySeg to be the 3 characters starting at the 3rd character(index 2) in the layer text box
        /// </summary>
        private void updateCatSeg()
        {
            this.categorySeg = this.layerTextBox.Text.Substring(2, 3);
        }

        /// <summary>
        /// Sets entityTypeSeg to be the 3 characters starting at the 6th character(index 5) in the layer text box
        /// </summary>
        private void updateEntTypeSeg()
        {
            this.entityTypeSeg = this.layerTextBox.Text.Substring(5, 2);
        }

        /// <summary>
        /// Sets entityDescSeg1 to be the 3 characters starting at the 8th character(index 7) in the layer text box
        /// Sets entityDescSeg2 to be the 3 characters starting at the 11th character(index 10) in the layer text box
        /// Sets entityDescSeg3 to be the 4 characters starting at the 14th character(index 13) in the layer text box
        /// </summary>
        private void updateEntDescSeg()
        {
            this.entityDescSeg1 = this.layerTextBox.Text.Substring(7, 3);
            this.entityDescSeg2 = this.layerTextBox.Text.Substring(10, 3);
            this.entityDescSeg3 = this.layerTextBox.Text.Substring(13, 4);
        }

        /// <summary>
        /// When the selected item in dataStateListBox is changed, 
        /// change the Data State segment of the layer name (before the first '-')
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void dataStateListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.addZs();
            //// this.layerTextBox.Text = this.dataStateListBox.SelectedItem.ToString().Split('\t')[0] + "-" + this.layerTextBox.Text.Substring(2);

            this.dataStateSeg = this.dataStateListBox.SelectedItem.ToString().Split('\t')[0] + "-"; // gets the segment of text before the tab in the selected item
            this.updateTextBox();
        }

        /// <summary>
        /// When the selected item in categoryListBox is changed, 
        /// change the Category segment of the layer name (between the first '-' and second '-')
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.addZs();
            //// this.layerTextBox.Text = this.layerTextBox.Text.Substring(0, 2) + this.categoryListBox.SelectedItem.ToString().Split('\t')[0] + "-" + this.layerTextBox.Text.Substring(5);

            this.categorySeg = this.categoryListBox.SelectedItem.ToString().Split('\t')[0] + "-"; // gets the segment of text before the tab in the selected item
            this.updateTextBox();
        }

        /// <summary>
        /// When the selected item in entityTypeListBox is changed, 
        /// change the Entity Type segment of the layer name (between the second '-' and third '-')
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void entityTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.addZs();
            //// this.layerTextBox.Text = this.layerTextBox.Text.Substring(0, 5) + this.entityTypeListBox.SelectedItem.ToString().Split('\t')[0] + "-" + this.layerTextBox.Text.Substring(7);

            this.entityTypeSeg = this.entityTypeListBox.SelectedItem.ToString().Split('\t')[0] + "-"; // gets the segment of text before the tab in the selected item
            this.updateTextBox();
        }

        /// <summary>
        /// Adds trailing Zs if the length is less than 17 characters long
        /// </summary>
        private void addZs()
        {
            while (this.layerTextBox.Text.Length < 17)
            {
                this.layerTextBox.Text += "Z";
            }
        }

        /// <summary>
        /// When the selected item in entityDescListBox is changed, 
        /// change the Entity Description segment of the layer name (after the last "-")
        /// then update layerTextBox
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void entityDescListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check radio buttons
            //     if button1 checked
            //         fill 1st 3 chars
            //     if button2 checked
            //         fill 2nd 3 chars
            //     else // button3 checked
            //         fill last 4 chars
            string ent = this.entityDescListBox.SelectedItem.ToString().Split('\t')[0]; // get all characters before the tab in the selected item in the entity descriptor box
            ent = ent.Trim(); // trim extra white space. just in case there were spaces before tab

            // add trailing Zs to fill out each section of the entity descriptor
            while (ent.Length < 4)
            {
                ent += "Z";
            }

            this.addZs();

            if (this.radioButton1.Checked)
            {
                ////                = first 3 chars of selected line in entDescListBox
                this.entityDescSeg1 = ent.Substring(0, 3);
            }
            else if (this.radioButton2.Checked)
            {
                ////                = first 3 chars of selected line in entDescListBox
                this.entityDescSeg2 = ent.Substring(0, 3);
            }
            else
            { // radioButton3.checked
                ////                = first 3 chars of selected line in entDescListBox + 1 trailing Z
                this.entityDescSeg3 = ent;
            }

            this.updateTextBox();
        }

        /// <summary>
        /// When the form is loaded, fill list boxes and the layer name text box
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void LayerMakeForm_Load(object sender, EventArgs e)
        {
            // clear out preset values in list boxes
            this.dataStateListBox.Items.Clear();
            this.categoryListBox.Items.Clear();
            this.entityTypeListBox.Items.Clear();
            this.entityDescListBox.Items.Clear();

            this.entityDescSeg2 = "ZZZ";
            this.entityDescSeg3 = "ZZZZ";

            // read in all the layer name segments to be put in the list boxes from an xml file
            this.ReadXML();

            // if the list boxes are not empty, select the first item
            if (this.dataStateListBox.Items.Count > 0)
            {
                this.dataStateListBox.SelectedIndex = 0;
            }

            if (this.categoryListBox.Items.Count > 0)
            {
                this.categoryListBox.SelectedIndex = 0;
            }

            if (this.entityTypeListBox.Items.Count > 0)
            {
                this.entityTypeListBox.SelectedIndex = 0;
            }

            if (this.entityDescListBox.Items.Count > 0)
            {
                this.entityDescListBox.SelectedIndex = 0;
            }

            ////this.layerTextBox.Text = this.layerTextBox.Text.Substring(0, 7) + "ZZZZZZZZZZ";
        }

        /// <summary>
        /// When user clicks Make button, add the contents of the layer name text box into the layersListBox and create it in AutoCAD
        /// if it isn't already in layersListBox or AutoCAD
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void makeButton_Click(object sender, EventArgs e)
        {
            // checked length.
            // if less than 10, add Zs
            // if more, cut off at 10
            this.addZs();

            if (this.layerTextBox.Text.Length > 17)
            {
                this.layerTextBox.Text = this.layerTextBox.Text.Substring(0, 17);
            }

            // start: make sure layer name does not already exist in AutoCAD
            Document acDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database acCurDb = acDoc.Database;

            using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
            {
                // Returns the layer table for the current database
                LayerTable acLayerTable = acTrans.GetObject(acCurDb.LayerTableId, OpenMode.ForRead) as LayerTable;

                // if the layer name to be added could not be found in autoCAD
                if (acLayerTable.Has(layerTextBox.Text) != true)
                {
                    // search layersListBox to see if there is already an identical one.
                    if (this.Unique())
                    {
                        this.layersListBox.Items.Add(this.layerTextBox.Text);

                        // add new Layer to layerList
                        this.layerList.Add(this.layerTextBox.Text, new Layer(this.layerTextBox.Text));
                    }        
                }

                // layer name was found
                else
                {
                    MessageBox.Show("Layer already exists.");
                }
            }

            // end     
        }

        /// <summary>
        /// checks that the text in layer textBox is different from all the items in layersListBox
        /// </summary>
        /// <returns>true if the text box text is not found in the list box. false if it is found</returns>
        private bool Unique()
        {
            bool isUnique = true;

            // loop through all items in layers list box
            for (int w = 0; w < this.layersListBox.Items.Count; w++)
            {
                // if current item in list box equals text in text box,
                // set isUnique to false and break out of loop
                if (this.layersListBox.Items[w].Equals(this.layerTextBox.Text))
                {
                    isUnique = false;
                    break;
                }
            }

            return isUnique;
        }

        /// <summary>
        /// When an item in layers list box is selected, enable delete, color, and ltype buttons
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void layersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // checks if something is actually selected. if not, index will be -1
            if (this.layersListBox.SelectedIndex >= 0)
            {
                this.enableButtons();
            }
        }

        /// <summary>
        /// Allows Delete, Color, and LType buttons to be clicked
        /// </summary>
        private void enableButtons()
        {
            if (!this.deleteButton.Enabled)
            {
                this.deleteButton.Enabled = true;
            }

            if (!this.colorButton.Enabled)
            {
                this.colorButton.Enabled = true;
            }

            if (!this.ltypeButton.Enabled)
            {
                this.ltypeButton.Enabled = true;
            }
        }

        /// <summary>
        /// Disables Delete, Color, and LType buttons from being clicked
        /// </summary>
        private void disableButtons()
        {
            if (this.deleteButton.Enabled)
            {
                this.deleteButton.Enabled = false;
            }

            if (this.colorButton.Enabled)
            {
                this.colorButton.Enabled = false;
            }

            if (this.ltypeButton.Enabled)
            {
                this.ltypeButton.Enabled = false;
            }
        }

        /// <summary>
        /// When user clicks delete button, delete selected layer in layersListBox
        /// and from autoCAD drawing
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Remove layer from layerList
            this.layerList.Remove(this.layersListBox.SelectedItem.ToString());

            // get current index so that, when the selected item is deleted, the item that takes its place will be selected.
            int index = this.layersListBox.SelectedIndex;
            this.layersListBox.Items.RemoveAt(this.layersListBox.SelectedIndex);

            // if the deleted item was not the last in the list, select item that replaces deleted item
            if (index < this.layersListBox.Items.Count)
            {
                this.layersListBox.SelectedIndex = index;
            }
            else
            { // deleted item was last in the list
                this.disableButtons(); // don't select anything and disable buttons
            }
        }

        /// <summary>
        /// When user clicks color button, call SelectColor() to open the AutoCAD layer color selector
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void colorButton_Click(object sender, EventArgs e)
        {
            this.SelectColor();
        }

        /// <summary>
        /// Opens an AutoCAD color dialog box to let the user choose a color for the currently selected layer
        /// </summary>
        private void SelectColor()
        {
            Autodesk.AutoCAD.Windows.ColorDialog dlg = new Autodesk.AutoCAD.Windows.ColorDialog();

            // if Cancel is clicked instead of OK
            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                // set selected color to White
                dlg.Color = Autodesk.AutoCAD.Colors.Color.FromRgb(255, 255, 255);
            }

            // set color in selected Layer in layerList
            ////         layerList[the selected layer name]                    (  Red value of the selected color,     Green value of selected color, Blue value of selected color     )
            this.layerList[this.layersListBox.SelectedItem.ToString()].SetColor(dlg.Color.ColorValue.R.ToString(), dlg.Color.ColorValue.G.ToString(), dlg.Color.ColorValue.B.ToString());
        }

        /// <summary>
        /// When user clicks L-Type button, call SelectLine() to open the AutoCAD line type selector
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void ltypeButton_Click(object sender, EventArgs e)
        {
            this.SelectLine();
        }

        /// <summary>
        /// Opens an AutoCAD linetype dialog box to let the user choose a linetype for the currently selected layer
        /// </summary>
        private void SelectLine()
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;

            Database db = doc.Database;

            Editor ed = doc.Editor;

            // default setting for linetype, in case one is not selected
            string lineName = "Continuous";

            LinetypeDialog ltd = new LinetypeDialog();

            // using will close connection when finished. Causes problems otherwise
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                LinetypeTable lt = (LinetypeTable)tr.GetObject(db.LinetypeTableId, OpenMode.ForRead);

                DialogResult dr = ltd.ShowDialog();

                // if OK is clicked on linetype dialog box
                if (dr == DialogResult.OK)
                {
                    LinetypeTableRecord symbol = (LinetypeTableRecord)tr.GetObject(ltd.Linetype, OpenMode.ForRead);

                    // if user does not select ByLayer or ByBlock as linetype, set lineName to their selection
                    // otherwise, leave it as Continuous
                    if (!symbol.Name.Equals("ByLayer") && !symbol.Name.Equals("ByBlock"))
                    {
                        lineName = symbol.Name;
                    }
                }
            }

            // set line in selected Layer in layerList
            ////    layerList[the selected layer name]
            this.layerList[this.layersListBox.SelectedItem.ToString()].SetLine(lineName);

            // brings form back to the front
            this.Activate();
        }

        /// <summary>
        /// When user clicks More button above the category list box, open a new form to show the category options in a larger window
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void moreCatButton_Click(object sender, EventArgs e)
        {
            this.textForm = new MoreForm(this.categoryListBox);
            this.textForm.ShowDialog(this); // disables LayerMakeForm while MoreForm is active
        }

        /// <summary>
        /// When user clicks More button above the entity descriptor list box, open a new form to show the entity descriptor options in a larger window
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void moreEntButton_Click(object sender, EventArgs e)
        {
            this.textForm = new MoreForm(this.entityDescListBox);
            this.textForm.ShowDialog(this); // disables LayerMakeForm while MoreForm is active
        }

        /// <summary>
        /// When user focus leaves the layer text box, set values for layer name segments
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void layerTextBox_Leave(object sender, EventArgs e)
        {
            this.addZs();
            this.layerTextBox.Text = this.layerTextBox.Text.ToUpper(); // make all text in textbox upper case
            this.updateAllSegs();
        }

        /// <summary>
        /// When user clicks cancel button, close the form without creating any layers.
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When user clicks ok button, create .
        /// </summary>
        /// <param name="sender">Auto generated sender object by Visual Studio.</param>
        /// <param name="e">Auto generated EventArgs by Visual Studio.</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();

            // Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor; 
            Autodesk.AutoCAD.ApplicationServices.Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;

            foreach (KeyValuePair<string, Layer> currLayer in this.layerList)
            {
                ////                 layer command, Make,     Layer Name          ,Color,TrueColor, Red value of current layer, Green value of curr layer    , Blue value of curr layer, Enter, LineType, Line Type of curr layer, Enter, Enter
                //ed.Command(new Object[] { "-LAYER", "M", currLayer.Value.GetName(), "C", "T", currLayer.Value.GetRed() + "," + currLayer.Value.GetGreen() + "," + currLayer.Value.GetBlue(), "", "L", currLayer.Value.GetLine(), "", "" });

                doc.SendStringToExecute("-LAYER M " + currLayer.Value.GetName() + "\n", true, false, false);
                doc.SendStringToExecute("C T " + currLayer.Value.GetRed() + "," + currLayer.Value.GetGreen() + "," + currLayer.Value.GetBlue() + "\n\n", true, false, false);
                doc.SendStringToExecute("L " + currLayer.Value.GetLine() + "\n\n\n", true, false, false);
            }
        }
    }
}
