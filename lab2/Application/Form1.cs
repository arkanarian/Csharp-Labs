using System;
using System.Drawing;
using System.Windows.Forms;
using DomainModel;

namespace Laba2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();           
        }

        public void InitializeMenu()
        {
            foreach (Type itm in Program.DomainModel.TypeList)
            {
                cmbFigures.Items.Add(itm.Name);
            }
        }

        // New file
        private void btnNew_Click(object sender, EventArgs e)
        {
            Program.Controller.NewFile();
            cmbFigures.Text = "";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Program.Controller.MouseDown(e.X, e.Y);       
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Program.Controller.MouseUp();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Program.AppModel.CurrentElement != null && Program.AppModel.IsCurrentElementActive)
            {
                EraseSelectedElement();
                Program.Controller.MouseMove(e.X, e.Y);
                DrawWithSelectedElement();
                Program.DomainModel.DrawElements();
            }
            else 
            {
                Program.Controller.MouseMove(e.X, e.Y);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
                Program.Controller.OpenFile(openFileDialog1.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
                Program.Controller.SaveFile(saveFileDialog.FileName);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            Program.DomainModel.DrawElements();
            DrawWithSelectedElement();
        }

        private void DrawWithSelectedElement()
        {
            if (Program.AppModel.CurrentElement != null && Program.AppModel.IsCurrentElementActive)
            {
                Pen pen = new Pen(Program.AppModel.CurrentElement.BorderColor, Program.AppModel.CurrentElement.Width);
                Program.AppModel.CurrentElement.FillColor = Program.AppModel.CurrentFillColor;
                Program.AppModel.CurrentElement.BorderColor = Program.AppModel.CurrentDrawingColor;
                Program.AppModel.CurrentElement.Width = Program.AppModel.CurrentWidth;
                Program.AppModel.CurrentElement.Draw(Program.DomainModel.Graphics, pen);
            }
        }

        private void EraseSelectedElement()
        {
            if (Program.AppModel.CurrentElement != null && Program.AppModel.IsCurrentElementActive)
            {
                Pen pen = new Pen(Color.White, Program.AppModel.CurrentElement.Width);
                Program.AppModel.CurrentElement.IsErased = true;
                Program.AppModel.CurrentElement.Draw(Program.DomainModel.Graphics, pen);
                Program.AppModel.CurrentElement.IsErased = false;
            }
        }

        private void cmbFigures_SelectedValueChanged(object sender, EventArgs e)
        {
            string newElement = cmbFigures.SelectedItem.ToString();
            Program.Controller.CreateNewElement(newElement);
        }

        private void btnDrawFigureCoordinates_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtX1.Text, out var coordX1) || coordX1 <= 0)
            {
                MessageBox.Show("Wrong coordinates x1");
                txtX1.Text = "1";
                return;
            }
            if (!int.TryParse(txtX2.Text, out var coordX2) || coordX2 <= 0)
            {
                MessageBox.Show("Wrong coordinates x2");
                txtX2.Text = "1";
                return;
            }
            if (!int.TryParse(txtY1.Text, out var coordY1) || coordY1 <= 0)
            {
                MessageBox.Show("Wrong coordinates y1");
                txtY1.Text = "1";
                return;
            }
            if (!int.TryParse(txtY2.Text, out var coordY2) || coordY2 <= 0)
            {
                MessageBox.Show("Wrong coordinates y2");
                txtY2.Text = "1";
                return;
            }
            if (cmbFigures.Text == "")
            {
                MessageBox.Show("You should select figure");
                return;
            }
            string newElement = cmbFigures.SelectedItem.ToString();

            Program.Controller.DrawByCoordinates(newElement, coordX1, coordY1, coordX2, coordY2);
        }
        private void undo_Click(object sender, EventArgs e)
        {
            Program.Controller.Undo();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            Program.Controller.Redo();
        }

        private void pnlBorderColorBase_Click(object sender, MouseEventArgs e)
        {
            var panel = sender as Panel;
            string color = panel.BackColor.Name;
            Program.Controller.SetMainColor(color);
            pnlCurrentBorderColor.BackColor = Color.FromName(color);
        }

        private void pnlBackColorBase_Click(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            string backgroudcolor = panel.BackColor.Name;
            Program.Controller.SetFillColor(backgroudcolor);
            pnlCurrentBackColor.BackColor = Color.FromName(backgroudcolor);
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            var txb = sender as TextBox;
            if(!int.TryParse(txb.Text, out var width) || width <= 0)
            {
                MessageBox.Show("Wrong width");
                txb.Text = "1";
            }
            Program.Controller.SetWidth(width);
        }
    }
}
