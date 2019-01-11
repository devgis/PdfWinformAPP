namespace PDFApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("测试项1", "ico_Examine.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("测试项2", "ico_dsmain.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("测试项3", "ico_SpeedupOpt.png");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("测试项4", "ico_expert.png");
            CCWin.CmSysButton cmSysButton1 = new CCWin.CmSysButton();
            CCWin.CmSysButton cmSysButton2 = new CCWin.CmSysButton();
            CCWin.CmSysButton cmSysButton3 = new CCWin.CmSysButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.skinAnimatorImg1 = new CCWin.SkinControl.SkinAnimatorImg();
            this.skinToolStrip2 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.layoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.listViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinToolStrip2.SuspendLayout();
            this.layoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "hover_360MobileMgr1.png");
            this.imageList.Images.SetKeyName(1, "ico_AdvTools.png");
            this.imageList.Images.SetKeyName(2, "ico_diannaomenzhen.png");
            this.imageList.Images.SetKeyName(3, "ico_dsmain.png");
            this.imageList.Images.SetKeyName(4, "ico_Examine.png");
            this.imageList.Images.SetKeyName(5, "ico_expert.png");
            this.imageList.Images.SetKeyName(6, "ico_rescue.png");
            this.imageList.Images.SetKeyName(7, "ico_softmgr.png");
            this.imageList.Images.SetKeyName(8, "ico_SpeedupOpt.png");
            this.imageList.Images.SetKeyName(9, "ico_SysRepair.png");
            this.imageList.Images.SetKeyName(10, "ico_TraceCleaner.png");
            this.imageList.Images.SetKeyName(11, "ico_VulRepair.png");
            // 
            // skinAnimatorImg1
            // 
            this.skinAnimatorImg1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinAnimatorImg1.BackColor = System.Drawing.Color.Transparent;
            this.skinAnimatorImg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinAnimatorImg1.FrameNumber = 7;
            this.skinAnimatorImg1.FrameRate = 250;
            this.skinAnimatorImg1.Image = ((System.Drawing.Image)(resources.GetObject("skinAnimatorImg1.Image")));
            this.skinAnimatorImg1.Location = new System.Drawing.Point(935, -2);
            this.skinAnimatorImg1.Name = "skinAnimatorImg1";
            this.skinAnimatorImg1.OneFrame = 1;
            this.skinAnimatorImg1.Size = new System.Drawing.Size(26, 34);
            this.skinAnimatorImg1.StartTime = 5000;
            this.skinAnimatorImg1.TabIndex = 141;
            this.skinAnimatorImg1.Text = "skinAnimatorImg1";
            // 
            // skinToolStrip2
            // 
            this.skinToolStrip2.Arrow = System.Drawing.Color.White;
            this.skinToolStrip2.AutoSize = false;
            this.skinToolStrip2.Back = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackRadius = 4;
            this.skinToolStrip2.BackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.skinToolStrip2.Base = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BaseFore = System.Drawing.SystemColors.ButtonHighlight;
            this.skinToolStrip2.BaseForeAnamorphosis = false;
            this.skinToolStrip2.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip2.BaseForeAnamorphosisColor = System.Drawing.Color.Black;
            this.skinToolStrip2.BaseForeOffset = new System.Drawing.Point(3, 6);
            this.skinToolStrip2.BaseHoverFore = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.skinToolStrip2.BaseItemAnamorphosis = false;
            this.skinToolStrip2.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.skinToolStrip2.BaseItemBorderShow = false;
            this.skinToolStrip2.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemDown")));
            this.skinToolStrip2.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinToolStrip2.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemMouse")));
            this.skinToolStrip2.BaseItemPressed = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BaseItemRadius = 2;
            this.skinToolStrip2.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.BaseItemSplitter = System.Drawing.Color.Transparent;
            this.skinToolStrip2.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip2.Fore = System.Drawing.Color.White;
            this.skinToolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.skinToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip2.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.skinToolStrip2.ItemAnamorphosis = false;
            this.skinToolStrip2.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemBorderShow = false;
            this.skinToolStrip2.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemRadius = 1;
            this.skinToolStrip2.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripButton15,
            this.toolStripButton24,
            this.toolStripButton25,
            this.toolStripButton26});
            this.skinToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.skinToolStrip2.Location = new System.Drawing.Point(4, 26);
            this.skinToolStrip2.Name = "skinToolStrip2";
            this.skinToolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.skinToolStrip2.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.Size = new System.Drawing.Size(1107, 76);
            this.skinToolStrip2.SkinAllColor = true;
            this.skinToolStrip2.TabIndex = 179;
            this.skinToolStrip2.Text = "今天";
            this.skinToolStrip2.TitleAnamorphosis = false;
            this.skinToolStrip2.TitleColor = System.Drawing.SystemColors.HighlightText;
            this.skinToolStrip2.TitleRadius = 4;
            this.skinToolStrip2.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.AutoSize = false;
            this.toolStripButton10.AutoToolTip = false;
            this.toolStripButton10.ForeColor = System.Drawing.Color.White;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton10.MergeIndex = 0;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton10.Text = "手机防盗";
            this.toolStripButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.AutoSize = false;
            this.toolStripButton11.AutoToolTip = false;
            this.toolStripButton11.ForeColor = System.Drawing.Color.White;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton11.MergeIndex = 0;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton11.Text = "手机助手";
            this.toolStripButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.AutoSize = false;
            this.toolStripButton12.AutoToolTip = false;
            this.toolStripButton12.ForeColor = System.Drawing.Color.White;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton12.MergeIndex = 0;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton12.Text = "360网盾";
            this.toolStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.AutoSize = false;
            this.toolStripButton13.AutoToolTip = false;
            this.toolStripButton13.ForeColor = System.Drawing.Color.White;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton13.MergeIndex = 0;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton13.Text = "开机加速";
            this.toolStripButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.AutoSize = false;
            this.toolStripButton14.AutoToolTip = false;
            this.toolStripButton14.ForeColor = System.Drawing.Color.White;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton14.MergeIndex = 0;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton14.Text = "宽带测速器";
            this.toolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.AutoSize = false;
            this.toolStripButton15.AutoToolTip = false;
            this.toolStripButton15.ForeColor = System.Drawing.Color.White;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton15.MergeIndex = 0;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton15.Text = "断网急救箱";
            this.toolStripButton15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton24
            // 
            this.toolStripButton24.AutoSize = false;
            this.toolStripButton24.AutoToolTip = false;
            this.toolStripButton24.ForeColor = System.Drawing.Color.White;
            this.toolStripButton24.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton24.Image")));
            this.toolStripButton24.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton24.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton24.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton24.MergeIndex = 0;
            this.toolStripButton24.Name = "toolStripButton24";
            this.toolStripButton24.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton24.Text = "系统急救箱";
            this.toolStripButton24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton25
            // 
            this.toolStripButton25.AutoSize = false;
            this.toolStripButton25.AutoToolTip = false;
            this.toolStripButton25.ForeColor = System.Drawing.Color.White;
            this.toolStripButton25.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton25.Image")));
            this.toolStripButton25.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton25.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton25.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton25.MergeIndex = 0;
            this.toolStripButton25.Name = "toolStripButton25";
            this.toolStripButton25.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton25.Text = "文件粉碎机";
            this.toolStripButton25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton26
            // 
            this.toolStripButton26.AutoSize = false;
            this.toolStripButton26.AutoToolTip = false;
            this.toolStripButton26.BackColor = System.Drawing.Color.White;
            this.toolStripButton26.CheckOnClick = true;
            this.toolStripButton26.ForeColor = System.Drawing.Color.White;
            this.toolStripButton26.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton26.Image")));
            this.toolStripButton26.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton26.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton26.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton26.MergeIndex = 0;
            this.toolStripButton26.Name = "toolStripButton26";
            this.toolStripButton26.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton26.Text = "游戏优化器";
            this.toolStripButton26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // layoutPanelMain
            // 
            this.layoutPanelMain.ColumnCount = 2;
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanelMain.Controls.Add(this.dataGridViewX1, 1, 0);
            this.layoutPanelMain.Controls.Add(this.listViewEx1, 0, 0);
            this.layoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelMain.Location = new System.Drawing.Point(4, 102);
            this.layoutPanelMain.Name = "layoutPanelMain";
            this.layoutPanelMain.RowCount = 2;
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutPanelMain.Size = new System.Drawing.Size(1107, 712);
            this.layoutPanelMain.TabIndex = 180;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(203, 3);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(901, 696);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // listViewEx1
            // 
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.listViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEx1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listViewEx1.LargeImageList = this.imageList;
            this.listViewEx1.Location = new System.Drawing.Point(3, 3);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(194, 696);
            this.listViewEx1.SmallImageList = this.imageList;
            this.listViewEx1.TabIndex = 1;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 200;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackShade = false;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptionHeight = 22;
            this.ClientSize = new System.Drawing.Size(1115, 818);
            this.CloseBoxSize = new System.Drawing.Size(27, 22);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.layoutPanelMain);
            this.Controls.Add(this.skinToolStrip2);
            this.Controls.Add(this.skinAnimatorImg1);
            this.EffectBack = System.Drawing.Color.Black;
            this.EffectCaption = CCWin.TitleType.Title;
            this.EffectWidth = 0;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaxDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxDownBack")));
            this.MaximizeBox = false;
            this.MaxMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxMouseBack")));
            this.MaxNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxNormlBack")));
            this.MaxSize = new System.Drawing.Size(27, 22);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(27, 22);
            this.Name = "MainForm";
            this.Radius = 1;
            this.RestoreDownBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreDownBack")));
            this.RestoreMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreMouseBack")));
            this.RestoreNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreNormlBack")));
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.SkinOpacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            cmSysButton1.Bounds = new System.Drawing.Rectangle(1028, 0, 27, 22);
            cmSysButton1.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton1.Location = new System.Drawing.Point(1028, 0);
            cmSysButton1.Name = "SysTool";
            cmSysButton1.OwnerForm = this;
            cmSysButton1.Size = new System.Drawing.Size(27, 22);
            cmSysButton1.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonDown")));
            cmSysButton1.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonMouse")));
            cmSysButton1.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonNorml")));
            cmSysButton1.ToolTip = "主菜单";
            cmSysButton2.Bounds = new System.Drawing.Rectangle(1001, 0, 27, 22);
            cmSysButton2.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton2.Location = new System.Drawing.Point(1001, 0);
            cmSysButton2.Name = "SysMsg";
            cmSysButton2.OwnerForm = this;
            cmSysButton2.Size = new System.Drawing.Size(27, 22);
            cmSysButton2.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonDown")));
            cmSysButton2.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonMouse")));
            cmSysButton2.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonNorml")));
            cmSysButton2.ToolTip = "反馈意见";
            cmSysButton3.Bounds = new System.Drawing.Rectangle(974, 0, 27, 22);
            cmSysButton3.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton3.Location = new System.Drawing.Point(974, 0);
            cmSysButton3.Name = "SysSkin";
            cmSysButton3.OwnerForm = this;
            cmSysButton3.Size = new System.Drawing.Size(27, 22);
            cmSysButton3.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton3.SysButtonDown")));
            cmSysButton3.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton3.SysButtonMouse")));
            cmSysButton3.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton3.SysButtonNorml")));
            cmSysButton3.ToolTip = "换肤";
            this.SysButtonItems.AddRange(new CCWin.CmSysButton[] {
            cmSysButton1,
            cmSysButton2,
            cmSysButton3});
            this.Text = "测试程序";
            this.TitleColor = System.Drawing.Color.White;
            this.TitleOffset = new System.Drawing.Point(13, 4);
            this.skinToolStrip2.ResumeLayout(false);
            this.skinToolStrip2.PerformLayout();
            this.layoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private CCWin.SkinControl.SkinAnimatorImg skinAnimatorImg1;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton24;
        private System.Windows.Forms.ToolStripButton toolStripButton25;
        private System.Windows.Forms.ToolStripButton toolStripButton26;
        private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewEx1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

