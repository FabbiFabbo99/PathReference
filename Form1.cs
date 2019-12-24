using Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Path_Reference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _Log = new Log();
            //_Paths = new XMLPaths();

            if (!File.Exists("Path.txt")) File.Create("Path.txt").Close();
            list_PathContainer.Items.AddRange(File.ReadAllLines("Path.txt"));
            _TheTimeToSaveHasComeMotherfucker.Start();

        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MaximizeFromItemBar();
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            foreach (var line in tbox_Path.Lines)
            {
                AddToList(line);
                RewriteUpdatedFile();
            }
        }
        private void bt_Remove_Click(object sender, EventArgs e)
        {
            foreach (string line in this.tbox_Path.Lines)
            {
                if (!this.list_PathContainer.Items.Contains(line))
                {
                    AutoClosingMessageBox.Show($"{line} Not in list", "alert", 1000);
                    MinimizeToItemBar();
                    MaximizeFromItemBar();
                }
                else
                {
                    this.list_PathContainer.Items.Remove(line);
                    //  handled by timer, to find a better solution
                    RewriteUpdatedFile();
                }
            }
        }
        private void box_ItemBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (list_PathContainer.SelectedItem != null)
                    Process.Start(this.list_PathContainer.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Porkadyo il path {list_PathContainer.SelectedItem.ToString()} non esiste");
                MinimizeToItemBar();
                MaximizeFromItemBar();
            }
        }
        private void box_ItemBox_Click(object sender, EventArgs e)
        {
            tbox_Path.Text = (string)list_PathContainer.SelectedItem;
        }
        private void _TheTimeToSaveHasComeMotherfucker_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //RewriteUpdatedFile();
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            MinimizeToItemBar();
        }
        private void MinimizeToItemBar()
        {
            this.Hide();
            this.notifyIcon1.Visible = true;
        }
        private void MaximizeFromItemBar()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
            var k = TopMost;
            this.TopMost = true;
            this.TopMost = k;
        }
        private void RewriteUpdatedFile()
        {
            File.Delete("Path.txt");
            File.Create("Path.txt").Close();

            var lst = new List<string>();
            foreach (var item in list_PathContainer.Items)
                lst.Add(item.ToString());

            File.WriteAllLines("Path.txt", lst.ToArray());
            this._Log.Append(nameof(RewriteUpdatedFile), "File saved");
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            RewriteUpdatedFile();
        }
        private void AddToList(string pathToAdd)
        {
            if (this.list_PathContainer.Items.Contains(pathToAdd))
                this.list_PathContainer.SelectedItem = pathToAdd;
            else
            {
                this.list_PathContainer.Items.Add(pathToAdd);
            }
        }

        private Point MouseDownLocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void List_PathContainer_DragDrop(object sender, DragEventArgs e)
        {
            var Paths = e.Data.GetData(DataFormats.FileDrop) as string[];
            foreach (string path in Paths)
            {
                AddToList(path);
                _Log.Append(nameof(List_PathContainer_DragDrop), $"Imported from DragDrop: {path}");
            }
        }
        private static void List_PathContainer_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case (int)Keys.R:
                    MessageBox.Show("f3");
                    break;
                default:
                    break;
            }
        }
    }
}
