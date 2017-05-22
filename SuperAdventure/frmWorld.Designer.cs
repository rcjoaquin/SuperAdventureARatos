namespace SuperAdventure
{
    partial class frmWorld
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.worldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monstersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblpWorld = new System.Windows.Forms.TableLayoutPanel();
            this.ctxMenuTablePanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRightColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ctxMenuTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldsToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.monstersToolStripMenuItem,
            this.questsToolStripMenuItem,
            this.charactersToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // worldsToolStripMenuItem
            // 
            this.worldsToolStripMenuItem.Name = "worldsToolStripMenuItem";
            this.worldsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.worldsToolStripMenuItem.Text = "Worlds";
            this.worldsToolStripMenuItem.Click += new System.EventHandler(this.worldsToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // monstersToolStripMenuItem
            // 
            this.monstersToolStripMenuItem.Name = "monstersToolStripMenuItem";
            this.monstersToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.monstersToolStripMenuItem.Text = "Monsters";
            this.monstersToolStripMenuItem.Click += new System.EventHandler(this.monstersToolStripMenuItem_Click);
            // 
            // questsToolStripMenuItem
            // 
            this.questsToolStripMenuItem.Name = "questsToolStripMenuItem";
            this.questsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.questsToolStripMenuItem.Text = "Quests";
            this.questsToolStripMenuItem.Click += new System.EventHandler(this.questsToolStripMenuItem_Click);
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorsToolStripMenuItem});
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.charactersToolStripMenuItem.Text = "Characters";
            // 
            // vendorsToolStripMenuItem
            // 
            this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
            this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.vendorsToolStripMenuItem.Text = "Vendors";
            this.vendorsToolStripMenuItem.Click += new System.EventHandler(this.vendorsToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tblpWorld
            // 
            this.tblpWorld.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblpWorld.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblpWorld.ColumnCount = 2;
            this.tblpWorld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpWorld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpWorld.Location = new System.Drawing.Point(0, 27);
            this.tblpWorld.Name = "tblpWorld";
            this.tblpWorld.RowCount = 2;
            this.tblpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpWorld.Size = new System.Drawing.Size(200, 100);
            this.tblpWorld.TabIndex = 2;
            // 
            // ctxMenuTablePanel
            // 
            this.ctxMenuTablePanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRightColumnToolStripMenuItem});
            this.ctxMenuTablePanel.Name = "ctxMenuTablePanel";
            this.ctxMenuTablePanel.Size = new System.Drawing.Size(174, 48);
            // 
            // addRightColumnToolStripMenuItem
            // 
            this.addRightColumnToolStripMenuItem.Name = "addRightColumnToolStripMenuItem";
            this.addRightColumnToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addRightColumnToolStripMenuItem.Text = "Add Right Column";
            this.addRightColumnToolStripMenuItem.Click += new System.EventHandler(this.addRightColumnToolStripMenuItem_Click);
            // 
            // frmWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(929, 555);
            this.Controls.Add(this.tblpWorld);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWorld";
            this.Text = "World";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxMenuTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monstersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tblpWorld;
        private System.Windows.Forms.ToolStripMenuItem worldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxMenuTablePanel;
        private System.Windows.Forms.ToolStripMenuItem addRightColumnToolStripMenuItem;
    }
}