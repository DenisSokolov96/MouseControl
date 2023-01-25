namespace MouseControl
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.oXTextBox = new System.Windows.Forms.TextBox();
            this.oYTextBox = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.WindInfoLabel = new System.Windows.Forms.Label();
            this.windOutInfo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outSymbolsOnScreen = new System.Windows.Forms.RichTextBox();
            this.symbolOutWind = new System.Windows.Forms.TextBox();
            this.allSymbol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oXTextBox
            // 
            this.oXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oXTextBox.Location = new System.Drawing.Point(27, 9);
            this.oXTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.oXTextBox.Name = "oXTextBox";
            this.oXTextBox.ReadOnly = true;
            this.oXTextBox.Size = new System.Drawing.Size(96, 20);
            this.oXTextBox.TabIndex = 0;
            this.oXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oYTextBox
            // 
            this.oYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oYTextBox.Location = new System.Drawing.Point(186, 9);
            this.oYTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.oYTextBox.Name = "oYTextBox";
            this.oYTextBox.ReadOnly = true;
            this.oYTextBox.Size = new System.Drawing.Size(96, 20);
            this.oYTextBox.TabIndex = 2;
            this.oYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(166, 11);
            this.YLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 3;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(7, 9);
            this.XLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 4;
            this.XLabel.Text = "X:";
            // 
            // WindInfoLabel
            // 
            this.WindInfoLabel.AutoSize = true;
            this.WindInfoLabel.Location = new System.Drawing.Point(7, 44);
            this.WindInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WindInfoLabel.Name = "WindInfoLabel";
            this.WindInfoLabel.Size = new System.Drawing.Size(139, 13);
            this.WindInfoLabel.TabIndex = 5;
            this.WindInfoLabel.Text = "Название элемента окна:";
            // 
            // windOutInfo
            // 
            this.windOutInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windOutInfo.Location = new System.Drawing.Point(9, 59);
            this.windOutInfo.Margin = new System.Windows.Forms.Padding(2);
            this.windOutInfo.Name = "windOutInfo";
            this.windOutInfo.ReadOnly = true;
            this.windOutInfo.Size = new System.Drawing.Size(273, 78);
            this.windOutInfo.TabIndex = 1;
            this.windOutInfo.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Буквы:";
            // 
            // outSymbolsOnScreen
            // 
            this.outSymbolsOnScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outSymbolsOnScreen.Location = new System.Drawing.Point(9, 198);
            this.outSymbolsOnScreen.Margin = new System.Windows.Forms.Padding(2);
            this.outSymbolsOnScreen.Name = "outSymbolsOnScreen";
            this.outSymbolsOnScreen.ReadOnly = true;
            this.outSymbolsOnScreen.Size = new System.Drawing.Size(273, 83);
            this.outSymbolsOnScreen.TabIndex = 6;
            this.outSymbolsOnScreen.Text = "";
            // 
            // symbolOutWind
            // 
            this.symbolOutWind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolOutWind.Location = new System.Drawing.Point(9, 162);
            this.symbolOutWind.Margin = new System.Windows.Forms.Padding(2);
            this.symbolOutWind.Name = "symbolOutWind";
            this.symbolOutWind.ReadOnly = true;
            this.symbolOutWind.Size = new System.Drawing.Size(96, 20);
            this.symbolOutWind.TabIndex = 9;
            this.symbolOutWind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // allSymbol
            // 
            this.allSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allSymbol.Location = new System.Drawing.Point(186, 162);
            this.allSymbol.Margin = new System.Windows.Forms.Padding(2);
            this.allSymbol.Name = "allSymbol";
            this.allSymbol.ReadOnly = true;
            this.allSymbol.Size = new System.Drawing.Size(96, 20);
            this.allSymbol.TabIndex = 8;
            this.allSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Символ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Кол-во символов:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 289);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.symbolOutWind);
            this.Controls.Add(this.allSymbol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outSymbolsOnScreen);
            this.Controls.Add(this.WindInfoLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.oYTextBox);
            this.Controls.Add(this.windOutInfo);
            this.Controls.Add(this.oXTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Перехватчик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oXTextBox;
        private System.Windows.Forms.TextBox oYTextBox;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label WindInfoLabel;
        private System.Windows.Forms.RichTextBox windOutInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox outSymbolsOnScreen;
        private System.Windows.Forms.TextBox symbolOutWind;
        private System.Windows.Forms.TextBox allSymbol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

