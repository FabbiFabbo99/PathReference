namespace Path_Reference
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.list_PathContainer = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbox_Path = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this._TheTimeToSaveHasComeMotherfucker = new System.Timers.Timer();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._TheTimeToSaveHasComeMotherfucker)).BeginInit();
            this.SuspendLayout();
            // 
            // list_PathContainer
            // 
            this.list_PathContainer.AllowDrop = true;
            this.list_PathContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_PathContainer.FormattingEnabled = true;
            this.list_PathContainer.HorizontalScrollbar = true;
            this.list_PathContainer.Location = new System.Drawing.Point(3, 3);
            this.list_PathContainer.Name = "list_PathContainer";
            this.list_PathContainer.Size = new System.Drawing.Size(317, 249);
            this.list_PathContainer.TabIndex = 0;
            this.list_PathContainer.Click += new System.EventHandler(this.box_ItemBox_Click);
            this.list_PathContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_PathContainer_DragDrop);
            this.list_PathContainer.DragOver += new System.Windows.Forms.DragEventHandler(Form1.List_PathContainer_DragOver);
            this.list_PathContainer.DoubleClick += new System.EventHandler(this.box_ItemBox_DoubleClick);
            this.list_PathContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.list_PathContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.list_PathContainer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 300);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tbox_Path, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Remove, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 258);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(317, 39);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.tableLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // tbox_Path
            // 
            this.tbox_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_Path.Location = new System.Drawing.Point(66, 3);
            this.tbox_Path.Multiline = true;
            this.tbox_Path.Name = "tbox_Path";
            this.tbox_Path.Size = new System.Drawing.Size(184, 33);
            this.tbox_Path.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(57, 33);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Remove.Location = new System.Drawing.Point(256, 3);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(58, 33);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Open Path Reference";
            this.notifyIcon1.BalloonTipTitle = "Path Reference";
            this.notifyIcon1.Icon = global::Path_Reference.Properties.Resources.icon_ico_fullwhite;
            this.notifyIcon1.Text = "Path Reference";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // _TheTimeToSaveHasComeMotherfucker
            // 
            this._TheTimeToSaveHasComeMotherfucker.Enabled = true;
            this._TheTimeToSaveHasComeMotherfucker.Interval = 600000D;
            this._TheTimeToSaveHasComeMotherfucker.SynchronizingObject = this;
            this._TheTimeToSaveHasComeMotherfucker.Elapsed += new System.Timers.ElapsedEventHandler(this._TheTimeToSaveHasComeMotherfucker_Elapsed);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Path Reference";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this._TheTimeToSaveHasComeMotherfucker)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion


        private System.Windows.Forms.ListBox list_PathContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbox_Path;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Timers.Timer _TheTimeToSaveHasComeMotherfucker;
        private XMLPaths _Paths;
        private Log _Log;
    }
}
