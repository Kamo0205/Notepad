using PresentationLayer;

namespace NotepadApp
{
    public partial class FrmNotepad : Form
    {
        SaveFileDialog sfd;
        OpenFileDialog ofd;
        int index;
        public FrmNotepad()
        {
            InitializeComponent();
            sfd = new SaveFileDialog();
            ofd = new OpenFileDialog();
            rtbTextArea.TabIndex = 5;
            rtbTextArea.Focus();
            this.Text = "untitled-file";
            miUndo.Enabled = true;
            rtbTextArea.Modified = false;
        }

        private void rtbTextArea_TextChanged(object sender, EventArgs e)
        {
            miUndo.Enabled = true;
            statusStrip1.Text = "Line: " + (rtbTextArea.GetLineFromCharIndex(Int32.MaxValue) + 1) + " Cols: " + +rtbTextArea.Text.Length;
        }

        private void OpenFile()
        {
            ofd.Title = "Opening File";
            ofd.Filter = "Text File|*.txt";
            ofd.FileName = String.Empty;
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            if (ofd.FileName == String.Empty)
                return;
            string str = ofd.FileName;
            rtbTextArea.LoadFile(str, RichTextBoxStreamType.PlainText);
            this.Text = ofd.FileName;
        }

        private void SaveFile()
        {
            sfd.Title = "Save As";
            sfd.Filter = "Text Document|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog()!=DialogResult.OK)
                return ;
            if (this.Text!= "untitled-file")
                rtbTextArea.SaveFile(this.Text, RichTextBoxStreamType.PlainText);
               return ;
            rtbTextArea.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sfd.FileName;
        }

        private void OpeningFile()
        {
            if (rtbTextArea.Modified == true)
            {
                DialogResult dr = MessageBox.Show("Do you want to save the changes?", "unsaved document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    rtbTextArea.Modified = false;
                    OpenFile();
                    return;
                }
                if (this.Text != "untitled-file")
                {
                    SaveFile();
                    OpenFile();
                    return;
                }
                DialogResult dr1 = MessageBox.Show("Do you want to save the changes to this file?", "Open", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr1 != DialogResult.Yes)
                    OpenFile();
                rtbTextArea.SaveFile(this.Text);
            }
            OpenFile();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpeningFile();
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            if (rtbTextArea.Modified)
            {
                DialogResult dr = MessageBox.Show("Do you want to save before exiting?", "unsaved file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    SaveFile();
                rtbTextArea.Modified = false;
            }
            Application.Exit();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            sfd.Title = "Save";
            DialogResult dr = MessageBox.Show("Do you want to save the file?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.Equals(DialogResult.Yes))
                SaveFile();
            rtbTextArea.Clear();
            this.Text = "untitled-file";
        }

        private void FrmNotepad_DragDrop(object sender, DragEventArgs e)
        {
            OpeningFile();
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            sfd.Title = "Save As";
            sfd.Filter = "Text Document|*.txt";
            sfd.DefaultExt = "txt";

            rtbTextArea.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sfd.FileName;
        }

        private void miPageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbTextArea.Text, rtbTextArea.Font, Brushes.Black, 100, 100);
        }

        private void miUndo_Click(object sender, EventArgs e)
        {
            if (rtbTextArea.CanUndo)
                rtbTextArea.Undo();
        }

        private void miRedo_Click(object sender, EventArgs e)
        {
            statusStrip1.Text = "used to redo last changed text";
            if (rtbTextArea.CanRedo)
                rtbTextArea.Redo();
        }

        private void miCut_Click(object sender, EventArgs e)
        {
            rtbTextArea.Cut();
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            rtbTextArea.Copy();
        }

        private void miPaste_Click(object sender, EventArgs e)
        {
            rtbTextArea.Paste();
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            rtbTextArea.SelectedText = "";
        }

        private void miFind_Click(object sender, EventArgs e)
        {
            //frmFindForm findForm = new frmFindForm(this);
            //findForm.ShowDialog();
        }

        public void FindNext(string str)
        {
            try
            {
                if (index == -1)
                    MessageBox.Show("Word Search Complete");
                else
                {
                    int starting = rtbTextArea.Text.IndexOf(str, index);
                    rtbTextArea.Select(starting, str.Length);
                    rtbTextArea.Focus();
                    index = starting + str.Length;
                }
            }
            catch (SystemException s)
            {
                MessageBox.Show(s.Message.ToString(),"Error message");
            }
        }

        private void miFindNext_Click(object sender, EventArgs e)
        {

        }

        private void miFindPrevious_Click(object sender, EventArgs e)
        {

        }

        private void miReplace_Click(object sender, EventArgs e)
        {

        }
        public void GoTo(int line)
        {
            index = rtbTextArea.GetFirstCharIndexFromLine(line - 1);
            rtbTextArea.Select(index, 0);
            rtbTextArea.Focus();
        }

        private void miGoTo_Click(object sender, EventArgs e)
        {

        }

        private void miSelectAll_Click(object sender, EventArgs e)
        {
            rtbTextArea.SelectAll();
        }

        private void miTimeDate_Click(object sender, EventArgs e)
        {
            rtbTextArea.Text += Convert.ToString(DateTime.Now);
        }

        private void miStatus_Click(object sender, EventArgs e)
        {
            statusStrip1.Text = "Cols " +rtbTextArea.Text.Length;
        }

        private void miWordWrap_Click(object sender, EventArgs e)
        {
            if (!miWordWrap.Checked)
                miWordWrap.Checked = true;
                rtbTextArea.WordWrap = true;
                return ;
            miWordWrap.Checked = false;
            rtbTextArea.WordWrap = false;
        }

        private void miFontTool_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = rtbTextArea.SelectionFont;
            fd.Color = rtbTextArea.SelectionColor;
            if (fd.ShowDialog() == DialogResult.OK)
                rtbTextArea.SelectionFont = fd.Font;
                rtbTextArea.SelectionColor = fd.Color;
        }

        private void miAddBullet_Click(object sender, EventArgs e)
        {
            try
            {
                rtbTextArea.BulletIndent = 10;
                rtbTextArea.SelectionBullet = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void miRemoveBullet_Click(object sender, EventArgs e)
        {
            try
            {
                rtbTextArea.SelectionBullet = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void miLeftIndent_Click(object sender, EventArgs e)
        {
            try

            {

                rtbTextArea.SelectionAlignment = HorizontalAlignment.Left;

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void miCenterIndent_Click(object sender, EventArgs e)
        {
            try

            {

                rtbTextArea.SelectionAlignment = HorizontalAlignment.Center;

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void miRightIndent_Click(object sender, EventArgs e)
        {
            try
            {
                rtbTextArea.SelectionAlignment = HorizontalAlignment.Right;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void miBackgroundColour_Click(object sender, EventArgs e)
        {
            ColorDialog cr = new ColorDialog();
            if (cr.ShowDialog() == DialogResult.OK)
                rtbTextArea.BackColor = cr.Color;
        }
    }
}