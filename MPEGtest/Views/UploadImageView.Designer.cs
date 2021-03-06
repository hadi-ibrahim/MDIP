﻿namespace MPEGtest.Views
{
    partial class UploadImageView
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConceptTxt = new System.Windows.Forms.TextBox();
            this.EventTxt = new System.Windows.Forms.TextBox();
            this.SpatialRelationSourceTxt = new System.Windows.Forms.TextBox();
            this.TemporalRelationSourceTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.AgentTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RelationTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.SpatialRelationTxt = new System.Windows.Forms.TextBox();
            this.SpatialRelationTargetTxt = new System.Windows.Forms.TextBox();
            this.TemporalRelationTxt = new System.Windows.Forms.TextBox();
            this.TemporalRelationTargetTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BrowseButtonOnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExitButtonOnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Concept";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Spatial Relation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temporal Relation";
            // 
            // ConceptTxt
            // 
            this.ConceptTxt.Location = new System.Drawing.Point(477, 184);
            this.ConceptTxt.Name = "ConceptTxt";
            this.ConceptTxt.Size = new System.Drawing.Size(176, 20);
            this.ConceptTxt.TabIndex = 8;
            // 
            // EventTxt
            // 
            this.EventTxt.Location = new System.Drawing.Point(477, 218);
            this.EventTxt.Name = "EventTxt";
            this.EventTxt.Size = new System.Drawing.Size(176, 20);
            this.EventTxt.TabIndex = 9;
            // 
            // SpatialRelationSourceTxt
            // 
            this.SpatialRelationSourceTxt.Location = new System.Drawing.Point(477, 253);
            this.SpatialRelationSourceTxt.Name = "SpatialRelationSourceTxt";
            this.SpatialRelationSourceTxt.Size = new System.Drawing.Size(52, 20);
            this.SpatialRelationSourceTxt.TabIndex = 10;
            // 
            // TemporalRelationSourceTxt
            // 
            this.TemporalRelationSourceTxt.Location = new System.Drawing.Point(477, 294);
            this.TemporalRelationSourceTxt.Name = "TemporalRelationSourceTxt";
            this.TemporalRelationSourceTxt.Size = new System.Drawing.Size(52, 20);
            this.TemporalRelationSourceTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (128)))), ((int) (((byte) (255)))));
            this.label6.Location = new System.Drawing.Point(366, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Insert All The information for the selected image";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 30);
            this.button3.TabIndex = 14;
            this.button3.Text = "Upload Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.UploadButtonOnClick);
            // 
            // AgentTxt
            // 
            this.AgentTxt.Location = new System.Drawing.Point(477, 338);
            this.AgentTxt.Name = "AgentTxt";
            this.AgentTxt.Size = new System.Drawing.Size(176, 20);
            this.AgentTxt.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Agent";
            // 
            // RelationTxt
            // 
            this.RelationTxt.Location = new System.Drawing.Point(477, 376);
            this.RelationTxt.Name = "RelationTxt";
            this.RelationTxt.Size = new System.Drawing.Size(176, 20);
            this.RelationTxt.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Relation";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(366, 507);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 30);
            this.button4.TabIndex = 22;
            this.button4.Text = "Search for image";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SearchHereButtonOnClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(183, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Upload New Image";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 100);
            this.panel1.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Location = new System.Drawing.Point(142, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 30);
            this.button5.TabIndex = 23;
            this.button5.Text = "Open filters";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OpenFiltersButtonClick);
            // 
            // imagePanel
            // 
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagePanel.Location = new System.Drawing.Point(25, 140);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(293, 242);
            this.imagePanel.TabIndex = 25;
            // 
            // SpatialRelationTxt
            // 
            this.SpatialRelationTxt.Location = new System.Drawing.Point(535, 253);
            this.SpatialRelationTxt.Name = "SpatialRelationTxt";
            this.SpatialRelationTxt.Size = new System.Drawing.Size(61, 20);
            this.SpatialRelationTxt.TabIndex = 8;
            // 
            // SpatialRelationTargetTxt
            // 
            this.SpatialRelationTargetTxt.Location = new System.Drawing.Point(602, 253);
            this.SpatialRelationTargetTxt.Name = "SpatialRelationTargetTxt";
            this.SpatialRelationTargetTxt.Size = new System.Drawing.Size(51, 20);
            this.SpatialRelationTargetTxt.TabIndex = 8;
            // 
            // TemporalRelationTxt
            // 
            this.TemporalRelationTxt.Location = new System.Drawing.Point(536, 294);
            this.TemporalRelationTxt.Name = "TemporalRelationTxt";
            this.TemporalRelationTxt.Size = new System.Drawing.Size(60, 20);
            this.TemporalRelationTxt.TabIndex = 18;
            // 
            // TemporalRelationTargetTxt
            // 
            this.TemporalRelationTargetTxt.Location = new System.Drawing.Point(602, 294);
            this.TemporalRelationTargetTxt.Name = "TemporalRelationTargetTxt";
            this.TemporalRelationTargetTxt.Size = new System.Drawing.Size(51, 20);
            this.TemporalRelationTargetTxt.TabIndex = 0;
            // 
            // UploadImageView
            // 
            this.ClientSize = new System.Drawing.Size(711, 544);
            this.Controls.Add(this.TemporalRelationTargetTxt);
            this.Controls.Add(this.TemporalRelationTxt);
            this.Controls.Add(this.SpatialRelationTargetTxt);
            this.Controls.Add(this.SpatialRelationTxt);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RelationTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AgentTxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TemporalRelationSourceTxt);
            this.Controls.Add(this.SpatialRelationSourceTxt);
            this.Controls.Add(this.EventTxt);
            this.Controls.Add(this.ConceptTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "UploadImageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel imagePanel;

        private System.Windows.Forms.Button button5;

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConceptTxt;
        private System.Windows.Forms.TextBox EventTxt;
        private System.Windows.Forms.TextBox SpatialRelationSourceTxt;
        private System.Windows.Forms.TextBox TemporalRelationSourceTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox AgentTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RelationTxt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox SpatialRelationTxt;
        private System.Windows.Forms.TextBox SpatialRelationTargetTxt;
        private System.Windows.Forms.TextBox TemporalRelationTxt;
        private System.Windows.Forms.TextBox TemporalRelationTargetTxt;
    }
}

