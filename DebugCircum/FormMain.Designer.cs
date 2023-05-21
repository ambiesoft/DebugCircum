namespace DebugCircum
{
    partial class FormMain
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
            tabMain = new TabControl();
            tpClipboard = new TabPage();
            btnCopy = new Button();
            udCopyCount = new NumericUpDown();
            tpFile = new TabPage();
            tabMain.SuspendLayout();
            tpClipboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udCopyCount).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tpClipboard);
            tabMain.Controls.Add(tpFile);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(800, 450);
            tabMain.TabIndex = 0;
            // 
            // tpClipboard
            // 
            tpClipboard.Controls.Add(btnCopy);
            tpClipboard.Controls.Add(udCopyCount);
            tpClipboard.Location = new Point(4, 24);
            tpClipboard.Name = "tpClipboard";
            tpClipboard.Padding = new Padding(3);
            tpClipboard.Size = new Size(792, 422);
            tpClipboard.TabIndex = 0;
            tpClipboard.Text = "Clipboard";
            tpClipboard.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(272, 96);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 1;
            btnCopy.Text = "&Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // udCopyCount
            // 
            udCopyCount.Location = new Point(94, 40);
            udCopyCount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            udCopyCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            udCopyCount.Name = "udCopyCount";
            udCopyCount.Size = new Size(120, 23);
            udCopyCount.TabIndex = 0;
            udCopyCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tpFile
            // 
            tpFile.Location = new Point(4, 24);
            tpFile.Name = "tpFile";
            tpFile.Padding = new Padding(3);
            tpFile.Size = new Size(792, 422);
            tpFile.TabIndex = 1;
            tpFile.Text = "File";
            tpFile.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabMain);
            Name = "FormMain";
            Text = "Form1";
            FormClosed += FormMain_FormClosed;
            tabMain.ResumeLayout(false);
            tpClipboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)udCopyCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tpClipboard;
        private Button btnCopy;
        private NumericUpDown udCopyCount;
        private TabPage tpFile;
    }
}