namespace PresentationLayer
{
    partial class frmFindForm
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblfind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbDirection = new System.Windows.Forms.GroupBox();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.cbWrapAround = new System.Windows.Forms.CheckBox();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.gbDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblfind
            // 
            this.lblfind.AutoSize = true;
            this.lblfind.Location = new System.Drawing.Point(12, 9);
            this.lblfind.Name = "lblfind";
            this.lblfind.Size = new System.Drawing.Size(62, 15);
            this.lblfind.TabIndex = 0;
            this.lblfind.Text = "Find what:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(80, 5);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(172, 23);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(263, 5);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 34);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbDirection
            // 
            this.gbDirection.Controls.Add(this.rbDown);
            this.gbDirection.Controls.Add(this.rbUp);
            this.gbDirection.Location = new System.Drawing.Point(151, 34);
            this.gbDirection.Name = "gbDirection";
            this.gbDirection.Size = new System.Drawing.Size(106, 44);
            this.gbDirection.TabIndex = 4;
            this.gbDirection.TabStop = false;
            this.gbDirection.Text = "Direction";
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Location = new System.Drawing.Point(6, 16);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(40, 19);
            this.rbUp.TabIndex = 0;
            this.rbUp.TabStop = true;
            this.rbUp.Text = "Up";
            this.rbUp.UseVisualStyleBackColor = true;
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDown.Location = new System.Drawing.Point(46, 16);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(56, 17);
            this.rbDown.TabIndex = 1;
            this.rbDown.TabStop = true;
            this.rbDown.Text = "Down";
            this.rbDown.UseVisualStyleBackColor = true;
            // 
            // cbWrapAround
            // 
            this.cbWrapAround.AutoSize = true;
            this.cbWrapAround.Location = new System.Drawing.Point(6, 78);
            this.cbWrapAround.Name = "cbWrapAround";
            this.cbWrapAround.Size = new System.Drawing.Size(95, 19);
            this.cbWrapAround.TabIndex = 5;
            this.cbWrapAround.Text = "Wrap around";
            this.cbWrapAround.UseVisualStyleBackColor = true;
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Location = new System.Drawing.Point(6, 53);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(86, 19);
            this.cbMatchCase.TabIndex = 6;
            this.cbMatchCase.Text = "Match case";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // frmFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 101);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.cbWrapAround);
            this.Controls.Add(this.gbDirection);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblfind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "frmFindForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.gbDirection.ResumeLayout(false);
            this.gbDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private CheckBox cbMatchCase;
        private CheckBox cbWrapAround;
        private GroupBox gbDirection;
        private RadioButton rbDown;
        private RadioButton rbUp;
        private Button btnCancel;
        private Button btnFindNext;
        private TextBox txtFind;
        private Label lblfind;
    }
}