﻿namespace ServerAdmin
{
    partial class PatchesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatchesForm));
            this.selectButton = new System.Windows.Forms.Button();
            this.patchList = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cfgButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(12, 143);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(259, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select Patches";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // patchList
            // 
            this.patchList.FormattingEnabled = true;
            this.patchList.Location = new System.Drawing.Point(13, 12);
            this.patchList.Name = "patchList";
            this.patchList.Size = new System.Drawing.Size(259, 121);
            this.patchList.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 203);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // cfgButton
            // 
            this.cfgButton.Location = new System.Drawing.Point(12, 172);
            this.cfgButton.Name = "cfgButton";
            this.cfgButton.Size = new System.Drawing.Size(259, 23);
            this.cfgButton.TabIndex = 5;
            this.cfgButton.Text = "Configure";
            this.cfgButton.UseVisualStyleBackColor = true;
            this.cfgButton.Click += new System.EventHandler(this.cfgButton_Click_1);
            // 
            // PatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.cfgButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.patchList);
            this.Controls.Add(this.selectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatchesForm";
            this.Text = "Patch File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatchesForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ListBox patchList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button cfgButton;
    }
}