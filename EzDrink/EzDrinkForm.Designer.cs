using System;
using System.Windows.Forms;

namespace EzDrink
{
    partial class EzDrinkForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }
        #region Windows Form 設計工具產生的程式碼
        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._myMenuStrip = new System.Windows.Forms.MenuStrip();
            this._myToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._orderSystemTabPage = new System.Windows.Forms.TabPage();
            this._ezDrinkMainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._orderSystemGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkGridView = new System.Windows.Forms.DataGridView();
            this._drinkSelectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._drinkAdditionGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkAdditionGridView = new System.Windows.Forms.DataGridView();
            this._additionSelectButton = new EzDrink.DataGridViewDisableButtonColumn();
            this._additionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._temperatureGroupBox = new System.Windows.Forms.GroupBox();
            this._iceButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._iceFreeButton = new System.Windows.Forms.Button();
            this._regularIceButton = new System.Windows.Forms.Button();
            this._easyIceButton = new System.Windows.Forms.Button();
            this._warmTemperatureButton = new System.Windows.Forms.Button();
            this._sweetLevelGroupBox = new System.Windows.Forms.GroupBox();
            this._sweetLevelButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._sugarFreeButton = new System.Windows.Forms.Button();
            this._regularSugarButton = new System.Windows.Forms.Button();
            this._quarterSugarButton = new System.Windows.Forms.Button();
            this._halfSugarButton = new System.Windows.Forms.Button();
            this._orderAndCheckOutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._orderDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this._orderDisplayGridView = new System.Windows.Forms.DataGridView();
            this._drinkNameAtOrderList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._priceAtOrderList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sweetLevelAtOrderList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._temperatureAtOrderList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionAtOrderList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._deleteOrderedDrinkButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._checkOutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._checkOutButton = new System.Windows.Forms.Button();
            this._checkOutLabel = new System.Windows.Forms.Label();
            this._myMainTab = new System.Windows.Forms.TabControl();
            this._backStageTab = new System.Windows.Forms.TabPage();
            this._backStageMainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._backStageOperationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._drinkListOperationGroupBox = new System.Windows.Forms.GroupBox();
            this._backStageDrinkEditTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._drinkListOperationButton = new System.Windows.Forms.Button();
            this._openDrinkListFileButton = new System.Windows.Forms.Button();
            this._drinkNameLabel = new System.Windows.Forms.Label();
            this._drinkPriceLabel = new System.Windows.Forms.Label();
            this._drinkNameTextBox = new System.Windows.Forms.TextBox();
            this._drinkPriceTextBox = new System.Windows.Forms.TextBox();
            this._drinkAdditionOperationGroupBox = new System.Windows.Forms.GroupBox();
            this._backStageDrinkAdditionEditTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._drinkAdditionNameTextBox = new System.Windows.Forms.TextBox();
            this._openDrinkAdditionListButton = new System.Windows.Forms.Button();
            this._drinkAdditionListOperationButton = new System.Windows.Forms.Button();
            this._drinkAdditionNameLabel = new System.Windows.Forms.Label();
            this._drinkAdditionPriceLabel = new System.Windows.Forms.Label();
            this._drinkAdditionPriceTextBox = new System.Windows.Forms.TextBox();
            this._editDrinkListGroupBox = new System.Windows.Forms.GroupBox();
            this._backStageDrinkListDataGridView = new System.Windows.Forms.DataGridView();
            this._buttonOnEditDrinkList = new System.Windows.Forms.DataGridViewButtonColumn();
            this._drinkNameOnEditDrinkList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkPriceOnEditDrinkList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._editDrinkAdditionListGroupBox = new System.Windows.Forms.GroupBox();
            this._backStageDrinkAdditionListDataGridView = new System.Windows.Forms.DataGridView();
            this._buttonOnEditDrinkAdditionList = new System.Windows.Forms.DataGridViewButtonColumn();
            this._editDrinkAdditionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._editDrinkAdditionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyTab = new System.Windows.Forms.TabPage();
            this._historyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._historyDetailTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._historyPriceLabel = new System.Windows.Forms.Label();
            this._historyDetailGroupBox = new System.Windows.Forms.GroupBox();
            this._historyDetailDataGridView = new System.Windows.Forms.DataGridView();
            this._historyDrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyDrinkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historySweet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyAddition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyGroupBox = new System.Windows.Forms.GroupBox();
            this._historyDataGridView = new System.Windows.Forms.DataGridView();
            this._historyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._myMenuStrip.SuspendLayout();
            this._orderSystemTabPage.SuspendLayout();
            this._ezDrinkMainTableLayoutPanel.SuspendLayout();
            this._orderSystemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkGridView)).BeginInit();
            this._additionTableLayoutPanel.SuspendLayout();
            this._drinkAdditionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditionGridView)).BeginInit();
            this._temperatureGroupBox.SuspendLayout();
            this._iceButtonTableLayoutPanel.SuspendLayout();
            this._sweetLevelGroupBox.SuspendLayout();
            this._sweetLevelButtonTableLayoutPanel.SuspendLayout();
            this._orderAndCheckOutTableLayoutPanel.SuspendLayout();
            this._orderDisplayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderDisplayGridView)).BeginInit();
            this._checkOutTableLayoutPanel.SuspendLayout();
            this._myMainTab.SuspendLayout();
            this._backStageTab.SuspendLayout();
            this._backStageMainTableLayoutPanel.SuspendLayout();
            this._backStageOperationTableLayoutPanel.SuspendLayout();
            this._drinkListOperationGroupBox.SuspendLayout();
            this._backStageDrinkEditTableLayoutPanel.SuspendLayout();
            this._drinkAdditionOperationGroupBox.SuspendLayout();
            this._backStageDrinkAdditionEditTableLayoutPanel.SuspendLayout();
            this._editDrinkListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._backStageDrinkListDataGridView)).BeginInit();
            this._editDrinkAdditionListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._backStageDrinkAdditionListDataGridView)).BeginInit();
            this._historyTab.SuspendLayout();
            this._historyTableLayoutPanel.SuspendLayout();
            this._historyDetailTableLayoutPanel.SuspendLayout();
            this._historyDetailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._historyDetailDataGridView)).BeginInit();
            this._historyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _myMenuStrip
            // 
            this._myMenuStrip.AccessibleName = "myMenuStrip";
            this._myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._myToolStripMenuItem,
            this._helpToolStripMenuItem});
            this._myMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._myMenuStrip.Name = "_myMenuStrip";
            this._myMenuStrip.Size = new System.Drawing.Size(1184, 28);
            this._myMenuStrip.TabIndex = 0;
            this._myMenuStrip.Text = "myMenuStrip";
            // 
            // _myToolStripMenuItem
            // 
            this._myToolStripMenuItem.AccessibleName = "file";
            this._myToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitToolStripMenuItem});
            this._myToolStripMenuItem.Name = "_myToolStripMenuItem";
            this._myToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this._myToolStripMenuItem.Text = "File";
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.AccessibleName = "exit";
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this._exitToolStripMenuItem.Text = "Exit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.AccessibleName = "help";
            this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutToolStripMenuItem});
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this._helpToolStripMenuItem.Text = "Help";
            // 
            // _aboutToolStripMenuItem
            // 
            this._aboutToolStripMenuItem.AccessibleName = "about";
            this._aboutToolStripMenuItem.Name = "_aboutToolStripMenuItem";
            this._aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this._aboutToolStripMenuItem.Text = "About";
            this._aboutToolStripMenuItem.Click += new System.EventHandler(this.ClickAboutToolStripMenuItem);
            // 
            // _orderSystemTabPage
            // 
            this._orderSystemTabPage.Controls.Add(this._ezDrinkMainTableLayoutPanel);
            this._orderSystemTabPage.Location = new System.Drawing.Point(4, 22);
            this._orderSystemTabPage.Name = "_orderSystemTabPage";
            this._orderSystemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._orderSystemTabPage.Size = new System.Drawing.Size(1176, 607);
            this._orderSystemTabPage.TabIndex = 0;
            this._orderSystemTabPage.Tag = "";
            this._orderSystemTabPage.Text = "點餐系統";
            this._orderSystemTabPage.UseVisualStyleBackColor = true;
            // 
            // _ezDrinkMainTableLayoutPanel
            // 
            this._ezDrinkMainTableLayoutPanel.ColumnCount = 5;
            this._ezDrinkMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._ezDrinkMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this._ezDrinkMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this._ezDrinkMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this._ezDrinkMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._ezDrinkMainTableLayoutPanel.Controls.Add(this._orderSystemGroupBox, 0, 0);
            this._ezDrinkMainTableLayoutPanel.Controls.Add(this._additionTableLayoutPanel, 2, 0);
            this._ezDrinkMainTableLayoutPanel.Controls.Add(this._orderAndCheckOutTableLayoutPanel, 4, 0);
            this._ezDrinkMainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ezDrinkMainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._ezDrinkMainTableLayoutPanel.Name = "_ezDrinkMainTableLayoutPanel";
            this._ezDrinkMainTableLayoutPanel.RowCount = 1;
            this._ezDrinkMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ezDrinkMainTableLayoutPanel.Size = new System.Drawing.Size(1170, 601);
            this._ezDrinkMainTableLayoutPanel.TabIndex = 1;
            // 
            // _orderSystemGroupBox
            // 
            this._orderSystemGroupBox.Controls.Add(this._drinkGridView);
            this._orderSystemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderSystemGroupBox.Location = new System.Drawing.Point(3, 3);
            this._orderSystemGroupBox.Name = "_orderSystemGroupBox";
            this._orderSystemGroupBox.Size = new System.Drawing.Size(228, 595);
            this._orderSystemGroupBox.TabIndex = 1;
            this._orderSystemGroupBox.TabStop = false;
            this._orderSystemGroupBox.Text = "飲料";
            // 
            // _drinkGridView
            // 
            this._drinkGridView.AccessibleName = "drinkGridView";
            this._drinkGridView.AllowUserToAddRows = false;
            this._drinkGridView.AllowUserToDeleteRows = false;
            this._drinkGridView.AllowUserToResizeColumns = false;
            this._drinkGridView.AllowUserToResizeRows = false;
            this._drinkGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._drinkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._drinkGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._drinkSelectButton,
            this._name,
            this._price});
            this._drinkGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkGridView.Location = new System.Drawing.Point(3, 18);
            this._drinkGridView.MultiSelect = false;
            this._drinkGridView.Name = "_drinkGridView";
            this._drinkGridView.ReadOnly = true;
            this._drinkGridView.RowHeadersVisible = false;
            this._drinkGridView.RowTemplate.Height = 24;
            this._drinkGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._drinkGridView.Size = new System.Drawing.Size(222, 574);
            this._drinkGridView.TabIndex = 0;
            this._drinkGridView.Tag = "";
            this._drinkGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrinkGridViewCellContentClick);
            // 
            // _drinkSelectButton
            // 
            this._drinkSelectButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._drinkSelectButton.FillWeight = 10F;
            this._drinkSelectButton.HeaderText = "";
            this._drinkSelectButton.Name = "_drinkSelectButton";
            this._drinkSelectButton.ReadOnly = true;
            this._drinkSelectButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._drinkSelectButton.Text = "選擇";
            this._drinkSelectButton.UseColumnTextForButtonValue = true;
            this._drinkSelectButton.Width = 50;
            // 
            // _name
            // 
            this._name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._name.FillWeight = 45F;
            this._name.HeaderText = "名稱";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            this._name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _price
            // 
            this._price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._price.FillWeight = 45F;
            this._price.HeaderText = "價格";
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            this._price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _additionTableLayoutPanel
            // 
            this._additionTableLayoutPanel.ColumnCount = 1;
            this._additionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._additionTableLayoutPanel.Controls.Add(this._drinkAdditionGroupBox, 0, 0);
            this._additionTableLayoutPanel.Controls.Add(this._temperatureGroupBox, 0, 2);
            this._additionTableLayoutPanel.Controls.Add(this._sweetLevelGroupBox, 0, 1);
            this._additionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._additionTableLayoutPanel.Location = new System.Drawing.Point(283, 3);
            this._additionTableLayoutPanel.Name = "_additionTableLayoutPanel";
            this._additionTableLayoutPanel.RowCount = 3;
            this._additionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._additionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._additionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._additionTableLayoutPanel.Size = new System.Drawing.Size(368, 595);
            this._additionTableLayoutPanel.TabIndex = 2;
            // 
            // _drinkAdditionGroupBox
            // 
            this._drinkAdditionGroupBox.Controls.Add(this._drinkAdditionGridView);
            this._drinkAdditionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkAdditionGroupBox.Location = new System.Drawing.Point(3, 3);
            this._drinkAdditionGroupBox.Name = "_drinkAdditionGroupBox";
            this._drinkAdditionGroupBox.Size = new System.Drawing.Size(362, 192);
            this._drinkAdditionGroupBox.TabIndex = 3;
            this._drinkAdditionGroupBox.TabStop = false;
            this._drinkAdditionGroupBox.Text = "加料";
            // 
            // _drinkAdditionGridView
            // 
            this._drinkAdditionGridView.AccessibleName = "drinkAddition";
            this._drinkAdditionGridView.AllowUserToAddRows = false;
            this._drinkAdditionGridView.AllowUserToDeleteRows = false;
            this._drinkAdditionGridView.AllowUserToResizeColumns = false;
            this._drinkAdditionGridView.AllowUserToResizeRows = false;
            this._drinkAdditionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._drinkAdditionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkAdditionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._additionSelectButton,
            this._additionName,
            this._additionPrice});
            this._drinkAdditionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkAdditionGridView.Location = new System.Drawing.Point(3, 18);
            this._drinkAdditionGridView.MultiSelect = false;
            this._drinkAdditionGridView.Name = "_drinkAdditionGridView";
            this._drinkAdditionGridView.ReadOnly = true;
            this._drinkAdditionGridView.RowHeadersVisible = false;
            this._drinkAdditionGridView.RowTemplate.Height = 24;
            this._drinkAdditionGridView.Size = new System.Drawing.Size(356, 171);
            this._drinkAdditionGridView.TabIndex = 0;
            this._drinkAdditionGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrinkAdditionGridViewCellContentClick);
            // 
            // _additionSelectButton
            // 
            this._additionSelectButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._additionSelectButton.FillWeight = 10F;
            this._additionSelectButton.HeaderText = "";
            this._additionSelectButton.Name = "_additionSelectButton";
            this._additionSelectButton.ReadOnly = true;
            this._additionSelectButton.Width = 50;
            // 
            // _additionName
            // 
            this._additionName.FillWeight = 45F;
            this._additionName.HeaderText = "名稱";
            this._additionName.Name = "_additionName";
            this._additionName.ReadOnly = true;
            this._additionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _additionPrice
            // 
            this._additionPrice.FillWeight = 45F;
            this._additionPrice.HeaderText = "價格";
            this._additionPrice.Name = "_additionPrice";
            this._additionPrice.ReadOnly = true;
            this._additionPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _temperatureGroupBox
            // 
            this._temperatureGroupBox.Controls.Add(this._iceButtonTableLayoutPanel);
            this._temperatureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._temperatureGroupBox.Location = new System.Drawing.Point(3, 399);
            this._temperatureGroupBox.Name = "_temperatureGroupBox";
            this._temperatureGroupBox.Size = new System.Drawing.Size(362, 193);
            this._temperatureGroupBox.TabIndex = 5;
            this._temperatureGroupBox.TabStop = false;
            this._temperatureGroupBox.Text = "溫度";
            // 
            // _iceButtonTableLayoutPanel
            // 
            this._iceButtonTableLayoutPanel.ColumnCount = 2;
            this._iceButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._iceButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._iceButtonTableLayoutPanel.Controls.Add(this._iceFreeButton, 1, 1);
            this._iceButtonTableLayoutPanel.Controls.Add(this._regularIceButton, 0, 0);
            this._iceButtonTableLayoutPanel.Controls.Add(this._easyIceButton, 0, 1);
            this._iceButtonTableLayoutPanel.Controls.Add(this._warmTemperatureButton, 1, 0);
            this._iceButtonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._iceButtonTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._iceButtonTableLayoutPanel.Name = "_iceButtonTableLayoutPanel";
            this._iceButtonTableLayoutPanel.RowCount = 2;
            this._iceButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._iceButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._iceButtonTableLayoutPanel.Size = new System.Drawing.Size(356, 172);
            this._iceButtonTableLayoutPanel.TabIndex = 0;
            // 
            // _iceFreeButton
            // 
            this._iceFreeButton.AccessibleName = "iceFreeButton";
            this._iceFreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._iceFreeButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._iceFreeButton.Location = new System.Drawing.Point(181, 89);
            this._iceFreeButton.Name = "_iceFreeButton";
            this._iceFreeButton.Size = new System.Drawing.Size(172, 80);
            this._iceFreeButton.TabIndex = 3;
            this._iceFreeButton.Text = "去冰";
            this._iceFreeButton.UseVisualStyleBackColor = true;
            this._iceFreeButton.Click += new System.EventHandler(this.ClickTemperatureButton);
            // 
            // _regularIceButton
            // 
            this._regularIceButton.AccessibleName = "regularIceButton";
            this._regularIceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._regularIceButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._regularIceButton.Location = new System.Drawing.Point(3, 3);
            this._regularIceButton.Name = "_regularIceButton";
            this._regularIceButton.Size = new System.Drawing.Size(172, 80);
            this._regularIceButton.TabIndex = 0;
            this._regularIceButton.Text = "正常";
            this._regularIceButton.UseVisualStyleBackColor = true;
            this._regularIceButton.Click += new System.EventHandler(this.ClickTemperatureButton);
            // 
            // _easyIceButton
            // 
            this._easyIceButton.AccessibleName = "easyIceButton";
            this._easyIceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._easyIceButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._easyIceButton.Location = new System.Drawing.Point(3, 89);
            this._easyIceButton.Name = "_easyIceButton";
            this._easyIceButton.Size = new System.Drawing.Size(172, 80);
            this._easyIceButton.TabIndex = 2;
            this._easyIceButton.Text = "少冰";
            this._easyIceButton.UseVisualStyleBackColor = true;
            this._easyIceButton.Click += new System.EventHandler(this.ClickTemperatureButton);
            // 
            // _warmTemperatureButton
            // 
            this._warmTemperatureButton.AccessibleName = "warmTemperatureButton";
            this._warmTemperatureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._warmTemperatureButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._warmTemperatureButton.Location = new System.Drawing.Point(181, 3);
            this._warmTemperatureButton.Name = "_warmTemperatureButton";
            this._warmTemperatureButton.Size = new System.Drawing.Size(172, 80);
            this._warmTemperatureButton.TabIndex = 1;
            this._warmTemperatureButton.Text = "溫熱";
            this._warmTemperatureButton.UseVisualStyleBackColor = true;
            this._warmTemperatureButton.Click += new System.EventHandler(this.ClickTemperatureButton);
            // 
            // _sweetLevelGroupBox
            // 
            this._sweetLevelGroupBox.Controls.Add(this._sweetLevelButtonTableLayoutPanel);
            this._sweetLevelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sweetLevelGroupBox.Location = new System.Drawing.Point(3, 201);
            this._sweetLevelGroupBox.Name = "_sweetLevelGroupBox";
            this._sweetLevelGroupBox.Size = new System.Drawing.Size(362, 192);
            this._sweetLevelGroupBox.TabIndex = 4;
            this._sweetLevelGroupBox.TabStop = false;
            this._sweetLevelGroupBox.Text = "甜度";
            // 
            // _sweetLevelButtonTableLayoutPanel
            // 
            this._sweetLevelButtonTableLayoutPanel.ColumnCount = 2;
            this._sweetLevelButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sweetLevelButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sweetLevelButtonTableLayoutPanel.Controls.Add(this._sugarFreeButton, 1, 1);
            this._sweetLevelButtonTableLayoutPanel.Controls.Add(this._regularSugarButton, 0, 0);
            this._sweetLevelButtonTableLayoutPanel.Controls.Add(this._quarterSugarButton, 0, 1);
            this._sweetLevelButtonTableLayoutPanel.Controls.Add(this._halfSugarButton, 1, 0);
            this._sweetLevelButtonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sweetLevelButtonTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._sweetLevelButtonTableLayoutPanel.Name = "_sweetLevelButtonTableLayoutPanel";
            this._sweetLevelButtonTableLayoutPanel.RowCount = 2;
            this._sweetLevelButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sweetLevelButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sweetLevelButtonTableLayoutPanel.Size = new System.Drawing.Size(356, 171);
            this._sweetLevelButtonTableLayoutPanel.TabIndex = 0;
            // 
            // _sugarFreeButton
            // 
            this._sugarFreeButton.AccessibleName = "sugarFreeButton";
            this._sugarFreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarFreeButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._sugarFreeButton.Location = new System.Drawing.Point(181, 88);
            this._sugarFreeButton.Name = "_sugarFreeButton";
            this._sugarFreeButton.Size = new System.Drawing.Size(172, 80);
            this._sugarFreeButton.TabIndex = 3;
            this._sugarFreeButton.Text = "無糖";
            this._sugarFreeButton.UseVisualStyleBackColor = true;
            this._sugarFreeButton.Click += new System.EventHandler(this.ClickSweetButton);
            // 
            // _regularSugarButton
            // 
            this._regularSugarButton.AccessibleName = "regularSugarButton";
            this._regularSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._regularSugarButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._regularSugarButton.Location = new System.Drawing.Point(3, 3);
            this._regularSugarButton.Name = "_regularSugarButton";
            this._regularSugarButton.Size = new System.Drawing.Size(172, 79);
            this._regularSugarButton.TabIndex = 0;
            this._regularSugarButton.Text = "正常";
            this._regularSugarButton.UseVisualStyleBackColor = true;
            this._regularSugarButton.Click += new System.EventHandler(this.ClickSweetButton);
            // 
            // _quarterSugarButton
            // 
            this._quarterSugarButton.AccessibleName = "quarterSugarButton";
            this._quarterSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._quarterSugarButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._quarterSugarButton.Location = new System.Drawing.Point(3, 88);
            this._quarterSugarButton.Name = "_quarterSugarButton";
            this._quarterSugarButton.Size = new System.Drawing.Size(172, 80);
            this._quarterSugarButton.TabIndex = 2;
            this._quarterSugarButton.Text = "微糖";
            this._quarterSugarButton.UseVisualStyleBackColor = true;
            this._quarterSugarButton.Click += new System.EventHandler(this.ClickSweetButton);
            // 
            // _halfSugarButton
            // 
            this._halfSugarButton.AccessibleName = "halfSugarButton";
            this._halfSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._halfSugarButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._halfSugarButton.Location = new System.Drawing.Point(181, 3);
            this._halfSugarButton.Name = "_halfSugarButton";
            this._halfSugarButton.Size = new System.Drawing.Size(172, 79);
            this._halfSugarButton.TabIndex = 1;
            this._halfSugarButton.Text = "半糖";
            this._halfSugarButton.UseVisualStyleBackColor = true;
            this._halfSugarButton.Click += new System.EventHandler(this.ClickSweetButton);
            // 
            // _orderAndCheckOutTableLayoutPanel
            // 
            this._orderAndCheckOutTableLayoutPanel.ColumnCount = 1;
            this._orderAndCheckOutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._orderAndCheckOutTableLayoutPanel.Controls.Add(this._orderDisplayGroupBox, 0, 0);
            this._orderAndCheckOutTableLayoutPanel.Controls.Add(this._checkOutTableLayoutPanel, 0, 1);
            this._orderAndCheckOutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderAndCheckOutTableLayoutPanel.Location = new System.Drawing.Point(703, 3);
            this._orderAndCheckOutTableLayoutPanel.Name = "_orderAndCheckOutTableLayoutPanel";
            this._orderAndCheckOutTableLayoutPanel.RowCount = 2;
            this._orderAndCheckOutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this._orderAndCheckOutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._orderAndCheckOutTableLayoutPanel.Size = new System.Drawing.Size(464, 595);
            this._orderAndCheckOutTableLayoutPanel.TabIndex = 3;
            // 
            // _orderDisplayGroupBox
            // 
            this._orderDisplayGroupBox.Controls.Add(this._orderDisplayGridView);
            this._orderDisplayGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderDisplayGroupBox.Location = new System.Drawing.Point(3, 3);
            this._orderDisplayGroupBox.Name = "_orderDisplayGroupBox";
            this._orderDisplayGroupBox.Size = new System.Drawing.Size(458, 529);
            this._orderDisplayGroupBox.TabIndex = 2;
            this._orderDisplayGroupBox.TabStop = false;
            this._orderDisplayGroupBox.Text = "點單";
            // 
            // _orderDisplayGridView
            // 
            this._orderDisplayGridView.AccessibleName = "orderDisplay";
            this._orderDisplayGridView.AllowUserToAddRows = false;
            this._orderDisplayGridView.AllowUserToDeleteRows = false;
            this._orderDisplayGridView.AllowUserToResizeColumns = false;
            this._orderDisplayGridView.AllowUserToResizeRows = false;
            this._orderDisplayGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._orderDisplayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._orderDisplayGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._drinkNameAtOrderList,
            this._priceAtOrderList,
            this._sweetLevelAtOrderList,
            this._temperatureAtOrderList,
            this._additionAtOrderList,
            this._deleteOrderedDrinkButton});
            this._orderDisplayGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderDisplayGridView.Location = new System.Drawing.Point(3, 18);
            this._orderDisplayGridView.MultiSelect = false;
            this._orderDisplayGridView.Name = "_orderDisplayGridView";
            this._orderDisplayGridView.ReadOnly = true;
            this._orderDisplayGridView.RowHeadersVisible = false;
            this._orderDisplayGridView.RowTemplate.Height = 24;
            this._orderDisplayGridView.Size = new System.Drawing.Size(452, 508);
            this._orderDisplayGridView.TabIndex = 0;
            this._orderDisplayGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDisplayGridViewCellContentClick);
            this._orderDisplayGridView.SelectionChanged += new System.EventHandler(this.OrderDisplayGridViewSelectionChanged);
            // 
            // _drinkNameAtOrderList
            // 
            this._drinkNameAtOrderList.FillWeight = 20F;
            this._drinkNameAtOrderList.HeaderText = "飲料名稱";
            this._drinkNameAtOrderList.Name = "_drinkNameAtOrderList";
            this._drinkNameAtOrderList.ReadOnly = true;
            this._drinkNameAtOrderList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._drinkNameAtOrderList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _priceAtOrderList
            // 
            this._priceAtOrderList.FillWeight = 8F;
            this._priceAtOrderList.HeaderText = "價格";
            this._priceAtOrderList.Name = "_priceAtOrderList";
            this._priceAtOrderList.ReadOnly = true;
            this._priceAtOrderList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._priceAtOrderList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _sweetLevelAtOrderList
            // 
            this._sweetLevelAtOrderList.FillWeight = 10F;
            this._sweetLevelAtOrderList.HeaderText = "甜度";
            this._sweetLevelAtOrderList.Name = "_sweetLevelAtOrderList";
            this._sweetLevelAtOrderList.ReadOnly = true;
            this._sweetLevelAtOrderList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._sweetLevelAtOrderList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _temperatureAtOrderList
            // 
            this._temperatureAtOrderList.FillWeight = 10F;
            this._temperatureAtOrderList.HeaderText = "溫度";
            this._temperatureAtOrderList.Name = "_temperatureAtOrderList";
            this._temperatureAtOrderList.ReadOnly = true;
            this._temperatureAtOrderList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._temperatureAtOrderList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _additionAtOrderList
            // 
            this._additionAtOrderList.FillWeight = 22F;
            this._additionAtOrderList.HeaderText = "加料";
            this._additionAtOrderList.Name = "_additionAtOrderList";
            this._additionAtOrderList.ReadOnly = true;
            this._additionAtOrderList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._additionAtOrderList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _deleteOrderedDrinkButton
            // 
            this._deleteOrderedDrinkButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._deleteOrderedDrinkButton.FillWeight = 10F;
            this._deleteOrderedDrinkButton.HeaderText = "";
            this._deleteOrderedDrinkButton.Name = "_deleteOrderedDrinkButton";
            this._deleteOrderedDrinkButton.ReadOnly = true;
            this._deleteOrderedDrinkButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._deleteOrderedDrinkButton.Text = "刪除";
            this._deleteOrderedDrinkButton.Width = 50;
            // 
            // _checkOutTableLayoutPanel
            // 
            this._checkOutTableLayoutPanel.ColumnCount = 3;
            this._checkOutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this._checkOutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._checkOutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._checkOutTableLayoutPanel.Controls.Add(this._checkOutButton, 2, 0);
            this._checkOutTableLayoutPanel.Controls.Add(this._checkOutLabel, 0, 0);
            this._checkOutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._checkOutTableLayoutPanel.Location = new System.Drawing.Point(3, 538);
            this._checkOutTableLayoutPanel.Name = "_checkOutTableLayoutPanel";
            this._checkOutTableLayoutPanel.RowCount = 1;
            this._checkOutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._checkOutTableLayoutPanel.Size = new System.Drawing.Size(458, 54);
            this._checkOutTableLayoutPanel.TabIndex = 3;
            // 
            // _checkOutButton
            // 
            this._checkOutButton.AccessibleName = "checkOutButton";
            this._checkOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._checkOutButton.Enabled = false;
            this._checkOutButton.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._checkOutButton.Location = new System.Drawing.Point(299, 3);
            this._checkOutButton.Name = "_checkOutButton";
            this._checkOutButton.Size = new System.Drawing.Size(156, 48);
            this._checkOutButton.TabIndex = 2;
            this._checkOutButton.Text = "結帳";
            this._checkOutButton.UseVisualStyleBackColor = true;
            this._checkOutButton.Click += new System.EventHandler(this.CheckOutButtonClick);
            // 
            // _checkOutLabel
            // 
            this._checkOutLabel.AutoSize = true;
            this._checkOutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._checkOutLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._checkOutLabel.Location = new System.Drawing.Point(3, 0);
            this._checkOutLabel.Name = "_checkOutLabel";
            this._checkOutLabel.Size = new System.Drawing.Size(245, 54);
            this._checkOutLabel.TabIndex = 1;
            this._checkOutLabel.Text = "總價:";
            this._checkOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _myMainTab
            // 
            this._myMainTab.Controls.Add(this._orderSystemTabPage);
            this._myMainTab.Controls.Add(this._backStageTab);
            this._myMainTab.Controls.Add(this._historyTab);
            this._myMainTab.Cursor = System.Windows.Forms.Cursors.Default;
            this._myMainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this._myMainTab.Location = new System.Drawing.Point(0, 28);
            this._myMainTab.Name = "_myMainTab";
            this._myMainTab.SelectedIndex = 0;
            this._myMainTab.Size = new System.Drawing.Size(1184, 633);
            this._myMainTab.TabIndex = 1;
            // 
            // _backStageTab
            // 
            this._backStageTab.Controls.Add(this._backStageMainTableLayoutPanel);
            this._backStageTab.Location = new System.Drawing.Point(4, 22);
            this._backStageTab.Name = "_backStageTab";
            this._backStageTab.Padding = new System.Windows.Forms.Padding(3);
            this._backStageTab.Size = new System.Drawing.Size(1176, 607);
            this._backStageTab.TabIndex = 1;
            this._backStageTab.Text = "後台管理";
            this._backStageTab.UseVisualStyleBackColor = true;
            // 
            // _backStageMainTableLayoutPanel
            // 
            this._backStageMainTableLayoutPanel.ColumnCount = 5;
            this._backStageMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._backStageMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._backStageMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._backStageMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._backStageMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._backStageMainTableLayoutPanel.Controls.Add(this._backStageOperationTableLayoutPanel, 2, 0);
            this._backStageMainTableLayoutPanel.Controls.Add(this._editDrinkListGroupBox, 0, 0);
            this._backStageMainTableLayoutPanel.Controls.Add(this._editDrinkAdditionListGroupBox, 4, 0);
            this._backStageMainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backStageMainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._backStageMainTableLayoutPanel.Name = "_backStageMainTableLayoutPanel";
            this._backStageMainTableLayoutPanel.RowCount = 1;
            this._backStageMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._backStageMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 601F));
            this._backStageMainTableLayoutPanel.Size = new System.Drawing.Size(1170, 601);
            this._backStageMainTableLayoutPanel.TabIndex = 0;
            // 
            // _backStageOperationTableLayoutPanel
            // 
            this._backStageOperationTableLayoutPanel.ColumnCount = 1;
            this._backStageOperationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._backStageOperationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._backStageOperationTableLayoutPanel.Controls.Add(this._drinkListOperationGroupBox, 0, 0);
            this._backStageOperationTableLayoutPanel.Controls.Add(this._drinkAdditionOperationGroupBox, 0, 1);
            this._backStageOperationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backStageOperationTableLayoutPanel.Location = new System.Drawing.Point(412, 3);
            this._backStageOperationTableLayoutPanel.Name = "_backStageOperationTableLayoutPanel";
            this._backStageOperationTableLayoutPanel.RowCount = 2;
            this._backStageOperationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._backStageOperationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._backStageOperationTableLayoutPanel.Size = new System.Drawing.Size(345, 595);
            this._backStageOperationTableLayoutPanel.TabIndex = 0;
            // 
            // _drinkListOperationGroupBox
            // 
            this._drinkListOperationGroupBox.Controls.Add(this._backStageDrinkEditTableLayoutPanel);
            this._drinkListOperationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkListOperationGroupBox.Location = new System.Drawing.Point(3, 3);
            this._drinkListOperationGroupBox.Name = "_drinkListOperationGroupBox";
            this._drinkListOperationGroupBox.Size = new System.Drawing.Size(339, 291);
            this._drinkListOperationGroupBox.TabIndex = 2;
            this._drinkListOperationGroupBox.TabStop = false;
            this._drinkListOperationGroupBox.Text = "飲料清單操作";
            // 
            // _backStageDrinkEditTableLayoutPanel
            // 
            this._backStageDrinkEditTableLayoutPanel.ColumnCount = 2;
            this._backStageDrinkEditTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._backStageDrinkEditTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._backStageDrinkEditTableLayoutPanel.Controls.Add(this._drinkListOperationButton, 0, 0);
            this._backStageDrinkEditTableLayoutPanel.Controls.Add(this._openDrinkListFileButton, 1, 0);
            this._backStageDrinkEditTableLayoutPanel.Controls.Add(this._drinkNameLabel, 0, 2);
            this._backStageDrinkEditTableLayoutPanel.Controls.Add(this._drinkPriceLabel, 0, 4);
            this._backStageDrinkEditTableLayoutPanel.Controls.Add(this._drinkNameTextBox, 1, 2);
            this._backStageDrinkEditTableLayoutPanel.Controls.Add(this._drinkPriceTextBox, 1, 4);
            this._backStageDrinkEditTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backStageDrinkEditTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._backStageDrinkEditTableLayoutPanel.Name = "_backStageDrinkEditTableLayoutPanel";
            this._backStageDrinkEditTableLayoutPanel.RowCount = 5;
            this._backStageDrinkEditTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._backStageDrinkEditTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._backStageDrinkEditTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._backStageDrinkEditTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.814815F));
            this._backStageDrinkEditTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.62963F));
            this._backStageDrinkEditTableLayoutPanel.Size = new System.Drawing.Size(333, 270);
            this._backStageDrinkEditTableLayoutPanel.TabIndex = 0;
            // 
            // _drinkListOperationButton
            // 
            this._drinkListOperationButton.AccessibleName = "drinkListOperationButton";
            this._drinkListOperationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkListOperationButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkListOperationButton.Location = new System.Drawing.Point(3, 3);
            this._drinkListOperationButton.Name = "_drinkListOperationButton";
            this._drinkListOperationButton.Size = new System.Drawing.Size(160, 75);
            this._drinkListOperationButton.TabIndex = 0;
            this._drinkListOperationButton.Text = "新增";
            this._drinkListOperationButton.UseVisualStyleBackColor = true;
            this._drinkListOperationButton.Click += new System.EventHandler(this.DrinkListOperationButtonClick);
            // 
            // _openDrinkListFileButton
            // 
            this._openDrinkListFileButton.AccessibleName = "openDrinkListFileButton";
            this._openDrinkListFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._openDrinkListFileButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._openDrinkListFileButton.Location = new System.Drawing.Point(169, 3);
            this._openDrinkListFileButton.Name = "_openDrinkListFileButton";
            this._openDrinkListFileButton.Size = new System.Drawing.Size(161, 75);
            this._openDrinkListFileButton.TabIndex = 1;
            this._openDrinkListFileButton.Text = "從檔案匯入";
            this._openDrinkListFileButton.UseVisualStyleBackColor = true;
            this._openDrinkListFileButton.Click += new System.EventHandler(this.OpenDrinkListFileButtonClick);
            // 
            // _drinkNameLabel
            // 
            this._drinkNameLabel.AutoSize = true;
            this._drinkNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkNameLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkNameLabel.Location = new System.Drawing.Point(3, 94);
            this._drinkNameLabel.Name = "_drinkNameLabel";
            this._drinkNameLabel.Size = new System.Drawing.Size(160, 81);
            this._drinkNameLabel.TabIndex = 2;
            this._drinkNameLabel.Text = "飲料名稱:";
            this._drinkNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _drinkPriceLabel
            // 
            this._drinkPriceLabel.AutoSize = true;
            this._drinkPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkPriceLabel.Location = new System.Drawing.Point(3, 188);
            this._drinkPriceLabel.Name = "_drinkPriceLabel";
            this._drinkPriceLabel.Size = new System.Drawing.Size(160, 82);
            this._drinkPriceLabel.TabIndex = 3;
            this._drinkPriceLabel.Text = "價格:";
            this._drinkPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _drinkNameTextBox
            // 
            this._drinkNameTextBox.AccessibleName = "drinkNameTextBox";
            this._drinkNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkNameTextBox.Enabled = false;
            this._drinkNameTextBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkNameTextBox.Location = new System.Drawing.Point(169, 118);
            this._drinkNameTextBox.Name = "_drinkNameTextBox";
            this._drinkNameTextBox.Size = new System.Drawing.Size(161, 33);
            this._drinkNameTextBox.TabIndex = 4;
            // 
            // _drinkPriceTextBox
            // 
            this._drinkPriceTextBox.AccessibleName = "drinkPriceTextBox";
            this._drinkPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkPriceTextBox.Enabled = false;
            this._drinkPriceTextBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkPriceTextBox.Location = new System.Drawing.Point(169, 212);
            this._drinkPriceTextBox.Name = "_drinkPriceTextBox";
            this._drinkPriceTextBox.Size = new System.Drawing.Size(161, 33);
            this._drinkPriceTextBox.TabIndex = 5;
            this._drinkPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrinkPriceTextBoxKeyPress);
            // 
            // _drinkAdditionOperationGroupBox
            // 
            this._drinkAdditionOperationGroupBox.Controls.Add(this._backStageDrinkAdditionEditTableLayoutPanel);
            this._drinkAdditionOperationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkAdditionOperationGroupBox.Location = new System.Drawing.Point(3, 300);
            this._drinkAdditionOperationGroupBox.Name = "_drinkAdditionOperationGroupBox";
            this._drinkAdditionOperationGroupBox.Size = new System.Drawing.Size(339, 292);
            this._drinkAdditionOperationGroupBox.TabIndex = 3;
            this._drinkAdditionOperationGroupBox.TabStop = false;
            this._drinkAdditionOperationGroupBox.Text = "加料清單操作";
            // 
            // _backStageDrinkAdditionEditTableLayoutPanel
            // 
            this._backStageDrinkAdditionEditTableLayoutPanel.ColumnCount = 2;
            this._backStageDrinkAdditionEditTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._backStageDrinkAdditionEditTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._backStageDrinkAdditionEditTableLayoutPanel.Controls.Add(this._drinkAdditionNameTextBox, 1, 2);
            this._backStageDrinkAdditionEditTableLayoutPanel.Controls.Add(this._openDrinkAdditionListButton, 1, 0);
            this._backStageDrinkAdditionEditTableLayoutPanel.Controls.Add(this._drinkAdditionListOperationButton, 0, 0);
            this._backStageDrinkAdditionEditTableLayoutPanel.Controls.Add(this._drinkAdditionNameLabel, 0, 2);
            this._backStageDrinkAdditionEditTableLayoutPanel.Controls.Add(this._drinkAdditionPriceLabel, 0, 4);
            this._backStageDrinkAdditionEditTableLayoutPanel.Controls.Add(this._drinkAdditionPriceTextBox, 1, 4);
            this._backStageDrinkAdditionEditTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backStageDrinkAdditionEditTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._backStageDrinkAdditionEditTableLayoutPanel.Name = "_backStageDrinkAdditionEditTableLayoutPanel";
            this._backStageDrinkAdditionEditTableLayoutPanel.RowCount = 5;
            this._backStageDrinkAdditionEditTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._backStageDrinkAdditionEditTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._backStageDrinkAdditionEditTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._backStageDrinkAdditionEditTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._backStageDrinkAdditionEditTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._backStageDrinkAdditionEditTableLayoutPanel.Size = new System.Drawing.Size(333, 271);
            this._backStageDrinkAdditionEditTableLayoutPanel.TabIndex = 1;
            // 
            // _drinkAdditionNameTextBox
            // 
            this._drinkAdditionNameTextBox.AccessibleName = "drinkAdditionNameTextBox";
            this._drinkAdditionNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkAdditionNameTextBox.Enabled = false;
            this._drinkAdditionNameTextBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkAdditionNameTextBox.Location = new System.Drawing.Point(169, 118);
            this._drinkAdditionNameTextBox.Name = "_drinkAdditionNameTextBox";
            this._drinkAdditionNameTextBox.Size = new System.Drawing.Size(161, 33);
            this._drinkAdditionNameTextBox.TabIndex = 6;
            // 
            // _openDrinkAdditionListButton
            // 
            this._openDrinkAdditionListButton.AccessibleName = "openDrinkAdditionListButton";
            this._openDrinkAdditionListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._openDrinkAdditionListButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._openDrinkAdditionListButton.Location = new System.Drawing.Point(169, 3);
            this._openDrinkAdditionListButton.Name = "_openDrinkAdditionListButton";
            this._openDrinkAdditionListButton.Size = new System.Drawing.Size(161, 75);
            this._openDrinkAdditionListButton.TabIndex = 2;
            this._openDrinkAdditionListButton.Text = "從檔案匯入";
            this._openDrinkAdditionListButton.UseVisualStyleBackColor = true;
            this._openDrinkAdditionListButton.Click += new System.EventHandler(this.OpenDrinkAdditionListButtonClick);
            // 
            // _drinkAdditionListOperationButton
            // 
            this._drinkAdditionListOperationButton.AccessibleName = "drinkAdditionListOperationButton";
            this._drinkAdditionListOperationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkAdditionListOperationButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkAdditionListOperationButton.Location = new System.Drawing.Point(3, 3);
            this._drinkAdditionListOperationButton.Name = "_drinkAdditionListOperationButton";
            this._drinkAdditionListOperationButton.Size = new System.Drawing.Size(160, 75);
            this._drinkAdditionListOperationButton.TabIndex = 2;
            this._drinkAdditionListOperationButton.Text = "新增";
            this._drinkAdditionListOperationButton.UseVisualStyleBackColor = true;
            this._drinkAdditionListOperationButton.Click += new System.EventHandler(this.DrinkAdditionListOperationButtonClick);
            // 
            // _drinkAdditionNameLabel
            // 
            this._drinkAdditionNameLabel.AutoSize = true;
            this._drinkAdditionNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkAdditionNameLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkAdditionNameLabel.Location = new System.Drawing.Point(3, 94);
            this._drinkAdditionNameLabel.Name = "_drinkAdditionNameLabel";
            this._drinkAdditionNameLabel.Size = new System.Drawing.Size(160, 81);
            this._drinkAdditionNameLabel.TabIndex = 3;
            this._drinkAdditionNameLabel.Text = "加料名稱:";
            this._drinkAdditionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _drinkAdditionPriceLabel
            // 
            this._drinkAdditionPriceLabel.AutoSize = true;
            this._drinkAdditionPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkAdditionPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkAdditionPriceLabel.Location = new System.Drawing.Point(3, 188);
            this._drinkAdditionPriceLabel.Name = "_drinkAdditionPriceLabel";
            this._drinkAdditionPriceLabel.Size = new System.Drawing.Size(160, 83);
            this._drinkAdditionPriceLabel.TabIndex = 4;
            this._drinkAdditionPriceLabel.Text = "價格:";
            this._drinkAdditionPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _drinkAdditionPriceTextBox
            // 
            this._drinkAdditionPriceTextBox.AccessibleName = "drinkAdditionPriceTextBox";
            this._drinkAdditionPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkAdditionPriceTextBox.Enabled = false;
            this._drinkAdditionPriceTextBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkAdditionPriceTextBox.Location = new System.Drawing.Point(169, 213);
            this._drinkAdditionPriceTextBox.Name = "_drinkAdditionPriceTextBox";
            this._drinkAdditionPriceTextBox.Size = new System.Drawing.Size(161, 33);
            this._drinkAdditionPriceTextBox.TabIndex = 7;
            this._drinkAdditionPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrinkAdditionPriceTextBoxKeyPress);
            // 
            // _editDrinkListGroupBox
            // 
            this._editDrinkListGroupBox.Controls.Add(this._backStageDrinkListDataGridView);
            this._editDrinkListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editDrinkListGroupBox.Location = new System.Drawing.Point(3, 3);
            this._editDrinkListGroupBox.Name = "_editDrinkListGroupBox";
            this._editDrinkListGroupBox.Size = new System.Drawing.Size(345, 595);
            this._editDrinkListGroupBox.TabIndex = 1;
            this._editDrinkListGroupBox.TabStop = false;
            this._editDrinkListGroupBox.Text = "飲料清單";
            // 
            // _backStageDrinkListDataGridView
            // 
            this._backStageDrinkListDataGridView.AccessibleName = "backStageDrinkListDataGridView";
            this._backStageDrinkListDataGridView.AllowUserToAddRows = false;
            this._backStageDrinkListDataGridView.AllowUserToDeleteRows = false;
            this._backStageDrinkListDataGridView.AllowUserToResizeColumns = false;
            this._backStageDrinkListDataGridView.AllowUserToResizeRows = false;
            this._backStageDrinkListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._backStageDrinkListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._buttonOnEditDrinkList,
            this._drinkNameOnEditDrinkList,
            this._drinkPriceOnEditDrinkList});
            this._backStageDrinkListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backStageDrinkListDataGridView.Location = new System.Drawing.Point(3, 18);
            this._backStageDrinkListDataGridView.Name = "_backStageDrinkListDataGridView";
            this._backStageDrinkListDataGridView.RowHeadersVisible = false;
            this._backStageDrinkListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._backStageDrinkListDataGridView.RowTemplate.Height = 24;
            this._backStageDrinkListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._backStageDrinkListDataGridView.Size = new System.Drawing.Size(339, 574);
            this._backStageDrinkListDataGridView.TabIndex = 0;
            this._backStageDrinkListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BackStageDrinkListDataGridViewCellContentClick);
            this._backStageDrinkListDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BackStageDrinkListDataGridViewCellContentChanged);
            // 
            // _buttonOnEditDrinkList
            // 
            this._buttonOnEditDrinkList.HeaderText = "";
            this._buttonOnEditDrinkList.Name = "_buttonOnEditDrinkList";
            this._buttonOnEditDrinkList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._buttonOnEditDrinkList.Text = "刪除";
            this._buttonOnEditDrinkList.UseColumnTextForButtonValue = true;
            this._buttonOnEditDrinkList.Width = 50;
            // 
            // _drinkNameOnEditDrinkList
            // 
            this._drinkNameOnEditDrinkList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._drinkNameOnEditDrinkList.FillWeight = 80F;
            this._drinkNameOnEditDrinkList.HeaderText = "飲料名稱";
            this._drinkNameOnEditDrinkList.Name = "_drinkNameOnEditDrinkList";
            this._drinkNameOnEditDrinkList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._drinkNameOnEditDrinkList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _drinkPriceOnEditDrinkList
            // 
            this._drinkPriceOnEditDrinkList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._drinkPriceOnEditDrinkList.FillWeight = 20F;
            this._drinkPriceOnEditDrinkList.HeaderText = "價格";
            this._drinkPriceOnEditDrinkList.Name = "_drinkPriceOnEditDrinkList";
            this._drinkPriceOnEditDrinkList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._drinkPriceOnEditDrinkList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _editDrinkAdditionListGroupBox
            // 
            this._editDrinkAdditionListGroupBox.Controls.Add(this._backStageDrinkAdditionListDataGridView);
            this._editDrinkAdditionListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editDrinkAdditionListGroupBox.Location = new System.Drawing.Point(821, 3);
            this._editDrinkAdditionListGroupBox.Name = "_editDrinkAdditionListGroupBox";
            this._editDrinkAdditionListGroupBox.Size = new System.Drawing.Size(346, 595);
            this._editDrinkAdditionListGroupBox.TabIndex = 2;
            this._editDrinkAdditionListGroupBox.TabStop = false;
            this._editDrinkAdditionListGroupBox.Text = "加料清單";
            // 
            // _backStageDrinkAdditionListDataGridView
            // 
            this._backStageDrinkAdditionListDataGridView.AccessibleName = "backStageDrinkAdditionListDataGridView";
            this._backStageDrinkAdditionListDataGridView.AllowUserToAddRows = false;
            this._backStageDrinkAdditionListDataGridView.AllowUserToDeleteRows = false;
            this._backStageDrinkAdditionListDataGridView.AllowUserToResizeColumns = false;
            this._backStageDrinkAdditionListDataGridView.AllowUserToResizeRows = false;
            this._backStageDrinkAdditionListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._backStageDrinkAdditionListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._buttonOnEditDrinkAdditionList,
            this._editDrinkAdditionName,
            this._editDrinkAdditionPrice});
            this._backStageDrinkAdditionListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backStageDrinkAdditionListDataGridView.Location = new System.Drawing.Point(3, 18);
            this._backStageDrinkAdditionListDataGridView.MultiSelect = false;
            this._backStageDrinkAdditionListDataGridView.Name = "_backStageDrinkAdditionListDataGridView";
            this._backStageDrinkAdditionListDataGridView.RowHeadersVisible = false;
            this._backStageDrinkAdditionListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._backStageDrinkAdditionListDataGridView.RowTemplate.Height = 24;
            this._backStageDrinkAdditionListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._backStageDrinkAdditionListDataGridView.Size = new System.Drawing.Size(340, 574);
            this._backStageDrinkAdditionListDataGridView.TabIndex = 0;
            this._backStageDrinkAdditionListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BackStageDrinkAdditionListDataGridViewCellContentClick);
            this._backStageDrinkAdditionListDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BackStageDrinkAdditionDataGridViewCellContentChanged);
            // 
            // _buttonOnEditDrinkAdditionList
            // 
            this._buttonOnEditDrinkAdditionList.HeaderText = "";
            this._buttonOnEditDrinkAdditionList.Name = "_buttonOnEditDrinkAdditionList";
            this._buttonOnEditDrinkAdditionList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._buttonOnEditDrinkAdditionList.Text = "刪除";
            this._buttonOnEditDrinkAdditionList.UseColumnTextForButtonValue = true;
            this._buttonOnEditDrinkAdditionList.Width = 50;
            // 
            // _editDrinkAdditionName
            // 
            this._editDrinkAdditionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._editDrinkAdditionName.FillWeight = 80F;
            this._editDrinkAdditionName.HeaderText = "名稱";
            this._editDrinkAdditionName.Name = "_editDrinkAdditionName";
            this._editDrinkAdditionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _editDrinkAdditionPrice
            // 
            this._editDrinkAdditionPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._editDrinkAdditionPrice.FillWeight = 20F;
            this._editDrinkAdditionPrice.HeaderText = "價格";
            this._editDrinkAdditionPrice.Name = "_editDrinkAdditionPrice";
            this._editDrinkAdditionPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _historyTab
            // 
            this._historyTab.Controls.Add(this._historyTableLayoutPanel);
            this._historyTab.Location = new System.Drawing.Point(4, 22);
            this._historyTab.Name = "_historyTab";
            this._historyTab.Padding = new System.Windows.Forms.Padding(3);
            this._historyTab.Size = new System.Drawing.Size(1176, 607);
            this._historyTab.TabIndex = 2;
            this._historyTab.Text = "歷史紀錄";
            this._historyTab.UseVisualStyleBackColor = true;
            // 
            // _historyTableLayoutPanel
            // 
            this._historyTableLayoutPanel.ColumnCount = 5;
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333F));
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333F));
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333F));
            this._historyTableLayoutPanel.Controls.Add(this._historyDetailTableLayoutPanel, 3, 0);
            this._historyTableLayoutPanel.Controls.Add(this._historyGroupBox, 1, 0);
            this._historyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._historyTableLayoutPanel.Name = "_historyTableLayoutPanel";
            this._historyTableLayoutPanel.RowCount = 1;
            this._historyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._historyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 601F));
            this._historyTableLayoutPanel.Size = new System.Drawing.Size(1170, 601);
            this._historyTableLayoutPanel.TabIndex = 0;
            // 
            // _historyDetailTableLayoutPanel
            // 
            this._historyDetailTableLayoutPanel.ColumnCount = 1;
            this._historyDetailTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._historyDetailTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._historyDetailTableLayoutPanel.Controls.Add(this._historyPriceLabel, 0, 1);
            this._historyDetailTableLayoutPanel.Controls.Add(this._historyDetailGroupBox, 0, 0);
            this._historyDetailTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyDetailTableLayoutPanel.Location = new System.Drawing.Point(605, 3);
            this._historyDetailTableLayoutPanel.Name = "_historyDetailTableLayoutPanel";
            this._historyDetailTableLayoutPanel.RowCount = 2;
            this._historyDetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this._historyDetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._historyDetailTableLayoutPanel.Size = new System.Drawing.Size(520, 595);
            this._historyDetailTableLayoutPanel.TabIndex = 0;
            // 
            // _historyPriceLabel
            // 
            this._historyPriceLabel.AccessibleName = "historyPriceLabel";
            this._historyPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._historyPriceLabel.AutoSize = true;
            this._historyPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._historyPriceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._historyPriceLabel.Location = new System.Drawing.Point(3, 547);
            this._historyPriceLabel.Name = "_historyPriceLabel";
            this._historyPriceLabel.Size = new System.Drawing.Size(514, 35);
            this._historyPriceLabel.TabIndex = 1;
            this._historyPriceLabel.Text = "總價: 元";
            this._historyPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _historyDetailGroupBox
            // 
            this._historyDetailGroupBox.Controls.Add(this._historyDetailDataGridView);
            this._historyDetailGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyDetailGroupBox.Location = new System.Drawing.Point(3, 3);
            this._historyDetailGroupBox.Name = "_historyDetailGroupBox";
            this._historyDetailGroupBox.Size = new System.Drawing.Size(514, 529);
            this._historyDetailGroupBox.TabIndex = 2;
            this._historyDetailGroupBox.TabStop = false;
            this._historyDetailGroupBox.Text = "詳細";
            // 
            // _historyDetailDataGridView
            // 
            this._historyDetailDataGridView.AccessibleName = "historyDetailDataGridView";
            this._historyDetailDataGridView.AllowUserToAddRows = false;
            this._historyDetailDataGridView.AllowUserToDeleteRows = false;
            this._historyDetailDataGridView.AllowUserToResizeColumns = false;
            this._historyDetailDataGridView.AllowUserToResizeRows = false;
            this._historyDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._historyDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._historyDrinkName,
            this._historyDrinkPrice,
            this._historySweet,
            this._historyTemperature,
            this._historyAddition});
            this._historyDetailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyDetailDataGridView.Location = new System.Drawing.Point(3, 18);
            this._historyDetailDataGridView.Name = "_historyDetailDataGridView";
            this._historyDetailDataGridView.ReadOnly = true;
            this._historyDetailDataGridView.RowHeadersVisible = false;
            this._historyDetailDataGridView.RowTemplate.Height = 24;
            this._historyDetailDataGridView.Size = new System.Drawing.Size(508, 508);
            this._historyDetailDataGridView.TabIndex = 0;
            // 
            // _historyDrinkName
            // 
            this._historyDrinkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._historyDrinkName.FillWeight = 20F;
            this._historyDrinkName.HeaderText = "飲料名稱";
            this._historyDrinkName.Name = "_historyDrinkName";
            this._historyDrinkName.ReadOnly = true;
            this._historyDrinkName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._historyDrinkName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _historyDrinkPrice
            // 
            this._historyDrinkPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._historyDrinkPrice.FillWeight = 8F;
            this._historyDrinkPrice.HeaderText = "價格";
            this._historyDrinkPrice.Name = "_historyDrinkPrice";
            this._historyDrinkPrice.ReadOnly = true;
            this._historyDrinkPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._historyDrinkPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _historySweet
            // 
            this._historySweet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._historySweet.FillWeight = 10F;
            this._historySweet.HeaderText = "甜度";
            this._historySweet.Name = "_historySweet";
            this._historySweet.ReadOnly = true;
            this._historySweet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._historySweet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _historyTemperature
            // 
            this._historyTemperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._historyTemperature.FillWeight = 10F;
            this._historyTemperature.HeaderText = "溫度";
            this._historyTemperature.Name = "_historyTemperature";
            this._historyTemperature.ReadOnly = true;
            this._historyTemperature.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._historyTemperature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _historyAddition
            // 
            this._historyAddition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._historyAddition.FillWeight = 32F;
            this._historyAddition.HeaderText = "加料";
            this._historyAddition.Name = "_historyAddition";
            this._historyAddition.ReadOnly = true;
            this._historyAddition.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._historyAddition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _historyGroupBox
            // 
            this._historyGroupBox.Controls.Add(this._historyDataGridView);
            this._historyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyGroupBox.Location = new System.Drawing.Point(41, 3);
            this._historyGroupBox.Name = "_historyGroupBox";
            this._historyGroupBox.Size = new System.Drawing.Size(520, 595);
            this._historyGroupBox.TabIndex = 1;
            this._historyGroupBox.TabStop = false;
            this._historyGroupBox.Text = "歷史";
            // 
            // _historyDataGridView
            // 
            this._historyDataGridView.AccessibleName = "historyDataGridView";
            this._historyDataGridView.AllowUserToAddRows = false;
            this._historyDataGridView.AllowUserToDeleteRows = false;
            this._historyDataGridView.AllowUserToResizeColumns = false;
            this._historyDataGridView.AllowUserToResizeRows = false;
            this._historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._historyPrice,
            this._historyTime});
            this._historyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyDataGridView.Location = new System.Drawing.Point(3, 18);
            this._historyDataGridView.MultiSelect = false;
            this._historyDataGridView.Name = "_historyDataGridView";
            this._historyDataGridView.ReadOnly = true;
            this._historyDataGridView.RowHeadersVisible = false;
            this._historyDataGridView.RowTemplate.Height = 24;
            this._historyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._historyDataGridView.Size = new System.Drawing.Size(514, 574);
            this._historyDataGridView.TabIndex = 0;
            this._historyDataGridView.SelectionChanged += new System.EventHandler(this.ChangeHistoryDataGridViewSelectionChanged);
            // 
            // _historyPrice
            // 
            this._historyPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._historyPrice.FillWeight = 80F;
            this._historyPrice.HeaderText = "時間";
            this._historyPrice.Name = "_historyPrice";
            this._historyPrice.ReadOnly = true;
            this._historyPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._historyPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _historyTime
            // 
            this._historyTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._historyTime.FillWeight = 20F;
            this._historyTime.HeaderText = "總價";
            this._historyTime.Name = "_historyTime";
            this._historyTime.ReadOnly = true;
            this._historyTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._historyTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EzDrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this._myMainTab);
            this.Controls.Add(this._myMenuStrip);
            this.MainMenuStrip = this._myMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "EzDrinkForm";
            this.Text = "EzDrink";
            this._myMenuStrip.ResumeLayout(false);
            this._myMenuStrip.PerformLayout();
            this._orderSystemTabPage.ResumeLayout(false);
            this._ezDrinkMainTableLayoutPanel.ResumeLayout(false);
            this._orderSystemGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkGridView)).EndInit();
            this._additionTableLayoutPanel.ResumeLayout(false);
            this._drinkAdditionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditionGridView)).EndInit();
            this._temperatureGroupBox.ResumeLayout(false);
            this._iceButtonTableLayoutPanel.ResumeLayout(false);
            this._sweetLevelGroupBox.ResumeLayout(false);
            this._sweetLevelButtonTableLayoutPanel.ResumeLayout(false);
            this._orderAndCheckOutTableLayoutPanel.ResumeLayout(false);
            this._orderDisplayGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._orderDisplayGridView)).EndInit();
            this._checkOutTableLayoutPanel.ResumeLayout(false);
            this._checkOutTableLayoutPanel.PerformLayout();
            this._myMainTab.ResumeLayout(false);
            this._backStageTab.ResumeLayout(false);
            this._backStageMainTableLayoutPanel.ResumeLayout(false);
            this._backStageOperationTableLayoutPanel.ResumeLayout(false);
            this._drinkListOperationGroupBox.ResumeLayout(false);
            this._backStageDrinkEditTableLayoutPanel.ResumeLayout(false);
            this._backStageDrinkEditTableLayoutPanel.PerformLayout();
            this._drinkAdditionOperationGroupBox.ResumeLayout(false);
            this._backStageDrinkAdditionEditTableLayoutPanel.ResumeLayout(false);
            this._backStageDrinkAdditionEditTableLayoutPanel.PerformLayout();
            this._editDrinkListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._backStageDrinkListDataGridView)).EndInit();
            this._editDrinkAdditionListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._backStageDrinkAdditionListDataGridView)).EndInit();
            this._historyTab.ResumeLayout(false);
            this._historyTableLayoutPanel.ResumeLayout(false);
            this._historyDetailTableLayoutPanel.ResumeLayout(false);
            this._historyDetailTableLayoutPanel.PerformLayout();
            this._historyDetailGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._historyDetailDataGridView)).EndInit();
            this._historyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._historyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _myMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _myToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.TabPage _orderSystemTabPage;
        private System.Windows.Forms.TabControl _myMainTab;
        private System.Windows.Forms.GroupBox _orderDisplayGroupBox;
        private System.Windows.Forms.GroupBox _orderSystemGroupBox;
        private System.Windows.Forms.GroupBox _drinkAdditionGroupBox;
        private System.Windows.Forms.GroupBox _temperatureGroupBox;
        private System.Windows.Forms.GroupBox _sweetLevelGroupBox;
        private System.Windows.Forms.DataGridView _drinkAdditionGridView;
        private System.Windows.Forms.Button _sugarFreeButton;
        private System.Windows.Forms.Button _quarterSugarButton;
        private System.Windows.Forms.Button _halfSugarButton;
        private System.Windows.Forms.Button _regularSugarButton;
        private System.Windows.Forms.Label _checkOutLabel;
        private System.Windows.Forms.Button _checkOutButton;
        private System.Windows.Forms.Button _easyIceButton;
        private System.Windows.Forms.Button _warmTemperatureButton;
        private System.Windows.Forms.Button _regularIceButton;
        private System.Windows.Forms.Button _iceFreeButton;
        private System.Windows.Forms.TableLayoutPanel _ezDrinkMainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _additionTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _orderAndCheckOutTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _checkOutTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _sweetLevelButtonTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _iceButtonTableLayoutPanel;
        private DataGridViewButtonColumn _drinkSelectButton;
        private DataGridViewTextBoxColumn _name;
        private DataGridViewTextBoxColumn _price;
        private DataGridViewTextBoxColumn _drinkNameAtOrderList;
        private DataGridViewTextBoxColumn _priceAtOrderList;
        private DataGridViewTextBoxColumn _sweetLevelAtOrderList;
        private DataGridViewTextBoxColumn _temperatureAtOrderList;
        private DataGridViewTextBoxColumn _additionAtOrderList;
        private DataGridViewButtonColumn _deleteOrderedDrinkButton;
        private DataGridViewDisableButtonColumn _additionSelectButton;
        private DataGridViewTextBoxColumn _additionName;
        private DataGridViewTextBoxColumn _additionPrice;
        private TabPage _backStageTab;
        private TableLayoutPanel _backStageMainTableLayoutPanel;
        private TableLayoutPanel _backStageOperationTableLayoutPanel;
        private TableLayoutPanel _backStageDrinkEditTableLayoutPanel;
        private TableLayoutPanel _backStageDrinkAdditionEditTableLayoutPanel;
        private GroupBox _drinkListOperationGroupBox;
        private GroupBox _drinkAdditionOperationGroupBox;
        private GroupBox _editDrinkListGroupBox;
        private GroupBox _editDrinkAdditionListGroupBox;
        private DataGridView _backStageDrinkListDataGridView;
        private DataGridView _backStageDrinkAdditionListDataGridView;
        private DataGridViewButtonColumn _buttonOnEditDrinkList;
        private DataGridViewTextBoxColumn _drinkNameOnEditDrinkList;
        private DataGridViewTextBoxColumn _drinkPriceOnEditDrinkList;
        private DataGridViewButtonColumn _buttonOnEditDrinkAdditionList;
        private DataGridViewTextBoxColumn _editDrinkAdditionName;
        private DataGridViewTextBoxColumn _editDrinkAdditionPrice;
        private Button _drinkListOperationButton;
        private Button _openDrinkListFileButton;
        private Label _drinkNameLabel;
        private Label _drinkPriceLabel;
        private TextBox _drinkNameTextBox;
        private TextBox _drinkPriceTextBox;
        private TextBox _drinkAdditionNameTextBox;
        private Button _openDrinkAdditionListButton;
        private Button _drinkAdditionListOperationButton;
        private Label _drinkAdditionNameLabel;
        private Label _drinkAdditionPriceLabel;
        private TextBox _drinkAdditionPriceTextBox;
        private ToolStripMenuItem _helpToolStripMenuItem;
        private ToolStripMenuItem _aboutToolStripMenuItem;
        private DataGridView _orderDisplayGridView;
        private TabPage _historyTab;
        private DataGridView _drinkGridView;
        private TableLayoutPanel _historyTableLayoutPanel;
        private TableLayoutPanel _historyDetailTableLayoutPanel;
        private Label _historyPriceLabel;
        private GroupBox _historyDetailGroupBox;
        private DataGridView _historyDetailDataGridView;
        private DataGridViewTextBoxColumn _historyDrinkName;
        private DataGridViewTextBoxColumn _historyDrinkPrice;
        private DataGridViewTextBoxColumn _historySweet;
        private DataGridViewTextBoxColumn _historyTemperature;
        private DataGridViewTextBoxColumn _historyAddition;
        private GroupBox _historyGroupBox;
        private DataGridView _historyDataGridView;
        private DataGridViewTextBoxColumn _historyPrice;
        private DataGridViewTextBoxColumn _historyTime;
    }
}

