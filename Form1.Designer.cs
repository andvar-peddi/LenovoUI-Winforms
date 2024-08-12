﻿namespace LenovoUI.Winforms
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            splitContainer = new SplitContainer();
            leftTableLayout = new TableLayoutPanel();
            labelGPU = new Label();
            labelVRAM = new Label();
            labelSSD = new Label();
            buttonStorage = new Button();
            buttonMacroKey = new Button();
            buttonPower = new Button();
            buttonMedia = new Button();
            buttonHardwareScan = new Button();
            buttonSystemUpdate = new Button();
            buttonCPU = new Button();
            buttonVRAM = new Button();
            button1 = new Button();
            labelSystemTools = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox12 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            label13 = new Label();
            labelLegionEdge = new Label();
            labelThermalMode = new Label();
            labelGPUOverlock = new Label();
            labelNetworkBoost = new Label();
            labelAutoClose = new Label();
            labelGPUWorkingMode = new Label();
            labelOverDrive = new Label();
            labelTouchpadLock = new Label();
            labelQuick = new Label();
            labelRapidCharge = new Label();
            labelWiFiSecurity = new Label();
            checkBox1 = new CheckBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            leftTableLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.BackColor = SystemColors.ControlDarkDark;
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.ForeColor = SystemColors.ControlText;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = SystemColors.ControlDarkDark;
            splitContainer.Panel1.Controls.Add(leftTableLayout);
            splitContainer.Panel1.Padding = new Padding(40);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer.Panel2.Padding = new Padding(40);
            splitContainer.Size = new Size(1876, 1139);
            splitContainer.SplitterDistance = 1192;
            splitContainer.SplitterWidth = 10;
            splitContainer.TabIndex = 0;
            // 
            // leftTableLayout
            // 
            leftTableLayout.AutoSize = true;
            leftTableLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            leftTableLayout.BackColor = Color.DarkSlateGray;
            leftTableLayout.ColumnCount = 5;
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.Controls.Add(labelGPU, 0, 1);
            leftTableLayout.Controls.Add(labelVRAM, 2, 1);
            leftTableLayout.Controls.Add(labelSSD, 4, 1);
            leftTableLayout.Controls.Add(buttonStorage, 4, 0);
            leftTableLayout.Controls.Add(buttonMacroKey, 1, 3);
            leftTableLayout.Controls.Add(buttonPower, 2, 3);
            leftTableLayout.Controls.Add(buttonMedia, 3, 3);
            leftTableLayout.Controls.Add(buttonHardwareScan, 4, 3);
            leftTableLayout.Controls.Add(buttonSystemUpdate, 0, 3);
            leftTableLayout.Controls.Add(buttonCPU, 1, 0);
            leftTableLayout.Controls.Add(buttonVRAM, 2, 0);
            leftTableLayout.Controls.Add(button1, 0, 0);
            leftTableLayout.Controls.Add(labelSystemTools, 0, 2);
            leftTableLayout.Controls.Add(label1, 0, 5);
            leftTableLayout.Dock = DockStyle.Fill;
            leftTableLayout.ForeColor = SystemColors.Control;
            leftTableLayout.Location = new Point(40, 40);
            leftTableLayout.Margin = new Padding(0);
            leftTableLayout.Name = "leftTableLayout";
            leftTableLayout.Padding = new Padding(40);
            leftTableLayout.RowCount = 6;
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            leftTableLayout.Size = new Size(1112, 1059);
            leftTableLayout.TabIndex = 0;
            // 
            // labelGPU
            // 
            labelGPU.BackColor = Color.Transparent;
            labelGPU.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGPU.ForeColor = Color.Transparent;
            labelGPU.Location = new Point(60, 334);
            labelGPU.Margin = new Padding(20, 1, 0, 0);
            labelGPU.Name = "labelGPU";
            labelGPU.Size = new Size(65, 30);
            labelGPU.TabIndex = 4;
            labelGPU.Text = "GPU";
            // 
            // labelVRAM
            // 
            labelVRAM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelVRAM.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVRAM.Location = new Point(583, 334);
            labelVRAM.Margin = new Padding(0, 1, 0, 0);
            labelVRAM.Name = "labelVRAM";
            labelVRAM.Size = new Size(75, 30);
            labelVRAM.TabIndex = 5;
            labelVRAM.Text = "VRAM";
            // 
            // labelSSD
            // 
            labelSSD.Anchor = AnchorStyles.Top;
            labelSSD.AutoSize = true;
            labelSSD.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSSD.ForeColor = SystemColors.Control;
            labelSSD.Location = new Point(942, 334);
            labelSSD.Margin = new Padding(0, 1, 0, 0);
            labelSSD.Name = "labelSSD";
            labelSSD.Size = new Size(52, 30);
            labelSSD.TabIndex = 6;
            labelSSD.Text = "SSD";
            // 
            // buttonStorage
            // 
            buttonStorage.Dock = DockStyle.Bottom;
            buttonStorage.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStorage.ForeColor = SystemColors.ControlText;
            buttonStorage.Location = new Point(864, 180);
            buttonStorage.Margin = new Padding(0, 20, 0, 20);
            buttonStorage.Name = "buttonStorage";
            buttonStorage.Size = new Size(208, 133);
            buttonStorage.TabIndex = 3;
            buttonStorage.Text = "88%";
            toolTip1.SetToolTip(buttonStorage, "Available space");
            buttonStorage.UseVisualStyleBackColor = true;
            // 
            // buttonMacroKey
            // 
            buttonMacroKey.Dock = DockStyle.Top;
            buttonMacroKey.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMacroKey.ForeColor = SystemColors.ControlText;
            buttonMacroKey.Location = new Point(266, 547);
            buttonMacroKey.Margin = new Padding(20);
            buttonMacroKey.Name = "buttonMacroKey";
            buttonMacroKey.Size = new Size(166, 123);
            buttonMacroKey.TabIndex = 9;
            buttonMacroKey.Text = "Macro Key";
            buttonMacroKey.UseVisualStyleBackColor = true;
            // 
            // buttonPower
            // 
            buttonPower.Dock = DockStyle.Top;
            buttonPower.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPower.ForeColor = SystemColors.ControlText;
            buttonPower.Location = new Point(472, 547);
            buttonPower.Margin = new Padding(20);
            buttonPower.Name = "buttonPower";
            buttonPower.Size = new Size(166, 123);
            buttonPower.TabIndex = 10;
            buttonPower.Text = "Power";
            buttonPower.UseVisualStyleBackColor = true;
            // 
            // buttonMedia
            // 
            buttonMedia.Dock = DockStyle.Top;
            buttonMedia.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMedia.ForeColor = SystemColors.ControlText;
            buttonMedia.Location = new Point(678, 547);
            buttonMedia.Margin = new Padding(20);
            buttonMedia.Name = "buttonMedia";
            buttonMedia.Size = new Size(166, 123);
            buttonMedia.TabIndex = 12;
            buttonMedia.Text = "Media";
            buttonMedia.UseVisualStyleBackColor = true;
            // 
            // buttonHardwareScan
            // 
            buttonHardwareScan.Dock = DockStyle.Top;
            buttonHardwareScan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonHardwareScan.ForeColor = SystemColors.ControlText;
            buttonHardwareScan.Location = new Point(884, 547);
            buttonHardwareScan.Margin = new Padding(20);
            buttonHardwareScan.Name = "buttonHardwareScan";
            buttonHardwareScan.Size = new Size(168, 123);
            buttonHardwareScan.TabIndex = 11;
            buttonHardwareScan.Text = "Hardware Scan";
            buttonHardwareScan.UseVisualStyleBackColor = true;
            // 
            // buttonSystemUpdate
            // 
            buttonSystemUpdate.Dock = DockStyle.Top;
            buttonSystemUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSystemUpdate.ForeColor = SystemColors.ControlText;
            buttonSystemUpdate.Location = new Point(60, 547);
            buttonSystemUpdate.Margin = new Padding(20);
            buttonSystemUpdate.Name = "buttonSystemUpdate";
            buttonSystemUpdate.Size = new Size(166, 123);
            buttonSystemUpdate.TabIndex = 8;
            buttonSystemUpdate.Text = "System Update";
            buttonSystemUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonCPU
            // 
            buttonCPU.Dock = DockStyle.Bottom;
            buttonCPU.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCPU.ForeColor = SystemColors.ControlText;
            buttonCPU.Location = new Point(246, 88);
            buttonCPU.Margin = new Padding(0, 20, 0, 20);
            buttonCPU.Name = "buttonCPU";
            buttonCPU.Size = new Size(206, 225);
            buttonCPU.TabIndex = 0;
            buttonCPU.Text = "CPU";
            toolTip1.SetToolTip(buttonCPU, "CPU usage");
            buttonCPU.UseVisualStyleBackColor = true;
            // 
            // buttonVRAM
            // 
            buttonVRAM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonVRAM.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVRAM.ForeColor = SystemColors.ControlText;
            buttonVRAM.Location = new Point(593, 70);
            buttonVRAM.Margin = new Padding(20, 30, 20, 30);
            buttonVRAM.Name = "buttonVRAM";
            buttonVRAM.Size = new Size(45, 233);
            buttonVRAM.TabIndex = 2;
            toolTip1.SetToolTip(buttonVRAM, "VRAM usage");
            buttonVRAM.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(60, 70);
            button1.Margin = new Padding(20, 30, 20, 30);
            button1.Name = "button1";
            button1.Size = new Size(45, 233);
            button1.TabIndex = 14;
            toolTip1.SetToolTip(button1, "VRAM usage");
            button1.UseVisualStyleBackColor = true;
            // 
            // labelSystemTools
            // 
            labelSystemTools.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSystemTools.AutoSize = true;
            labelSystemTools.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSystemTools.Location = new Point(40, 489);
            labelSystemTools.Margin = new Padding(0);
            labelSystemTools.Name = "labelSystemTools";
            labelSystemTools.Size = new Size(176, 38);
            labelSystemTools.TabIndex = 7;
            labelSystemTools.Text = "System Tools";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 820);
            label1.Margin = new Padding(0, 1, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 38);
            label1.TabIndex = 13;
            label1.Text = "System Health";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.DarkSlateGray;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(checkBox12, 1, 11);
            tableLayoutPanel1.Controls.Add(checkBox11, 1, 10);
            tableLayoutPanel1.Controls.Add(checkBox10, 1, 9);
            tableLayoutPanel1.Controls.Add(checkBox8, 1, 7);
            tableLayoutPanel1.Controls.Add(checkBox7, 1, 6);
            tableLayoutPanel1.Controls.Add(checkBox6, 1, 5);
            tableLayoutPanel1.Controls.Add(checkBox5, 1, 4);
            tableLayoutPanel1.Controls.Add(checkBox4, 1, 3);
            tableLayoutPanel1.Controls.Add(checkBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(checkBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(label13, 0, 11);
            tableLayoutPanel1.Controls.Add(labelLegionEdge, 0, 0);
            tableLayoutPanel1.Controls.Add(labelThermalMode, 0, 1);
            tableLayoutPanel1.Controls.Add(labelGPUOverlock, 0, 2);
            tableLayoutPanel1.Controls.Add(labelNetworkBoost, 0, 3);
            tableLayoutPanel1.Controls.Add(labelAutoClose, 0, 4);
            tableLayoutPanel1.Controls.Add(labelGPUWorkingMode, 0, 5);
            tableLayoutPanel1.Controls.Add(labelOverDrive, 0, 6);
            tableLayoutPanel1.Controls.Add(labelTouchpadLock, 0, 7);
            tableLayoutPanel1.Controls.Add(labelQuick, 0, 8);
            tableLayoutPanel1.Controls.Add(labelRapidCharge, 0, 9);
            tableLayoutPanel1.Controls.Add(labelWiFiSecurity, 0, 10);
            tableLayoutPanel1.Controls.Add(checkBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(40, 40);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(40);
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.95825624F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.958257F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.958257F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.958257F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.958257F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.958257F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.958257F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.958257F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.459178F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.958257F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.958257F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.958257F));
            tableLayoutPanel1.Size = new Size(594, 1059);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // checkBox12
            // 
            checkBox12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox12.AutoSize = true;
            checkBox12.ForeColor = SystemColors.Control;
            checkBox12.Location = new Point(427, 990);
            checkBox12.Margin = new Padding(130, 0, 0, 0);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(127, 29);
            checkBox12.TabIndex = 24;
            checkBox12.Text = "checkBox12";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox11.AutoSize = true;
            checkBox11.ForeColor = SystemColors.Control;
            checkBox11.Location = new Point(427, 902);
            checkBox11.Margin = new Padding(130, 0, 0, 0);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(127, 29);
            checkBox11.TabIndex = 23;
            checkBox11.Text = "checkBox11";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox10.AutoSize = true;
            checkBox10.ForeColor = SystemColors.Control;
            checkBox10.Location = new Point(427, 825);
            checkBox10.Margin = new Padding(130, 0, 0, 0);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(127, 29);
            checkBox10.TabIndex = 22;
            checkBox10.Text = "checkBox10";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox8.AutoSize = true;
            checkBox8.ForeColor = SystemColors.Control;
            checkBox8.Location = new Point(433, 627);
            checkBox8.Margin = new Padding(130, 0, 0, 0);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(121, 29);
            checkBox8.TabIndex = 20;
            checkBox8.Text = "checkBox8";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox7.AutoSize = true;
            checkBox7.ForeColor = SystemColors.Control;
            checkBox7.Location = new Point(433, 550);
            checkBox7.Margin = new Padding(130, 0, 0, 0);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(121, 29);
            checkBox7.TabIndex = 19;
            checkBox7.Text = "checkBox7";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox6.AutoSize = true;
            checkBox6.ForeColor = SystemColors.Control;
            checkBox6.Location = new Point(433, 473);
            checkBox6.Margin = new Padding(130, 0, 0, 0);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(121, 29);
            checkBox6.TabIndex = 18;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox5.AutoSize = true;
            checkBox5.ForeColor = SystemColors.Control;
            checkBox5.Location = new Point(433, 396);
            checkBox5.Margin = new Padding(130, 0, 0, 0);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(121, 29);
            checkBox5.TabIndex = 17;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = SystemColors.Control;
            checkBox4.Location = new Point(433, 319);
            checkBox4.Margin = new Padding(130, 0, 0, 0);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(121, 29);
            checkBox4.TabIndex = 16;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = SystemColors.Control;
            checkBox3.Location = new Point(433, 242);
            checkBox3.Margin = new Padding(130, 0, 0, 0);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 29);
            checkBox3.TabIndex = 15;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = SystemColors.Control;
            checkBox2.Location = new Point(433, 165);
            checkBox2.Margin = new Padding(130, 0, 0, 0);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 29);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Bottom;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(40, 987);
            label13.Margin = new Padding(0);
            label13.Name = "label13";
            label13.Size = new Size(257, 32);
            label13.TabIndex = 12;
            label13.Text = "Adaptive Refresh Rate";
            // 
            // labelLegionEdge
            // 
            labelLegionEdge.AutoSize = true;
            labelLegionEdge.Dock = DockStyle.Bottom;
            labelLegionEdge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLegionEdge.ForeColor = SystemColors.Control;
            labelLegionEdge.Location = new Point(40, 79);
            labelLegionEdge.Margin = new Padding(0);
            labelLegionEdge.Name = "labelLegionEdge";
            labelLegionEdge.Size = new Size(257, 38);
            labelLegionEdge.TabIndex = 1;
            labelLegionEdge.Text = "Legion Edge";
            // 
            // labelThermalMode
            // 
            labelThermalMode.AutoSize = true;
            labelThermalMode.Dock = DockStyle.Bottom;
            labelThermalMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelThermalMode.ForeColor = SystemColors.Control;
            labelThermalMode.Location = new Point(40, 162);
            labelThermalMode.Margin = new Padding(0);
            labelThermalMode.Name = "labelThermalMode";
            labelThermalMode.Size = new Size(257, 32);
            labelThermalMode.TabIndex = 2;
            labelThermalMode.Text = "Thermal Mode";
            // 
            // labelGPUOverlock
            // 
            labelGPUOverlock.AutoSize = true;
            labelGPUOverlock.Dock = DockStyle.Bottom;
            labelGPUOverlock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGPUOverlock.ForeColor = SystemColors.Control;
            labelGPUOverlock.Location = new Point(40, 239);
            labelGPUOverlock.Margin = new Padding(0);
            labelGPUOverlock.Name = "labelGPUOverlock";
            labelGPUOverlock.Size = new Size(257, 32);
            labelGPUOverlock.TabIndex = 3;
            labelGPUOverlock.Text = "GPU Overclock";
            // 
            // labelNetworkBoost
            // 
            labelNetworkBoost.AutoSize = true;
            labelNetworkBoost.Dock = DockStyle.Bottom;
            labelNetworkBoost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNetworkBoost.ForeColor = SystemColors.Control;
            labelNetworkBoost.Location = new Point(40, 316);
            labelNetworkBoost.Margin = new Padding(0);
            labelNetworkBoost.Name = "labelNetworkBoost";
            labelNetworkBoost.Size = new Size(257, 32);
            labelNetworkBoost.TabIndex = 4;
            labelNetworkBoost.Text = "Network Boost";
            // 
            // labelAutoClose
            // 
            labelAutoClose.AutoSize = true;
            labelAutoClose.Dock = DockStyle.Bottom;
            labelAutoClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAutoClose.ForeColor = SystemColors.Control;
            labelAutoClose.Location = new Point(40, 393);
            labelAutoClose.Margin = new Padding(0);
            labelAutoClose.Name = "labelAutoClose";
            labelAutoClose.Size = new Size(257, 32);
            labelAutoClose.TabIndex = 5;
            labelAutoClose.Text = "Auto Close";
            // 
            // labelGPUWorkingMode
            // 
            labelGPUWorkingMode.AutoSize = true;
            labelGPUWorkingMode.Dock = DockStyle.Bottom;
            labelGPUWorkingMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGPUWorkingMode.ForeColor = SystemColors.Control;
            labelGPUWorkingMode.Location = new Point(40, 470);
            labelGPUWorkingMode.Margin = new Padding(0);
            labelGPUWorkingMode.Name = "labelGPUWorkingMode";
            labelGPUWorkingMode.Size = new Size(257, 32);
            labelGPUWorkingMode.TabIndex = 6;
            labelGPUWorkingMode.Text = "GPU Working Mode";
            // 
            // labelOverDrive
            // 
            labelOverDrive.AutoSize = true;
            labelOverDrive.Dock = DockStyle.Bottom;
            labelOverDrive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOverDrive.ForeColor = SystemColors.Control;
            labelOverDrive.Location = new Point(40, 547);
            labelOverDrive.Margin = new Padding(0);
            labelOverDrive.Name = "labelOverDrive";
            labelOverDrive.Size = new Size(257, 32);
            labelOverDrive.TabIndex = 7;
            labelOverDrive.Text = "Over Drive";
            // 
            // labelTouchpadLock
            // 
            labelTouchpadLock.AutoSize = true;
            labelTouchpadLock.Dock = DockStyle.Bottom;
            labelTouchpadLock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTouchpadLock.ForeColor = SystemColors.Control;
            labelTouchpadLock.Location = new Point(40, 624);
            labelTouchpadLock.Margin = new Padding(0);
            labelTouchpadLock.Name = "labelTouchpadLock";
            labelTouchpadLock.Size = new Size(257, 32);
            labelTouchpadLock.TabIndex = 8;
            labelTouchpadLock.Text = "Touchpad Lock";
            // 
            // labelQuick
            // 
            labelQuick.AutoSize = true;
            labelQuick.Dock = DockStyle.Bottom;
            labelQuick.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQuick.ForeColor = SystemColors.Control;
            labelQuick.Location = new Point(40, 732);
            labelQuick.Margin = new Padding(0);
            labelQuick.Name = "labelQuick";
            labelQuick.Size = new Size(257, 45);
            labelQuick.TabIndex = 9;
            labelQuick.Text = "Quick Settings";
            // 
            // labelRapidCharge
            // 
            labelRapidCharge.AutoSize = true;
            labelRapidCharge.Dock = DockStyle.Bottom;
            labelRapidCharge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRapidCharge.ForeColor = SystemColors.Control;
            labelRapidCharge.Location = new Point(40, 822);
            labelRapidCharge.Margin = new Padding(0);
            labelRapidCharge.Name = "labelRapidCharge";
            labelRapidCharge.Size = new Size(257, 32);
            labelRapidCharge.TabIndex = 10;
            labelRapidCharge.Text = "Rapid Charge";
            // 
            // labelWiFiSecurity
            // 
            labelWiFiSecurity.AutoSize = true;
            labelWiFiSecurity.Dock = DockStyle.Bottom;
            labelWiFiSecurity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWiFiSecurity.ForeColor = SystemColors.Control;
            labelWiFiSecurity.Location = new Point(40, 899);
            labelWiFiSecurity.Margin = new Padding(0);
            labelWiFiSecurity.Name = "labelWiFiSecurity";
            labelWiFiSecurity.Size = new Size(257, 32);
            labelWiFiSecurity.TabIndex = 11;
            labelWiFiSecurity.Text = "WiFi Security";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(433, 88);
            checkBox1.Margin = new Padding(130, 0, 0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1876, 1139);
            Controls.Add(splitContainer);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LenovoUI";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            leftTableLayout.ResumeLayout(false);
            leftTableLayout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TableLayoutPanel leftTableLayout;
        private Button buttonCPU;
        private Button buttonVRAM;
        private Button buttonStorage;
        private Label labelGPU;
        private Label labelVRAM;
        private Label labelSSD;
        private Label labelSystemTools;
        private Button buttonSystemUpdate;
        private Button buttonMacroKey;
        private Button buttonPower;
        private Button buttonMedia;
        private Button buttonHardwareScan;
        private Label label1;
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelLegionEdge;
        private Label label13;
        private Label labelThermalMode;
        private Label labelGPUOverlock;
        private Label labelNetworkBoost;
        private Label labelAutoClose;
        private Label labelGPUWorkingMode;
        private Label labelOverDrive;
        private Label labelTouchpadLock;
        private Label labelQuick;
        private Label labelRapidCharge;
        private Label labelWiFiSecurity;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button1;
    }
}
