namespace GADE6112_Task_3___19011648
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
            this.components = new System.ComponentModel.Container();
            this.gpbxMap = new System.Windows.Forms.GroupBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.tmrRound = new System.Windows.Forms.Timer(this.components);
            this.btnControl = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.trkbrWidth = new System.Windows.Forms.TrackBar();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.trkbrHeight = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbxMap
            // 
            this.gpbxMap.Location = new System.Drawing.Point(12, 12);
            this.gpbxMap.Name = "gpbxMap";
            this.gpbxMap.Size = new System.Drawing.Size(665, 695);
            this.gpbxMap.TabIndex = 0;
            this.gpbxMap.TabStop = false;
            this.gpbxMap.Text = "Map";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(683, 346);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(325, 361);
            this.txtOut.TabIndex = 1;
            // 
            // tmrRound
            // 
            this.tmrRound.Interval = 500;
            this.tmrRound.Tick += new System.EventHandler(this.TmrRound_Tick);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(683, 202);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(325, 66);
            this.btnControl.TabIndex = 2;
            this.btnControl.Text = "Start Sim";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.BtnControl_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(851, 274);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(157, 66);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(683, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 66);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(683, 24);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(46, 17);
            this.lblRound.TabIndex = 5;
            this.lblRound.Text = "label1";
            // 
            // trkbrWidth
            // 
            this.trkbrWidth.Location = new System.Drawing.Point(683, 61);
            this.trkbrWidth.Maximum = 100;
            this.trkbrWidth.Minimum = 1;
            this.trkbrWidth.Name = "trkbrWidth";
            this.trkbrWidth.Size = new System.Drawing.Size(325, 56);
            this.trkbrWidth.TabIndex = 6;
            this.trkbrWidth.Value = 1;
            this.trkbrWidth.Scroll += new System.EventHandler(this.TrkbrWidth_Scroll);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(683, 41);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(91, 17);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Map Width: 1";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(683, 120);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(96, 17);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Map Height: 1";
            // 
            // trkbrHeight
            // 
            this.trkbrHeight.Location = new System.Drawing.Point(683, 140);
            this.trkbrHeight.Maximum = 100;
            this.trkbrHeight.Minimum = 1;
            this.trkbrHeight.Name = "trkbrHeight";
            this.trkbrHeight.Size = new System.Drawing.Size(325, 56);
            this.trkbrHeight.TabIndex = 9;
            this.trkbrHeight.Value = 1;
            this.trkbrHeight.Scroll += new System.EventHandler(this.TrkbrHeight_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 719);
            this.Controls.Add(this.trkbrHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.trkbrWidth);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.gpbxMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkbrWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxMap;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Timer tmrRound;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.TrackBar trkbrWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TrackBar trkbrHeight;
    }
}

