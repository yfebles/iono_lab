namespace IonoLab
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabladiariatoolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.cursorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.kmtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.kmvaluetoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ftoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fvaluetoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.toolsBar = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.preToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fullstoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mouseStripButton = new System.Windows.Forms.ToolStripButton();
            this.m3000StripButton = new System.Windows.Forms.ToolStripButton();
            this.erasetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lb_station = new System.Windows.Forms.Label();
            this.ionoviewer = new IonoLab.Ionoviewer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mainmenu.SuspendLayout();
            this.statusbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolsBar.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainmenu.Size = new System.Drawing.Size(950, 24);
            this.mainmenu.TabIndex = 0;
            this.mainmenu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.tabladiariatoolstrip,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "&Archivo";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.openToolStripMenuItem.Text = "&Abrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(246, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.saveToolStripMenuItem.Text = "&Guardar Imagen";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tabladiariatoolstrip
            // 
            this.tabladiariatoolstrip.Name = "tabladiariatoolstrip";
            this.tabladiariatoolstrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tabladiariatoolstrip.Size = new System.Drawing.Size(249, 22);
            this.tabladiariatoolstrip.Text = "Guardar Tabla Diaria";
            this.tabladiariatoolstrip.Click += new System.EventHandler(this.tabladiariatoolstrip_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 22);
            this.toolStripMenuItem1.Text = "Guardar Tabla Mensual";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.printToolStripMenuItem.Text = "&Imprimir";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(246, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.fullScreenToolStripMenuItem1,
            this.toolStripSeparator9,
            this.cursorToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.viewToolStripMenuItem.Text = "&Ver";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fullScreenToolStripMenuItem.Text = "Maximizado";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem1
            // 
            this.fullScreenToolStripMenuItem1.Name = "fullScreenToolStripMenuItem1";
            this.fullScreenToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.fullScreenToolStripMenuItem1.Text = "Pantalla completa";
            this.fullScreenToolStripMenuItem1.Click += new System.EventHandler(this.fullScreenToolStripMenuItem1_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(174, 6);
            // 
            // cursorToolStripMenuItem
            // 
            this.cursorToolStripMenuItem.Checked = true;
            this.cursorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cursorToolStripMenuItem.Name = "cursorToolStripMenuItem";
            this.cursorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cursorToolStripMenuItem.Text = "Cursor";
            this.cursorToolStripMenuItem.Click += new System.EventHandler(this.mouseStripButton_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.toolsToolStripMenuItem.Text = "&Herramientas";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.optionsToolStripMenuItem.Text = "&Opciones";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.helpToolStripMenuItem.Text = "&Ayuda";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(121, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kmtoolStripStatusLabel,
            this.kmvaluetoolStripStatusLabel,
            this.ftoolStripStatusLabel,
            this.fvaluetoolStripStatusLabel});
            this.statusbar.Location = new System.Drawing.Point(0, 543);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(950, 22);
            this.statusbar.TabIndex = 1;
            this.statusbar.Text = "statusStrip1";
            // 
            // kmtoolStripStatusLabel
            // 
            this.kmtoolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmtoolStripStatusLabel.Name = "kmtoolStripStatusLabel";
            this.kmtoolStripStatusLabel.Size = new System.Drawing.Size(28, 17);
            this.kmtoolStripStatusLabel.Text = "km:";
            // 
            // kmvaluetoolStripStatusLabel
            // 
            this.kmvaluetoolStripStatusLabel.Name = "kmvaluetoolStripStatusLabel";
            this.kmvaluetoolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.kmvaluetoolStripStatusLabel.Text = "0";
            // 
            // ftoolStripStatusLabel
            // 
            this.ftoolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftoolStripStatusLabel.Name = "ftoolStripStatusLabel";
            this.ftoolStripStatusLabel.Size = new System.Drawing.Size(15, 17);
            this.ftoolStripStatusLabel.Text = "f:";
            // 
            // fvaluetoolStripStatusLabel
            // 
            this.fvaluetoolStripStatusLabel.Name = "fvaluetoolStripStatusLabel";
            this.fvaluetoolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.fvaluetoolStripStatusLabel.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            this.splitContainer1.Panel1.Controls.Add(this.toolsBar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lb_station);
            this.splitContainer1.Panel2.Controls.Add(this.ionoviewer);
            this.splitContainer1.Size = new System.Drawing.Size(950, 519);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView
            // 
            this.treeView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Indent = 15;
            this.treeView.Location = new System.Drawing.Point(0, 25);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(213, 494);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // toolsBar
            // 
            this.toolsBar.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.toolsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.preToolStripButton,
            this.nextToolStripButton,
            this.fullstoolStripButton,
            this.toolStripSeparator7,
            this.mouseStripButton,
            this.m3000StripButton,
            this.erasetoolStripButton});
            this.toolsBar.Location = new System.Drawing.Point(0, 0);
            this.toolsBar.Name = "toolsBar";
            this.toolsBar.Size = new System.Drawing.Size(213, 25);
            this.toolsBar.TabIndex = 0;
            this.toolsBar.Text = "Tools";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // preToolStripButton
            // 
            this.preToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.preToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("preToolStripButton.Image")));
            this.preToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.preToolStripButton.Name = "preToolStripButton";
            this.preToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.preToolStripButton.Text = "Previous";
            this.preToolStripButton.Click += new System.EventHandler(this.preToolStripButton_Click);
            // 
            // nextToolStripButton
            // 
            this.nextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nextToolStripButton.Image")));
            this.nextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextToolStripButton.Name = "nextToolStripButton";
            this.nextToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nextToolStripButton.Text = "Next";
            this.nextToolStripButton.Click += new System.EventHandler(this.nextToolStripButton_Click);
            // 
            // fullstoolStripButton
            // 
            this.fullstoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fullstoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fullstoolStripButton.Image")));
            this.fullstoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fullstoolStripButton.Name = "fullstoolStripButton";
            this.fullstoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fullstoolStripButton.Text = "Full screen";
            this.fullstoolStripButton.Click += new System.EventHandler(this.fullScreenToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // mouseStripButton
            // 
            this.mouseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mouseStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mouseStripButton.Image")));
            this.mouseStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mouseStripButton.Name = "mouseStripButton";
            this.mouseStripButton.Size = new System.Drawing.Size(23, 22);
            this.mouseStripButton.Text = "Mouse";
            this.mouseStripButton.Click += new System.EventHandler(this.mouseStripButton_Click);
            // 
            // m3000StripButton
            // 
            this.m3000StripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m3000StripButton.Image = ((System.Drawing.Image)(resources.GetObject("m3000StripButton.Image")));
            this.m3000StripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m3000StripButton.Name = "m3000StripButton";
            this.m3000StripButton.Size = new System.Drawing.Size(23, 22);
            this.m3000StripButton.Text = "M(3000)";
            this.m3000StripButton.Click += new System.EventHandler(this.m3000StripButton_Click);
            // 
            // erasetoolStripButton
            // 
            this.erasetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.erasetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("erasetoolStripButton.Image")));
            this.erasetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.erasetoolStripButton.Name = "erasetoolStripButton";
            this.erasetoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.erasetoolStripButton.Text = "Borrar datos del ionograma actual.";
            this.erasetoolStripButton.Click += new System.EventHandler(this.erasetoolStripButton_Click);
            // 
            // lb_station
            // 
            this.lb_station.AutoSize = true;
            this.lb_station.BackColor = System.Drawing.Color.Black;
            this.lb_station.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_station.ForeColor = System.Drawing.Color.White;
            this.lb_station.Location = new System.Drawing.Point(37, 0);
            this.lb_station.Name = "lb_station";
            this.lb_station.Size = new System.Drawing.Size(103, 25);
            this.lb_station.TabIndex = 1;
            this.lb_station.Text = "Estación";
            // 
            // ionoviewer
            // 
            this.ionoviewer.BackColor = System.Drawing.SystemColors.Menu;
            this.ionoviewer.ChartInfo = ((IonoLab.ChartDetail)(resources.GetObject("ionoviewer.ChartInfo")));
            this.ionoviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ionoviewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ionoviewer.Ionogram = null;
            this.ionoviewer.Location = new System.Drawing.Point(0, 0);
            this.ionoviewer.Name = "ionoviewer";
            this.ionoviewer.ShowMouse = true;
            this.ionoviewer.ShowMouseM300 = false;
            this.ionoviewer.Size = new System.Drawing.Size(733, 519);
            this.ionoviewer.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton1,
            this.saveToolStripButton1,
            this.printToolStripButton,
            this.toolStripSeparator8,
            this.helpToolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(539, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton1
            // 
            this.openToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton1.Image")));
            this.openToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton1.Name = "openToolStripButton1";
            this.openToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton1.Text = "&Open";
            // 
            // saveToolStripButton1
            // 
            this.saveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton1.Image")));
            this.saveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton1.Name = "saveToolStripButton1";
            this.saveToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton1.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton1
            // 
            this.helpToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton1.Image")));
            this.helpToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton1.Name = "helpToolStripButton1";
            this.helpToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton1.Text = "He&lp";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "jpg";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Title = "Guardar Tabla Diaria                                 ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 565);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.mainmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainmenu;
            this.Name = "mainForm";
            this.Text = "Ionolab v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolsBar.ResumeLayout(false);
            this.toolsBar.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolsBar;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton preToolStripButton;
        private System.Windows.Forms.ToolStripButton nextToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton1;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton helpToolStripButton1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.OpenFileDialog openFile;
        private Ionoviewer ionoviewer;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripButton mouseStripButton;
        private System.Windows.Forms.ToolStripStatusLabel kmtoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel kmvaluetoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ftoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel fvaluetoolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursorToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ToolStripButton erasetoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton fullstoolStripButton;
        private System.Windows.Forms.ToolStripButton m3000StripButton;
        private System.Windows.Forms.Label lb_station;
        private System.Windows.Forms.ToolStripMenuItem tabladiariatoolstrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

