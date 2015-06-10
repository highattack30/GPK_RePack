﻿namespace GPK_RePack.Forms
{
    partial class Options
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDataProps = new System.Windows.Forms.RadioButton();
            this.btnData = new System.Windows.Forms.RadioButton();
            this.btnProperties = new System.Windows.Forms.RadioButton();
            this.btnLogTrace = new System.Windows.Forms.RadioButton();
            this.btnLogDebug = new System.Windows.Forms.RadioButton();
            this.btnLogInfo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnViewNormal = new System.Windows.Forms.RadioButton();
            this.btnViewClass = new System.Windows.Forms.RadioButton();
            this.boxDebug = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProperties);
            this.groupBox1.Controls.Add(this.btnData);
            this.groupBox1.Controls.Add(this.btnDataProps);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copy Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLogTrace);
            this.groupBox2.Controls.Add(this.btnLogInfo);
            this.groupBox2.Controls.Add(this.btnLogDebug);
            this.groupBox2.Location = new System.Drawing.Point(171, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "The settings are saved automatically.";
            // 
            // btnDataProps
            // 
            this.btnDataProps.AutoSize = true;
            this.btnDataProps.Location = new System.Drawing.Point(6, 19);
            this.btnDataProps.Name = "btnDataProps";
            this.btnDataProps.Size = new System.Drawing.Size(107, 17);
            this.btnDataProps.TabIndex = 0;
            this.btnDataProps.TabStop = true;
            this.btnDataProps.Text = "Data + Properties";
            this.btnDataProps.UseVisualStyleBackColor = true;
            this.btnDataProps.CheckedChanged += new System.EventHandler(this.btnDataProps_CheckedChanged);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(6, 42);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(107, 17);
            this.btnData.TabIndex = 1;
            this.btnData.TabStop = true;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.CheckedChanged += new System.EventHandler(this.btnData_CheckedChanged);
            // 
            // btnProperties
            // 
            this.btnProperties.Location = new System.Drawing.Point(6, 65);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(107, 17);
            this.btnProperties.TabIndex = 2;
            this.btnProperties.TabStop = true;
            this.btnProperties.Text = "Properties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.CheckedChanged += new System.EventHandler(this.btnProperties_CheckedChanged);
            // 
            // btnLogTrace
            // 
            this.btnLogTrace.Location = new System.Drawing.Point(6, 65);
            this.btnLogTrace.Name = "btnLogTrace";
            this.btnLogTrace.Size = new System.Drawing.Size(107, 17);
            this.btnLogTrace.TabIndex = 5;
            this.btnLogTrace.TabStop = true;
            this.btnLogTrace.Text = "Trace";
            this.btnLogTrace.UseVisualStyleBackColor = true;
            this.btnLogTrace.CheckedChanged += new System.EventHandler(this.btnLogTrace_CheckedChanged);
            // 
            // btnLogDebug
            // 
            this.btnLogDebug.Location = new System.Drawing.Point(6, 42);
            this.btnLogDebug.Name = "btnLogDebug";
            this.btnLogDebug.Size = new System.Drawing.Size(107, 17);
            this.btnLogDebug.TabIndex = 4;
            this.btnLogDebug.TabStop = true;
            this.btnLogDebug.Text = "Debug";
            this.btnLogDebug.UseVisualStyleBackColor = true;
            this.btnLogDebug.CheckedChanged += new System.EventHandler(this.btnLogDebug_CheckedChanged);
            // 
            // btnLogInfo
            // 
            this.btnLogInfo.AutoSize = true;
            this.btnLogInfo.Location = new System.Drawing.Point(6, 19);
            this.btnLogInfo.Name = "btnLogInfo";
            this.btnLogInfo.Size = new System.Drawing.Size(43, 17);
            this.btnLogInfo.TabIndex = 3;
            this.btnLogInfo.TabStop = true;
            this.btnLogInfo.Text = "Info";
            this.btnLogInfo.UseVisualStyleBackColor = true;
            this.btnLogInfo.CheckedChanged += new System.EventHandler(this.btnLogInfo_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnViewNormal);
            this.groupBox3.Controls.Add(this.btnViewClass);
            this.groupBox3.Location = new System.Drawing.Point(309, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 98);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Mode";
            // 
            // btnViewNormal
            // 
            this.btnViewNormal.AutoSize = true;
            this.btnViewNormal.Location = new System.Drawing.Point(6, 19);
            this.btnViewNormal.Name = "btnViewNormal";
            this.btnViewNormal.Size = new System.Drawing.Size(141, 17);
            this.btnViewNormal.TabIndex = 3;
            this.btnViewNormal.TabStop = true;
            this.btnViewNormal.Text = "Normal (Imports/Exports)";
            this.btnViewNormal.UseVisualStyleBackColor = true;
            this.btnViewNormal.CheckedChanged += new System.EventHandler(this.btnViewNormal_CheckedChanged);
            // 
            // btnViewClass
            // 
            this.btnViewClass.Location = new System.Drawing.Point(6, 42);
            this.btnViewClass.Name = "btnViewClass";
            this.btnViewClass.Size = new System.Drawing.Size(107, 17);
            this.btnViewClass.TabIndex = 4;
            this.btnViewClass.TabStop = true;
            this.btnViewClass.Text = "Per Class";
            this.btnViewClass.UseVisualStyleBackColor = true;
            this.btnViewClass.CheckedChanged += new System.EventHandler(this.btnViewClass_CheckedChanged);
            // 
            // boxDebug
            // 
            this.boxDebug.AutoSize = true;
            this.boxDebug.Location = new System.Drawing.Point(204, 112);
            this.boxDebug.Name = "boxDebug";
            this.boxDebug.Size = new System.Drawing.Size(88, 17);
            this.boxDebug.TabIndex = 7;
            this.boxDebug.Text = "Debug Mode";
            this.boxDebug.UseVisualStyleBackColor = true;
            this.boxDebug.CheckedChanged += new System.EventHandler(this.boxDebug_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 134);
            this.Controls.Add(this.boxDebug);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnData;
        private System.Windows.Forms.RadioButton btnDataProps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnProperties;
        private System.Windows.Forms.RadioButton btnLogTrace;
        private System.Windows.Forms.RadioButton btnLogInfo;
        private System.Windows.Forms.RadioButton btnLogDebug;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btnViewNormal;
        private System.Windows.Forms.RadioButton btnViewClass;
        private System.Windows.Forms.CheckBox boxDebug;
    }
}