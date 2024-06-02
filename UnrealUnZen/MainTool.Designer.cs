namespace UnrealUnZen
{
    partial class MainTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTool));
            this.OpenTocBTN = new System.Windows.Forms.Button();
            this.UnpackBTN = new System.Windows.Forms.Button();
            this.ArchiveViewTV = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AESKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RepackBTN = new System.Windows.Forms.Button();
            this.RepackMethodCMB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UTocVerCMB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MountPointTXB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RegexUnpack = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dontUseItIfYouDontKnowHowWorksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repackUsingCustomManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenTocBTN
            // 
            this.OpenTocBTN.Location = new System.Drawing.Point(10, 130);
            this.OpenTocBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenTocBTN.Name = "OpenTocBTN";
            this.OpenTocBTN.Size = new System.Drawing.Size(334, 24);
            this.OpenTocBTN.TabIndex = 0;
            this.OpenTocBTN.Text = "Load TOC";
            this.OpenTocBTN.UseVisualStyleBackColor = true;
            this.OpenTocBTN.Click += new System.EventHandler(this.OpenTocBTN_Click);
            // 
            // UnpackBTN
            // 
            this.UnpackBTN.Enabled = false;
            this.UnpackBTN.Location = new System.Drawing.Point(224, 180);
            this.UnpackBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UnpackBTN.Name = "UnpackBTN";
            this.UnpackBTN.Size = new System.Drawing.Size(120, 54);
            this.UnpackBTN.TabIndex = 2;
            this.UnpackBTN.Text = "Unpack ALL Files";
            this.UnpackBTN.UseVisualStyleBackColor = true;
            this.UnpackBTN.Click += new System.EventHandler(this.UnpackBTN_Click);
            // 
            // ArchiveViewTV
            // 
            this.ArchiveViewTV.Location = new System.Drawing.Point(10, 180);
            this.ArchiveViewTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ArchiveViewTV.Name = "ArchiveViewTV";
            this.ArchiveViewTV.Size = new System.Drawing.Size(209, 434);
            this.ArchiveViewTV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unreal Engine IoStore Tool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "for unpack and repack ucas/utoc files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Archive view:";
            // 
            // AESKey
            // 
            this.AESKey.Location = new System.Drawing.Point(59, 80);
            this.AESKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AESKey.Name = "AESKey";
            this.AESKey.Size = new System.Drawing.Size(285, 19);
            this.AESKey.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "AES Key:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "(leave empty if not needed)";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(225, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 60);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fix by nevmensik       By NoobInCoding\r\n\r\nThanks to gitMenv - EmOo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // RepackBTN
            // 
            this.RepackBTN.Enabled = false;
            this.RepackBTN.Location = new System.Drawing.Point(224, 240);
            this.RepackBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RepackBTN.Name = "RepackBTN";
            this.RepackBTN.Size = new System.Drawing.Size(120, 48);
            this.RepackBTN.TabIndex = 14;
            this.RepackBTN.Text = "Repack Files (need a lot of time)";
            this.RepackBTN.UseVisualStyleBackColor = true;
            this.RepackBTN.Click += new System.EventHandler(this.RepackBTN_Click);
            // 
            // RepackMethodCMB
            // 
            this.RepackMethodCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RepackMethodCMB.FormattingEnabled = true;
            this.RepackMethodCMB.Items.AddRange(new object[] {
            "None",
            "Zlib",
            "Oodle"});
            this.RepackMethodCMB.Location = new System.Drawing.Point(225, 324);
            this.RepackMethodCMB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RepackMethodCMB.Name = "RepackMethodCMB";
            this.RepackMethodCMB.Size = new System.Drawing.Size(121, 22);
            this.RepackMethodCMB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Repack compression Method:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Repack UTOC Version:";
            // 
            // UTocVerCMB
            // 
            this.UTocVerCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UTocVerCMB.FormattingEnabled = true;
            this.UTocVerCMB.Items.AddRange(new object[] {
            "2",
            "3"});
            this.UTocVerCMB.Location = new System.Drawing.Point(225, 368);
            this.UTocVerCMB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UTocVerCMB.Name = "UTocVerCMB";
            this.UTocVerCMB.Size = new System.Drawing.Size(121, 22);
            this.UTocVerCMB.TabIndex = 19;
            this.UTocVerCMB.SelectedIndexChanged += new System.EventHandler(this.UTocVerCMB_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mount Point:";
            // 
            // MountPointTXB
            // 
            this.MountPointTXB.Location = new System.Drawing.Point(223, 410);
            this.MountPointTXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MountPointTXB.Name = "MountPointTXB";
            this.MountPointTXB.Size = new System.Drawing.Size(124, 19);
            this.MountPointTXB.TabIndex = 21;
            this.MountPointTXB.Text = "../../../";
            this.MountPointTXB.TextChanged += new System.EventHandler(this.MountPointTXB_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 625);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "Filter (For Unpack):";
            // 
            // RegexUnpack
            // 
            this.RegexUnpack.Location = new System.Drawing.Point(91, 621);
            this.RegexUnpack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegexUnpack.Name = "RegexUnpack";
            this.RegexUnpack.Size = new System.Drawing.Size(235, 19);
            this.RegexUnpack.TabIndex = 22;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(356, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dontUseItIfYouDontKnowHowWorksToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveManifestToolStripMenuItem,
            this.fixManifestToolStripMenuItem,
            this.repackUsingCustomManifestToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton1.Text = "Manifest";
            this.toolStripDropDownButton1.ToolTipText = "Manifest";
            // 
            // dontUseItIfYouDontKnowHowWorksToolStripMenuItem
            // 
            this.dontUseItIfYouDontKnowHowWorksToolStripMenuItem.Enabled = false;
            this.dontUseItIfYouDontKnowHowWorksToolStripMenuItem.Name = "dontUseItIfYouDontKnowHowWorksToolStripMenuItem";
            this.dontUseItIfYouDontKnowHowWorksToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.dontUseItIfYouDontKnowHowWorksToolStripMenuItem.Text = "EXPERIMRNTAL - DON\'T USE";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // saveManifestToolStripMenuItem
            // 
            this.saveManifestToolStripMenuItem.Enabled = false;
            this.saveManifestToolStripMenuItem.Name = "saveManifestToolStripMenuItem";
            this.saveManifestToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.saveManifestToolStripMenuItem.Text = "Save Manifest";
            this.saveManifestToolStripMenuItem.Click += new System.EventHandler(this.saveManifestToolStripMenuItem_Click);
            // 
            // fixManifestToolStripMenuItem
            // 
            this.fixManifestToolStripMenuItem.Enabled = false;
            this.fixManifestToolStripMenuItem.Name = "fixManifestToolStripMenuItem";
            this.fixManifestToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.fixManifestToolStripMenuItem.Text = "Fix Manifest";
            this.fixManifestToolStripMenuItem.Click += new System.EventHandler(this.fixManifestToolStripMenuItem_Click);
            // 
            // repackUsingCustomManifestToolStripMenuItem
            // 
            this.repackUsingCustomManifestToolStripMenuItem.Name = "repackUsingCustomManifestToolStripMenuItem";
            this.repackUsingCustomManifestToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.repackUsingCustomManifestToolStripMenuItem.Text = "Repack Custom Manifest";
            this.repackUsingCustomManifestToolStripMenuItem.Click += new System.EventHandler(this.repackUsingCustomManifestToolStripMenuItem_Click);
            // 
            // HelpFilter
            // 
            this.HelpFilter.Location = new System.Drawing.Point(326, 620);
            this.HelpFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpFilter.Name = "HelpFilter";
            this.HelpFilter.Size = new System.Drawing.Size(21, 24);
            this.HelpFilter.TabIndex = 25;
            this.HelpFilter.Text = "?";
            this.HelpFilter.UseVisualStyleBackColor = true;
            this.HelpFilter.Click += new System.EventHandler(this.HelpFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tools:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(228, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "READ/ПРОЧИТАЙ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(356, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HelpFilter);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RegexUnpack);
            this.Controls.Add(this.MountPointTXB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UTocVerCMB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RepackMethodCMB);
            this.Controls.Add(this.RepackBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AESKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArchiveViewTV);
            this.Controls.Add(this.UnpackBTN);
            this.Controls.Add(this.OpenTocBTN);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainTool";
            this.Text = "UnrealUnZen | Unreal Engine IoStore Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenTocBTN;
        private System.Windows.Forms.Button UnpackBTN;
        private System.Windows.Forms.TreeView ArchiveViewTV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AESKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RepackBTN;
        private System.Windows.Forms.ComboBox RepackMethodCMB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox UTocVerCMB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MountPointTXB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RegexUnpack;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem saveManifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixManifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repackUsingCustomManifestToolStripMenuItem;
        private System.Windows.Forms.Button HelpFilter;
        private System.Windows.Forms.ToolStripMenuItem dontUseItIfYouDontKnowHowWorksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

