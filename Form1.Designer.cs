
namespace FileRenamer
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
            this.lbl_source = new System.Windows.Forms.Label();
            this.txtbox_source = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lstbox_files = new System.Windows.Forms.ListBox();
            this.txtbox_newname = new System.Windows.Forms.TextBox();
            this.lbl_newname = new System.Windows.Forms.Label();
            this.btn_rename = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_startfrom = new System.Windows.Forms.Label();
            this.txtbox_startfrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbox_date = new System.Windows.Forms.CheckBox();
            this.btn_selectnone = new System.Windows.Forms.Button();
            this.btn_selectall = new System.Windows.Forms.Button();
            this.btn_removeitem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_source
            // 
            this.lbl_source.AutoSize = true;
            this.lbl_source.Location = new System.Drawing.Point(13, 13);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(73, 13);
            this.lbl_source.TabIndex = 0;
            this.lbl_source.Text = "Source Folder";
            // 
            // txtbox_source
            // 
            this.txtbox_source.Location = new System.Drawing.Point(92, 10);
            this.txtbox_source.Name = "txtbox_source";
            this.txtbox_source.Size = new System.Drawing.Size(295, 20);
            this.txtbox_source.TabIndex = 1;
            this.txtbox_source.TextChanged += new System.EventHandler(this.txtbox_source_TextChanged);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(393, 8);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // lstbox_files
            // 
            this.lstbox_files.FormattingEnabled = true;
            this.lstbox_files.Location = new System.Drawing.Point(16, 49);
            this.lstbox_files.Name = "lstbox_files";
            this.lstbox_files.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbox_files.Size = new System.Drawing.Size(184, 446);
            this.lstbox_files.TabIndex = 3;
            this.lstbox_files.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstbox_files_DragDrop);
            this.lstbox_files.DragOver += new System.Windows.Forms.DragEventHandler(this.lstbox_files_DragOver);
            this.lstbox_files.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstbox_files_MouseDown);
            // 
            // txtbox_newname
            // 
            this.txtbox_newname.Location = new System.Drawing.Point(331, 68);
            this.txtbox_newname.Name = "txtbox_newname";
            this.txtbox_newname.Size = new System.Drawing.Size(137, 20);
            this.txtbox_newname.TabIndex = 4;
            // 
            // lbl_newname
            // 
            this.lbl_newname.AutoSize = true;
            this.lbl_newname.Location = new System.Drawing.Point(251, 71);
            this.lbl_newname.Name = "lbl_newname";
            this.lbl_newname.Size = new System.Drawing.Size(74, 13);
            this.lbl_newname.TabIndex = 5;
            this.lbl_newname.Text = "New file name";
            // 
            // btn_rename
            // 
            this.btn_rename.Location = new System.Drawing.Point(282, 510);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(75, 23);
            this.btn_rename.TabIndex = 7;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(393, 510);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_startfrom
            // 
            this.lbl_startfrom.AutoSize = true;
            this.lbl_startfrom.Location = new System.Drawing.Point(221, 104);
            this.lbl_startfrom.Name = "lbl_startfrom";
            this.lbl_startfrom.Size = new System.Drawing.Size(104, 13);
            this.lbl_startfrom.TabIndex = 9;
            this.lbl_startfrom.Text = "Start numbering from";
            // 
            // txtbox_startfrom
            // 
            this.txtbox_startfrom.Location = new System.Drawing.Point(331, 101);
            this.txtbox_startfrom.Name = "txtbox_startfrom";
            this.txtbox_startfrom.Size = new System.Drawing.Size(59, 20);
            this.txtbox_startfrom.TabIndex = 10;
            this.txtbox_startfrom.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add date";
            // 
            // chkbox_date
            // 
            this.chkbox_date.AutoSize = true;
            this.chkbox_date.Location = new System.Drawing.Point(331, 134);
            this.chkbox_date.Name = "chkbox_date";
            this.chkbox_date.Size = new System.Drawing.Size(15, 14);
            this.chkbox_date.TabIndex = 12;
            this.chkbox_date.UseVisualStyleBackColor = true;
            // 
            // btn_selectnone
            // 
            this.btn_selectnone.Location = new System.Drawing.Point(97, 510);
            this.btn_selectnone.Name = "btn_selectnone";
            this.btn_selectnone.Size = new System.Drawing.Size(75, 23);
            this.btn_selectnone.TabIndex = 13;
            this.btn_selectnone.Text = "Select None";
            this.btn_selectnone.UseVisualStyleBackColor = true;
            this.btn_selectnone.Click += new System.EventHandler(this.btn_selectnone_Click);
            // 
            // btn_selectall
            // 
            this.btn_selectall.Location = new System.Drawing.Point(16, 510);
            this.btn_selectall.Name = "btn_selectall";
            this.btn_selectall.Size = new System.Drawing.Size(75, 23);
            this.btn_selectall.TabIndex = 14;
            this.btn_selectall.Text = "Select All";
            this.btn_selectall.UseVisualStyleBackColor = true;
            this.btn_selectall.Click += new System.EventHandler(this.btn_selectall_Click);
            // 
            // btn_removeitem
            // 
            this.btn_removeitem.Location = new System.Drawing.Point(178, 510);
            this.btn_removeitem.Name = "btn_removeitem";
            this.btn_removeitem.Size = new System.Drawing.Size(98, 23);
            this.btn_removeitem.TabIndex = 15;
            this.btn_removeitem.Text = "Remove selected";
            this.btn_removeitem.UseVisualStyleBackColor = true;
            this.btn_removeitem.Click += new System.EventHandler(this.btn_removeitem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 549);
            this.Controls.Add(this.btn_removeitem);
            this.Controls.Add(this.btn_selectall);
            this.Controls.Add(this.btn_selectnone);
            this.Controls.Add(this.chkbox_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_startfrom);
            this.Controls.Add(this.lbl_startfrom);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_rename);
            this.Controls.Add(this.lbl_newname);
            this.Controls.Add(this.txtbox_newname);
            this.Controls.Add(this.lstbox_files);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txtbox_source);
            this.Controls.Add(this.lbl_source);
            this.MaximumSize = new System.Drawing.Size(503, 588);
            this.MinimumSize = new System.Drawing.Size(503, 588);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_source;
        private System.Windows.Forms.TextBox txtbox_source;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox lstbox_files;
        private System.Windows.Forms.TextBox txtbox_newname;
        private System.Windows.Forms.Label lbl_newname;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_startfrom;
        private System.Windows.Forms.TextBox txtbox_startfrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbox_date;
        private System.Windows.Forms.Button btn_selectnone;
        private System.Windows.Forms.Button btn_selectall;
        private System.Windows.Forms.Button btn_removeitem;
    }
}

