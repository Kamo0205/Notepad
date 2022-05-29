namespace NotepadApp
{
    partial class FrmNotepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotepad));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miCut = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.miPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miFind = new System.Windows.Forms.ToolStripMenuItem();
            this.miFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.miFindPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.miReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.miGoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.miSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.miZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.miZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.miZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.miRestoreDefaultZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.miStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.miFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.miWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.miFontTool = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddBullet = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveBullet = new System.Windows.Forms.ToolStripMenuItem();
            this.miLeftIndent = new System.Windows.Forms.ToolStripMenuItem();
            this.miCenterIndent = new System.Windows.Forms.ToolStripMenuItem();
            this.miRightIndent = new System.Windows.Forms.ToolStripMenuItem();
            this.miBackgroundColour = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbTextArea = new System.Windows.Forms.RichTextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miEdit,
            this.miView,
            this.miFormat,
            this.styleToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miNewWindow,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.toolStripSeparator4,
            this.miPageSetup,
            this.miPrint,
            this.toolStripSeparator5,
            this.miClose});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miNew.Size = new System.Drawing.Size(220, 22);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miNewWindow
            // 
            this.miNewWindow.Name = "miNewWindow";
            this.miNewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.miNewWindow.Size = new System.Drawing.Size(220, 22);
            this.miNewWindow.Text = "New Window";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(220, 22);
            this.miOpen.Text = "Open...";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(220, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.miSaveAs.Size = new System.Drawing.Size(220, 22);
            this.miSaveAs.Text = "Save As...";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(217, 6);
            // 
            // miPageSetup
            // 
            this.miPageSetup.Name = "miPageSetup";
            this.miPageSetup.Size = new System.Drawing.Size(220, 22);
            this.miPageSetup.Text = "Page Setup...";
            this.miPageSetup.Click += new System.EventHandler(this.miPageSetup_Click);
            // 
            // miPrint
            // 
            this.miPrint.Name = "miPrint";
            this.miPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.miPrint.Size = new System.Drawing.Size(220, 22);
            this.miPrint.Text = "Print...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(217, 6);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(220, 22);
            this.miClose.Text = "Close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // miEdit
            // 
            this.miEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUndo,
            this.miRedo,
            this.toolStripSeparator2,
            this.miCut,
            this.miCopy,
            this.miPaste,
            this.miDelete,
            this.toolStripSeparator1,
            this.miFind,
            this.miFindNext,
            this.miFindPrevious,
            this.miReplace,
            this.miGoTo,
            this.toolStripSeparator3,
            this.miSelectAll,
            this.miTimeDate});
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(39, 20);
            this.miEdit.Text = "Edit";
            // 
            // miUndo
            // 
            this.miUndo.Name = "miUndo";
            this.miUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.miUndo.Size = new System.Drawing.Size(196, 22);
            this.miUndo.Text = "Undo";
            this.miUndo.Click += new System.EventHandler(this.miUndo_Click);
            // 
            // miRedo
            // 
            this.miRedo.Name = "miRedo";
            this.miRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.miRedo.Size = new System.Drawing.Size(196, 22);
            this.miRedo.Text = "Redo";
            this.miRedo.Click += new System.EventHandler(this.miRedo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // miCut
            // 
            this.miCut.Name = "miCut";
            this.miCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.miCut.Size = new System.Drawing.Size(196, 22);
            this.miCut.Text = "Cut";
            this.miCut.Click += new System.EventHandler(this.miCut_Click);
            // 
            // miCopy
            // 
            this.miCopy.Name = "miCopy";
            this.miCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.miCopy.Size = new System.Drawing.Size(196, 22);
            this.miCopy.Text = "Copy";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // miPaste
            // 
            this.miPaste.Name = "miPaste";
            this.miPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.miPaste.Size = new System.Drawing.Size(196, 22);
            this.miPaste.Text = "Paste";
            this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.miDelete.Size = new System.Drawing.Size(196, 22);
            this.miDelete.Text = "Delete";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // miFind
            // 
            this.miFind.Name = "miFind";
            this.miFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.miFind.Size = new System.Drawing.Size(196, 22);
            this.miFind.Text = "Find";
            this.miFind.Click += new System.EventHandler(this.miFind_Click);
            // 
            // miFindNext
            // 
            this.miFindNext.Name = "miFindNext";
            this.miFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.miFindNext.Size = new System.Drawing.Size(196, 22);
            this.miFindNext.Text = "Find Next";
            this.miFindNext.Click += new System.EventHandler(this.miFindNext_Click);
            // 
            // miFindPrevious
            // 
            this.miFindPrevious.Name = "miFindPrevious";
            this.miFindPrevious.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.miFindPrevious.Size = new System.Drawing.Size(196, 22);
            this.miFindPrevious.Text = "Find Previous";
            this.miFindPrevious.Click += new System.EventHandler(this.miFindPrevious_Click);
            // 
            // miReplace
            // 
            this.miReplace.Name = "miReplace";
            this.miReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.miReplace.Size = new System.Drawing.Size(196, 22);
            this.miReplace.Text = "Replace...";
            this.miReplace.Click += new System.EventHandler(this.miReplace_Click);
            // 
            // miGoTo
            // 
            this.miGoTo.Name = "miGoTo";
            this.miGoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.miGoTo.Size = new System.Drawing.Size(196, 22);
            this.miGoTo.Text = "Go To..";
            this.miGoTo.Click += new System.EventHandler(this.miGoTo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // miSelectAll
            // 
            this.miSelectAll.Name = "miSelectAll";
            this.miSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.miSelectAll.Size = new System.Drawing.Size(196, 22);
            this.miSelectAll.Text = "Select All";
            this.miSelectAll.Click += new System.EventHandler(this.miSelectAll_Click);
            // 
            // miTimeDate
            // 
            this.miTimeDate.Name = "miTimeDate";
            this.miTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.miTimeDate.Size = new System.Drawing.Size(196, 22);
            this.miTimeDate.Text = "Time/Date";
            this.miTimeDate.Click += new System.EventHandler(this.miTimeDate_Click);
            // 
            // miView
            // 
            this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miZoom,
            this.miStatus});
            this.miView.Name = "miView";
            this.miView.Size = new System.Drawing.Size(44, 20);
            this.miView.Text = "View";
            // 
            // miZoom
            // 
            this.miZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miZoomIn,
            this.miZoomOut,
            this.miRestoreDefaultZoom});
            this.miZoom.Name = "miZoom";
            this.miZoom.Size = new System.Drawing.Size(106, 22);
            this.miZoom.Text = "Zoom";
            // 
            // miZoomIn
            // 
            this.miZoomIn.Name = "miZoomIn";
            this.miZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.miZoomIn.Size = new System.Drawing.Size(229, 22);
            this.miZoomIn.Text = "Zoom In";
            // 
            // miZoomOut
            // 
            this.miZoomOut.Name = "miZoomOut";
            this.miZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.miZoomOut.Size = new System.Drawing.Size(229, 22);
            this.miZoomOut.Text = "Zoom Out";
            // 
            // miRestoreDefaultZoom
            // 
            this.miRestoreDefaultZoom.Name = "miRestoreDefaultZoom";
            this.miRestoreDefaultZoom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.miRestoreDefaultZoom.Size = new System.Drawing.Size(229, 22);
            this.miRestoreDefaultZoom.Text = "Restore Default Zoom";
            // 
            // miStatus
            // 
            this.miStatus.Name = "miStatus";
            this.miStatus.Size = new System.Drawing.Size(106, 22);
            this.miStatus.Text = "Status";
            this.miStatus.Click += new System.EventHandler(this.miStatus_Click);
            // 
            // miFormat
            // 
            this.miFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWordWrap,
            this.miFontTool});
            this.miFormat.Name = "miFormat";
            this.miFormat.Size = new System.Drawing.Size(57, 20);
            this.miFormat.Text = "Format";
            // 
            // miWordWrap
            // 
            this.miWordWrap.Name = "miWordWrap";
            this.miWordWrap.Size = new System.Drawing.Size(134, 22);
            this.miWordWrap.Text = "Word Wrap";
            this.miWordWrap.Click += new System.EventHandler(this.miWordWrap_Click);
            // 
            // miFontTool
            // 
            this.miFontTool.Name = "miFontTool";
            this.miFontTool.Size = new System.Drawing.Size(134, 22);
            this.miFontTool.Text = "Font";
            this.miFontTool.Click += new System.EventHandler(this.miFontTool_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddBullet,
            this.miRemoveBullet,
            this.miLeftIndent,
            this.miCenterIndent,
            this.miRightIndent,
            this.miBackgroundColour});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // miAddBullet
            // 
            this.miAddBullet.Name = "miAddBullet";
            this.miAddBullet.Size = new System.Drawing.Size(180, 22);
            this.miAddBullet.Text = "Add Bullet";
            this.miAddBullet.Click += new System.EventHandler(this.miAddBullet_Click);
            // 
            // miRemoveBullet
            // 
            this.miRemoveBullet.Name = "miRemoveBullet";
            this.miRemoveBullet.Size = new System.Drawing.Size(180, 22);
            this.miRemoveBullet.Text = "Remove Bullet";
            this.miRemoveBullet.Click += new System.EventHandler(this.miRemoveBullet_Click);
            // 
            // miLeftIndent
            // 
            this.miLeftIndent.Name = "miLeftIndent";
            this.miLeftIndent.Size = new System.Drawing.Size(180, 22);
            this.miLeftIndent.Text = "Left Indent";
            this.miLeftIndent.Click += new System.EventHandler(this.miLeftIndent_Click);
            // 
            // miCenterIndent
            // 
            this.miCenterIndent.Name = "miCenterIndent";
            this.miCenterIndent.Size = new System.Drawing.Size(180, 22);
            this.miCenterIndent.Text = "Center Indent";
            this.miCenterIndent.Click += new System.EventHandler(this.miCenterIndent_Click);
            // 
            // miRightIndent
            // 
            this.miRightIndent.Name = "miRightIndent";
            this.miRightIndent.Size = new System.Drawing.Size(180, 22);
            this.miRightIndent.Text = "Right Indent";
            this.miRightIndent.Click += new System.EventHandler(this.miRightIndent_Click);
            // 
            // miBackgroundColour
            // 
            this.miBackgroundColour.Name = "miBackgroundColour";
            this.miBackgroundColour.Size = new System.Drawing.Size(180, 22);
            this.miBackgroundColour.Text = "Background Colour";
            this.miBackgroundColour.Click += new System.EventHandler(this.miBackgroundColour_Click);
            // 
            // rtbTextArea
            // 
            this.rtbTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTextArea.Location = new System.Drawing.Point(0, 24);
            this.rtbTextArea.Name = "rtbTextArea";
            this.rtbTextArea.Size = new System.Drawing.Size(800, 426);
            this.rtbTextArea.TabIndex = 1;
            this.rtbTextArea.Text = "";
            this.rtbTextArea.TextChanged += new System.EventHandler(this.rtbTextArea_TextChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmNotepad
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbTextArea);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmNotepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmNotepad_DragDrop);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msMenu;
        private ToolStripMenuItem miFile;
        private ToolStripMenuItem miOpen;
        private ToolStripMenuItem miSave;
        private ToolStripMenuItem miClose;
        private ToolStripMenuItem miEdit;
        private RichTextBox rtbTextArea;
        private ToolStripMenuItem miNew;
        private ToolStripMenuItem miNewWindow;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem miPageSetup;
        private ToolStripMenuItem miPrint;
        private ToolStripMenuItem miUndo;
        private ToolStripMenuItem miRedo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem miCut;
        private ToolStripMenuItem miCopy;
        private ToolStripMenuItem miDelete;
        private ToolStripMenuItem miPaste;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem miFind;
        private ToolStripMenuItem miFindNext;
        private ToolStripMenuItem miFindPrevious;
        private ToolStripMenuItem miReplace;
        private ToolStripMenuItem miGoTo;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem miSelectAll;
        private ToolStripMenuItem miTimeDate;
        private ToolStripMenuItem miView;
        private ToolStripMenuItem miStatus;
        private ToolStripMenuItem miFormat;
        private ToolStripMenuItem miWordWrap;
        private ToolStripMenuItem miFontTool;
        private ToolStripMenuItem styleToolStripMenuItem;
        private ToolStripMenuItem miAddBullet;
        private ToolStripMenuItem miRemoveBullet;
        private ToolStripMenuItem miLeftIndent;
        private ToolStripMenuItem miCenterIndent;
        private ToolStripMenuItem miRightIndent;
        private ToolStripMenuItem miBackgroundColour;
        private ToolStripMenuItem miSaveAs;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem miZoom;
        private ToolStripMenuItem miZoomIn;
        private ToolStripMenuItem miZoomOut;
        private ToolStripMenuItem miRestoreDefaultZoom;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private StatusStrip statusStrip1;
        private FontDialog fontDialog1;
    }
}