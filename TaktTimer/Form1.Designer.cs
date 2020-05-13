namespace TaktTimer
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.RunTab = new System.Windows.Forms.TabPage();
            this.PCTSetupTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tCycleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainTabControl.SuspendLayout();
            this.RunTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.RunTab);
            this.mainTabControl.Controls.Add(this.PCTSetupTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ItemSize = new System.Drawing.Size(75, 35);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(771, 464);
            this.mainTabControl.TabIndex = 0;
            // 
            // RunTab
            // 
            this.RunTab.Controls.Add(this.tableLayoutPanel1);
            this.RunTab.Location = new System.Drawing.Point(4, 39);
            this.RunTab.Name = "RunTab";
            this.RunTab.Padding = new System.Windows.Forms.Padding(3);
            this.RunTab.Size = new System.Drawing.Size(763, 421);
            this.RunTab.TabIndex = 0;
            this.RunTab.Text = "Run";
            this.RunTab.UseVisualStyleBackColor = true;
            // 
            // PCTSetupTab
            // 
            this.PCTSetupTab.Location = new System.Drawing.Point(4, 39);
            this.PCTSetupTab.Name = "PCTSetupTab";
            this.PCTSetupTab.Padding = new System.Windows.Forms.Padding(3);
            this.PCTSetupTab.Size = new System.Drawing.Size(763, 421);
            this.PCTSetupTab.TabIndex = 1;
            this.PCTSetupTab.Text = "PCT Setup";
            this.PCTSetupTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tCycleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 415);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tCycleLabel
            // 
            this.tCycleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tCycleLabel.AutoSize = true;
            this.tCycleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 108F);
            this.tCycleLabel.Location = new System.Drawing.Point(150, 63);
            this.tCycleLabel.Name = "tCycleLabel";
            this.tCycleLabel.Size = new System.Drawing.Size(229, 163);
            this.tCycleLabel.TabIndex = 0;
            this.tCycleLabel.Text = "50";
            this.tCycleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.currentTimeLabel, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 293);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(523, 119);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.currentTimeLabel.Location = new System.Drawing.Point(342, 70);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(100, 37);
            this.currentTimeLabel.TabIndex = 0;
            this.currentTimeLabel.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(771, 464);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.Text = "TaktTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.RunTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage RunTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tCycleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.TabPage PCTSetupTab;
        private System.Windows.Forms.Timer timer1;
    }
}

