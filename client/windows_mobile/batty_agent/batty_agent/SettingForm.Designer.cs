﻿namespace nayutaya.batty.agent
{
    partial class SettingForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.settingTab = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.validTokenLabel = new System.Windows.Forms.Label();
            this.invalidTokenLabel = new System.Windows.Forms.Label();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recordTabPage = new System.Windows.Forms.TabPage();
            this.recordOnAcConnectCheckBox = new System.Windows.Forms.CheckBox();
            this.recordOnChargeCheckBox = new System.Windows.Forms.CheckBox();
            this.recordTimingTabPage = new System.Windows.Forms.TabPage();
            this.recordOnChargeChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.recordOnLevelChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recordOnIntervalComboBox = new System.Windows.Forms.ComboBox();
            this.recordOnIntervalCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendTimingTabPage = new System.Windows.Forms.TabPage();
            this.sendOnChargeChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.sendOnLevelChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendOnCountComboBox = new System.Windows.Forms.ComboBox();
            this.sendOnCountCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendOnIntervalComboBox = new System.Windows.Forms.ComboBox();
            this.sendOnIntervalCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.settingTab.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.recordTabPage.SuspendLayout();
            this.recordTimingTabPage.SuspendLayout();
            this.sendTimingTabPage.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingTab
            // 
            this.settingTab.Controls.Add(this.generalTabPage);
            this.settingTab.Controls.Add(this.recordTabPage);
            this.settingTab.Controls.Add(this.recordTimingTabPage);
            this.settingTab.Controls.Add(this.sendTimingTabPage);
            this.settingTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingTab.Location = new System.Drawing.Point(0, 0);
            this.settingTab.Name = "settingTab";
            this.settingTab.SelectedIndex = 0;
            this.settingTab.Size = new System.Drawing.Size(240, 268);
            this.settingTab.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.panel6);
            this.generalTabPage.Location = new System.Drawing.Point(0, 0);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(240, 245);
            this.generalTabPage.Text = "基本";
            // 
            // validTokenLabel
            // 
            this.validTokenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.validTokenLabel.ForeColor = System.Drawing.Color.Green;
            this.validTokenLabel.Location = new System.Drawing.Point(3, 43);
            this.validTokenLabel.Name = "validTokenLabel";
            this.validTokenLabel.Size = new System.Drawing.Size(220, 32);
            this.validTokenLabel.Text = "デバイストークンは正しい形式です。";
            // 
            // invalidTokenLabel
            // 
            this.invalidTokenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.invalidTokenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.invalidTokenLabel.Location = new System.Drawing.Point(3, 43);
            this.invalidTokenLabel.Name = "invalidTokenLabel";
            this.invalidTokenLabel.Size = new System.Drawing.Size(220, 32);
            this.invalidTokenLabel.Text = "デバイストークンが正しい形式ではありません。";
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenTextBox.Location = new System.Drawing.Point(3, 19);
            this.tokenTextBox.MaxLength = 20;
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(220, 21);
            this.tokenTextBox.TabIndex = 1;
            this.tokenTextBox.TextChanged += new System.EventHandler(this.tokenTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 16);
            this.label6.Text = "デバイストークン";
            // 
            // recordTabPage
            // 
            this.recordTabPage.Controls.Add(this.panel7);
            this.recordTabPage.Location = new System.Drawing.Point(0, 0);
            this.recordTabPage.Name = "recordTabPage";
            this.recordTabPage.Size = new System.Drawing.Size(240, 245);
            this.recordTabPage.Text = "記録";
            // 
            // recordOnAcConnectCheckBox
            // 
            this.recordOnAcConnectCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recordOnAcConnectCheckBox.Location = new System.Drawing.Point(3, 74);
            this.recordOnAcConnectCheckBox.Name = "recordOnAcConnectCheckBox";
            this.recordOnAcConnectCheckBox.Size = new System.Drawing.Size(220, 20);
            this.recordOnAcConnectCheckBox.TabIndex = 1;
            this.recordOnAcConnectCheckBox.Text = "電源接続中も記録する";
            // 
            // recordOnChargeCheckBox
            // 
            this.recordOnChargeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recordOnChargeCheckBox.Location = new System.Drawing.Point(3, 0);
            this.recordOnChargeCheckBox.Name = "recordOnChargeCheckBox";
            this.recordOnChargeCheckBox.Size = new System.Drawing.Size(220, 20);
            this.recordOnChargeCheckBox.TabIndex = 0;
            this.recordOnChargeCheckBox.Text = "充電中も記録する";
            // 
            // recordTimingTabPage
            // 
            this.recordTimingTabPage.Controls.Add(this.panel8);
            this.recordTimingTabPage.Location = new System.Drawing.Point(0, 0);
            this.recordTimingTabPage.Name = "recordTimingTabPage";
            this.recordTimingTabPage.Size = new System.Drawing.Size(240, 245);
            this.recordTimingTabPage.Text = "記録タイミング";
            // 
            // recordOnChargeChangeCheckBox
            // 
            this.recordOnChargeChangeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recordOnChargeChangeCheckBox.Location = new System.Drawing.Point(3, 115);
            this.recordOnChargeChangeCheckBox.Name = "recordOnChargeChangeCheckBox";
            this.recordOnChargeChangeCheckBox.Size = new System.Drawing.Size(220, 20);
            this.recordOnChargeChangeCheckBox.TabIndex = 4;
            this.recordOnChargeChangeCheckBox.Text = "充電状態変化時に記録";
            // 
            // recordOnLevelChangeCheckBox
            // 
            this.recordOnLevelChangeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recordOnLevelChangeCheckBox.Location = new System.Drawing.Point(3, 89);
            this.recordOnLevelChangeCheckBox.Name = "recordOnLevelChangeCheckBox";
            this.recordOnLevelChangeCheckBox.Size = new System.Drawing.Size(220, 20);
            this.recordOnLevelChangeCheckBox.TabIndex = 5;
            this.recordOnLevelChangeCheckBox.Text = "バッテリレベル変化時に記録";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(89, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.Text = "分";
            // 
            // recordOnIntervalComboBox
            // 
            this.recordOnIntervalComboBox.Items.Add("1");
            this.recordOnIntervalComboBox.Items.Add("3");
            this.recordOnIntervalComboBox.Items.Add("5");
            this.recordOnIntervalComboBox.Items.Add("10");
            this.recordOnIntervalComboBox.Items.Add("15");
            this.recordOnIntervalComboBox.Items.Add("30");
            this.recordOnIntervalComboBox.Items.Add("60");
            this.recordOnIntervalComboBox.Items.Add("90");
            this.recordOnIntervalComboBox.Items.Add("120");
            this.recordOnIntervalComboBox.Location = new System.Drawing.Point(33, 61);
            this.recordOnIntervalComboBox.Name = "recordOnIntervalComboBox";
            this.recordOnIntervalComboBox.Size = new System.Drawing.Size(50, 22);
            this.recordOnIntervalComboBox.TabIndex = 2;
            // 
            // recordOnIntervalCheckBox
            // 
            this.recordOnIntervalCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recordOnIntervalCheckBox.Location = new System.Drawing.Point(3, 35);
            this.recordOnIntervalCheckBox.Name = "recordOnIntervalCheckBox";
            this.recordOnIntervalCheckBox.Size = new System.Drawing.Size(220, 20);
            this.recordOnIntervalCheckBox.TabIndex = 1;
            this.recordOnIntervalCheckBox.Text = "指定した間隔で記録";
            this.recordOnIntervalCheckBox.CheckStateChanged += new System.EventHandler(this.recordOnIntervalCheckBox_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.Text = "下記のタイミングで、自動的にバッテリ残量を記録します。";
            // 
            // sendTimingTabPage
            // 
            this.sendTimingTabPage.Controls.Add(this.panel3);
            this.sendTimingTabPage.Location = new System.Drawing.Point(0, 0);
            this.sendTimingTabPage.Name = "sendTimingTabPage";
            this.sendTimingTabPage.Size = new System.Drawing.Size(240, 245);
            this.sendTimingTabPage.Text = "送信タイミング";
            // 
            // sendOnChargeChangeCheckBox
            // 
            this.sendOnChargeChangeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sendOnChargeChangeCheckBox.Location = new System.Drawing.Point(3, 169);
            this.sendOnChargeChangeCheckBox.Name = "sendOnChargeChangeCheckBox";
            this.sendOnChargeChangeCheckBox.Size = new System.Drawing.Size(220, 20);
            this.sendOnChargeChangeCheckBox.TabIndex = 4;
            this.sendOnChargeChangeCheckBox.Text = "充電状態変化時に送信";
            // 
            // sendOnLevelChangeCheckBox
            // 
            this.sendOnLevelChangeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sendOnLevelChangeCheckBox.Location = new System.Drawing.Point(3, 143);
            this.sendOnLevelChangeCheckBox.Name = "sendOnLevelChangeCheckBox";
            this.sendOnLevelChangeCheckBox.Size = new System.Drawing.Size(220, 20);
            this.sendOnLevelChangeCheckBox.TabIndex = 3;
            this.sendOnLevelChangeCheckBox.Text = "バッテリレベル変化時に送信";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(89, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.Text = "件";
            // 
            // sendOnCountComboBox
            // 
            this.sendOnCountComboBox.Items.Add("1");
            this.sendOnCountComboBox.Items.Add("3");
            this.sendOnCountComboBox.Items.Add("5");
            this.sendOnCountComboBox.Items.Add("10");
            this.sendOnCountComboBox.Items.Add("15");
            this.sendOnCountComboBox.Items.Add("20");
            this.sendOnCountComboBox.Items.Add("30");
            this.sendOnCountComboBox.Location = new System.Drawing.Point(33, 115);
            this.sendOnCountComboBox.Name = "sendOnCountComboBox";
            this.sendOnCountComboBox.Size = new System.Drawing.Size(50, 22);
            this.sendOnCountComboBox.TabIndex = 1;
            // 
            // sendOnCountCheckBox
            // 
            this.sendOnCountCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sendOnCountCheckBox.Location = new System.Drawing.Point(3, 89);
            this.sendOnCountCheckBox.Name = "sendOnCountCheckBox";
            this.sendOnCountCheckBox.Size = new System.Drawing.Size(220, 20);
            this.sendOnCountCheckBox.TabIndex = 0;
            this.sendOnCountCheckBox.Text = "指定した件数が溜まったら送信";
            this.sendOnCountCheckBox.CheckStateChanged += new System.EventHandler(this.sendOnCountCheckBox_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(89, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.Text = "分";
            // 
            // sendOnIntervalComboBox
            // 
            this.sendOnIntervalComboBox.Items.Add("1");
            this.sendOnIntervalComboBox.Items.Add("3");
            this.sendOnIntervalComboBox.Items.Add("5");
            this.sendOnIntervalComboBox.Items.Add("10");
            this.sendOnIntervalComboBox.Items.Add("15");
            this.sendOnIntervalComboBox.Items.Add("30");
            this.sendOnIntervalComboBox.Items.Add("60");
            this.sendOnIntervalComboBox.Items.Add("90");
            this.sendOnIntervalComboBox.Items.Add("120");
            this.sendOnIntervalComboBox.Location = new System.Drawing.Point(33, 61);
            this.sendOnIntervalComboBox.Name = "sendOnIntervalComboBox";
            this.sendOnIntervalComboBox.Size = new System.Drawing.Size(50, 22);
            this.sendOnIntervalComboBox.TabIndex = 1;
            // 
            // sendOnIntervalCheckBox
            // 
            this.sendOnIntervalCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sendOnIntervalCheckBox.Location = new System.Drawing.Point(3, 35);
            this.sendOnIntervalCheckBox.Name = "sendOnIntervalCheckBox";
            this.sendOnIntervalCheckBox.Size = new System.Drawing.Size(220, 20);
            this.sendOnIntervalCheckBox.TabIndex = 0;
            this.sendOnIntervalCheckBox.Text = "指定した間隔で送信";
            this.sendOnIntervalCheckBox.CheckStateChanged += new System.EventHandler(this.sendOnIntervalCheckBox_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 32);
            this.label3.Text = "下記のタイミングで、自動的にバッテリ残量をサーバに送信します。";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.validTokenLabel);
            this.panel6.Controls.Add(this.tokenTextBox);
            this.panel6.Controls.Add(this.invalidTokenLabel);
            this.panel6.Location = new System.Drawing.Point(7, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 235);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.recordOnChargeCheckBox);
            this.panel7.Controls.Add(this.recordOnAcConnectCheckBox);
            this.panel7.Location = new System.Drawing.Point(7, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(226, 235);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(33, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 48);
            this.label7.Text = "充電中にバッテリ残量が正しく取得できない場合は、チェックを外してください。";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(33, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 48);
            this.label8.Text = "電源接続中にバッテリ残量が正しく取得できない場合は、チェックを外してください。";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.recordOnIntervalCheckBox);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.recordOnIntervalComboBox);
            this.panel8.Controls.Add(this.recordOnChargeChangeCheckBox);
            this.panel8.Controls.Add(this.recordOnLevelChangeCheckBox);
            this.panel8.Location = new System.Drawing.Point(7, 7);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(226, 235);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.sendOnIntervalCheckBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.sendOnCountCheckBox);
            this.panel3.Controls.Add(this.sendOnIntervalComboBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.sendOnChargeChangeCheckBox);
            this.panel3.Controls.Add(this.sendOnCountComboBox);
            this.panel3.Controls.Add(this.sendOnLevelChangeCheckBox);
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 235);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.settingTab);
            this.Menu = this.mainMenu1;
            this.Name = "SettingForm";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.settingTab.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.recordTabPage.ResumeLayout(false);
            this.recordTimingTabPage.ResumeLayout(false);
            this.sendTimingTabPage.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingTab;
        private System.Windows.Forms.TabPage recordTimingTabPage;
        private System.Windows.Forms.TabPage sendTimingTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox recordOnIntervalComboBox;
        private System.Windows.Forms.CheckBox recordOnIntervalCheckBox;
        private System.Windows.Forms.CheckBox recordOnLevelChangeCheckBox;
        private System.Windows.Forms.CheckBox recordOnChargeChangeCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sendOnIntervalComboBox;
        private System.Windows.Forms.CheckBox sendOnIntervalCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sendOnCountComboBox;
        private System.Windows.Forms.CheckBox sendOnCountCheckBox;
        private System.Windows.Forms.CheckBox sendOnChargeChangeCheckBox;
        private System.Windows.Forms.CheckBox sendOnLevelChangeCheckBox;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage recordTabPage;
        private System.Windows.Forms.CheckBox recordOnAcConnectCheckBox;
        private System.Windows.Forms.CheckBox recordOnChargeCheckBox;
        private System.Windows.Forms.Label validTokenLabel;
        private System.Windows.Forms.Label invalidTokenLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
    }
}